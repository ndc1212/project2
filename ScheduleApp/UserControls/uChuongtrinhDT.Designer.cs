namespace ScheduleApp.UserControls
{
    partial class uChuongtrinhDT
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvChuongtrinhDT = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongtrinhDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách chương trình đào tạo";
            // 
            // dgvChuongtrinhDT
            // 
            this.dgvChuongtrinhDT.AutoGenerateContextFilters = true;
            this.dgvChuongtrinhDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuongtrinhDT.DateWithTime = false;
            this.dgvChuongtrinhDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChuongtrinhDT.Location = new System.Drawing.Point(0, 31);
            this.dgvChuongtrinhDT.Name = "dgvChuongtrinhDT";
            this.dgvChuongtrinhDT.Size = new System.Drawing.Size(1021, 524);
            this.dgvChuongtrinhDT.TabIndex = 16;
            this.dgvChuongtrinhDT.TimeFilter = false;
            this.dgvChuongtrinhDT.SortStringChanged += new System.EventHandler(this.dgvChuongtrinhDT_SortStringChanged);
            this.dgvChuongtrinhDT.FilterStringChanged += new System.EventHandler(this.dgvChuongtrinhDT_FilterStringChanged);
            // 
            // uChuongtrinhDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvChuongtrinhDT);
            this.Controls.Add(this.label1);
            this.Name = "uChuongtrinhDT";
            this.Size = new System.Drawing.Size(1021, 555);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongtrinhDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource;
        private ADGV.AdvancedDataGridView dgvChuongtrinhDT;
    }
}
