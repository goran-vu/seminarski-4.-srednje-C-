﻿namespace seminarski.inf
{
    partial class Form2
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
            this.Spirometrija_DataSet = new seminarski.inf.Spirometrija_DataSet();
            this.UceniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UceniciTableAdapter = new seminarski.inf.Spirometrija_DataSetTableAdapters.UceniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Spirometrija_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UceniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UceniciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "seminarski.inf.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Spirometrija_DataSet
            // 
            this.Spirometrija_DataSet.DataSetName = "Spirometrija_DataSet";
            this.Spirometrija_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UceniciBindingSource
            // 
            this.UceniciBindingSource.DataMember = "Ucenici";
            this.UceniciBindingSource.DataSource = this.Spirometrija_DataSet;
            // 
            // UceniciTableAdapter
            // 
            this.UceniciTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Spirometrija_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UceniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UceniciBindingSource;
        private Spirometrija_DataSet Spirometrija_DataSet;
        private Spirometrija_DataSetTableAdapters.UceniciTableAdapter UceniciTableAdapter;
    }
}