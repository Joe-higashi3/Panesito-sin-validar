namespace WindowsFormsApp2.forms
{
    partial class frmalmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmalmacen));
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgalmacen = new System.Windows.Forms.DataGridView();
            this.apidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLMACENPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoAlmacen = new WindowsFormsApp2.panesitoAlmacen();
            this.aLMACEN_PRODUCTOTableAdapter = new WindowsFormsApp2.panesitoAlmacenTableAdapters.ALMACEN_PRODUCTOTableAdapter();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtnombre = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(214, 16);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 26);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(103, 18);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(68, 24);
            this.txtid.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // dgalmacen
            // 
            this.dgalmacen.AllowUserToAddRows = false;
            this.dgalmacen.AllowUserToDeleteRows = false;
            this.dgalmacen.AutoGenerateColumns = false;
            this.dgalmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgalmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apidDataGridViewTextBoxColumn,
            this.apnombreDataGridViewTextBoxColumn});
            this.dgalmacen.DataSource = this.aLMACENPRODUCTOBindingSource;
            this.dgalmacen.Location = new System.Drawing.Point(19, 115);
            this.dgalmacen.Name = "dgalmacen";
            this.dgalmacen.ReadOnly = true;
            this.dgalmacen.Size = new System.Drawing.Size(413, 267);
            this.dgalmacen.TabIndex = 6;
            this.dgalmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgalmacen_CellContentClick);
            // 
            // apidDataGridViewTextBoxColumn
            // 
            this.apidDataGridViewTextBoxColumn.DataPropertyName = "ap_id";
            this.apidDataGridViewTextBoxColumn.HeaderText = "ap_id";
            this.apidDataGridViewTextBoxColumn.Name = "apidDataGridViewTextBoxColumn";
            this.apidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apnombreDataGridViewTextBoxColumn
            // 
            this.apnombreDataGridViewTextBoxColumn.DataPropertyName = "ap_nombre";
            this.apnombreDataGridViewTextBoxColumn.HeaderText = "ap_nombre";
            this.apnombreDataGridViewTextBoxColumn.Name = "apnombreDataGridViewTextBoxColumn";
            this.apnombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLMACENPRODUCTOBindingSource
            // 
            this.aLMACENPRODUCTOBindingSource.DataMember = "ALMACEN_PRODUCTO";
            this.aLMACENPRODUCTOBindingSource.DataSource = this.panesitoAlmacen;
            // 
            // panesitoAlmacen
            // 
            this.panesitoAlmacen.DataSetName = "panesitoAlmacen";
            this.panesitoAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLMACEN_PRODUCTOTableAdapter
            // 
            this.aLMACEN_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(307, 16);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 26);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(103, 61);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(329, 20);
            this.txtnombre.SoloLetras = true;
            this.txtnombre.SoloNumeros = false;
            this.txtnombre.TabIndex = 13;
            this.txtnombre.Validar = true;
            this.txtnombre.VRFC = false;
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            this.errorValidacion.Icon = ((System.Drawing.Icon)(resources.GetObject("errorValidacion.Icon")));
            // 
            // frmalmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 399);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgalmacen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmalmacen";
            this.Text = "ALMACEN";
            this.Load += new System.EventHandler(this.frmalmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgalmacen;
        private panesitoAlmacen panesitoAlmacen;
        private System.Windows.Forms.BindingSource aLMACENPRODUCTOBindingSource;
        private panesitoAlmacenTableAdapters.ALMACEN_PRODUCTOTableAdapter aLMACEN_PRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btncancelar;
        private Utilerias.Validacion txtnombre;
        private System.Windows.Forms.ErrorProvider errorValidacion;
    }
}