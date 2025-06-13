namespace UniversidadAplication
{
    partial class frmReporteNotasMateriasCursadas
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
            this.dataSetNotasMateriasCursadas = new UniversidadAplication.DataSetNotasMateriasCursadas();
            this.spReporteNotasEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ReporteNotasEstudianteTableAdapter = new UniversidadAplication.DataSetNotasMateriasCursadasTableAdapters.sp_ReporteNotasEstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNotasMateriasCursadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteNotasEstudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNotasMateriasCursadas";
            reportDataSource1.Value = this.spReporteNotasEstudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UniversidadAplication.ReportNotasMateriasCursadas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetNotasMateriasCursadas
            // 
            this.dataSetNotasMateriasCursadas.DataSetName = "DataSetNotasMateriasCursadas";
            this.dataSetNotasMateriasCursadas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReporteNotasEstudianteBindingSource
            // 
            this.spReporteNotasEstudianteBindingSource.DataMember = "sp_ReporteNotasEstudiante";
            this.spReporteNotasEstudianteBindingSource.DataSource = this.dataSetNotasMateriasCursadas;
            // 
            // sp_ReporteNotasEstudianteTableAdapter
            // 
            this.sp_ReporteNotasEstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteNotasMateriasCursadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteNotasMateriasCursadas";
            this.Text = "frmReporteNotasMateriasCursadas";
            this.Load += new System.EventHandler(this.frmReporteNotasMateriasCursadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNotasMateriasCursadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteNotasEstudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReporteNotasEstudianteBindingSource;
        private DataSetNotasMateriasCursadas dataSetNotasMateriasCursadas;
        private DataSetNotasMateriasCursadasTableAdapters.sp_ReporteNotasEstudianteTableAdapter sp_ReporteNotasEstudianteTableAdapter;
    }
}