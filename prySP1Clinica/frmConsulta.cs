using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1Clinica
{
    public partial class frmConsulta : Form
    {

        // definición nombres de los archivos como constantes
        private const string NombreArchivoMedico = "Medicos.txt";
        private const string NombreArchivoEspecialidad = "Especialidades.txt";

        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            ListarEspecialidades();
            dgvConsulta.Rows.Clear();
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void btnRegistroEspecialidad_Click(object sender, EventArgs e)
        {
            // se crea un objeto de tipo frmRegistroEspecialidad pasando la ruta al archivo de especialidad
            frmRegistroEspecialidad frm = new frmRegistroEspecialidad(NombreArchivoEspecialidad);
            frm.ShowDialog();
        }

        private void btnRegistroMedico_Click(object sender, EventArgs e)
        {
            // se crea un objeto de tipo frmRegistroMedico pasando la ruta al archivo de medicos
            frmRegistroMedico frm = new frmRegistroMedico(NombreArchivoMedico);
            frm.ShowDialog();
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEspecialidad.Text = cmbEspecialidad.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(NombreArchivoMedico) || cmbEspecialidad.Text == "")
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            clsArchivo Medico = new clsArchivo();
            Medico.NombreArchivo = NombreArchivoMedico;
            List<clsRegistroMedico> ListaMedicos = Medico.ListarMedicos();

            clsArchivo Especialidad = new clsArchivo();
            Especialidad.NombreArchivo = NombreArchivoEspecialidad;
            List<clsRegistroEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();

            dgvConsulta.Rows.Clear();

            bool control = false;    
            foreach (clsRegistroEspecialidad especialidad in ListaEspecialidad)
            {
                if (especialidad.Nombre == cmbEspecialidad.Text)
                {
                    foreach (clsRegistroMedico medico in ListaMedicos)
                    {
                        if (especialidad.NumeroID == medico.NumEspecialidad)
                        {
                            dgvConsulta.Rows.Add(medico.Matricula, medico.Nombre);
                            control = true;
                        }
                    }
                }
            }

            if (control == false)
            {
                MessageBox.Show("No hay médicos registrados en esta especialidad.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ListarEspecialidades();
        }

        public void ListarEspecialidades()
        {
            if (!File.Exists(NombreArchivoEspecialidad))
            {
                cmbEspecialidad.Items.Clear();
                return;
            }

            clsArchivo Especialidad = new clsArchivo();
            Especialidad.NombreArchivo = NombreArchivoEspecialidad;
            List<clsRegistroEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();
            cmbEspecialidad.Items.Clear();

            foreach (clsRegistroEspecialidad especialidad in ListaEspecialidad)
            {
                cmbEspecialidad.Items.Add(especialidad.Nombre);
            }
        }
    }
}