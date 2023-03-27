using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySP1Clinica
{
    public class clsArchivo
    {

        // propiedades
        public string NombreArchivo { get; set; }

        // métodos
        public bool GrabarNuevoMedico(clsRegistroMedico medico)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter AD = new StreamWriter(NombreArchivo, true);

                AD.WriteLine(medico.Matricula + "," + medico.Nombre + "," + medico.NumEspecialidad);
                AD.Close();
                AD.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public bool GrabarNuevaEspecialidad(clsRegistroEspecialidad especialidad)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter AD = new StreamWriter(NombreArchivo, true);

                AD.WriteLine(especialidad.Nombre + "," + especialidad.NumeroID);
                AD.Close();
                AD.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public List<clsRegistroEspecialidad> ListarEspecialidad()
        {
            List<clsRegistroEspecialidad> ListaEspecialidad = new List<clsRegistroEspecialidad>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                while (AD.EndOfStream == false)
                {
                    Linea = AD.ReadLine();
                    clsRegistroEspecialidad NuevaEspecialidad = new clsRegistroEspecialidad();
                    NuevaEspecialidad.Nombre = Linea.Split(',')[0];
                    NuevaEspecialidad.NumeroID = Linea.Split(',')[1];
                    ListaEspecialidad.Add(NuevaEspecialidad);
                }
                AD.Close();
                AD.Dispose();
            }
            return ListaEspecialidad;
        }

        public List<clsRegistroMedico> ListarMedicos()
        {
            List<clsRegistroMedico> ListaMedicos = new List<clsRegistroMedico>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                while (AD.EndOfStream == false)
                {
                    Linea = AD.ReadLine();
                    clsRegistroMedico Medico = new clsRegistroMedico();
                    Medico.Matricula = Linea.Split(',')[0];
                    Medico.Nombre = Linea.Split(',')[1];
                    Medico.NumEspecialidad = Linea.Split(',')[2];
                    ListaMedicos.Add(Medico);
                }
                AD.Close();
                AD.Dispose();
            }
            return ListaMedicos;
        }

        public bool BuscarNumeroEspecialidad(string Numero)
        {
            bool resultado = false;
            string Linea;
            string NumeroLeido;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                while (AD.EndOfStream == false)
                {
                    Linea = AD.ReadLine();
                    NumeroLeido = Linea.Split(',')[1];
                    if (Numero == NumeroLeido)
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

        public bool BuscarNombreEspecialidad(string Nombre)
        {
            bool resultado = false;
            string Linea;
            string NombreLeido;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                while (AD.EndOfStream == false)
                {
                    Linea = AD.ReadLine();
                    NombreLeido = Linea.Split(',')[0];
                    if (Nombre == NombreLeido)
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

        public bool BuscarMatricula(string Matricula)
        {
            bool resultado = false;
            string Linea;
            string MatriculaLeida;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                while (AD.EndOfStream == false)
                {
                    Linea = AD.ReadLine();
                    MatriculaLeida = Linea.Split(',')[0];
                    if (MatriculaLeida == Matricula)
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
    }
}
