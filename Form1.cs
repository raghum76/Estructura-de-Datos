using System;
using System.Windows.Forms;

namespace Control_Inventario_EnlazadasSimples
{
    public partial class Form1 : Form
    {
        Inventario x = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Agregar_Click(object sender, EventArgs e)
        {
            x.Agregar(new Producto(int.Parse(txt_codigo.Text),
                txt_nombre.Text , txt_precio.Text , int.Parse(txt_cantidad.Text)));
        }

        private void cmd_Buscar_Click(object sender, EventArgs e)
        {
            txt_Res.Text =  x.Buscar(int.Parse(txt_codigo.Text)).ToString();
            //Que pasara cuando no se encuentre lo que buscas?
        }

        private void cmd_Mostrar_Click(object sender, EventArgs e)
        {
            txt_Res.Text = x.Mostrar();
        }

        private void cmd_Borrar_Click(object sender, EventArgs e)
        {
            x.Eliminar(int.Parse(txt_codigo.Text));
        }

        private void cmd_Insertar_Click(object sender, EventArgs e)
        {
            x.Insertar(new Producto(int.Parse(txt_codigo.Text),
                txt_nombre.Text, txt_precio.Text, int.Parse(txt_cantidad.Text)), 
                int.Parse(txt_Posicion.Text) - 1);
        }

        private void cmd_InsertarInicio_Click(object sender, EventArgs e)
        {
            x.Insertar(new Producto(int.Parse(txt_codigo.Text),
              txt_nombre.Text, txt_precio.Text, int.Parse(txt_cantidad.Text)), 0);
        }
    }
}
