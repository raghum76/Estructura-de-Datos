using System;

namespace Control_Inventario_EnlazadasSimples
{
    class Inventario
    {
        int cantidad = 0;
        Producto inicio = null;
        Producto fin = null;
        Producto aux = null;

        private bool _codigoRepetido = false;
        private bool _noElemento = false;

        public bool codigoRepetido { get { return _codigoRepetido; } }
        public bool noElemento { get { return _noElemento; } }

        public Producto Buscar(int code)
        {
            aux = inicio;
            while (aux.codigo != code && aux != fin) 
            {
                aux = aux.siguiente;
            }
            if (aux == fin)
                return null;
            else
                return aux;
        }

        public void Agregar(Producto prod)
        {
            if(inicio == null)
            {
                inicio = prod;
                fin = prod;
            }

            else
            {
                fin.siguiente = prod;
                fin = prod;
            }

            cantidad++;
        }

        public void Eliminar(int code)
        {
            aux = inicio;

            _noElemento = false;

            if (inicio != null)
            {
                if (code != aux.codigo)
                {
                    while (aux != fin && aux.siguiente.codigo != code)
                    { aux = aux.siguiente; }

                    if (aux != fin)
                    {
                        aux.siguiente = aux.siguiente.siguiente;
                        cantidad--;
                    }

                    else
                        _noElemento = true;
                }
                else
                {
                    inicio = inicio.siguiente;
                    cantidad--;
                }
            }
        }

        public void Insertar(Producto prod, int posicion)
        {
            if (posicion == 0)
            {
                prod.siguiente = inicio;
                inicio = prod;
                cantidad++;
            }
            else
            {
                aux = inicio;
                for (int x = 1; x < posicion; x++)
                {
                    aux = aux.siguiente;
                }
                prod.siguiente = aux.siguiente;
                aux.siguiente = prod;
                cantidad++;
            }
        }
        
        public string Mostrar()
        {
            string res = "";
            aux = inicio;
            for (int x = 0; x < cantidad; x++)
            {
                res += aux.ToString() + Environment.NewLine;
                aux = aux.siguiente;
            }
            return res;
        }
    }
       
}
