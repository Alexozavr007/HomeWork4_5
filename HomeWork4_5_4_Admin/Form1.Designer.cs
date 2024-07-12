namespace HomeWork4_5_4_Admin {
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
            groupBox1 = new GroupBox();
            cbAllowSpamSend = new CheckBox();
            cbAllowDiskFormat = new CheckBox();
            groupBox2 = new GroupBox();
            rbCenter = new RadioButton();
            rbRightBottom = new RadioButton();
            rbLeftBottom = new RadioButton();
            rbRightTop = new RadioButton();
            rbLeftTop = new RadioButton();
            cbAllowtxtbox = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAllowtxtbox);
            groupBox1.Controls.Add(cbAllowSpamSend);
            groupBox1.Controls.Add(cbAllowDiskFormat);
            groupBox1.Location = new Point(28, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 86);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Доступні функції";
            // 
            // cbAllowSpamSend
            // 
            cbAllowSpamSend.AutoSize = true;
            cbAllowSpamSend.Location = new Point(9, 53);
            cbAllowSpamSend.Name = "cbAllowSpamSend";
            cbAllowSpamSend.Size = new Size(128, 19);
            cbAllowSpamSend.TabIndex = 1;
            cbAllowSpamSend.Text = "розсилання спаму";
            cbAllowSpamSend.UseVisualStyleBackColor = true;
            cbAllowSpamSend.CheckedChanged += cbAllowSpamSend_CheckedChanged;
            // 
            // cbAllowDiskFormat
            // 
            cbAllowDiskFormat.AutoSize = true;
            cbAllowDiskFormat.Location = new Point(9, 28);
            cbAllowDiskFormat.Name = "cbAllowDiskFormat";
            cbAllowDiskFormat.Size = new Size(141, 19);
            cbAllowDiskFormat.TabIndex = 0;
            cbAllowDiskFormat.Text = "форматування диску";
            cbAllowDiskFormat.UseVisualStyleBackColor = true;
            cbAllowDiskFormat.CheckedChanged += cbAllowDiskFormat_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbCenter);
            groupBox2.Controls.Add(rbRightBottom);
            groupBox2.Controls.Add(rbLeftBottom);
            groupBox2.Controls.Add(rbRightTop);
            groupBox2.Controls.Add(rbLeftTop);
            groupBox2.Location = new Point(28, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Положення на екрані";
            // 
            // rbCenter
            // 
            rbCenter.AutoSize = true;
            rbCenter.Location = new Point(75, 72);
            rbCenter.Name = "rbCenter";
            rbCenter.Size = new Size(59, 19);
            rbCenter.TabIndex = 4;
            rbCenter.TabStop = true;
            rbCenter.Text = "Центр";
            rbCenter.UseVisualStyleBackColor = true;
            rbCenter.CheckedChanged += WindowPositionChanged;
            // 
            // rbRightBottom
            // 
            rbRightBottom.AutoSize = true;
            rbRightBottom.Location = new Point(148, 47);
            rbRightBottom.Name = "rbRightBottom";
            rbRightBottom.Size = new Size(82, 19);
            rbRightBottom.TabIndex = 3;
            rbRightBottom.TabStop = true;
            rbRightBottom.Text = "Право низ";
            rbRightBottom.UseVisualStyleBackColor = true;
            rbRightBottom.CheckedChanged += WindowPositionChanged;
            // 
            // rbLeftBottom
            // 
            rbLeftBottom.AutoSize = true;
            rbLeftBottom.Location = new Point(148, 22);
            rbLeftBottom.Name = "rbLeftBottom";
            rbLeftBottom.Size = new Size(71, 19);
            rbLeftBottom.TabIndex = 2;
            rbLeftBottom.TabStop = true;
            rbLeftBottom.Text = "Ліво низ";
            rbLeftBottom.UseVisualStyleBackColor = true;
            rbLeftBottom.CheckedChanged += WindowPositionChanged;
            // 
            // rbRightTop
            // 
            rbRightTop.AutoSize = true;
            rbRightTop.Location = new Point(9, 47);
            rbRightTop.Name = "rbRightTop";
            rbRightTop.Size = new Size(88, 19);
            rbRightTop.TabIndex = 1;
            rbRightTop.TabStop = true;
            rbRightTop.Text = "Право верх";
            rbRightTop.UseVisualStyleBackColor = true;
            rbRightTop.CheckedChanged += WindowPositionChanged;
            // 
            // rbLeftTop
            // 
            rbLeftTop.AutoSize = true;
            rbLeftTop.Location = new Point(9, 22);
            rbLeftTop.Name = "rbLeftTop";
            rbLeftTop.Size = new Size(77, 19);
            rbLeftTop.TabIndex = 0;
            rbLeftTop.TabStop = true;
            rbLeftTop.Text = "Ліво верх";
            rbLeftTop.UseVisualStyleBackColor = true;
            rbLeftTop.CheckedChanged += WindowPositionChanged;
            // 
            // cbAllowtxtbox
            // 
            cbAllowtxtbox.AutoSize = true;
            cbAllowtxtbox.Location = new Point(148, 53);
            cbAllowtxtbox.Name = "cbAllowtxtbox";
            cbAllowtxtbox.Size = new Size(97, 19);
            cbAllowtxtbox.TabIndex = 2;
            cbAllowtxtbox.Text = "доступ вводу";
            cbAllowtxtbox.UseVisualStyleBackColor = true;
            cbAllowtxtbox.CheckedChanged += cbAllowtxtbox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 253);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Адмін";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox cbAllowSpamSend;
        private CheckBox cbAllowDiskFormat;
        private GroupBox groupBox2;
        private RadioButton rbCenter;
        private RadioButton rbRightBottom;
        private RadioButton rbLeftBottom;
        private RadioButton rbRightTop;
        private RadioButton rbLeftTop;
        private CheckBox cbAllowtxtbox;
    }
}
