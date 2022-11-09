using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.busquedas
{
    public partial class frmbusquedapedidos : Form
    {
        public frmbusquedapedidos()
        {
            InitializeComponent();
        }

        private void frmbusquedapedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pedidos.PEDIDO' Puede moverla o quitarla según sea necesario.
            this.pEDIDOTableAdapter.Fill(this.pedidos.PEDIDO);

        }
    }
}
