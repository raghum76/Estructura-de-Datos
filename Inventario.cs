using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario_EnlazadasSimples
{
    class Inventario
    {

        List<Producto> inventario = new List<Producto>();
        Producto inicio = null;

        private bool _codigoRepetido = false;
        private bool _noElemento = false;

        public bool codigoRepetido { get { return _codigoRepetido; } }
        public bool noElemento { get { return _noElemento; } }

        public Inventario()
        {
        }


        public Producto Buscar(int Codigo)
        {
            int c = 0;
            if (inicio != null)
            {
                while (c < inventario.Count && inventario[c].codigo != Codigo)
                { c++; }

                if (c != inventario.Count)
                    return inventario[c];
                else
                    return null;

            }
            return null;
        }

        public void Agregar(Producto Articulo)
        {
            if (Buscar(Articulo.codigo) != null)
            {
                _codigoRepetido = true;
            }
            else
            {
                _codigoRepetido = false;
                if(inicio==null)
                {
                    inicio = Articulo;
                    inventario.Add(Articulo);
                }
                else
                {
                    inventario[inventario.Count - 1].siguiente = Articulo;
                    inventario.Add(Articulo);
                }
            }
        }

        public void Borrar(int Codigo)
        {
            int c = 0;
            _noElemento = false;

            if (inicio != null)
            {
                if (Codigo != inicio.codigo)
                {
                    while (c < inventario.Count - 1 && inventario[c].siguiente.codigo != Codigo)
                    { c++; }

                    if (c != inventario.Count - 1)
                    {
                        inventario[c].siguiente = inventario[c].siguiente.siguiente;
                        inventario.Remove(inventario[c + 1]);
                    }

                    else
                        _noElemento = true;
                }
                else
                {
                    inventario.Remove(inventario[0]);
                    inicio = inventario[0];
                }

            }
            
        }

        public void Insertar(Producto Articulo, int posicion)
        {
            if (inicio != null)
            {
                if (posicion == 0)
                {
                    Articulo.siguiente = inventario[0];
                    inicio = Articulo;
                    inventario.Insert(0, Articulo);
                }
                else
                {
                    if (posicion < inventario.Count)
                    {
                        inventario.Insert(posicion, Articulo);
                        inventario[posicion - 1].siguiente = Articulo;
                        inventario[posicion].siguiente = inventario[posicion + 1];
                    }

                }
            }
        }

        public string Mostrar()
        {
            string res = "";
            for (int i = 0; i < inventario.Count; i++)
            {
                res += inventario[i] + Environment.NewLine;
            }
            return res;


        }

      
    }
}
