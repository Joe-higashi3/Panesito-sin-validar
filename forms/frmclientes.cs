using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.clases;

namespace WindowsFormsApp2.forms
{
    public partial class frmclientes : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmclientes()
        {
            InitializeComponent();
            sConexion = Conexion.conn();

        }
        private void frmclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMunicipio.MUNICIPIO' Puede moverla o quitarla según sea necesario.
            this.mUNICIPIOTableAdapter.Fill(this.dsMunicipio.MUNICIPIO);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet2.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter2.Fill(this.panesitoDataSet2.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet1.CLIENTE' Puede moverla o quitarla según sea necesario.
            //this.cLIENTETableAdapter1.Fill(this.panesitoDataSet1.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            //this.cLIENTETableAdapter.Fill(this.panesitoDataSet.CLIENTE);
            txttelefono.Focus();
            consecutivo();
        }

        private void GuardarCliente()
        {
            clscliente cliente = new clscliente();
            cliente.iIdcliente = Convert.ToInt32(txtid.Text);
            cliente.sNombre = txtnombre.Text;
            cliente.sApellido_p = txtapellidop.Text;
            cliente.sApellido_m = txtapellidom.Text;
            cliente.sTelefono = txttelefono.Text;
            cliente.sCalle = txtcalle.Text;
            cliente.sNum_int = txtnumint.Text;
            cliente.sNum_ext = txtnumext.Text;
            cliente.sColonia = txtcolonia.Text;
            cliente.iMunicipio = Convert.ToInt32(cmbxMunicipio.SelectedValue);
            cliente.sStatus = cmbxstatus.Text.Substring(0,1);
            if (cliente.Guardar() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: "+ cliente.error);
                
            }
        }
        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(cl_id_cliente),0) + 1 AS consecutivo FROM CLIENTE";


            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }


        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtapellidop.Clear();
            txtapellidom.Clear();
            txttelefono.Clear();
            txtcalle.Clear();
            txtnumint.Clear();
            txtnumext.Clear();
            txtcolonia.Clear();
            consecutivo();
            this.cLIENTETableAdapter2.Fill(this.panesitoDataSet2.CLIENTE);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        private void txtid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmpedidos PED = new frmpedidos();
                PED.Show();
            }
        }

        private void dtwclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_id_cliente.ToString();
            txtnombre.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_nombre.ToString();
            txtapellidop.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_apellido_pat.ToString();
            txtapellidom.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_apellido_mat.ToString();
            txttelefono.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_telefono.ToString();
            txtcalle.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_calle.ToString();
            txtnumint.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_num_interior.ToString();
            txtnumext.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_num_exterior.ToString();
            txtcolonia.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_colonia.ToString();
            cmbxMunicipio.SelectedValue = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_id_municipio;
            string sSTATUS;
            sSTATUS = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_status.ToString();
            switch (sSTATUS)
            {
                case "A":
                    cmbxstatus.Text = "Activo";
                    break;
                case "C":
                    cmbxstatus.Text = "Cancelado";
                    break;
                default:
                    cmbxstatus.Text = "Activo";
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
