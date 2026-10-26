namespace Escuela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MatriculaLabel = new Label();
            txtMatricula = new TextBox();
            NombreLabel = new Label();
            txtNombre = new TextBox();
            nudSemestre = new NumericUpDown();
            Semestre = new Label();
            GrupoLabel = new Label();
            txtGrupo = new TextBox();
            EspecialidadLabel = new Label();
            MostrarBTN = new Button();
            GuardarBTN = new Button();
            LimpiarBTN = new Button();
            DGValumnos = new DataGridView();
            EspecialidadTXT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGValumnos).BeginInit();
            SuspendLayout();
            // 
            // MatriculaLabel
            // 
            MatriculaLabel.AutoSize = true;
            MatriculaLabel.Location = new Point(29, 49);
            MatriculaLabel.Name = "MatriculaLabel";
            MatriculaLabel.Size = new Size(57, 15);
            MatriculaLabel.TabIndex = 0;
            MatriculaLabel.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(92, 49);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(156, 23);
            txtMatricula.TabIndex = 1;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(29, 164);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(51, 15);
            NombreLabel.TabIndex = 2;
            NombreLabel.Text = "Nombre";
            NombreLabel.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 164);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 23);
            txtNombre.TabIndex = 3;
            // 
            // nudSemestre
            // 
            nudSemestre.Location = new Point(404, 20);
            nudSemestre.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudSemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(120, 23);
            nudSemestre.TabIndex = 4;
            nudSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Semestre
            // 
            Semestre.AutoSize = true;
            Semestre.Location = new Point(333, 20);
            Semestre.Name = "Semestre";
            Semestre.Size = new Size(55, 15);
            Semestre.TabIndex = 5;
            Semestre.Text = "Semestre";
            // 
            // GrupoLabel
            // 
            GrupoLabel.AutoSize = true;
            GrupoLabel.Location = new Point(333, 95);
            GrupoLabel.Name = "GrupoLabel";
            GrupoLabel.Size = new Size(40, 15);
            GrupoLabel.TabIndex = 6;
            GrupoLabel.Text = "Grupo";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(404, 95);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(120, 23);
            txtGrupo.TabIndex = 7;
            // 
            // EspecialidadLabel
            // 
            EspecialidadLabel.AutoSize = true;
            EspecialidadLabel.Location = new Point(333, 172);
            EspecialidadLabel.Name = "EspecialidadLabel";
            EspecialidadLabel.Size = new Size(72, 15);
            EspecialidadLabel.TabIndex = 8;
            EspecialidadLabel.Text = "Especialidad";
            // 
            // MostrarBTN
            // 
            MostrarBTN.Location = new Point(663, 119);
            MostrarBTN.Name = "MostrarBTN";
            MostrarBTN.Size = new Size(75, 23);
            MostrarBTN.TabIndex = 9;
            MostrarBTN.Text = "Mostrar";
            MostrarBTN.UseVisualStyleBackColor = true;
            MostrarBTN.Click += MostrarBTN_Click;
            // 
            // GuardarBTN
            // 
            GuardarBTN.Location = new Point(663, 41);
            GuardarBTN.Name = "GuardarBTN";
            GuardarBTN.Size = new Size(75, 23);
            GuardarBTN.TabIndex = 10;
            GuardarBTN.Text = "Guardar";
            GuardarBTN.UseVisualStyleBackColor = true;
            GuardarBTN.Click += GuardarBTN_Click;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(663, 198);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(75, 23);
            LimpiarBTN.TabIndex = 11;
            LimpiarBTN.Text = "Limpiar";
            LimpiarBTN.UseVisualStyleBackColor = true;
            LimpiarBTN.Click += LimpiarBTN_Click;
            // 
            // DGValumnos
            // 
            DGValumnos.AllowUserToAddRows = false;
            DGValumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGValumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGValumnos.Location = new Point(12, 288);
            DGValumnos.Name = "DGValumnos";
            DGValumnos.ReadOnly = true;
            DGValumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGValumnos.Size = new Size(776, 271);
            DGValumnos.TabIndex = 12;
            // 
            // EspecialidadTXT
            // 
            EspecialidadTXT.Location = new Point(411, 161);
            EspecialidadTXT.Name = "EspecialidadTXT";
            EspecialidadTXT.Size = new Size(113, 23);
            EspecialidadTXT.TabIndex = 13;
            EspecialidadTXT.TextChanged += EspecialidadTXT_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 581);
            Controls.Add(EspecialidadTXT);
            Controls.Add(DGValumnos);
            Controls.Add(LimpiarBTN);
            Controls.Add(GuardarBTN);
            Controls.Add(MostrarBTN);
            Controls.Add(EspecialidadLabel);
            Controls.Add(txtGrupo);
            Controls.Add(GrupoLabel);
            Controls.Add(Semestre);
            Controls.Add(nudSemestre);
            Controls.Add(txtNombre);
            Controls.Add(NombreLabel);
            Controls.Add(txtMatricula);
            Controls.Add(MatriculaLabel);
            Name = "Form1";
            Text = "Base de datos con Access";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGValumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MatriculaLabel;
        private TextBox txtMatricula;
        private Label NombreLabel;
        private TextBox txtNombre;
        private NumericUpDown nudSemestre;
        private Label Semestre;
        private Label GrupoLabel;
        private TextBox txtGrupo;
        private Label EspecialidadLabel;
        private Button MostrarBTN;
        private Button GuardarBTN;
        private Button LimpiarBTN;
        private DataGridView DGValumnos;
        private TextBox EspecialidadTXT;
    }
}
