using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversidadAplication
{
    public partial class VerReportes : Form
    {
        public VerReportes()
        {
            InitializeComponent();
        }

        // Ejemplo 1: Desde un botón en el formulario principal
        private void btnReporteMateriasOfertadas_Click(object sender, EventArgs e)
        {
            // Obtener los valores desde controles del formulario
            int codCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
            int codPlanEstudio = Convert.ToInt32(cmbPlanEstudio.SelectedValue);
            int anio = Convert.ToInt32(nudAnio.Value);
            string semestre = cmbSemestre.Text;

            // Llamar al reporte
            ReportManager.AbrirReporteMateriasOfertadas(codCarrera, codPlanEstudio, anio, semestre);
        }

        // Ejemplo 2: Reporte de asistencia
        private void btnReporteAsistencia_Click(object sender, EventArgs e)
        {
            if (cmbMateria.SelectedValue != null)
            {
                int codMateria = Convert.ToInt32(cmbMateria.SelectedValue);
                ReportManager.AbrirReporteAsistencia(codMateria);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una materia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Ejemplo 3: Reporte de notas
        private void btnReporteNotas_Click(object sender, EventArgs e)
        {
            int codEstudiante = Convert.ToInt32(cmbEstudiante.SelectedValue);
            int anio = Convert.ToInt32(nudAnio.Value);
            string semestre = cmbSemestre.Text;

            ReportManager.AbrirReporteNotas(codEstudiante, anio, semestre);
        }

        // Ejemplo 4: Boletín de aprobados
        private void btnBoletin_Click(object sender, EventArgs e)
        {
            int codEstudiante = Convert.ToInt32(cmbEstudiante.SelectedValue);
            int anio = Convert.ToInt32(nudAnio.Value);
            string semestre = cmbSemestre.Text;

            ReportManager.AbrirBoletin(codEstudiante, anio, semestre);
        }
    }
}