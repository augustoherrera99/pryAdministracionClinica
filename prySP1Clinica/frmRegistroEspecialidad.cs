using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1Clinica
{
    public partial class frmRegistroEspecialidad : Form
    {
        // variable para guardar el nombre del archivo de especialidades
        private string NombreArchivoEspecialidad;

        public frmRegistroEspecialidad(string NombreArchivo)
        {
            InitializeComponent();
            NombreArchivoEspecialidad = NombreArchivo;
        }

        private void frmRegistroEspecialidad_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEspecialidad_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                clsRegistroEspecialidad NuevaEspecialidad = CrearEspecialidad();
                clsArchivo Especialidad = new clsArchivo();
                Especialidad.NombreArchivo = NombreArchivoEspecialidad;
                Especialidad.GrabarNuevaEspecialidad(NuevaEspecialidad);

                txtNombre.Text = "";
                txtNumeroID.Text = "";
                MessageBox.Show("¡Registro exitoso!", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos erróneos. Vuelve a intentarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private clsRegistroEspecialidad CrearEspecialidad()
        {
            clsRegistroEspecialidad NuevaEspecialidad = new clsRegistroEspecialidad();

            NuevaEspecialidad.Nombre = txtNombre.Text;
            NuevaEspecialidad.NumeroID = txtNumeroID.Text; 

            return NuevaEspecialidad;
        }

        private void btnSalirRegEsp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarDatos()
        {
            bool resultado = false;
            if (txtNombre.Text != "")
            {
                if (txtNumeroID.Text != "")
                {
                    clsArchivo Especialidad = new clsArchivo();
                    Especialidad.NombreArchivo = NombreArchivoEspecialidad;
                    if (Especialidad.BuscarNumeroEspecialidad(txtNumeroID.Text) == false)
                    {
                        if (Especialidad.BuscarNombreEspecialidad(txtNombre.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No se pueden ingresar ni comas ni numeros
            if ((!Char.IsLetter(e.KeyChar) || e.KeyChar == ',' || txtNombre.Text.Contains(",")) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtNumeroID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo se pueden ingresar numeros
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
