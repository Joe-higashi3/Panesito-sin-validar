namespace WindowsFormsApp2.forms
{
    partial class frmcategoria
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcategoria = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoCategoria = new WindowsFormsApp2.panesitoCategoria();
            this.cATEGORIATableAdapter = new WindowsFormsApp2.panesitoCategoriaTableAdapters.CATEGORIATableAdapter();
            this.txtdescripcion = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(254, 105);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(130, 77);
            this.btncancelar.TabIndex = 22;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(95, 105);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(130, 77);
            this.btnguardar.TabIndex = 21;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(48, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(130, 20);
            this.txtid.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id";
            // 
            // dgvcategoria
            // 
            this.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategoria.Location = new System.Drawing.Point(29, 188);
            this.dgvcategoria.Name = "dgvcategoria";
            this.dgvcategoria.Size = new System.Drawing.Size(0, 0);
            this.dgvcategoria.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caidDataGridViewTextBoxColumn,
            this.cadescripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cATEGORIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 199);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // caidDataGridViewTextBoxColumn
            // 
            this.caidDataGridViewTextBoxColumn.DataPropertyName = "ca_id";
            this.caidDataGridViewTextBoxColumn.HeaderText = "ca_id";
            this.caidDataGridViewTextBoxColumn.Name = "caidDataGridViewTextBoxColumn";
            this.caidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadescripcionDataGridViewTextBoxColumn
            // 
            this.cadescripcionDataGridViewTextBoxColumn.DataPropertyName = "ca_descripcion";
            this.cadescripcionDataGridViewTextBoxColumn.HeaderText = "ca_descripcion";
            this.cadescripcionDataGridViewTextBoxColumn.Name = "cadescripcionDataGridViewTextBoxColumn";
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.panesitoCategoria;
            // 
            // panesitoCategoria
            // 
            this.panesitoCategoria.DataSetName = "panesitoCategoria";
            this.panesitoCategoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(95, 69);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(289, 20);
            this.txtdescripcion.SoloLetras = true;
            this.txtdescripcion.SoloNumeros = false;
            this.txtdescripcion.TabIndex = 25;
            this.txtdescripcion.Validar = true;
            this.txtdescripcion.VRFC = false;
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // frmcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcategoria);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmcategoria";
            this.Text = "frmcategoria";
            this.Load += new System.EventHandler(this.frmcategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private panesitoCategoria panesitoCategoria;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private panesitoCategoriaTableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn caidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadescripcionDataGridViewTextBoxColumn;
        private Utilerias.Validacion txtdescripcion;
        private System.Windows.Forms.ErrorProvider errorValidacion;
    }
}