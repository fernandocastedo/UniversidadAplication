namespace UniversidadAplication
{
    partial class frmReporteAsistenciaEstudiante
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
            this.SuspendLayout();
            // 
            // frmReporteAsistenciaEstudiante
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmReporteAsistenciaEstudiante";
            this.Load += new System.EventHandler(this.frmReporteAsistenciaEstudiante_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReporteAsistenciaMateriaBindingSource;
        private DataSetAsistenciaEstudiante dataSetAsistenciaEstudiante;
        private DataSetAsistenciaEstudianteTableAdapters.sp_ReporteAsistenciaMateriaTableAdapter sp_ReporteAsistenciaMateriaTableAdapter;
    }
}