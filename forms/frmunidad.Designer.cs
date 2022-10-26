namespace WindowsFormsApp2.forms
{
    partial class frmunidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmunidad));
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidunidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvunidad = new System.Windows.Forms.DataGridView();
            this.unidunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.undescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoUnidad1 = new WindowsFormsApp2.panesitoUnidad1();
            this.uNIDADTableAdapter = new WindowsFormsApp2.panesitoUnidad1TableAdapters.UNIDADTableAdapter();
            this.txtdescunidad = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvunidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(356, 126);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(93, 32);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Unidad:";
            // 
            // txtidunidad
            // 
            this.txtidunidad.Enabled = false;
            this.txtidunidad.Location = new System.Drawing.Point(92, 37);
            this.txtidunidad.Name = "txtidunidad";
            this.txtidunidad.Size = new System.Drawing.Size(51, 20);
            this.txtidunidad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(240, 126);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(96, 32);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvunidad
            // 
            this.dgvunidad.AllowUserToAddRows = false;
            this.dgvunidad.AllowUserToDeleteRows = false;
            this.dgvunidad.AutoGenerateColumns = false;
            this.dgvunidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvunidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unidunidadDataGridViewTextBoxColumn,
            this.undescripcionDataGridViewTextBoxColumn});
            this.dgvunidad.DataSource = this.uNIDADBindingSource;
            this.dgvunidad.Location = new System.Drawing.Point(-1, 235);
            this.dgvunidad.Name = "dgvunidad";
            this.dgvunidad.ReadOnly = true;
            this.dgvunidad.Size = new System.Drawing.Size(858, 199);
            this.dgvunidad.TabIndex = 7;
            this.dgvunidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvunidad_CellContentClick);
            // 
            // unidunidadDataGridViewTextBoxColumn
            // 
            this.unidunidadDataGridViewTextBoxColumn.DataPropertyName = "un_id_unidad";
            this.unidunidadDataGridViewTextBoxColumn.HeaderText = "un_id_unidad";
            this.unidunidadDataGridViewTextBoxColumn.Name = "unidunidadDataGridViewTextBoxColumn";
            this.unidunidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // undescripcionDataGridViewTextBoxColumn
            // 
            this.undescripcionDataGridViewTextBoxColumn.DataPropertyName = "un_descripcion";
            this.undescripcionDataGridViewTextBoxColumn.HeaderText = "un_descripcion";
            this.undescripcionDataGridViewTextBoxColumn.Name = "undescripcionDataGridViewTextBoxColumn";
            this.undescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.panesitoUnidad1;
            // 
            // panesitoUnidad1
            // 
            this.panesitoUnidad1.DataSetName = "panesitoUnidad1";
            this.panesitoUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // txtdescunidad
            // 
            this.txtdescunidad.Location = new System.Drawing.Point(92, 80);
            this.txtdescunidad.Name = "txtdescunidad";
            this.txtdescunidad.Size = new System.Drawing.Size(100, 20);
            this.txtdescunidad.SoloLetras = false;
            this.txtdescunidad.SoloNumeros = true;
            this.txtdescunidad.TabIndex = 14;
            this.txtdescunidad.Validar = true;
            this.txtdescunidad.VRFC = false;
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            this.errorValidacion.Icon = ((System.Drawing.Icon)(resources.GetObject("errorValidacion.Icon")));
            // 
            // frmunidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 433);
            this.Controls.Add(this.txtdescunidad);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidunidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvunidad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmunidad";
            this.Text = "frmunidad";
            this.Load += new System.EventHandler(this.frmunidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvunidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidunidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvunidad;
        private panesitoUnidad1 panesitoUnidad1;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private panesitoUnidad1TableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn undescripcionDataGridViewTextBoxColumn;
        private Utilerias.Validacion txtdescunidad;
        private System.Windows.Forms.ErrorProvider errorValidacion;
    }
}