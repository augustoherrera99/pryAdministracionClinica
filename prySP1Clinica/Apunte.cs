using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prySP1Clinica
{
    internal class Apunte
    {
        // Propiedades Archivo
        public string NombreArchivo { get; set; }

        // definición nombres de los archivos como constantes en form principal (MUY IMPORTANTE)
        private const string NombreArchivoMedico = "Medicos.txt";
        private const string NombreArchivoEspecialidad = "Especialidades.txt";

        // Grabar datos
        public bool GrabarDatos(clsRegistroMedico Medico)
        {
            bool resultado = false;

            if (NombreArchivo != "")
            {
                StreamWriter AD = new StreamWriter(NombreArchivo, true);

                AD.WriteLine(Medico.Matricula + "," + Medico.Nombre + "," + Medico.NumEspecialidad);
                AD.Close();
                AD.Dispose();
                resultado = true;
            }
            return resultado;
        }

        //Leer Datos
        public bool LeerDatos()
        {
            bool resultado = false;
            string Linea;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);

                Linea = AD.ReadLine();
                clsRegistroEspecialidad Especialidad = new clsRegistroEspecialidad();

                Especialidad.Nombre = Linea.Split(',')[0];
                Especialidad.NumeroID = Linea.Split(',')[1];

                AD.Close();
                AD.Dispose();

                MessageBox.Show(Especialidad.Nombre + Especialidad.NumeroID);
                resultado = true;
            }
            return resultado;
        }

        // Crear Lista
        public List<clsRegistroEspecialidad> ListarDatos()
        {
            List<clsRegistroEspecialidad> Lista = new List<clsRegistroEspecialidad>();
            string Linea;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);

                while (AD.EndOfStream == false)
                {
                    Linea = AD.ReadLine();
                    clsRegistroEspecialidad Especialidad = new clsRegistroEspecialidad();
                    Especialidad.Nombre = Linea.Split(',')[0];
                    Especialidad.NumeroID = Linea.Split(',')[1];
                    Lista.Add(Especialidad);
                }
                AD.Close();
                AD.Dispose();
            }
            return Lista;
        }

        //Buscar Datos
        public bool BuscarDato(string Dato)
        {
            bool resultado = false;
            string Linea;
            string DatoLeido;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);

                while (AD.EndOfStream == false)
                {
                    Linea = AD.ReadLine();
                    DatoLeido = Linea.Split(',')[0];
                    if (DatoLeido == Dato)
                    {
                        resultado = true;
                        break;
                    }
                }
                AD.Close();
                AD.Dispose();
            }
            return resultado;
        }

        // Ordenar datos de una lista
        public List<clsRegistroEspecialidad> OrdenarDatos()
        {
            // lee el contenido completo del archivo y lo
            // almacena en una lista de objetos
            List<clsRegistroEspecialidad> Lista = ListarDatos();
            // convertir la lista en un arreglo con el método "ToArray()"
            clsRegistroEspecialidad[] DatosArray = Lista.ToArray();
            // ordenar el arreglo con el método de Burbuja
            // por el campo Nombre en forma ascendente (de menor a mayor)
            for (int i = 0; i < DatosArray.Length - 1; i++)
            {
                for (int j = 0; j < DatosArray.Length - 1; j++)
                {
                    // se comparan los nombres de los repuestos
                    // usando el método 'Compare' de la clase string
                    if (string.Compare(DatosArray[j].Nombre,
                    DatosArray[j + 1].Nombre) > 0)
                    {
                        // se intercambian si el nombre en j es mayor al nombre en j+1
                        clsRegistroEspecialidad aux = DatosArray[j];
                        DatosArray[j] = DatosArray[j + 1];
                        DatosArray[j + 1] = aux;
                    }
                }
            }
            // convertir el arreglo ya ordenado en una lista
            List<clsRegistroEspecialidad> Ordenados = DatosArray.ToList<clsRegistroEspecialidad>();
            // devuelve la lista ordenada por nombre en forma ascendente
            return Ordenados;
        }

        // Invocar Método ListarEspecialidad para mostrar en interfaz
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
                cmbEspecialidad.Items.Add(especialidad.Nombre); // Llenar combo
                dgvConsulta.Rows.Add(variable1, variable2); // Llenar DataGridView
            }
        }

        // Invocación método BuscarDato
        public bool ValidarDato()
        {
            bool resultado = false;

            clsArchivo Matricula = new clsArchivo();
            Matricula.NombreArchivo = NombreArchivoMedico;

            if (Matricula.BuscarMatricula(txtMatricula.Text) == false)
            {
                resultado = true;
            }
            return resultado;
        }
        
        
        // Invocación Método Grabar Dato
        public void Registrar()
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

        
        // Se crea nueva ventana y se pasa la dirección del archivo
        public void NuevaVentana()
        {
            // se crea un objeto de tipo frmRegistroEspecialidad pasando la ruta al archivo de especialidad
            frmRegistroEspecialidad frm = new frmRegistroEspecialidad(NombreArchivoEspecialidad);
            frm.ShowDialog();
        }

       // Lo que hay que colocar en el form de la nueva ventana
        
        // variable para guardar el nombre del archivo de especialidades
        private string NombreArchivoEspecialidad;

        public frmRegistroEspecialidad(string NombreArchivo)
        {
            InitializeComponent();
            NombreArchivoEspecialidad = NombreArchivo;
        }

        // Como escribir la dirección del archivo si no se encuentra enlazado a la ventana
        private void frmRegistroMedico_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\" + "Especialidades.txt"))
            {
                cmbEspecialidad.Items.Clear();

            }   return;
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
