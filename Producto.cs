using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario_EnlazadasSimples
{
    class Producto
    {
        private int _codigo;
        public int codigo { get { return _codigo; } set { _codigo = value; } }

        private string _nombre;
        public string nombre { get { return _nombre; } set { _nombre = value; } }

        private string _precio;
        public string precio { get { return _precio; } set { _precio = value; } }

        private int _cantidad;
        public int cantidad { get { return _cantidad; } set { _cantidad = value; } }

        private Producto _siguiente;
        public Producto siguiente { get { return _siguiente; } set { _siguiente = value; } }

        public Producto()
        {

        }

        public Producto(int codigo, string nombre, string precio, int cantidad)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
            _siguiente = null;
        }

        public override string ToString()
        {
            return _codigo + ", " + _nombre + ", " + _cantidad + ", " + _precio;
        }

    }
}
