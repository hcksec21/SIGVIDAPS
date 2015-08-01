namespace SIGVIDAPS_FORMS
{
    partial class mdiMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFormularios = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmnuformAnticipo = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmnuFormLiquidacion = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularMontoDeViáticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasDeCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasDePeajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmnuCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.combinaciónDeViáticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprobarFormulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormularios,
            this.mnuFacturas,
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.mnuAdministracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFormularios
            // 
            this.mnuFormularios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmnuformAnticipo,
            this.sbmnuFormLiquidacion,
            this.calcularMontoDeViáticoToolStripMenuItem,
            this.aprobarFormulariosToolStripMenuItem});
            this.mnuFormularios.Name = "mnuFormularios";
            this.mnuFormularios.Size = new System.Drawing.Size(82, 20);
            this.mnuFormularios.Text = "Formularios";
            // 
            // sbmnuformAnticipo
            // 
            this.sbmnuformAnticipo.Name = "sbmnuformAnticipo";
            this.sbmnuformAnticipo.Size = new System.Drawing.Size(258, 22);
            this.sbmnuformAnticipo.Text = "Ingresar Formulario de Anticipo";
            this.sbmnuformAnticipo.Click += new System.EventHandler(this.sbmnuformAnticipo_Click_1);
            // 
            // sbmnuFormLiquidacion
            // 
            this.sbmnuFormLiquidacion.Name = "sbmnuFormLiquidacion";
            this.sbmnuFormLiquidacion.Size = new System.Drawing.Size(258, 22);
            this.sbmnuFormLiquidacion.Text = "Ingresar Formulario de Liquidación";
            this.sbmnuFormLiquidacion.Click += new System.EventHandler(this.sbmnuFormLiquidacion_Click);
            // 
            // calcularMontoDeViáticoToolStripMenuItem
            // 
            this.calcularMontoDeViáticoToolStripMenuItem.Name = "calcularMontoDeViáticoToolStripMenuItem";
            this.calcularMontoDeViáticoToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.calcularMontoDeViáticoToolStripMenuItem.Text = "Calcular Monto de Viático";
            // 
            // mnuFacturas
            // 
            this.mnuFacturas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasDeCombustibleToolStripMenuItem,
            this.facturasDePeajeToolStripMenuItem});
            this.mnuFacturas.Name = "mnuFacturas";
            this.mnuFacturas.Size = new System.Drawing.Size(63, 20);
            this.mnuFacturas.Text = "Facturas";
            // 
            // facturasDeCombustibleToolStripMenuItem
            // 
            this.facturasDeCombustibleToolStripMenuItem.Name = "facturasDeCombustibleToolStripMenuItem";
            this.facturasDeCombustibleToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.facturasDeCombustibleToolStripMenuItem.Text = "Registrar Factura de Combustible";
            this.facturasDeCombustibleToolStripMenuItem.Click += new System.EventHandler(this.facturasDeCombustibleToolStripMenuItem_Click);
            // 
            // facturasDePeajeToolStripMenuItem
            // 
            this.facturasDePeajeToolStripMenuItem.Name = "facturasDePeajeToolStripMenuItem";
            this.facturasDePeajeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.facturasDePeajeToolStripMenuItem.Text = "Registrar Factura de Peaje";
            this.facturasDePeajeToolStripMenuItem.Click += new System.EventHandler(this.facturasDePeajeToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.modificarEliminarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // modificarEliminarUsuarioToolStripMenuItem
            // 
            this.modificarEliminarUsuarioToolStripMenuItem.Name = "modificarEliminarUsuarioToolStripMenuItem";
            this.modificarEliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.modificarEliminarUsuarioToolStripMenuItem.Text = "Modificar / Eliminar Usuario";
            this.modificarEliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarEliminarUsuarioToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEmpleadoToolStripMenuItem,
            this.modificarEliminarEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // registrarEmpleadoToolStripMenuItem
            // 
            this.registrarEmpleadoToolStripMenuItem.Name = "registrarEmpleadoToolStripMenuItem";
            this.registrarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.registrarEmpleadoToolStripMenuItem.Text = "Registrar Empleado";
            this.registrarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadoToolStripMenuItem_Click);
            // 
            // modificarEliminarEmpleadoToolStripMenuItem
            // 
            this.modificarEliminarEmpleadoToolStripMenuItem.Name = "modificarEliminarEmpleadoToolStripMenuItem";
            this.modificarEliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.modificarEliminarEmpleadoToolStripMenuItem.Text = "Modificar / Eliminar Empleado";
            this.modificarEliminarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.modificarEliminarEmpleadoToolStripMenuItem_Click);
            // 
            // mnuAdministracion
            // 
            this.mnuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmnuCargo,
            this.toolStripMenuItem2,
            this.combinaciónDeViáticoToolStripMenuItem});
            this.mnuAdministracion.Name = "mnuAdministracion";
            this.mnuAdministracion.Size = new System.Drawing.Size(100, 20);
            this.mnuAdministracion.Text = "Administración";
            // 
            // sbmnuCargo
            // 
            this.sbmnuCargo.Name = "sbmnuCargo";
            this.sbmnuCargo.Size = new System.Drawing.Size(282, 22);
            this.sbmnuCargo.Text = "Administrar Cargos de Empleado";
            this.sbmnuCargo.Click += new System.EventHandler(this.sbmnuCargo_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(282, 22);
            this.toolStripMenuItem2.Text = "Administrar Opciones de Viáticos";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // combinaciónDeViáticoToolStripMenuItem
            // 
            this.combinaciónDeViáticoToolStripMenuItem.Name = "combinaciónDeViáticoToolStripMenuItem";
            this.combinaciónDeViáticoToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.combinaciónDeViáticoToolStripMenuItem.Text = "Administrar Combinaciones de Viáticos";
            this.combinaciónDeViáticoToolStripMenuItem.Click += new System.EventHandler(this.combinaciónDeViáticoToolStripMenuItem_Click);
            // 
            // aprobarFormulariosToolStripMenuItem
            // 
            this.aprobarFormulariosToolStripMenuItem.Name = "aprobarFormulariosToolStripMenuItem";
            this.aprobarFormulariosToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.aprobarFormulariosToolStripMenuItem.Text = "Aprobar Formularios";
            // 
            // mdiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SIGVIDAPS_FORMS.Properties.Resources.Logo_MAGAP_NUEVO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(840, 488);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdiMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdiMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFormularios;
        private System.Windows.Forms.ToolStripMenuItem sbmnuformAnticipo;
        private System.Windows.Forms.ToolStripMenuItem sbmnuFormLiquidacion;
        private System.Windows.Forms.ToolStripMenuItem mnuFacturas;
        private System.Windows.Forms.ToolStripMenuItem facturasDeCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasDePeajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion;
        private System.Windows.Forms.ToolStripMenuItem sbmnuCargo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem combinaciónDeViáticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularMontoDeViáticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEliminarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprobarFormulariosToolStripMenuItem;
    }
}
