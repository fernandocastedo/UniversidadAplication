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
    public partial class frmReporteAsistenciaEstudiante : Form
    {
        private gdatos gDatos = new gdatos();
        private int codMateria;

        public frmReporteAsistenciaEstudiante(int codMateria)
        {
            InitializeComponent();
            this.codMateria = codMateria;
        }

        private void frmReporteAsistenciaEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] parametros = {
                new SqlParameter("@Cod_Materia", codMateria)
            };

                DataTable dt = gDatos.EjecutarConsultaConParametros("EXEC sp_ReporteAsistenciaMateria @Cod_Materia", parametros);

                if (dt.Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource("DataSetAsistenciaEstudiante", dt);
                    reportViewer1.LocalReport.ReportPath = "ReportAsistenciaEstudiante.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros de asistencia para la materia seleccionada.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Si no necesitas lógica especial, basta refrescar el control.
            this.reportViewer1.RefreshReport();
        }
        private void frmReporteAsistenciaEstudiante_Load_1(object sender, EventArgs e)
        {

        }
    }
}
