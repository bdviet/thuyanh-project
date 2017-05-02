namespace Nhân_Viên
{
    partial class BC
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSet1 = new Nhân_Viên.DataSet1();
            this.nvstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvstTableAdapter = new Nhân_Viên.DataSet1TableAdapters.nvstTableAdapter();
            this.QLNVSTDataSet = new Nhân_Viên.QLNVSTDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNVSTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nvstBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nhân_Viên.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(837, 332);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN KHÁCH SẠN CENTURY\r\n49 Lê Lợi, Phú Hội, Tp. Huế, Thừa Thiên Hu" +
    "ế\r\nSĐT: 0234 3823 390";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nvstBindingSource
            // 
            this.nvstBindingSource.DataMember = "nvst";
            this.nvstBindingSource.DataSource = this.DataSet1;
            // 
            // nvstTableAdapter
            // 
            this.nvstTableAdapter.ClearBeforeFill = true;
            // 
            // QLNVSTDataSet
            // 
            this.QLNVSTDataSet.DataSetName = "QLNVSTDataSet";
            this.QLNVSTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BC";
            this.Text = "BC";
            this.Load += new System.EventHandler(this.BC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNVSTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nvstBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.nvstTableAdapter nvstTableAdapter;
        private QLNVSTDataSet QLNVSTDataSet;
    }
}