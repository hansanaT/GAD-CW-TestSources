using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Send_Mail_Test
{
    public partial class Send_Mail : Form
    {
        public Send_Mail()
        {
            InitializeComponent();
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            string emailAddress = txt_email.Text;
            string messageText = txt_msg.Text;

            try
            {
                UserCredential credential;

                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        new[] { GmailService.Scope.GmailSend },
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                var gmailService = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Your Application Name"
                });

                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress("Hansana", "hansanathimeth@gmail.com")); //Sender's Name and Email Address
                emailMessage.To.Add(new MailboxAddress("", emailAddress)); // Recipient's email address
                emailMessage.Subject = "Welcome to the Application!";
                emailMessage.Body = new TextPart("plain")
                {
                    Text = messageText
                };

                var rawMessage = Base64UrlEncode(emailMessage.ToString());
                var message = new Google.Apis.Gmail.v1.Data.Message
                {
                    Raw = rawMessage
                };

                gmailService.Users.Messages.Send(message, "me").Execute();

                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the email: {ex.Message}");
            }
        }
        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return System.Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }
    }
}
