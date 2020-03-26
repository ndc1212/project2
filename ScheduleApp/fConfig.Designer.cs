namespace ScheduleApp
{
    partial class fConfig
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
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnLoaddata = new System.Windows.Forms.Button();
            this.cbPhienConfig = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNamhoc = new System.Windows.Forms.ComboBox();
            this.cbHocky = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(16, 57);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(41, 13);
            this.lbPass.TabIndex = 9;
            this.lbPass.Text = "Học kỳ";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(16, 19);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(50, 13);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "Năm học";
            // 
            // btnLoaddata
            // 
            this.btnLoaddata.Location = new System.Drawing.Point(134, 133);
            this.btnLoaddata.Name = "btnLoaddata";
            this.btnLoaddata.Size = new System.Drawing.Size(185, 32);
            this.btnLoaddata.TabIndex = 5;
            this.btnLoaddata.Text = "Tải dữ liệu";
            this.btnLoaddata.UseVisualStyleBackColor = true;
            this.btnLoaddata.Click += new System.EventHandler(this.btnLoaddata_Click);
            // 
            // cbPhienConfig
            // 
            this.cbPhienConfig.FormattingEnabled = true;
            this.cbPhienConfig.Location = new System.Drawing.Point(134, 90);
            this.cbPhienConfig.Name = "cbPhienConfig";
            this.cbPhienConfig.Size = new System.Drawing.Size(356, 21);
            this.cbPhienConfig.TabIndex = 10;
            this.cbPhienConfig.SelectedIndexChanged += new System.EventHandler(this.cbPhienConfig_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Phiên";
            // 
            // cbNamhoc
            // 
            this.cbNamhoc.FormattingEnabled = true;
            this.cbNamhoc.Location = new System.Drawing.Point(134, 11);
            this.cbNamhoc.Name = "cbNamhoc";
            this.cbNamhoc.Size = new System.Drawing.Size(185, 21);
            this.cbNamhoc.TabIndex = 12;
            // 
            // cbHocky
            // 
            this.cbHocky.FormattingEnabled = true;
            this.cbHocky.Location = new System.Drawing.Point(134, 49);
            this.cbHocky.Name = "cbHocky";
            this.cbHocky.Size = new System.Drawing.Size(185, 21);
            this.cbHocky.TabIndex = 13;
            // 
            // fConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 168);
            this.Controls.Add(this.cbHocky);
            this.Controls.Add(this.cbNamhoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPhienConfig);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnLoaddata);
            this.Name = "fConfig";
            this.Text = "fConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnLoaddata;
        private System.Windows.Forms.ComboBox cbPhienConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNamhoc;
        private System.Windows.Forms.ComboBox cbHocky;
    }
}