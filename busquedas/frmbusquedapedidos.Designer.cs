﻿namespace WindowsFormsApp2.busquedas
{
    partial class frmbusquedapedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidos = new WindowsFormsApp2.Pedidos();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pEDIDOTableAdapter = new WindowsFormsApp2.PedidosTableAdapters.PEDIDOTableAdapter();
            this.peidpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_apellido_pat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peidclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peidempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peestatuspedidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 30);
            this.textBox4.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 88;
            this.label3.Text = "Telefono:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peidpedidoDataGridViewTextBoxColumn,
            this.cl_nombre,
            this.cl_apellido_pat,
            this.cl_telefono,
            this.peidclienteDataGridViewTextBoxColumn,
            this.peidempleadoDataGridViewTextBoxColumn,
            this.peestatuspedidoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.pEDIDOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 302);
            this.dataGridView1.TabIndex = 87;
            // 
            // pEDIDOBindingSource
            // 
            this.pEDIDOBindingSource.DataMember = "PEDIDO";
            this.pEDIDOBindingSource.DataSource = this.pedidos;
            // 
            // pedidos
            // 
            this.pedidos.DataSetName = "Pedidos";
            this.pedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(533, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 56);
            this.button7.TabIndex = 86;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(140, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(337, 30);
            this.textBox6.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 84;
            this.label6.Text = "Apellido P:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(140, 41);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(337, 30);
            this.txtnombre.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 90;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pEDIDOTableAdapter
            // 
            this.pEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // peidpedidoDataGridViewTextBoxColumn
            // 
            this.peidpedidoDataGridViewTextBoxColumn.DataPropertyName = "pe_id_pedido";
            this.peidpedidoDataGridViewTextBoxColumn.HeaderText = "pe_id_pedido";
            this.peidpedidoDataGridViewTextBoxColumn.Name = "peidpedidoDataGridViewTextBoxColumn";
            this.peidpedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cl_nombre
            // 
            this.cl_nombre.DataPropertyName = "cl_nombre";
            this.cl_nombre.HeaderText = "cl_nombre";
            this.cl_nombre.Name = "cl_nombre";
            this.cl_nombre.ReadOnly = true;
            // 
            // cl_apellido_pat
            // 
            this.cl_apellido_pat.DataPropertyName = "cl_apellido_pat";
            this.cl_apellido_pat.HeaderText = "cl_apellido_pat";
            this.cl_apellido_pat.Name = "cl_apellido_pat";
            this.cl_apellido_pat.ReadOnly = true;
            // 
            // cl_telefono
            // 
            this.cl_telefono.DataPropertyName = "cl_telefono";
            this.cl_telefono.HeaderText = "cl_telefono";
            this.cl_telefono.Name = "cl_telefono";
            this.cl_telefono.ReadOnly = true;
            // 
            // peidclienteDataGridViewTextBoxColumn
            // 
            this.peidclienteDataGridViewTextBoxColumn.DataPropertyName = "pe_id_cliente";
            this.peidclienteDataGridViewTextBoxColumn.HeaderText = "pe_id_cliente";
            this.peidclienteDataGridViewTextBoxColumn.Name = "peidclienteDataGridViewTextBoxColumn";
            this.peidclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peidempleadoDataGridViewTextBoxColumn
            // 
            this.peidempleadoDataGridViewTextBoxColumn.DataPropertyName = "pe_id_empleado";
            this.peidempleadoDataGridViewTextBoxColumn.HeaderText = "pe_id_empleado";
            this.peidempleadoDataGridViewTextBoxColumn.Name = "peidempleadoDataGridViewTextBoxColumn";
            this.peidempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peestatuspedidoDataGridViewCheckBoxColumn
            // 
            this.peestatuspedidoDataGridViewCheckBoxColumn.DataPropertyName = "pe_estatus_pedido";
            this.peestatuspedidoDataGridViewCheckBoxColumn.HeaderText = "pe_estatus_pedido";
            this.peestatuspedidoDataGridViewCheckBoxColumn.Name = "peestatuspedidoDataGridViewCheckBoxColumn";
            this.peestatuspedidoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // frmbusquedapedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmbusquedapedidos";
            this.Text = "frmbusquedapedidos";
            this.Load += new System.EventHandler(this.frmbusquedapedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Pedidos pedidos;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource;
        private PedidosTableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peidpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_apellido_pat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn peidclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peidempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn peestatuspedidoDataGridViewCheckBoxColumn;
    }
}