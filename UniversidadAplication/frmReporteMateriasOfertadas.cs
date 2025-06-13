using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversidadAplication
{
    public partial class frmReporteMateriasOfertadas : Form
    {
        private gdatos gDatos = new gdatos();
        private int codCarrera;
        private int codPlanEstudio;
        private int anio;
        private string semestre;

        public frmReporteMateriasOfertadas(int codCarrera, int codPlanEstudio, int anio, string semestre)
        {
            InitializeComponent();
            this.codCarrera = codCarrera;
            this.codPlanEstudio = codPlanEstudio;
            this.anio = anio;
            this.semestre = semestre;
        }

        private void frmReporteMateriasOfertadas_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear parámetros para el procedimiento almacenado
                SqlParameter[] parametros = {
                new SqlParameter("@Cod_Carrera", codCarrera),
                new SqlParameter("@Cod_PlanEstudio", codPlanEstudio),
                new SqlParameter("@Anio", anio),
                new SqlParameter("@Semestre", semestre)
            };

                // Ejecutar el procedimiento almacenado
                DataTable dt = gDatos.EjecutarConsultaConParametros("EXEC sp_ReporteMateriasOfertadas @Cod_Carrera, @Cod_PlanEstudio, @Anio, @Semestre", parametros);

                if (dt.Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource("DataSetMateriasOfertadas", dt);
                    reportViewer1.LocalReport.ReportPath = "ReportMateriasOfertadas.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No se encontraron materias ofertadas para los criterios seleccionados.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de materias ofertadas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
