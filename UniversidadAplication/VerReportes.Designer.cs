using System;

namespace UniversidadAplication
{
    partial class VerReportes
    {
        /// <summary>Variable del diseñador necesaria.</summary>
        private System.ComponentModel.IContainer components = null;

        /* ---------- Controles visibles ---------- */
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuModulos;

        // items de “Reportes”
        private System.Windows.Forms.ToolStripMenuItem mnuRptMateriasOfertadas;
        private System.Windows.Forms.ToolStripMenuItem mnuRptAsistencia;
        private System.Windows.Forms.ToolStripMenuItem mnuRptNotas;
        private System.Windows.Forms.ToolStripMenuItem mnuRptBoletin;

        // items de “Módulos”
        private System.Windows.Forms.ToolStripMenuItem mnuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterias;
        private System.Windows.Forms.ToolStripMenuItem mnuPlanes;

        private System.Windows.Forms.TableLayoutPanel tlpParametros;
        private System.Windows.Forms.Button btnGenerar;

        // Controles reutilizables (se añaden / quitan del tlp)
        internal System.Windows.Forms.NumericUpDown numCarrera;
        internal System.Windows.Forms.NumericUpDown numPlan;
        internal System.Windows.Forms.NumericUpDown numAnio;
        internal System.Windows.Forms.ComboBox cboSemestre;
        internal System.Windows.Forms.NumericUpDown numMateria;
        internal System.Windows.Forms.NumericUpDown numEstudiante;

        #region Código generado por Diseñador de Windows Forms
        /// <summary>Método necesario para admitir el Diseñador. No modifiques
        /// el contenido de este método con el editor de código.</summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModulos = new System.Windows.Forms.ToolStripMenuItem();

            this.mnuRptMateriasOfertadas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRptAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRptNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRptBoletin = new System.Windows.Forms.ToolStripMenuItem();

            this.mnuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlanes = new System.Windows.Forms.ToolStripMenuItem();

            this.tlpParametros = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerar = new System.Windows.Forms.Button();

            // ─────────────────────────────────────────────────────────
            // MenuStrip
            // ─────────────────────────────────────────────────────────
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuReportes,
                this.menuModulos});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(684, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuMain";

            // menuReportes
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuRptMateriasOfertadas,
                this.mnuRptAsistencia,
                this.mnuRptNotas,
                this.mnuRptBoletin});
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(65, 20);
            this.menuReportes.Text = "Reportes";

            // menuModulos
            this.menuModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuAlumnos,
                this.mnuMaterias,
                this.mnuPlanes});
            this.menuModulos.Name = "menuModulos";
            this.menuModulos.Size = new System.Drawing.Size(66, 20);
            this.menuModulos.Text = "Módulos";

            /* ---------- Items de Reportes ---------- */
            this.mnuRptMateriasOfertadas.Name = "mnuRptMateriasOfertadas";
            this.mnuRptMateriasOfertadas.Size = new System.Drawing.Size(187, 22);
            this.mnuRptMateriasOfertadas.Text = "Materias ofertadas";

            this.mnuRptAsistencia.Name = "mnuRptAsistencia";
            this.mnuRptAsistencia.Size = new System.Drawing.Size(187, 22);
            this.mnuRptAsistencia.Text = "Asistencia estudiante";

            this.mnuRptNotas.Name = "mnuRptNotas";
            this.mnuRptNotas.Size = new System.Drawing.Size(187, 22);
            this.mnuRptNotas.Text = "Notas materias cursadas";

            this.mnuRptBoletin.Name = "mnuRptBoletin";
            this.mnuRptBoletin.Size = new System.Drawing.Size(187, 22);
            this.mnuRptBoletin.Text = "Boletín";

            /* ---------- Items de Módulos ---------- */
            this.mnuAlumnos.Name = "mnuAlumnos";
            this.mnuAlumnos.Size = new System.Drawing.Size(180, 22);
            this.mnuAlumnos.Text = "Alumnos";

            this.mnuMaterias.Name = "mnuMaterias";
            this.mnuMaterias.Size = new System.Drawing.Size(180, 22);
            this.mnuMaterias.Text = "Materias";

            this.mnuPlanes.Name = "mnuPlanes";
            this.mnuPlanes.Size = new System.Drawing.Size(180, 22);
            this.mnuPlanes.Text = "Planes de estudio";

            // ─────────────────────────────────────────────────────────
            // TableLayoutPanel (parámetros)
            // ─────────────────────────────────────────────────────────
            this.tlpParametros.Anchor = ((System.Windows.Forms.AnchorStyles)
                                         ((((System.Windows.Forms.AnchorStyles.Top
                                         | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right))));
            this.tlpParametros.AutoSize = true;
            this.tlpParametros.ColumnCount = 2;
            this.tlpParametros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpParametros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpParametros.Location = new System.Drawing.Point(12, 40);
            this.tlpParametros.Name = "tlpParametros";
            this.tlpParametros.RowCount = 1;    // valor válido para el diseñador
            this.tlpParametros.RowStyles.Add(new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.AutoSize));
            this.tlpParametros.Size = new System.Drawing.Size(660, 0);
            this.tlpParametros.TabIndex = 1;

            // ─────────────────────────────────────────────────────────
            // Botón Generar
            // ─────────────────────────────────────────────────────────
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerar.Location = new System.Drawing.Point(572, 360);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 30);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            // ─────────────────────────────────────────────────────────
            // Controles ocultos/reutilizables
            // (no se muestran por defecto; los añade ConstruirPanelParametros)
            // ─────────────────────────────────────────────────────────
            this.numCarrera = new System.Windows.Forms.NumericUpDown();
            this.numPlan = new System.Windows.Forms.NumericUpDown();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.numMateria = new System.Windows.Forms.NumericUpDown();
            this.numEstudiante = new System.Windows.Forms.NumericUpDown();

            this.cboSemestre.Items.AddRange(new object[] { "1er Semestre", "2do Semestre" });
            this.cboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;


            // ─────────────────────────────────────────────────────────
            // Propiedades del Form
            // ─────────────────────────────────────────────────────────
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.tlpParametros);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "VerReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universidad – Reportes";

            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        /// <summary>Liberar los recursos que se estén usando.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
    }
}