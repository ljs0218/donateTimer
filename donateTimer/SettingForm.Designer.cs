namespace donateTimer
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addChecked = new System.Windows.Forms.CheckBox();
            this.subChecked = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "1분당 가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "추가, 삭감 가능 여부";
            // 
            // addChecked
            // 
            this.addChecked.AutoSize = true;
            this.addChecked.Checked = true;
            this.addChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addChecked.Location = new System.Drawing.Point(14, 95);
            this.addChecked.Name = "addChecked";
            this.addChecked.Size = new System.Drawing.Size(48, 16);
            this.addChecked.TabIndex = 3;
            this.addChecked.Text = "추가";
            this.addChecked.UseVisualStyleBackColor = true;
            this.addChecked.CheckedChanged += new System.EventHandler(this.addChecked_CheckedChanged);
            // 
            // subChecked
            // 
            this.subChecked.AutoSize = true;
            this.subChecked.Checked = true;
            this.subChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subChecked.Location = new System.Drawing.Point(14, 117);
            this.subChecked.Name = "subChecked";
            this.subChecked.Size = new System.Drawing.Size(48, 16);
            this.subChecked.TabIndex = 4;
            this.subChecked.Text = "삭감";
            this.subChecked.UseVisualStyleBackColor = true;
            this.subChecked.CheckedChanged += new System.EventHandler(this.subChecked_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "100",
            "150",
            "200",
            "250",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.comboBox1.Location = new System.Drawing.Point(14, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "100";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(156, 154);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.subChecked);
            this.Controls.Add(this.addChecked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox addChecked;
        private System.Windows.Forms.CheckBox subChecked;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}