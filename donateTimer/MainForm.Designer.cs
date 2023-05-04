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
            this.twipBox.Location = new System.Drawing.Point(23, 23);
            this.twipBox.Name = "twipBox";
            this.twipBox.Size = new System.Drawing.Size(190, 35);
            this.twipBox.TabIndex = 0;
            this.twipBox.Text = "PBvNXmw5qp";
            // 
            // toonationBox
            // 
            this.toonationBox.Location = new System.Drawing.Point(241, 23);
            this.toonationBox.Name = "toonationBox";
            this.toonationBox.Size = new System.Drawing.Size(190, 35);
            this.toonationBox.TabIndex = 1;
            this.toonationBox.Text = "f07544f8835c57c908763ae409bb2bb2";
            // 
            // twipConnectBtn
            // 
            this.twipConnectBtn.Location = new System.Drawing.Point(23, 83);
            this.twipConnectBtn.Name = "twipConnectBtn";
            this.twipConnectBtn.Size = new System.Drawing.Size(190, 72);
            this.twipConnectBtn.TabIndex = 2;
            this.twipConnectBtn.Text = "button1";
            this.twipConnectBtn.UseVisualStyleBackColor = true;
            this.twipConnectBtn.Click += new System.EventHandler(this.twipConnectBtn_Click);
            // 
            // toonationConnectBtn
            // 
            this.toonationConnectBtn.Location = new System.Drawing.Point(241, 83);
            this.toonationConnectBtn.Name = "toonationConnectBtn";
            this.toonationConnectBtn.Size = new System.Drawing.Size(190, 72);
            this.toonationConnectBtn.TabIndex = 3;
            this.toonationConnectBtn.Text = "button2";
            this.toonationConnectBtn.UseVisualStyleBackColor = true;
            this.toonationConnectBtn.Click += new System.EventHandler(this.toonationConnectBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 226);
            this.Controls.Add(this.toonationConnectBtn);
            this.Controls.Add(this.twipConnectBtn);
            this.Controls.Add(this.toonationBox);
            this.Controls.Add(this.twipBox);
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