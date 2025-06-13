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
        // Enum que identifica cada reporte disponible
        private enum TipoReporte
        {
            MateriasOfertadas,
            Asistencia,
            Notas,
            Boletin
        }

        // Mapa que relaciona el tipo de reporte con su “launcher”
        private readonly Dictionary<TipoReporte, Action> _launchers;
        private TipoReporte _reporteActual;

        public VerReportes()
        {
            InitializeComponent();

            foreach (var num in new[] { numCarrera, numPlan, numAnio, numMateria, numEstudiante })
            {
                num.Maximum = 1000000;
                num.Minimum = 0;
                num.Width = 150;
            }
            numAnio.Maximum = 2100;
            numAnio.Minimum = 1950;
            numAnio.Value = DateTime.Now.Year;
            /* ---------- Mapeo de reportes ---------- */
            _launchers = new Dictionary<TipoReporte, Action>
            {
                { TipoReporte.MateriasOfertadas, LanzarMateriasOfertadas },
                { TipoReporte.Asistencia,         LanzarAsistencia },
                { TipoReporte.Notas,              LanzarNotas },
                { TipoReporte.Boletin,            LanzarBoletin }
            };

            /* ---------- Wire-up de menú ---------- */
            mnuRptMateriasOfertadas.Click += (_, __) => SeleccionarReporte(TipoReporte.MateriasOfertadas);
            mnuRptAsistencia.Click += (_, __) => SeleccionarReporte(TipoReporte.Asistencia);
            mnuRptNotas.Click += (_, __) => SeleccionarReporte(TipoReporte.Notas);
            mnuRptBoletin.Click += (_, __) => SeleccionarReporte(TipoReporte.Boletin);


            /* ---------- Estado inicial ---------- */
            btnGenerar.Enabled = false;      // hasta que se elija un reporte

            // Dejamos el panel sin filas para empezar
            tlpParametros.Controls.Clear();
            tlpParametros.RowStyles.Clear();
            tlpParametros.RowCount = 0;
        }

        /* ════════════════════════════════════════════════════════
           NAVEGACIÓN
           ════════════════════════════════════════════════════════ */
        private void SeleccionarReporte(TipoReporte tipo)
        {
            _reporteActual = tipo;
            ConstruirPanelParametros(tipo);   // repinta los controles requeridos
            btnGenerar.Enabled = true;
        }

        /* ════════════════════════════════════════════════════════
           BOTÓN “GENERAR”
           ════════════════════════════════════════════════════════ */
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (_launchers.TryGetValue(_reporteActual, out var action))
                action.Invoke();
        }

        /* ════════════════════════════════════════════════════════
           “Launchers” (es decir, abrir cada reporte)
           ════════════════════════════════════════════════════════ */
        private void LanzarMateriasOfertadas()
        {
            int codCarrera = (int)numCarrera.Value;
            int codPlanEstudio = (int)numPlan.Value;
            int anio = (int)numAnio.Value;
            string semestre = cboSemestre.Text;

            ReportManager.AbrirReporteMateriasOfertadas(
                codCarrera, codPlanEstudio, anio, semestre);
        }

        private void LanzarAsistencia()
        {
            int codMateria = (int)numMateria.Value;
            ReportManager.AbrirReporteAsistencia(codMateria);
        }

        private void LanzarNotas()
        {
            int codEstudiante = (int)numEstudiante.Value;
            int anio = (int)numAnio.Value;
            string semestre = cboSemestre.Text;

            ReportManager.AbrirReporteNotas(codEstudiante, anio, semestre);
        }

        private void LanzarBoletin()
        {
            int codEstudiante = (int)numEstudiante.Value;
            int anio = (int)numAnio.Value;
            string semestre = cboSemestre.Text;

            ReportManager.AbrirBoletin(codEstudiante, anio, semestre);
        }

        /* ════════════════════════════════════════════════════════
           Construcción dinámica del panel de parámetros
           (limpia y coloca solo los que requiere el reporte)
           ════════════════════════════════════════════════════════ */
        private void ConstruirPanelParametros(TipoReporte tipo)
        {
            tlpParametros.Controls.Clear();

            // helper local
            void AddRow(Control ctrl, string etiqueta)
            {
                var lbl = new Label { Text = etiqueta, Anchor = AnchorStyles.Right, AutoSize = true };
                tlpParametros.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                int row = tlpParametros.RowCount++;
                tlpParametros.Controls.Add(lbl, 0, row);
                tlpParametros.Controls.Add(ctrl, 1, row);
            }

            switch (tipo)
            {
                case TipoReporte.MateriasOfertadas:
                    AddRow(numCarrera, "Cod. Carrera");
                    AddRow(numPlan, "Cod. Plan");
                    AddRow(numAnio, "Año");
                    AddRow(cboSemestre, "Semestre");
                    break;

                case TipoReporte.Asistencia:
                    AddRow(numMateria, "Cod. Materia");
                    break;

                case TipoReporte.Notas:
                    AddRow(numEstudiante, "Cod. Estudiante");
                    AddRow(numAnio, "Año");
                    AddRow(cboSemestre, "Semestre");
                    break;

                case TipoReporte.Boletin:
                    AddRow(numEstudiante, "Cod. Estudiante");
                    AddRow(numAnio, "Año");
                    AddRow(cboSemestre, "Semestre");
                    break;
            }
        }
    }
}