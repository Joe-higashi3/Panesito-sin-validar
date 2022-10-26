﻿using System;
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
    public partial class frmproveedor : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmproveedor()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }
        private void frmproveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet8.REGIMEN' Puede moverla o quitarla según sea necesario.
            this.rEGIMENTableAdapter.Fill(this.panesitoDataSet8.REGIMEN);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet7.MUNICIPIO' Puede moverla o quitarla según sea necesario.
            this.mUNICIPIOTableAdapter.Fill(this.panesitoDataSet7.MUNICIPIO);
            // TODO: esta línea de código carga datos en la tabla 'panesitoProveedores.PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORTableAdapter.Fill(this.panesitoProveedores.PROVEEDOR);
            txttelefono.Focus();
            consecutivo();
        }
        private void Guardar_proveedor()
        {
            clsproveedor proveedor = new clsproveedor();
            proveedor.iId_proveedor = Convert.ToInt32(txtid.Text);
            proveedor.sNombre = txtnombre.Text;
            proveedor.sApellido_pat = txtapellidop.Text;
            proveedor.sApellido_mat = txtapellidom.Text;
            proveedor.iRegimen = Convert.ToInt32(cbxregimen.SelectedValue);
            proveedor.sRFC = txtRFC.Text;
            proveedor.sRazon_social = txtrazon_social.Text;
            proveedor.sTelefono = txttelefono.Text;
            proveedor.sCalle = txtcalle.Text;
            proveedor.sNum_int = txtnumint.Text;
            proveedor.sNum_ext = txtnumext.Text;
            proveedor.sColonia = txtcolonia.Text;
            proveedor.iId_municipio = Convert.ToInt32(cbxMunicipio.SelectedValue);
            proveedor.sStatus = cbxstatus.Text.Substring(0, 1);
            if (proveedor.Guardar() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + proveedor.error);

            }
        }

        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(pdr_id),0) + 1 AS consecutivo FROM PROVEEDOR";
            
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
            txtRFC.Clear();
            txtrazon_social.Clear();
            txttelefono.Clear();
            txtcalle.Clear();
            txtnumint.Clear();
            txtnumext.Clear();
            txtcolonia.Clear();
            consecutivo();
            this.pROVEEDORTableAdapter.Fill(this.panesitoProveedores.PROVEEDOR);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_id.ToString();
            txtnombre.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_nombre.ToString();
            txtapellidop.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_apellido_pat.ToString();
            txtapellidom.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_apellido_mat.ToString();
            cbxregimen.SelectedValue = this.panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_regimen.ToString();
            txtRFC.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_RFC.ToString();
            txtrazon_social.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_rason_social.ToString();
            txttelefono.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_telefono.ToString();
            txtcalle.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_calle.ToString();
            txtnumint.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_num_interior.ToString();
            txtnumext.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_apellido_mat.ToString();
            txtcolonia.Text = panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_num_exterior.ToString();
            cbxMunicipio.SelectedValue = this.panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_id_municipio.ToString();
            cbxstatus.SelectedValue = this.panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_status.ToString();
            string sSTATUS;
            sSTATUS = this.panesitoProveedores.PROVEEDOR[pROVEEDORBindingSource.Position].pdr_status.ToString();
            switch (sSTATUS)
            {
                case "A":
                    cbxstatus.Text = "Activo";
                    break;
                case "C":
                    cbxstatus.Text = "Cancelado";
                    break;
                default:
                    cbxstatus.Text = "Activo";
                    break;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar_proveedor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
