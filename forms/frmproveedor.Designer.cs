namespace WindowsFormsApp2.forms
{
    partial class frmproveedor
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
            this.cbxstatus = new System.Windows.Forms.ComboBox();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.mUNICIPIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet7 = new WindowsFormsApp2.panesitoDataSet7();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxregimen = new System.Windows.Forms.ComboBox();
            this.rEGIMENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet8 = new WindowsFormsApp2.panesitoDataSet8();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pdridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrapellidopatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrapellidomatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrregimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrRFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrrasonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrtelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrnuminteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrnumexteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrcoloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdridmunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVEEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoProveedores = new WindowsFormsApp2.PanesitoProveedores();
            this.pROVEEDORTableAdapter = new WindowsFormsApp2.PanesitoProveedoresTableAdapters.PROVEEDORTableAdapter();
            this.mUNICIPIOTableAdapter = new WindowsFormsApp2.panesitoDataSet7TableAdapters.MUNICIPIOTableAdapter();
            this.rEGIMENTableAdapter = new WindowsFormsApp2.panesitoDataSet8TableAdapters.REGIMENTableAdapter();
            this.txttelefono = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnombre = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtapellidop = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtapellidom = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtrazon_social = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcolonia = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnumint = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnumext = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcalle = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mUNICIPIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIMENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxstatus
            // 
            this.cbxstatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstatus.FormattingEnabled = true;
            this.cbxstatus.Items.AddRange(new object[] {
            "Activo",
            "Cancelado"});
            this.cbxstatus.Location = new System.Drawing.Point(1080, 160);
            this.cbxstatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxstatus.Name = "cbxstatus";
            this.cbxstatus.Size = new System.Drawing.Size(166, 44);
            this.cbxstatus.TabIndex = 66;
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.DataSource = this.mUNICIPIOBindingSource;
            this.cbxMunicipio.DisplayMember = "mu_descripcion";
            this.cbxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(778, 163);
            this.cbxMunicipio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(182, 44);
            this.cbxMunicipio.TabIndex = 65;
            this.cbxMunicipio.ValueMember = "mu_id_municipio";
            // 
            // mUNICIPIOBindingSource
            // 
            this.mUNICIPIOBindingSource.DataMember = "MUNICIPIO";
            this.mUNICIPIOBindingSource.DataSource = this.panesitoDataSet7;
            // 
            // panesitoDataSet7
            // 
            this.panesitoDataSet7.DataSetName = "panesitoDataSet7";
            this.panesitoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(611, 160);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 36);
            this.label11.TabIndex = 64;
            this.label11.Text = "Municipio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(963, 162);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 37);
            this.label10.TabIndex = 63;
            this.label10.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(622, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 39);
            this.label9.TabIndex = 62;
            this.label9.Text = "Colonia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(971, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 39);
            this.label8.TabIndex = 61;
            this.label8.Text = "N. Exterior:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 39);
            this.label7.TabIndex = 60;
            this.label7.Text = "N. Interior:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 39);
            this.label6.TabIndex = 59;
            this.label6.Text = "Apellido P:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 39);
            this.label5.TabIndex = 58;
            this.label5.Text = "Apellido M:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1017, 238);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 50);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(839, 238);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(173, 50);
            this.btnguardar.TabIndex = 56;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(82, 5);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(51, 46);
            this.txtid.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 39);
            this.label4.TabIndex = 54;
            this.label4.Text = "Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 39);
            this.label3.TabIndex = 53;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 39);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 39);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID:";
            // 
            // txtRFC
            // 
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.Location = new System.Drawing.Point(226, 211);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(47, 46);
            this.txtRFC.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(122, 212);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 39);
            this.label12.TabIndex = 68;
            this.label12.Text = "RFC:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 323);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 36);
            this.label13.TabIndex = 70;
            this.label13.Text = "Regimen:";
            // 
            // cbxregimen
            // 
            this.cbxregimen.DataSource = this.rEGIMENBindingSource;
            this.cbxregimen.DisplayMember = "rg_descripcion";
            this.cbxregimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxregimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxregimen.FormattingEnabled = true;
            this.cbxregimen.Location = new System.Drawing.Point(164, 323);
            this.cbxregimen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxregimen.Name = "cbxregimen";
            this.cbxregimen.Size = new System.Drawing.Size(1075, 37);
            this.cbxregimen.TabIndex = 71;
            this.cbxregimen.ValueMember = "rg_id";
            // 
            // rEGIMENBindingSource
            // 
            this.rEGIMENBindingSource.DataMember = "REGIMEN";
            this.rEGIMENBindingSource.DataSource = this.panesitoDataSet8;
            // 
            // panesitoDataSet8
            // 
            this.panesitoDataSet8.DataSetName = "panesitoDataSet8";
            this.panesitoDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1, 254);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 39);
            this.label14.TabIndex = 73;
            this.label14.Text = "Razon social:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pdridDataGridViewTextBoxColumn,
            this.pdrnombreDataGridViewTextBoxColumn,
            this.pdrapellidopatDataGridViewTextBoxColumn,
            this.pdrapellidomatDataGridViewTextBoxColumn,
            this.pdrregimenDataGridViewTextBoxColumn,
            this.pdrRFCDataGridViewTextBoxColumn,
            this.pdrrasonsocialDataGridViewTextBoxColumn,
            this.pdrtelefonoDataGridViewTextBoxColumn,
            this.pdrcalleDataGridViewTextBoxColumn,
            this.pdrnuminteriorDataGridViewTextBoxColumn,
            this.pdrnumexteriorDataGridViewTextBoxColumn,
            this.pdrcoloniaDataGridViewTextBoxColumn,
            this.pdridmunicipioDataGridViewTextBoxColumn,
            this.pdrstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROVEEDORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 535);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1214, 268);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pdridDataGridViewTextBoxColumn
            // 
            this.pdridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdridDataGridViewTextBoxColumn.DataPropertyName = "pdr_id";
            this.pdridDataGridViewTextBoxColumn.HeaderText = "pdr_id";
            this.pdridDataGridViewTextBoxColumn.Name = "pdridDataGridViewTextBoxColumn";
            this.pdridDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdridDataGridViewTextBoxColumn.Width = 61;
            // 
            // pdrnombreDataGridViewTextBoxColumn
            // 
            this.pdrnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrnombreDataGridViewTextBoxColumn.DataPropertyName = "pdr_nombre";
            this.pdrnombreDataGridViewTextBoxColumn.HeaderText = "pdr_nombre";
            this.pdrnombreDataGridViewTextBoxColumn.Name = "pdrnombreDataGridViewTextBoxColumn";
            this.pdrnombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrnombreDataGridViewTextBoxColumn.Width = 88;
            // 
            // pdrapellidopatDataGridViewTextBoxColumn
            // 
            this.pdrapellidopatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrapellidopatDataGridViewTextBoxColumn.DataPropertyName = "pdr_apellido_pat";
            this.pdrapellidopatDataGridViewTextBoxColumn.HeaderText = "pdr_apellido_pat";
            this.pdrapellidopatDataGridViewTextBoxColumn.Name = "pdrapellidopatDataGridViewTextBoxColumn";
            this.pdrapellidopatDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrapellidopatDataGridViewTextBoxColumn.Width = 110;
            // 
            // pdrapellidomatDataGridViewTextBoxColumn
            // 
            this.pdrapellidomatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrapellidomatDataGridViewTextBoxColumn.DataPropertyName = "pdr_apellido_mat";
            this.pdrapellidomatDataGridViewTextBoxColumn.HeaderText = "pdr_apellido_mat";
            this.pdrapellidomatDataGridViewTextBoxColumn.Name = "pdrapellidomatDataGridViewTextBoxColumn";
            this.pdrapellidomatDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrapellidomatDataGridViewTextBoxColumn.Width = 112;
            // 
            // pdrregimenDataGridViewTextBoxColumn
            // 
            this.pdrregimenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrregimenDataGridViewTextBoxColumn.DataPropertyName = "pdr_regimen";
            this.pdrregimenDataGridViewTextBoxColumn.HeaderText = "pdr_regimen";
            this.pdrregimenDataGridViewTextBoxColumn.Name = "pdrregimenDataGridViewTextBoxColumn";
            this.pdrregimenDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrregimenDataGridViewTextBoxColumn.Width = 90;
            // 
            // pdrRFCDataGridViewTextBoxColumn
            // 
            this.pdrRFCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrRFCDataGridViewTextBoxColumn.DataPropertyName = "pdr_RFC";
            this.pdrRFCDataGridViewTextBoxColumn.HeaderText = "pdr_RFC";
            this.pdrRFCDataGridViewTextBoxColumn.Name = "pdrRFCDataGridViewTextBoxColumn";
            this.pdrRFCDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrRFCDataGridViewTextBoxColumn.Width = 74;
            // 
            // pdrrasonsocialDataGridViewTextBoxColumn
            // 
            this.pdrrasonsocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrrasonsocialDataGridViewTextBoxColumn.DataPropertyName = "pdr_rason_social";
            this.pdrrasonsocialDataGridViewTextBoxColumn.HeaderText = "pdr_rason_social";
            this.pdrrasonsocialDataGridViewTextBoxColumn.Name = "pdrrasonsocialDataGridViewTextBoxColumn";
            this.pdrrasonsocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrrasonsocialDataGridViewTextBoxColumn.Width = 112;
            // 
            // pdrtelefonoDataGridViewTextBoxColumn
            // 
            this.pdrtelefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrtelefonoDataGridViewTextBoxColumn.DataPropertyName = "pdr_telefono";
            this.pdrtelefonoDataGridViewTextBoxColumn.HeaderText = "pdr_telefono";
            this.pdrtelefonoDataGridViewTextBoxColumn.Name = "pdrtelefonoDataGridViewTextBoxColumn";
            this.pdrtelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrtelefonoDataGridViewTextBoxColumn.Width = 91;
            // 
            // pdrcalleDataGridViewTextBoxColumn
            // 
            this.pdrcalleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrcalleDataGridViewTextBoxColumn.DataPropertyName = "pdr_calle";
            this.pdrcalleDataGridViewTextBoxColumn.HeaderText = "pdr_calle";
            this.pdrcalleDataGridViewTextBoxColumn.Name = "pdrcalleDataGridViewTextBoxColumn";
            this.pdrcalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrcalleDataGridViewTextBoxColumn.Width = 75;
            // 
            // pdrnuminteriorDataGridViewTextBoxColumn
            // 
            this.pdrnuminteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrnuminteriorDataGridViewTextBoxColumn.DataPropertyName = "pdr_num_interior";
            this.pdrnuminteriorDataGridViewTextBoxColumn.HeaderText = "pdr_num_interior";
            this.pdrnuminteriorDataGridViewTextBoxColumn.Name = "pdrnuminteriorDataGridViewTextBoxColumn";
            this.pdrnuminteriorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrnuminteriorDataGridViewTextBoxColumn.Width = 110;
            // 
            // pdrnumexteriorDataGridViewTextBoxColumn
            // 
            this.pdrnumexteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrnumexteriorDataGridViewTextBoxColumn.DataPropertyName = "pdr_num_exterior";
            this.pdrnumexteriorDataGridViewTextBoxColumn.HeaderText = "pdr_num_exterior";
            this.pdrnumexteriorDataGridViewTextBoxColumn.Name = "pdrnumexteriorDataGridViewTextBoxColumn";
            this.pdrnumexteriorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrnumexteriorDataGridViewTextBoxColumn.Width = 113;
            // 
            // pdrcoloniaDataGridViewTextBoxColumn
            // 
            this.pdrcoloniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrcoloniaDataGridViewTextBoxColumn.DataPropertyName = "pdr_colonia";
            this.pdrcoloniaDataGridViewTextBoxColumn.HeaderText = "pdr_colonia";
            this.pdrcoloniaDataGridViewTextBoxColumn.Name = "pdrcoloniaDataGridViewTextBoxColumn";
            this.pdrcoloniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrcoloniaDataGridViewTextBoxColumn.Width = 87;
            // 
            // pdridmunicipioDataGridViewTextBoxColumn
            // 
            this.pdridmunicipioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdridmunicipioDataGridViewTextBoxColumn.DataPropertyName = "pdr_id_municipio";
            this.pdridmunicipioDataGridViewTextBoxColumn.HeaderText = "pdr_id_municipio";
            this.pdridmunicipioDataGridViewTextBoxColumn.Name = "pdridmunicipioDataGridViewTextBoxColumn";
            this.pdridmunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdridmunicipioDataGridViewTextBoxColumn.Width = 111;
            // 
            // pdrstatusDataGridViewTextBoxColumn
            // 
            this.pdrstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrstatusDataGridViewTextBoxColumn.DataPropertyName = "pdr_status";
            this.pdrstatusDataGridViewTextBoxColumn.HeaderText = "pdr_status";
            this.pdrstatusDataGridViewTextBoxColumn.Name = "pdrstatusDataGridViewTextBoxColumn";
            this.pdrstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrstatusDataGridViewTextBoxColumn.Width = 81;
            // 
            // pROVEEDORBindingSource
            // 
            this.pROVEEDORBindingSource.DataMember = "PROVEEDOR";
            this.pROVEEDORBindingSource.DataSource = this.panesitoProveedores;
            // 
            // panesitoProveedores
            // 
            this.panesitoProveedores.DataSetName = "PanesitoProveedores";
            this.panesitoProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVEEDORTableAdapter
            // 
            this.pROVEEDORTableAdapter.ClearBeforeFill = true;
            // 
            // mUNICIPIOTableAdapter
            // 
            this.mUNICIPIOTableAdapter.ClearBeforeFill = true;
            // 
            // rEGIMENTableAdapter
            // 
            this.rEGIMENTableAdapter.ClearBeforeFill = true;
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txttelefono.Location = new System.Drawing.Point(314, 4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(232, 46);
            this.txttelefono.SoloLetras = false;
            this.txttelefono.SoloNumeros = true;
            this.txttelefono.TabIndex = 75;
            this.txttelefono.Validar = true;
            this.txttelefono.VRFC = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtnombre.Location = new System.Drawing.Point(225, 55);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(321, 46);
            this.txtnombre.SoloLetras = true;
            this.txtnombre.SoloNumeros = false;
            this.txtnombre.TabIndex = 76;
            this.txtnombre.Validar = false;
            this.txtnombre.VRFC = false;
            // 
            // txtapellidop
            // 
            this.txtapellidop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtapellidop.Location = new System.Drawing.Point(226, 107);
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(320, 46);
            this.txtapellidop.SoloLetras = true;
            this.txtapellidop.SoloNumeros = false;
            this.txtapellidop.TabIndex = 77;
            this.txtapellidop.Validar = false;
            this.txtapellidop.VRFC = false;
            // 
            // txtapellidom
            // 
            this.txtapellidom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtapellidom.Location = new System.Drawing.Point(226, 156);
            this.txtapellidom.Name = "txtapellidom";
            this.txtapellidom.Size = new System.Drawing.Size(321, 46);
            this.txtapellidom.SoloLetras = true;
            this.txtapellidom.SoloNumeros = false;
            this.txtapellidom.TabIndex = 78;
            this.txtapellidom.Validar = false;
            this.txtapellidom.VRFC = false;
            // 
            // txtrazon_social
            // 
            this.txtrazon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtrazon_social.Location = new System.Drawing.Point(245, 262);
            this.txtrazon_social.Name = "txtrazon_social";
            this.txtrazon_social.Size = new System.Drawing.Size(301, 46);
            this.txtrazon_social.SoloLetras = false;
            this.txtrazon_social.SoloNumeros = false;
            this.txtrazon_social.TabIndex = 79;
            this.txtrazon_social.Validar = false;
            this.txtrazon_social.VRFC = false;
            // 
            // txtcolonia
            // 
            this.txtcolonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtcolonia.Location = new System.Drawing.Point(786, 4);
            this.txtcolonia.Name = "txtcolonia";
            this.txtcolonia.Size = new System.Drawing.Size(457, 46);
            this.txtcolonia.SoloLetras = true;
            this.txtcolonia.SoloNumeros = false;
            this.txtcolonia.TabIndex = 80;
            this.txtcolonia.Validar = true;
            this.txtcolonia.VRFC = false;
            // 
            // txtnumint
            // 
            this.txtnumint.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtnumint.Location = new System.Drawing.Point(784, 56);
            this.txtnumint.Name = "txtnumint";
            this.txtnumint.Size = new System.Drawing.Size(145, 46);
            this.txtnumint.SoloLetras = false;
            this.txtnumint.SoloNumeros = true;
            this.txtnumint.TabIndex = 81;
            this.txtnumint.Validar = true;
            this.txtnumint.VRFC = false;
            // 
            // txtnumext
            // 
            this.txtnumext.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtnumext.Location = new System.Drawing.Point(1180, 57);
            this.txtnumext.Name = "txtnumext";
            this.txtnumext.Size = new System.Drawing.Size(100, 46);
            this.txtnumext.SoloLetras = false;
            this.txtnumext.SoloNumeros = true;
            this.txtnumext.TabIndex = 82;
            this.txtnumext.Validar = true;
            this.txtnumext.VRFC = false;
            // 
            // txtcalle
            // 
            this.txtcalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtcalle.Location = new System.Drawing.Point(784, 105);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(468, 46);
            this.txtcalle.SoloLetras = true;
            this.txtcalle.SoloNumeros = false;
            this.txtcalle.TabIndex = 83;
            this.txtcalle.Validar = true;
            this.txtcalle.VRFC = false;
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // frmproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 609);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.txtnumext);
            this.Controls.Add(this.txtnumint);
            this.Controls.Add(this.txtcolonia);
            this.Controls.Add(this.txtrazon_social);
            this.Controls.Add(this.txtapellidom);
            this.Controls.Add(this.txtapellidop);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbxregimen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxstatus);
            this.Controls.Add(this.cbxMunicipio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmproveedor";
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmproveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mUNICIPIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIMENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxstatus;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxregimen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PanesitoProveedores panesitoProveedores;
        private System.Windows.Forms.BindingSource pROVEEDORBindingSource;
        private PanesitoProveedoresTableAdapters.PROVEEDORTableAdapter pROVEEDORTableAdapter;
        private panesitoDataSet7 panesitoDataSet7;
        private System.Windows.Forms.BindingSource mUNICIPIOBindingSource;
        private panesitoDataSet7TableAdapters.MUNICIPIOTableAdapter mUNICIPIOTableAdapter;
        private panesitoDataSet8 panesitoDataSet8;
        private System.Windows.Forms.BindingSource rEGIMENBindingSource;
        private panesitoDataSet8TableAdapters.REGIMENTableAdapter rEGIMENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrapellidopatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrapellidomatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrregimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrRFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrrasonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrtelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrnuminteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrnumexteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrcoloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdridmunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrstatusDataGridViewTextBoxColumn;
        private Utilerias.Validacion txttelefono;
        private Utilerias.Validacion txtnombre;
        private Utilerias.Validacion txtapellidop;
        private Utilerias.Validacion txtapellidom;
        private Utilerias.Validacion txtrazon_social;
        private Utilerias.Validacion txtcolonia;
        private Utilerias.Validacion txtnumint;
        private Utilerias.Validacion txtnumext;
        private Utilerias.Validacion txtcalle;
        private System.Windows.Forms.ErrorProvider errorValidacion;
    }
}