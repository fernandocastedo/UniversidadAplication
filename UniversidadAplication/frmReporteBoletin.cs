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
    public partial class frmReporteBoletin : Form
    {
        private gdatos gDatos = new gdatos();
        private int codEstudiante;
        private int anio;
        private string semestre;

        public frmReporteBoletin(int codEstudiante, int anio, string semestre)
        {
            InitializeComponent();
            this.codEstudiante = codEstudiante;
            this.anio = anio;
            this.semestre = semestre;
        }

        private void frmReporteBoletin_Load(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] parametros = {
                new SqlParameter("@Cod_Estudiante", codEstudiante),
                new SqlParameter("@Anio", anio),
                new SqlParameter("@Semestre", semestre)
            };

                DataTable dt = gDatos.EjecutarConsultaConParametros("EXEC sp_BoletinAprobados @Cod_Estudiante, @Anio, @Semestre", parametros);

                if (dt.Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource("DataSetBoletin", dt);
                    reportViewer1.LocalReport.ReportPath = "ReportBoletin.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("El estudiante no tiene materias aprobadas en la gestión seleccionada.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el boletín: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
