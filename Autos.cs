using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos_Lista
{
    class Autos
    {
        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private int anio;
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int noPuertas;
        public int NoPuertas
        {
            get { return noPuertas; }
            set { noPuertas = value; }
        }


    }
}
