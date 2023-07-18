namespace QR_Scanner
{
    partial class QR_Scanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_qr = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_camType = new System.Windows.Forms.ComboBox();
            this.txt_qr = new System.Windows.Forms.TextBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_qr
            // 
            this.pb_qr.Location = new System.Drawing.Point(31, 81);
            this.pb_qr.Name = "pb_qr";
            this.pb_qr.Size = new System.Drawing.Size(549, 432);
            this.pb_qr.TabIndex = 0;
            this.pb_qr.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // cmb_camType
            // 
            this.cmb_camType.FormattingEnabled = true;
            this.cmb_camType.Location = new System.Drawing.Point(343, 17);
            this.cmb_camType.Name = "cmb_camType";
            this.cmb_camType.Size = new System.Drawing.Size(337, 24);
            this.cmb_camType.TabIndex = 2;
            // 
            // txt_qr
            // 
            this.txt_qr.Location = new System.Drawing.Point(616, 183);
            this.txt_qr.Multiline = true;
            this.txt_qr.Name = "txt_qr";
            this.txt_qr.Size = new System.Drawing.Size(298, 92);
            this.txt_qr.TabIndex = 3;
            // 
            // btn_scan
            // 
            this.btn_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.Location = new System.Drawing.Point(708, 281);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(113, 41);
            this.btn_scan.TabIndex = 4;
            this.btn_scan.Text = "&Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QR_Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 525);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.txt_qr);
            this.Controls.Add(this.cmb_camType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_qr);
            this.Name = "QR_Scanner";
            this.Text = "Scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QR_Scanner_FormClosing);
            this.Load += new System.EventHandler(this.QR_Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_qr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_camType;
        private System.Windows.Forms.TextBox txt_qr;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Timer timer1;
    }
}

