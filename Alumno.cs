using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Alumnoss
{
    class Alumno
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre=value; }
        }
        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        private string grupo;
        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        private string carrera;
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
    }
}
