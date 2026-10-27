using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Conectando a la base de datos
            GuardarBTN.Click += GuardarBTN_Click;
            MostrarBTN.Click += MostrarBTN_Click;
            LimpiarBTN.Click += LimpiarBTN_Click;
            //Consultamos los alumnos al abrir la ventana
            Load += Form1_Load;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EspecialidadTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void GuardarBTN_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                string.IsNullOrWhiteSpace(txtGrupo.Text) ||
                string.IsNullOrWhiteSpace(EspecialidadTXT.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(nudSemestre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Obtenemos los datos del formulario 
            try
            {
                using (OleDbConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = "INSERT INTO alumnos" + "(Matricula, Nombre, Semestre, Grupo, Especialidad)" +
                        "VALUES (?,?,?,?,?)";
                    using (OleDbCommand comando= new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtMatricula.Text.Trim();
                        comando.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtNombre.Text.Trim();
                        comando.Parameters.Add("?", OleDbType.Integer).Value = nudSemestre.Value;
                        comando.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtGrupo.Text.Trim();
                        comando.Parameters.Add("?", OleDbType.VarWChar, 50).Value = EspecialidadTXT.Text.Trim();
                        comando.ExecuteNonQuery();
                    }
                }
                LimpiarCampos();
                CargarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el alumno: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            nudSemestre.Value = 1;
            txtGrupo.Clear();
            EspecialidadTXT.Clear();
            txtMatricula.Focus();
        }
        private void MostrarBTN_Click(object sender, EventArgs e)
        {

        }
        private void CargarAlumnos()
        {
            try
            {
                using (OleDbConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = "SELECT IdAlumno , Matricula , Nombre," +
                        "Semestre , Grupo , Especialidad" +
                       " FROM alumnos Order by IdAlumno";
                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
                    { 
                        {
                            DataTable tabla = new DataTable();
                            adaptador.Fill(tabla);
                            DGValumnos.DataSource = tabla;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los alumnos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
