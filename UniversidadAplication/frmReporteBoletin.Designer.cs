namespace UniversidadAplication
{
    partial class frmReporteBoletin
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
            this.dataSetBoletin = new UniversidadAplication.DataSetBoletin();
            this.spBoletinAprobadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BoletinAprobadosTableAdapter = new UniversidadAplication.DataSetBoletinTableAdapters.sp_BoletinAprobadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoletin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBoletinAprobadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetBoletin";
            reportDataSource1.Value = this.spBoletinAprobadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UniversidadAplication.ReportBoletin.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetBoletin
            // 
            this.dataSetBoletin.DataSetName = "DataSetBoletin";
            this.dataSetBoletin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spBoletinAprobadosBindingSource
            // 
            this.spBoletinAprobadosBindingSource.DataMember = "sp_BoletinAprobados";
            this.spBoletinAprobadosBindingSource.DataSource = this.dataSetBoletin;
            // 
            // sp_BoletinAprobadosTableAdapter
            // 
            this.sp_BoletinAprobadosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteBoletin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteBoletin";
            this.Text = "frmReporteBoletin";
            this.Load += new System.EventHandler(this.frmReporteBoletin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoletin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBoletinAprobadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spBoletinAprobadosBindingSource;
        private DataSetBoletin dataSetBoletin;
        private DataSetBoletinTableAdapters.sp_BoletinAprobadosTableAdapter sp_BoletinAprobadosTableAdapter;
    }
}