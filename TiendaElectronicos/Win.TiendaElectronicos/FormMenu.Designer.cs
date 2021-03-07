namespace Win.TiendaElectronicos
{
    partial class FormMenu
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
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atencionAlClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteInacistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.bancosToolStripMenuItem,
            this.rHToolStripMenuItem,
            this.almacenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atencionAlClienteToolStripMenuItem,
            this.enviosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // atencionAlClienteToolStripMenuItem
            // 
            this.atencionAlClienteToolStripMenuItem.Name = "atencionAlClienteToolStripMenuItem";
            this.atencionAlClienteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.atencionAlClienteToolStripMenuItem.Text = "Atencion al Cliente";
            this.atencionAlClienteToolStripMenuItem.Click += new System.EventHandler(this.atencionAlClienteToolStripMenuItem_Click);
            // 
            // enviosToolStripMenuItem
            // 
            this.enviosToolStripMenuItem.Name = "enviosToolStripMenuItem";
            this.enviosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.enviosToolStripMenuItem.Text = "Envios";
            this.enviosToolStripMenuItem.Click += new System.EventHandler(this.enviosToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteVentasToolStripMenuItem,
            this.reporteComprasToolStripMenuItem,
            this.reporteInacistenciasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteVentasToolStripMenuItem
            // 
            this.reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            this.reporteVentasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reporteVentasToolStripMenuItem.Text = "Reporte - Ventas";
            this.reporteVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteVentasToolStripMenuItem_Click);
            // 
            // reporteComprasToolStripMenuItem
            // 
            this.reporteComprasToolStripMenuItem.Name = "reporteComprasToolStripMenuItem";
            this.reporteComprasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reporteComprasToolStripMenuItem.Text = "Reporte - Compras";
            this.reporteComprasToolStripMenuItem.Click += new System.EventHandler(this.reporteComprasToolStripMenuItem_Click);
            // 
            // reporteInacistenciasToolStripMenuItem
            // 
            this.reporteInacistenciasToolStripMenuItem.Name = "reporteInacistenciasToolStripMenuItem";
            this.reporteInacistenciasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reporteInacistenciasToolStripMenuItem.Text = "Reporte - Inacistencias";
            this.reporteInacistenciasToolStripMenuItem.Click += new System.EventHandler(this.reporteInacistenciasToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.bancosToolStripMenuItem.Text = "Bancos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mayoreToolStripMenuItem,
            this.exclusivosToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // rHToolStripMenuItem
            // 
            this.rHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.horasToolStripMenuItem});
            this.rHToolStripMenuItem.Name = "rHToolStripMenuItem";
            this.rHToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.rHToolStripMenuItem.Text = "RH";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // horasToolStripMenuItem
            // 
            this.horasToolStripMenuItem.Name = "horasToolStripMenuItem";
            this.horasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.horasToolStripMenuItem.Text = "Horas";
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.devolucionesToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.almacenToolStripMenuItem.Text = "Almacen";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entradasToolStripMenuItem.Text = "Entradas ";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salidasToolStripMenuItem.Text = "Salidas";
            this.salidasToolStripMenuItem.Click += new System.EventHandler(this.salidasToolStripMenuItem_Click);
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generalToolStripMenuItem.Text = "Cardex";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // mayoreToolStripMenuItem
            // 
            this.mayoreToolStripMenuItem.Name = "mayoreToolStripMenuItem";
            this.mayoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mayoreToolStripMenuItem.Text = "Mayore";
            this.mayoreToolStripMenuItem.Click += new System.EventHandler(this.mayoreToolStripMenuItem_Click);
            // 
            // exclusivosToolStripMenuItem
            // 
            this.exclusivosToolStripMenuItem.Name = "exclusivosToolStripMenuItem";
            this.exclusivosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exclusivosToolStripMenuItem.Text = "Exclusivos";
            this.exclusivosToolStripMenuItem.Click += new System.EventHandler(this.exclusivosToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 284);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atencionAlClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteInacistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mayoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclusivosToolStripMenuItem;
    }
}