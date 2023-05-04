namespace donateTimer
{
    partial class MainForm
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
            this.twipBox = new System.Windows.Forms.TextBox();
            this.toonationBox = new System.Windows.Forms.TextBox();
            this.twipConnectBtn = new System.Windows.Forms.Button();
            this.toonationConnectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // twipBox
            // 
            this.twipBox.Location = new System.Drawing.Point(12, 12);
            this.twipBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.twipBox.Name = "twipBox";
            this.twipBox.Size = new System.Drawing.Size(104, 21);
            this.twipBox.TabIndex = 0;
            // 
            // toonationBox
            // 
            this.toonationBox.Location = new System.Drawing.Point(130, 12);
            this.toonationBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toonationBox.Name = "toonationBox";
            this.toonationBox.Size = new System.Drawing.Size(104, 21);
            this.toonationBox.TabIndex = 1;
            // 
            // twipConnectBtn
            // 
            this.twipConnectBtn.Location = new System.Drawing.Point(12, 42);
            this.twipConnectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.twipConnectBtn.Name = "twipConnectBtn";
            this.twipConnectBtn.Size = new System.Drawing.Size(102, 45);
            this.twipConnectBtn.TabIndex = 2;
            this.twipConnectBtn.Text = "Twip 연동";
            this.twipConnectBtn.UseVisualStyleBackColor = true;
            this.twipConnectBtn.Click += new System.EventHandler(this.twipConnectBtn_Click);
            // 
            // toonationConnectBtn
            // 
            this.toonationConnectBtn.Location = new System.Drawing.Point(130, 42);
            this.toonationConnectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toonationConnectBtn.Name = "toonationConnectBtn";
            this.toonationConnectBtn.Size = new System.Drawing.Size(102, 45);
            this.toonationConnectBtn.TabIndex = 3;
            this.toonationConnectBtn.Text = "Toonation 연동";
            this.toonationConnectBtn.UseVisualStyleBackColor = true;
            this.toonationConnectBtn.Click += new System.EventHandler(this.toonationConnectBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 98);
            this.Controls.Add(this.toonationConnectBtn);
            this.Controls.Add(this.twipConnectBtn);
            this.Controls.Add(this.toonationBox);
            this.Controls.Add(this.twipBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox twipBox;
        private System.Windows.Forms.TextBox toonationBox;
        private System.Windows.Forms.Button twipConnectBtn;
        private System.Windows.Forms.Button toonationConnectBtn;
    }
}