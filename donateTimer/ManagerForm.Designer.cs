namespace donateTimer
{
    partial class ManagerForm
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
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addWonBox = new System.Windows.Forms.TextBox();
            this.subWonBox = new System.Windows.Forms.TextBox();
            this.addWonBtn = new System.Windows.Forms.Button();
            this.subWonBtn = new System.Windows.Forms.Button();
            this.subMinutesBtn = new System.Windows.Forms.Button();
            this.addMinutesBtn = new System.Windows.Forms.Button();
            this.subMinutesBox = new System.Windows.Forms.TextBox();
            this.addMinutesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(14, 217);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(206, 40);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "시작";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(14, 261);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(206, 40);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "일시 정지";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "원";
            // 
            // addWonBox
            // 
            this.addWonBox.Location = new System.Drawing.Point(16, 38);
            this.addWonBox.Name = "addWonBox";
            this.addWonBox.Size = new System.Drawing.Size(100, 21);
            this.addWonBox.TabIndex = 3;
            // 
            // subWonBox
            // 
            this.subWonBox.Location = new System.Drawing.Point(120, 38);
            this.subWonBox.Name = "subWonBox";
            this.subWonBox.Size = new System.Drawing.Size(100, 21);
            this.subWonBox.TabIndex = 4;
            // 
            // addWonBtn
            // 
            this.addWonBtn.Location = new System.Drawing.Point(16, 65);
            this.addWonBtn.Name = "addWonBtn";
            this.addWonBtn.Size = new System.Drawing.Size(98, 44);
            this.addWonBtn.TabIndex = 5;
            this.addWonBtn.Text = "추가";
            this.addWonBtn.UseVisualStyleBackColor = true;
            this.addWonBtn.Click += new System.EventHandler(this.addWonBtn_Click);
            // 
            // subWonBtn
            // 
            this.subWonBtn.Location = new System.Drawing.Point(120, 65);
            this.subWonBtn.Name = "subWonBtn";
            this.subWonBtn.Size = new System.Drawing.Size(100, 44);
            this.subWonBtn.TabIndex = 6;
            this.subWonBtn.Text = "삭감";
            this.subWonBtn.UseVisualStyleBackColor = true;
            this.subWonBtn.Click += new System.EventHandler(this.subWonBtn_Click);
            // 
            // subMinutesBtn
            // 
            this.subMinutesBtn.Location = new System.Drawing.Point(120, 163);
            this.subMinutesBtn.Name = "subMinutesBtn";
            this.subMinutesBtn.Size = new System.Drawing.Size(100, 44);
            this.subMinutesBtn.TabIndex = 10;
            this.subMinutesBtn.Text = "삭감";
            this.subMinutesBtn.UseVisualStyleBackColor = true;
            this.subMinutesBtn.Click += new System.EventHandler(this.subMinutesBtn_Click);
            // 
            // addMinutesBtn
            // 
            this.addMinutesBtn.Location = new System.Drawing.Point(14, 163);
            this.addMinutesBtn.Name = "addMinutesBtn";
            this.addMinutesBtn.Size = new System.Drawing.Size(102, 44);
            this.addMinutesBtn.TabIndex = 9;
            this.addMinutesBtn.Text = "추가";
            this.addMinutesBtn.UseVisualStyleBackColor = true;
            this.addMinutesBtn.Click += new System.EventHandler(this.addMinutesBtn_Click);
            // 
            // subMinutesBox
            // 
            this.subMinutesBox.Location = new System.Drawing.Point(120, 136);
            this.subMinutesBox.Name = "subMinutesBox";
            this.subMinutesBox.Size = new System.Drawing.Size(100, 21);
            this.subMinutesBox.TabIndex = 8;
            // 
            // addMinutesBox
            // 
            this.addMinutesBox.Location = new System.Drawing.Point(16, 136);
            this.addMinutesBox.Name = "addMinutesBox";
            this.addMinutesBox.Size = new System.Drawing.Size(100, 21);
            this.addMinutesBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "분";
            // 
            // settingBtn
            // 
            this.settingBtn.Location = new System.Drawing.Point(196, 8);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(24, 24);
            this.settingBtn.TabIndex = 12;
            this.settingBtn.Text = "!";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(239, 316);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subMinutesBtn);
            this.Controls.Add(this.addMinutesBtn);
            this.Controls.Add(this.subMinutesBox);
            this.Controls.Add(this.addMinutesBox);
            this.Controls.Add(this.subWonBtn);
            this.Controls.Add(this.addWonBtn);
            this.Controls.Add(this.subWonBox);
            this.Controls.Add(this.addWonBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addWonBox;
        private System.Windows.Forms.TextBox subWonBox;
        private System.Windows.Forms.Button addWonBtn;
        private System.Windows.Forms.Button subWonBtn;
        private System.Windows.Forms.Button subMinutesBtn;
        private System.Windows.Forms.Button addMinutesBtn;
        private System.Windows.Forms.TextBox subMinutesBox;
        private System.Windows.Forms.TextBox addMinutesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button settingBtn;
    }
}