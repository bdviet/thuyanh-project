﻿namespace Nhân_Viên
{
    partial class REPORT
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
            this.nvstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Nhân_Viên.DataSet1();
            this.nvstTableAdapter = new Nhân_Viên.DataSet1TableAdapters.nvstTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nvstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nvstBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nhân_Viên.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(869, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // nvstBindingSource
            // 
            this.nvstBindingSource.DataMember = "nvst";
            this.nvstBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nvstTableAdapter
            // 
            this.nvstTableAdapter.ClearBeforeFill = true;
            // 
            // REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 394);
            this.Controls.Add(this.reportViewer1);
            this.Name = "REPORT";
            this.Text = "REPORT";
            this.Load += new System.EventHandler(this.REPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nvstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nvstBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.nvstTableAdapter nvstTableAdapter;
    }
}