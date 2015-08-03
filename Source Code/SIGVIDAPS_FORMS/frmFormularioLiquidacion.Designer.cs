namespace SIGVIDAPS_FORMS
{
    partial class frmFormularioLiquidacion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Facturas = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lstImgFacturas = new System.Windows.Forms.ListView();
            this.Observaciones = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Transporte = new System.Windows.Forms.TabPage();
            this.btnEliminarTrans = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpHoraSalidaTrans = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalidaTrans = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtpHoraLlegadaTrans = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLlegadaTrans = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNuevoTrans = new System.Windows.Forms.Button();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoTransporte = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreTransporte = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgTransporte = new System.Windows.Forms.DataGridView();
            this.TransporteList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividades = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dtpHoraSalidaInf = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalidaInf = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dtpHoraLlegadaInf = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLlegadaInf = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalleActividades = new System.Windows.Forms.TextBox();
            this.DatosGenerales = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskNumeroSolicitud = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Facturas.SuspendLayout();
            this.Observaciones.SuspendLayout();
            this.Transporte.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransporte)).BeginInit();
            this.Actividades.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.DatosGenerales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SIGVIDAPS_FORMS.Properties.Resources.sigtierras;
            this.pictureBox1.Location = new System.Drawing.Point(565, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 109);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 43);
            this.label4.TabIndex = 18;
            this.label4.Text = "Formulario de Liquidación";
            // 
            // Facturas
            // 
            this.Facturas.Controls.Add(this.btnBuscar);
            this.Facturas.Controls.Add(this.txtMonto);
            this.Facturas.Controls.Add(this.label17);
            this.Facturas.Controls.Add(this.lstImgFacturas);
            this.Facturas.Location = new System.Drawing.Point(4, 22);
            this.Facturas.Name = "Facturas";
            this.Facturas.Size = new System.Drawing.Size(822, 443);
            this.Facturas.TabIndex = 4;
            this.Facturas.Text = "Facturas";
            this.Facturas.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources.document_search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(705, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 59);
            this.btnBuscar.TabIndex = 98;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.AccessibleName = "inpNumeroSolicitud";
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(593, 354);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(106, 20);
            this.txtMonto.TabIndex = 97;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.SlateGray;
            this.label17.Location = new System.Drawing.Point(510, 348);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 25);
            this.label17.TabIndex = 96;
            this.label17.Text = "Monto";
            // 
            // lstImgFacturas
            // 
            this.lstImgFacturas.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lstImgFacturas.Location = new System.Drawing.Point(45, 54);
            this.lstImgFacturas.MultiSelect = false;
            this.lstImgFacturas.Name = "lstImgFacturas";
            this.lstImgFacturas.Size = new System.Drawing.Size(654, 294);
            this.lstImgFacturas.TabIndex = 95;
            this.lstImgFacturas.UseCompatibleStateImageBehavior = false;
            // 
            // Observaciones
            // 
            this.Observaciones.Controls.Add(this.textBox5);
            this.Observaciones.Location = new System.Drawing.Point(4, 22);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Padding = new System.Windows.Forms.Padding(3);
            this.Observaciones.Size = new System.Drawing.Size(822, 443);
            this.Observaciones.TabIndex = 3;
            this.Observaciones.Text = "Observaciones";
            this.Observaciones.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(11, 13);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(794, 239);
            this.textBox5.TabIndex = 0;
            // 
            // Transporte
            // 
            this.Transporte.Controls.Add(this.btnEliminarTrans);
            this.Transporte.Controls.Add(this.groupBox6);
            this.Transporte.Controls.Add(this.groupBox7);
            this.Transporte.Controls.Add(this.btnNuevoTrans);
            this.Transporte.Controls.Add(this.cmbRuta);
            this.Transporte.Controls.Add(this.label7);
            this.Transporte.Controls.Add(this.cmbTipoTransporte);
            this.Transporte.Controls.Add(this.label6);
            this.Transporte.Controls.Add(this.label5);
            this.Transporte.Controls.Add(this.txtNombreTransporte);
            this.Transporte.Controls.Add(this.groupBox4);
            this.Transporte.Location = new System.Drawing.Point(4, 22);
            this.Transporte.Name = "Transporte";
            this.Transporte.Size = new System.Drawing.Size(822, 443);
            this.Transporte.TabIndex = 2;
            this.Transporte.Text = "Transporte";
            this.Transporte.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTrans
            // 
            this.btnEliminarTrans.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources.delete;
            this.btnEliminarTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTrans.Location = new System.Drawing.Point(746, 250);
            this.btnEliminarTrans.Name = "btnEliminarTrans";
            this.btnEliminarTrans.Size = new System.Drawing.Size(55, 58);
            this.btnEliminarTrans.TabIndex = 90;
            this.btnEliminarTrans.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.dtpHoraSalidaTrans);
            this.groupBox6.Controls.Add(this.dtpFechaSalidaTrans);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox6.Location = new System.Drawing.Point(24, 124);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(692, 57);
            this.groupBox6.TabIndex = 96;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Salida";
            // 
            // dtpHoraSalidaTrans
            // 
            this.dtpHoraSalidaTrans.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalidaTrans.Location = new System.Drawing.Point(518, 21);
            this.dtpHoraSalidaTrans.Name = "dtpHoraSalidaTrans";
            this.dtpHoraSalidaTrans.Size = new System.Drawing.Size(71, 22);
            this.dtpHoraSalidaTrans.TabIndex = 58;
            // 
            // dtpFechaSalidaTrans
            // 
            this.dtpFechaSalidaTrans.Location = new System.Drawing.Point(140, 21);
            this.dtpFechaSalidaTrans.Name = "dtpFechaSalidaTrans";
            this.dtpFechaSalidaTrans.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaSalidaTrans.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.SlateGray;
            this.label11.Location = new System.Drawing.Point(450, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "Hora";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.SlateGray;
            this.label14.Location = new System.Drawing.Point(56, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 25);
            this.label14.TabIndex = 53;
            this.label14.Text = "Fecha";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.dtpHoraLlegadaTrans);
            this.groupBox7.Controls.Add(this.dtpFechaLlegadaTrans);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox7.Location = new System.Drawing.Point(22, 187);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(692, 57);
            this.groupBox7.TabIndex = 94;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Llegada";
            // 
            // dtpHoraLlegadaTrans
            // 
            this.dtpHoraLlegadaTrans.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraLlegadaTrans.Location = new System.Drawing.Point(518, 21);
            this.dtpHoraLlegadaTrans.Name = "dtpHoraLlegadaTrans";
            this.dtpHoraLlegadaTrans.Size = new System.Drawing.Size(73, 22);
            this.dtpHoraLlegadaTrans.TabIndex = 58;
            // 
            // dtpFechaLlegadaTrans
            // 
            this.dtpFechaLlegadaTrans.Location = new System.Drawing.Point(140, 21);
            this.dtpFechaLlegadaTrans.Name = "dtpFechaLlegadaTrans";
            this.dtpFechaLlegadaTrans.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaLlegadaTrans.TabIndex = 57;
            this.dtpFechaLlegadaTrans.Value = new System.DateTime(2015, 8, 2, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.SlateGray;
            this.label8.Location = new System.Drawing.Point(450, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 54;
            this.label8.Text = "Hora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.SlateGray;
            this.label10.Location = new System.Drawing.Point(56, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 53;
            this.label10.Text = "Fecha";
            // 
            // btnNuevoTrans
            // 
            this.btnNuevoTrans.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources._new;
            this.btnNuevoTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoTrans.Location = new System.Drawing.Point(746, 169);
            this.btnNuevoTrans.Name = "btnNuevoTrans";
            this.btnNuevoTrans.Size = new System.Drawing.Size(55, 58);
            this.btnNuevoTrans.TabIndex = 87;
            this.btnNuevoTrans.Text = " ";
            this.btnNuevoTrans.UseVisualStyleBackColor = true;
            // 
            // cmbRuta
            // 
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(325, 85);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(377, 21);
            this.cmbRuta.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AccessibleName = "lblNumeroSolicitud";
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(103, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 93;
            this.label7.Text = "Ruta";
            // 
            // cmbTipoTransporte
            // 
            this.cmbTipoTransporte.FormattingEnabled = true;
            this.cmbTipoTransporte.Location = new System.Drawing.Point(326, 52);
            this.cmbTipoTransporte.Name = "cmbTipoTransporte";
            this.cmbTipoTransporte.Size = new System.Drawing.Size(377, 21);
            this.cmbTipoTransporte.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AccessibleName = "lblNumeroSolicitud";
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(103, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 25);
            this.label6.TabIndex = 91;
            this.label6.Text = "Nombre Transporte";
            // 
            // label5
            // 
            this.label5.AccessibleName = "lblNumeroSolicitud";
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(103, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Tipo Transporte";
            // 
            // txtNombreTransporte
            // 
            this.txtNombreTransporte.AccessibleName = "inpNumeroSolicitud";
            this.txtNombreTransporte.Location = new System.Drawing.Point(325, 16);
            this.txtNombreTransporte.Name = "txtNombreTransporte";
            this.txtNombreTransporte.Size = new System.Drawing.Size(378, 20);
            this.txtNombreTransporte.TabIndex = 88;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.dtgTransporte);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox4.Location = new System.Drawing.Point(22, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(694, 176);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transporte";
            // 
            // dtgTransporte
            // 
            this.dtgTransporte.AllowUserToAddRows = false;
            this.dtgTransporte.AllowUserToDeleteRows = false;
            this.dtgTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTransporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransporteList,
            this.Tipo,
            this.Ruta,
            this.Salida,
            this.Llegada});
            this.dtgTransporte.Location = new System.Drawing.Point(36, 21);
            this.dtgTransporte.MultiSelect = false;
            this.dtgTransporte.Name = "dtgTransporte";
            this.dtgTransporte.ReadOnly = true;
            this.dtgTransporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTransporte.Size = new System.Drawing.Size(644, 139);
            this.dtgTransporte.TabIndex = 0;
            // 
            // TransporteList
            // 
            this.TransporteList.HeaderText = "Transporte";
            this.TransporteList.Name = "TransporteList";
            this.TransporteList.ReadOnly = true;
            this.TransporteList.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            this.Ruta.Width = 125;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            this.Salida.Width = 125;
            // 
            // Llegada
            // 
            this.Llegada.HeaderText = "Llegada";
            this.Llegada.Name = "Llegada";
            this.Llegada.ReadOnly = true;
            this.Llegada.Width = 125;
            // 
            // Actividades
            // 
            this.Actividades.Controls.Add(this.groupBox3);
            this.Actividades.Location = new System.Drawing.Point(4, 22);
            this.Actividades.Name = "Actividades";
            this.Actividades.Padding = new System.Windows.Forms.Padding(3);
            this.Actividades.Size = new System.Drawing.Size(822, 443);
            this.Actividades.TabIndex = 1;
            this.Actividades.Text = "Informe de Actividades";
            this.Actividades.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDetalleActividades);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(18, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 388);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informe de Actividades y Productos Alcanzados";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.dtpHoraSalidaInf);
            this.groupBox8.Controls.Add(this.dtpFechaSalidaInf);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox8.Location = new System.Drawing.Point(17, 231);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(756, 57);
            this.groupBox8.TabIndex = 78;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Salida";
            // 
            // dtpHoraSalidaInf
            // 
            this.dtpHoraSalidaInf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalidaInf.Location = new System.Drawing.Point(566, 21);
            this.dtpHoraSalidaInf.Name = "dtpHoraSalidaInf";
            this.dtpHoraSalidaInf.Size = new System.Drawing.Size(71, 22);
            this.dtpHoraSalidaInf.TabIndex = 58;
            // 
            // dtpFechaSalidaInf
            // 
            this.dtpFechaSalidaInf.Location = new System.Drawing.Point(188, 21);
            this.dtpFechaSalidaInf.Name = "dtpFechaSalidaInf";
            this.dtpFechaSalidaInf.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaSalidaInf.TabIndex = 57;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.SlateGray;
            this.label19.Location = new System.Drawing.Point(498, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 25);
            this.label19.TabIndex = 54;
            this.label19.Text = "Hora";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.SlateGray;
            this.label20.Location = new System.Drawing.Point(104, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 25);
            this.label20.TabIndex = 53;
            this.label20.Text = "Fecha";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.White;
            this.groupBox9.Controls.Add(this.dtpHoraLlegadaInf);
            this.groupBox9.Controls.Add(this.dtpFechaLlegadaInf);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox9.Location = new System.Drawing.Point(15, 294);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(758, 57);
            this.groupBox9.TabIndex = 77;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Llegada";
            // 
            // dtpHoraLlegadaInf
            // 
            this.dtpHoraLlegadaInf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraLlegadaInf.Location = new System.Drawing.Point(566, 21);
            this.dtpHoraLlegadaInf.Name = "dtpHoraLlegadaInf";
            this.dtpHoraLlegadaInf.Size = new System.Drawing.Size(73, 22);
            this.dtpHoraLlegadaInf.TabIndex = 58;
            // 
            // dtpFechaLlegadaInf
            // 
            this.dtpFechaLlegadaInf.Location = new System.Drawing.Point(188, 21);
            this.dtpFechaLlegadaInf.Name = "dtpFechaLlegadaInf";
            this.dtpFechaLlegadaInf.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaLlegadaInf.TabIndex = 57;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.SlateGray;
            this.label21.Location = new System.Drawing.Point(498, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 25);
            this.label21.TabIndex = 54;
            this.label21.Text = "Hora";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.SlateGray;
            this.label22.Location = new System.Drawing.Point(104, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 25);
            this.label22.TabIndex = 53;
            this.label22.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Detalle";
            // 
            // txtDetalleActividades
            // 
            this.txtDetalleActividades.Location = new System.Drawing.Point(17, 59);
            this.txtDetalleActividades.Multiline = true;
            this.txtDetalleActividades.Name = "txtDetalleActividades";
            this.txtDetalleActividades.Size = new System.Drawing.Size(756, 140);
            this.txtDetalleActividades.TabIndex = 51;
            // 
            // DatosGenerales
            // 
            this.DatosGenerales.Controls.Add(this.groupBox1);
            this.DatosGenerales.Controls.Add(this.groupBox2);
            this.DatosGenerales.Location = new System.Drawing.Point(4, 22);
            this.DatosGenerales.Name = "DatosGenerales";
            this.DatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.DatosGenerales.Size = new System.Drawing.Size(822, 443);
            this.DatosGenerales.TabIndex = 0;
            this.DatosGenerales.Text = "Datos Generales";
            this.DatosGenerales.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.mskNumeroSolicitud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaSolicitud);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 91);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud de Licencia con Remuneración";
            // 
            // mskNumeroSolicitud
            // 
            this.mskNumeroSolicitud.Location = new System.Drawing.Point(19, 56);
            this.mskNumeroSolicitud.Mask = "999999999999999";
            this.mskNumeroSolicitud.Name = "mskNumeroSolicitud";
            this.mskNumeroSolicitud.Size = new System.Drawing.Size(142, 22);
            this.mskNumeroSolicitud.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblNumeroSolicitud";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nro Solicitud";
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblFechaSolicitud";
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(572, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Solicitud";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(543, 56);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(242, 22);
            this.dtpFechaSolicitud.TabIndex = 7;
            this.dtpFechaSolicitud.Value = new System.DateTime(2015, 8, 3, 2, 11, 58, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.lblCargo);
            this.groupBox2.Controls.Add(this.txtCiudad);
            this.groupBox2.Controls.Add(this.cmbUnidad);
            this.groupBox2.Controls.Add(this.cmbEmpleados);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Cargo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(5, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 177);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales";
            // 
            // label23
            // 
            this.label23.AccessibleName = "lblPuesto";
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.SlateGray;
            this.label23.Location = new System.Drawing.Point(311, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 25);
            this.label23.TabIndex = 59;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(312, 66);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(0, 16);
            this.lblCargo.TabIndex = 58;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AccessibleName = "inpNumeroSolicitud";
            this.txtCiudad.Location = new System.Drawing.Point(315, 91);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(286, 22);
            this.txtCiudad.TabIndex = 57;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Items.AddRange(new object[] {
            "Unidad Administrativa",
            "Unidad de RRHH"});
            this.cmbUnidad.Location = new System.Drawing.Point(315, 124);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(286, 24);
            this.cmbUnidad.TabIndex = 56;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(315, 30);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(286, 24);
            this.cmbEmpleados.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.SlateGray;
            this.label13.Location = new System.Drawing.Point(189, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 54;
            this.label13.Text = "Ciudad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.SlateGray;
            this.label12.Location = new System.Drawing.Point(189, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 53;
            this.label12.Text = "Unidad";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.BackColor = System.Drawing.Color.White;
            this.Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Cargo.ForeColor = System.Drawing.Color.SlateGray;
            this.Cargo.Location = new System.Drawing.Point(189, 59);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(75, 25);
            this.Cargo.TabIndex = 52;
            this.Cargo.Text = "Cargo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.SlateGray;
            this.label15.Location = new System.Drawing.Point(189, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 25);
            this.label15.TabIndex = 51;
            this.label15.Text = "Empleado";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DatosGenerales);
            this.tabControl1.Controls.Add(this.Actividades);
            this.tabControl1.Controls.Add(this.Transporte);
            this.tabControl1.Controls.Add(this.Observaciones);
            this.tabControl1.Controls.Add(this.Facturas);
            this.tabControl1.Location = new System.Drawing.Point(12, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 469);
            this.tabControl1.TabIndex = 82;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Location = new System.Drawing.Point(437, 591);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 49);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Location = new System.Drawing.Point(303, 591);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 49);
            this.btnGuardar.TabIndex = 83;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmFormularioLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources.awesome_white_wallpaper_70_113_hd_wallpapers;
            this.ClientSize = new System.Drawing.Size(854, 645);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmFormularioLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Formulario de Liquidación";
            this.Load += new System.EventHandler(this.frmFormularioLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Facturas.ResumeLayout(false);
            this.Facturas.PerformLayout();
            this.Observaciones.ResumeLayout(false);
            this.Observaciones.PerformLayout();
            this.Transporte.ResumeLayout(false);
            this.Transporte.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransporte)).EndInit();
            this.Actividades.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.DatosGenerales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Facturas;
        private System.Windows.Forms.TabPage Observaciones;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage Transporte;
        private System.Windows.Forms.TabPage Actividades;
        private System.Windows.Forms.TabPage DatosGenerales;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView lstImgFacturas;
        private System.Windows.Forms.Button btnEliminarTrans;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtpHoraSalidaTrans;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidaTrans;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegadaTrans;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegadaTrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNuevoTrans;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoTransporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreTransporte;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransporteList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llegada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dtpHoraSalidaInf;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidaInf;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegadaInf;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegadaInf;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalleActividades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskNumeroSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.ImageList imageList1;
    }
}