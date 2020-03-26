﻿namespace ScheduleApp.UserControls
{
    partial class ucSubjects
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.lb_subjects = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(445, 39);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 25);
            this.lbName.TabIndex = 14;
            // 
            // dgvClasses
            // 
            this.dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(686, 457);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.Size = new System.Drawing.Size(669, 326);
            this.dgvClasses.TabIndex = 13;
            // 
            // lb_subjects
            // 
            this.lb_subjects.AutoSize = true;
            this.lb_subjects.Location = new System.Drawing.Point(558, 793);
            this.lb_subjects.Name = "lb_subjects";
            this.lb_subjects.Size = new System.Drawing.Size(0, 13);
            this.lb_subjects.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 793);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng cộng:";
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Location = new System.Drawing.Point(686, 83);
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.Size = new System.Drawing.Size(669, 326);
            this.dgvPrograms.TabIndex = 10;
            this.dgvPrograms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrograms_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách môn học được dạy vào học kỳ:";
            // 
            // dgvSubject
            // 
            this.dgvSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Location = new System.Drawing.Point(26, 83);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.Size = new System.Drawing.Size(606, 700);
            this.dgvSubject.TabIndex = 8;
            this.dgvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellClick);
            // 
            // ucSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.lb_subjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPrograms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSubject);
            this.Name = "ucSubjects";
            this.Size = new System.Drawing.Size(1380, 845);
            this.Load += new System.EventHandler(this.ucSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Label lb_subjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPrograms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSubject;
    }
}