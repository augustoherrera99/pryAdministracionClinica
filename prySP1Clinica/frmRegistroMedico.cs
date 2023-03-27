using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySP1Clinica
{
    public partial class frmRegistroMedico : Form
    {
        // variable para guardar el nombre del archivo de medicos
        private string NombreArchivoMedico;

        public frmRegistroMedico(string NombreArchivo)
        {
            InitializeComponent();
            NombreArchivoMedico = NombreArchivo;
        }

        private void frmRegistroMedico_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\" + "Especialidades.txt"))
            {
                cmbEspecialidad.Items.Clear();
                return;
            }

            clsArchivo Especialidad = new clsArchivo();
            Especialidad.NombreArchivo = Application.StartupPath + "\\" + "Especialidades.txt";
            List<clsRegistroEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();
            cmbEspecialidad.Items.Clear();

            foreach (clsRegistroEspecialidad especialidad in ListaEspecialidad)
            {
                cmbEspecialidad.Items.Add(especialidad.NumeroID);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                clsRegistroMedico NuevoMedico = CrearMedico();
                clsArchivo Medico = new clsArchivo();
                Medico.NombreArchivo = NombreArchivoMedico;
                Medico.GrabarNuevoMedico(NuevoMedico);

                txtMatricula.Text = "";
                txtNombre.Text = "";
                cmbEspecialidad.SelectedIndex = -1;
                MessageBox.Show("¡Registro exitoso!", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos erróneos. Vuelve a intentarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private clsRegistroMedico CrearMedico()
        {
            clsRegistroMedico NuevoMedico = new clsRegistroMedico();

            NuevoMedico.Matricula = txtMatricula.Text;
            NuevoMedico.Nombre = txtNombre.Text;
            NuevoMedico.NumEspecialidad = cmbEspecialidad.Text;

            return NuevoMedico;
        }

        public bool ValidarDatos()
        {
            bool resultado = false;

            if (txtMatricula.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (cmbEspecialidad.Text != "")
                    {
                        clsArchivo Matricula = new clsArchivo();
                        Matricula.NombreArchivo = NombreArchivoMedico;
                       
                        if (Matricula.BuscarMatricula(txtMatricula.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo se pueden ingresar numeros
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No se pueden ingresar comas ni numeros
            if ((!Char.IsLetter(e.KeyChar) || e.KeyChar == ',' || txtNombre.Text.Contains(",")) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
