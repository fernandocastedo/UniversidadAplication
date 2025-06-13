namespace UniversidadAplication
{
    partial class frmReporteMateriasOfertadas
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
            this.dataSetMateriasOfertadas = new UniversidadAplication.DataSetMateriasOfertadas();
            this.spReporteMateriasOfertadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ReporteMateriasOfertadasTableAdapter = new UniversidadAplication.DataSetMateriasOfertadasTableAdapters.sp_ReporteMateriasOfertadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMateriasOfertadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteMateriasOfertadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMateriasOfertadas";
            reportDataSource1.Value = this.spReporteMateriasOfertadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UniversidadAplication.ReportMateriasOfertadas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSetMateriasOfertadas
            // 
            this.dataSetMateriasOfertadas.DataSetName = "DataSetMateriasOfertadas";
            this.dataSetMateriasOfertadas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReporteMateriasOfertadasBindingSource
            // 
            this.spReporteMateriasOfertadasBindingSource.DataMember = "sp_ReporteMateriasOfertadas";
            this.spReporteMateriasOfertadasBindingSource.DataSource = this.dataSetMateriasOfertadas;
            // 
            // sp_ReporteMateriasOfertadasTableAdapter
            // 
            this.sp_ReporteMateriasOfertadasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteMateriasOfertadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteMateriasOfertadas";
            this.Text = "frmReporteMateriasOfertadas";
            this.Load += new System.EventHandler(this.frmReporteMateriasOfertadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMateriasOfertadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteMateriasOfertadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReporteMateriasOfertadasBindingSource;
        private DataSetMateriasOfertadas dataSetMateriasOfertadas;
        private DataSetMateriasOfertadasTableAdapters.sp_ReporteMateriasOfertadasTableAdapter sp_ReporteMateriasOfertadasTableAdapter;
    }
}