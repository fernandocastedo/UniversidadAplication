using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadAplication
{
    public class ReportManager
    {
        public static void AbrirReporteMateriasOfertadas(int codCarrera, int codPlanEstudio, int anio, string semestre)
        {
            frmReporteMateriasOfertadas frm = new frmReporteMateriasOfertadas(codCarrera, codPlanEstudio, anio, semestre);
            frm.ShowDialog();
        }

        public static void AbrirReporteAsistencia(int codMateria)
        {
            frmReporteAsistenciaEstudiante frm = new frmReporteAsistenciaEstudiante(codMateria);
            frm.ShowDialog();
        }

        public static void AbrirReporteNotas(int codEstudiante, int anio, string semestre)
        {
            frmReporteNotasMateriasCursadas frm = new frmReporteNotasMateriasCursadas(codEstudiante, anio, semestre);
            frm.ShowDialog();
        }

        public static void AbrirBoletin(int codEstudiante, int anio, string semestre)
        {
            frmReporteBoletin frm = new frmReporteBoletin(codEstudiante, anio, semestre);
            frm.ShowDialog();
        }
    }
}
