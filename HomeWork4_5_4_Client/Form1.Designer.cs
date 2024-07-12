namespace HomeWork4_5_4_Client {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnFormatDisk = new Button();
            btnSpamSend = new Button();
            txtbox = new TextBox();
            SuspendLayout();
            // 
            // btnFormatDisk
            // 
            btnFormatDisk.Location = new Point(50, 47);
            btnFormatDisk.Name = "btnFormatDisk";
            btnFormatDisk.Size = new Size(129, 23);
            btnFormatDisk.TabIndex = 0;
            btnFormatDisk.Text = "Форматувати диск";
            btnFormatDisk.UseVisualStyleBackColor = true;
            // 
            // btnSpamSend
            // 
            btnSpamSend.Location = new Point(202, 47);
            btnSpamSend.Name = "btnSpamSend";
            btnSpamSend.Size = new Size(158, 23);
            btnSpamSend.TabIndex = 1;
            btnSpamSend.Text = "Розсилати спам";
            btnSpamSend.UseVisualStyleBackColor = true;
            // 
            // txtbox
            // 
            txtbox.Location = new Point(133, 76);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(109, 23);
            txtbox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 129);
            Controls.Add(txtbox);
            Controls.Add(btnSpamSend);
            Controls.Add(btnFormatDisk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFormatDisk;
        private Button btnSpamSend;
        private TextBox txtbox;
    }
}
