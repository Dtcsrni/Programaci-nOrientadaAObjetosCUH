using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productoss
{
    class Productos
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private float precio;
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int existencia;
        public int Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }
        private string proveedor;
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        
    }
}
