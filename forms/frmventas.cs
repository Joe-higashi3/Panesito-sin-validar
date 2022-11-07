using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.busquedas;
namespace WindowsFormsApp2.forms
{
    public partial class frmventas : Form
    {
        public frmventas()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmbusquedaclientes bc = new frmbusquedaclientes();
            bc.Show();
        }
    }
}
