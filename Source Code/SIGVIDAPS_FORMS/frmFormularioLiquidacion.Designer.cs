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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Facturas = new System.Windows.Forms.TabPage();
            this.Observaciones = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Transporte = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgTransporte = new System.Windows.Forms.DataGridView();
            this.txtNombreTransporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoTransporte = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.btnNuevoTrans = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaLlegadaTrans = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraLlegadaTrans = new System.Windows.Forms.DateTimePicker();
            this.btnModificarTrans = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaSalidaTrans = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalidaTrans = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarTrans = new System.Windows.Forms.Button();
            this.btnGuardarTrans = new System.Windows.Forms.Button();
            this.Actividades = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDetalleActividades = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaLlegadaInf = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraLlegadaInf = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaSalidaInf = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalidaInf = new System.Windows.Forms.DateTimePicker();
            this.DatosGenerales = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroSolicitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Observaciones.SuspendLayout();
            this.Transporte.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransporte)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.Actividades.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.DatosGenerales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.Facturas.Location = new System.Drawing.Point(4, 22);
            this.Facturas.Name = "Facturas";
            this.Facturas.Size = new System.Drawing.Size(822, 443);
            this.Facturas.TabIndex = 4;
            this.Facturas.Text = "Facturas";
            this.Facturas.UseVisualStyleBackColor = true;
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
            this.Transporte.Controls.Add(this.btnGuardarTrans);
            this.Transporte.Controls.Add(this.btnEliminarTrans);
            this.Transporte.Controls.Add(this.groupBox6);
            this.Transporte.Controls.Add(this.btnModificarTrans);
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.dtgTransporte);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox4.Location = new System.Drawing.Point(17, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(694, 176);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transporte";
            // 
            // dtgTransporte
            // 
            this.dtgTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTransporte.Location = new System.Drawing.Point(17, 21);
            this.dtgTransporte.Name = "dtgTransporte";
            this.dtgTransporte.Size = new System.Drawing.Size(657, 139);
            this.dtgTransporte.TabIndex = 0;
            // 
            // txtNombreTransporte
            // 
            this.txtNombreTransporte.AccessibleName = "inpNumeroSolicitud";
            this.txtNombreTransporte.Location = new System.Drawing.Point(297, 22);
            this.txtNombreTransporte.Name = "txtNombreTransporte";
            this.txtNombreTransporte.Size = new System.Drawing.Size(378, 20);
            this.txtNombreTransporte.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AccessibleName = "lblNumeroSolicitud";
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(75, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "Tipo Transporte";
            // 
            // label6
            // 
            this.label6.AccessibleName = "lblNumeroSolicitud";
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(75, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 25);
            this.label6.TabIndex = 68;
            this.label6.Text = "Nombre Transporte";
            // 
            // cmbTipoTransporte
            // 
            this.cmbTipoTransporte.FormattingEnabled = true;
            this.cmbTipoTransporte.Location = new System.Drawing.Point(298, 58);
            this.cmbTipoTransporte.Name = "cmbTipoTransporte";
            this.cmbTipoTransporte.Size = new System.Drawing.Size(377, 21);
            this.cmbTipoTransporte.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AccessibleName = "lblNumeroSolicitud";
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(75, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 70;
            this.label7.Text = "Ruta";
            // 
            // cmbRuta
            // 
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(297, 91);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(377, 21);
            this.cmbRuta.TabIndex = 73;
            // 
            // btnNuevoTrans
            // 
            this.btnNuevoTrans.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources._new;
            this.btnNuevoTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoTrans.Location = new System.Drawing.Point(742, 101);
            this.btnNuevoTrans.Name = "btnNuevoTrans";
            this.btnNuevoTrans.Size = new System.Drawing.Size(55, 58);
            this.btnNuevoTrans.TabIndex = 66;
            this.btnNuevoTrans.Text = " ";
            this.btnNuevoTrans.UseVisualStyleBackColor = true;
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
            this.groupBox7.Location = new System.Drawing.Point(17, 207);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(692, 57);
            this.groupBox7.TabIndex = 73;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Llegada";
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
            // dtpFechaLlegadaTrans
            // 
            this.dtpFechaLlegadaTrans.Location = new System.Drawing.Point(140, 21);
            this.dtpFechaLlegadaTrans.Name = "dtpFechaLlegadaTrans";
            this.dtpFechaLlegadaTrans.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaLlegadaTrans.TabIndex = 57;
            // 
            // dtpHoraLlegadaTrans
            // 
            this.dtpHoraLlegadaTrans.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraLlegadaTrans.Location = new System.Drawing.Point(518, 21);
            this.dtpHoraLlegadaTrans.Name = "dtpHoraLlegadaTrans";
            this.dtpHoraLlegadaTrans.Size = new System.Drawing.Size(73, 22);
            this.dtpHoraLlegadaTrans.TabIndex = 58;
            // 
            // btnModificarTrans
            // 
            this.btnModificarTrans.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources.edit;
            this.btnModificarTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarTrans.Location = new System.Drawing.Point(742, 227);
            this.btnModificarTrans.Name = "btnModificarTrans";
            this.btnModificarTrans.Size = new System.Drawing.Size(55, 58);
            this.btnModificarTrans.TabIndex = 67;
            this.btnModificarTrans.UseVisualStyleBackColor = true;
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
            this.groupBox6.Location = new System.Drawing.Point(19, 144);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(692, 57);
            this.groupBox6.TabIndex = 74;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Salida";
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
            // dtpFechaSalidaTrans
            // 
            this.dtpFechaSalidaTrans.Location = new System.Drawing.Point(140, 21);
            this.dtpFechaSalidaTrans.Name = "dtpFechaSalidaTrans";
            this.dtpFechaSalidaTrans.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaSalidaTrans.TabIndex = 57;
            // 
            // dtpHoraSalidaTrans
            // 
            this.dtpHoraSalidaTrans.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalidaTrans.Location = new System.Drawing.Point(518, 21);
            this.dtpHoraSalidaTrans.Name = "dtpHoraSalidaTrans";
            this.dtpHoraSalidaTrans.Size = new System.Drawing.Size(71, 22);
            this.dtpHoraSalidaTrans.TabIndex = 58;
            // 
            // btnEliminarTrans
            // 
            this.btnEliminarTrans.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources.delete;
            this.btnEliminarTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTrans.Location = new System.Drawing.Point(742, 291);
            this.btnEliminarTrans.Name = "btnEliminarTrans";
            this.btnEliminarTrans.Size = new System.Drawing.Size(55, 58);
            this.btnEliminarTrans.TabIndex = 68;
            this.btnEliminarTrans.UseVisualStyleBackColor = true;
            // 
            // btnGuardarTrans
            // 
            this.btnGuardarTrans.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources.save;
            this.btnGuardarTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarTrans.Location = new System.Drawing.Point(742, 164);
            this.btnGuardarTrans.Name = "btnGuardarTrans";
            this.btnGuardarTrans.Size = new System.Drawing.Size(55, 58);
            this.btnGuardarTrans.TabIndex = 69;
            this.btnGuardarTrans.Text = " ";
            this.btnGuardarTrans.UseVisualStyleBackColor = true;
            this.btnGuardarTrans.Click += new System.EventHandler(this.btnGuardarTrans_Click);
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
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDetalleActividades);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(17, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 388);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informe de Actividades y Productos Alcanzados";
            // 
            // txtDetalleActividades
            // 
            this.txtDetalleActividades.Location = new System.Drawing.Point(17, 59);
            this.txtDetalleActividades.Multiline = true;
            this.txtDetalleActividades.Name = "txtDetalleActividades";
            this.txtDetalleActividades.Size = new System.Drawing.Size(756, 140);
            this.txtDetalleActividades.TabIndex = 51;
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
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.dtpHoraLlegadaInf);
            this.groupBox8.Controls.Add(this.dtpFechaLlegadaInf);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox8.Location = new System.Drawing.Point(50, 280);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(692, 57);
            this.groupBox8.TabIndex = 75;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Llegada";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.SlateGray;
            this.label18.Location = new System.Drawing.Point(56, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 25);
            this.label18.TabIndex = 53;
            this.label18.Text = "Fecha";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.SlateGray;
            this.label17.Location = new System.Drawing.Point(450, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 25);
            this.label17.TabIndex = 54;
            this.label17.Text = "Hora";
            // 
            // dtpFechaLlegadaInf
            // 
            this.dtpFechaLlegadaInf.Location = new System.Drawing.Point(140, 21);
            this.dtpFechaLlegadaInf.Name = "dtpFechaLlegadaInf";
            this.dtpFechaLlegadaInf.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaLlegadaInf.TabIndex = 57;
            // 
            // dtpHoraLlegadaInf
            // 
            this.dtpHoraLlegadaInf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraLlegadaInf.Location = new System.Drawing.Point(518, 21);
            this.dtpHoraLlegadaInf.Name = "dtpHoraLlegadaInf";
            this.dtpHoraLlegadaInf.Size = new System.Drawing.Size(101, 22);
            this.dtpHoraLlegadaInf.TabIndex = 58;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.dtpHoraSalidaInf);
            this.groupBox5.Controls.Add(this.dtpFechaSalidaInf);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox5.Location = new System.Drawing.Point(52, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(692, 57);
            this.groupBox5.TabIndex = 76;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Salida";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.SlateGray;
            this.label16.Location = new System.Drawing.Point(56, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 25);
            this.label16.TabIndex = 53;
            this.label16.Text = "Fecha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.SlateGray;
            this.label9.Location = new System.Drawing.Point(450, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Hora";
            // 
            // dtpFechaSalidaInf
            // 
            this.dtpFechaSalidaInf.Location = new System.Drawing.Point(140, 21);
            this.dtpFechaSalidaInf.Name = "dtpFechaSalidaInf";
            this.dtpFechaSalidaInf.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaSalidaInf.TabIndex = 57;
            // 
            // dtpHoraSalidaInf
            // 
            this.dtpHoraSalidaInf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalidaInf.Location = new System.Drawing.Point(518, 21);
            this.dtpHoraSalidaInf.Name = "dtpHoraSalidaInf";
            this.dtpHoraSalidaInf.Size = new System.Drawing.Size(101, 22);
            this.dtpHoraSalidaInf.TabIndex = 58;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblCargo);
            this.groupBox2.Controls.Add(this.txtCiudad);
            this.groupBox2.Controls.Add(this.cmbUnidad);
            this.groupBox2.Controls.Add(this.cmbEmpleado);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Cargo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 177);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.SlateGray;
            this.label15.Location = new System.Drawing.Point(5, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 25);
            this.label15.TabIndex = 39;
            this.label15.Text = "Empleado";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.BackColor = System.Drawing.Color.White;
            this.Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Cargo.ForeColor = System.Drawing.Color.SlateGray;
            this.Cargo.Location = new System.Drawing.Point(5, 58);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(85, 25);
            this.Cargo.TabIndex = 40;
            this.Cargo.Text = "Puesto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.SlateGray;
            this.label12.Location = new System.Drawing.Point(5, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "Unidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.SlateGray;
            this.label13.Location = new System.Drawing.Point(5, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 42;
            this.label13.Text = "Ciudad";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(131, 29);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(603, 24);
            this.cmbEmpleado.TabIndex = 43;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Items.AddRange(new object[] {
            "Unidad Administrativa",
            "Unidad de RRHH"});
            this.cmbUnidad.Location = new System.Drawing.Point(131, 119);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(253, 24);
            this.cmbUnidad.TabIndex = 46;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AccessibleName = "inpNumeroSolicitud";
            this.txtCiudad.Location = new System.Drawing.Point(131, 90);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(253, 22);
            this.txtCiudad.TabIndex = 47;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(128, 65);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(0, 16);
            this.lblCargo.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumeroSolicitud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaSolicitud);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 91);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud de Licencia con Remuneración";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(585, 48);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(185, 22);
            this.dtpFechaSolicitud.TabIndex = 3;
            this.dtpFechaSolicitud.Value = new System.DateTime(2015, 8, 2, 16, 22, 15, 0);
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblFechaSolicitud";
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(592, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Solicitud";
            // 
            // txtNumeroSolicitud
            // 
            this.txtNumeroSolicitud.AccessibleName = "inpNumeroSolicitud";
            this.txtNumeroSolicitud.Location = new System.Drawing.Point(19, 50);
            this.txtNumeroSolicitud.Name = "txtNumeroSolicitud";
            this.txtNumeroSolicitud.Size = new System.Drawing.Size(141, 22);
            this.txtNumeroSolicitud.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblNumeroSolicitud";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro Solicitud";
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
            this.Observaciones.ResumeLayout(false);
            this.Observaciones.PerformLayout();
            this.Transporte.ResumeLayout(false);
            this.Transporte.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransporte)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.Actividades.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.DatosGenerales.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnGuardarTrans;
        private System.Windows.Forms.Button btnEliminarTrans;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtpHoraSalidaTrans;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidaTrans;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnModificarTrans;
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
        private System.Windows.Forms.TabPage Actividades;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpHoraSalidaInf;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidaInf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegadaInf;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegadaInf;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalleActividades;
        private System.Windows.Forms.TabPage DatosGenerales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroSolicitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}