namespace ConectorSAP
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerFacturas = new System.Windows.Forms.Timer(this.components);
            this.lbErrores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEstadoActual = new System.Windows.Forms.Label();
            this.timerSAPfacturas = new System.Windows.Forms.Timer(this.components);
            this.timerInsertarInventario = new System.Windows.Forms.Timer(this.components);
            this.timerInvVT = new System.Windows.Forms.Timer(this.components);
            this.timerPrecios = new System.Windows.Forms.Timer(this.components);
            this.checkBoxFac = new System.Windows.Forms.CheckBox();
            this.InsercionFacturasSAP = new System.Windows.Forms.CheckBox();
            this.InsertarInventario = new System.Windows.Forms.CheckBox();
            this.InventarioVTEX = new System.Windows.Forms.CheckBox();
            this.ActualizarPrecios = new System.Windows.Forms.CheckBox();
            this.lbBitacora = new System.Windows.Forms.ListBox();
            this.timerBodega = new System.Windows.Forms.Timer(this.components);
            this.Bodegas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pagos = new System.Windows.Forms.CheckBox();
            this.timerPagos = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerFacturas
            // 
            this.timerFacturas.Interval = 50000;
            this.timerFacturas.Tick += new System.EventHandler(this.timerFacturas_Tick);
            // 
            // lbErrores
            // 
            this.lbErrores.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrores.FormattingEnabled = true;
            this.lbErrores.ItemHeight = 20;
            this.lbErrores.Location = new System.Drawing.Point(24, 131);
            this.lbErrores.Name = "lbErrores";
            this.lbErrores.Size = new System.Drawing.Size(881, 124);
            this.lbErrores.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Errores";
            // 
            // lbEstadoActual
            // 
            this.lbEstadoActual.AutoSize = true;
            this.lbEstadoActual.Location = new System.Drawing.Point(21, 502);
            this.lbEstadoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstadoActual.Name = "lbEstadoActual";
            this.lbEstadoActual.Size = new System.Drawing.Size(95, 17);
            this.lbEstadoActual.TabIndex = 11;
            this.lbEstadoActual.Text = "Estado Actual";
            // 
            // timerSAPfacturas
            // 
            this.timerSAPfacturas.Tick += new System.EventHandler(this.timerSAPfacturas_Tick);
            // 
            // timerInsertarInventario
            // 
            this.timerInsertarInventario.Tick += new System.EventHandler(this.timerInsertarInventario_Tick);
            // 
            // timerInvVT
            // 
            this.timerInvVT.Tick += new System.EventHandler(this.timerInvVT_Tick);
            // 
            // timerPrecios
            // 
            this.timerPrecios.Tick += new System.EventHandler(this.timerPrecios_Tick);
            // 
            // checkBoxFac
            // 
            this.checkBoxFac.AutoSize = true;
            this.checkBoxFac.Location = new System.Drawing.Point(24, 21);
            this.checkBoxFac.Name = "checkBoxFac";
            this.checkBoxFac.Size = new System.Drawing.Size(146, 21);
            this.checkBoxFac.TabIndex = 12;
            this.checkBoxFac.Text = "Insercion Facturas";
            this.checkBoxFac.UseVisualStyleBackColor = true;
            this.checkBoxFac.CheckedChanged += new System.EventHandler(this.checkBoxFac_CheckedChanged);
            // 
            // InsercionFacturasSAP
            // 
            this.InsercionFacturasSAP.AutoSize = true;
            this.InsercionFacturasSAP.Location = new System.Drawing.Point(189, 21);
            this.InsercionFacturasSAP.Name = "InsercionFacturasSAP";
            this.InsercionFacturasSAP.Size = new System.Drawing.Size(177, 21);
            this.InsercionFacturasSAP.TabIndex = 13;
            this.InsercionFacturasSAP.Text = "Insercion Facturas SAP";
            this.InsercionFacturasSAP.UseVisualStyleBackColor = true;
            this.InsercionFacturasSAP.CheckedChanged += new System.EventHandler(this.InsercionFacturasSAP_CheckedChanged);
            // 
            // InsertarInventario
            // 
            this.InsertarInventario.AutoSize = true;
            this.InsertarInventario.Location = new System.Drawing.Point(392, 22);
            this.InsertarInventario.Name = "InsertarInventario";
            this.InsertarInventario.Size = new System.Drawing.Size(153, 21);
            this.InsertarInventario.TabIndex = 14;
            this.InsertarInventario.Text = "Insercion Inventario";
            this.InsertarInventario.UseVisualStyleBackColor = true;
            this.InsertarInventario.CheckedChanged += new System.EventHandler(this.InsertarInventario_CheckedChanged);
            // 
            // InventarioVTEX
            // 
            this.InventarioVTEX.AutoSize = true;
            this.InventarioVTEX.Location = new System.Drawing.Point(569, 23);
            this.InventarioVTEX.Name = "InventarioVTEX";
            this.InventarioVTEX.Size = new System.Drawing.Size(132, 21);
            this.InventarioVTEX.TabIndex = 15;
            this.InventarioVTEX.Text = "Inventario VTEX";
            this.InventarioVTEX.UseVisualStyleBackColor = true;
            this.InventarioVTEX.CheckedChanged += new System.EventHandler(this.InventarioVTEX_CheckedChanged);
            // 
            // ActualizarPrecios
            // 
            this.ActualizarPrecios.AutoSize = true;
            this.ActualizarPrecios.Location = new System.Drawing.Point(731, 23);
            this.ActualizarPrecios.Name = "ActualizarPrecios";
            this.ActualizarPrecios.Size = new System.Drawing.Size(143, 21);
            this.ActualizarPrecios.TabIndex = 16;
            this.ActualizarPrecios.Text = "Actualizar Precios";
            this.ActualizarPrecios.UseVisualStyleBackColor = true;
            this.ActualizarPrecios.CheckedChanged += new System.EventHandler(this.ActualizarPrecios_CheckedChanged);
            // 
            // lbBitacora
            // 
            this.lbBitacora.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBitacora.FormattingEnabled = true;
            this.lbBitacora.ItemHeight = 20;
            this.lbBitacora.Location = new System.Drawing.Point(24, 285);
            this.lbBitacora.Name = "lbBitacora";
            this.lbBitacora.Size = new System.Drawing.Size(881, 204);
            this.lbBitacora.TabIndex = 17;
            // 
            // timerBodega
            // 
            this.timerBodega.Tick += new System.EventHandler(this.timerBodega_Tick);
            // 
            // Bodegas
            // 
            this.Bodegas.AutoSize = true;
            this.Bodegas.Location = new System.Drawing.Point(24, 61);
            this.Bodegas.Name = "Bodegas";
            this.Bodegas.Size = new System.Drawing.Size(152, 21);
            this.Bodegas.TabIndex = 18;
            this.Bodegas.Text = "Actualizar Bodegas";
            this.Bodegas.UseVisualStyleBackColor = true;
            this.Bodegas.CheckedChanged += new System.EventHandler(this.Bodegas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bitacora";
            // 
            // Pagos
            // 
            this.Pagos.AutoSize = true;
            this.Pagos.Location = new System.Drawing.Point(202, 61);
            this.Pagos.Name = "Pagos";
            this.Pagos.Size = new System.Drawing.Size(131, 21);
            this.Pagos.TabIndex = 20;
            this.Pagos.Text = "Reenviar Pagos";
            this.Pagos.UseVisualStyleBackColor = true;
            this.Pagos.CheckedChanged += new System.EventHandler(this.Pagos_CheckedChanged);
            // 
            // timerPagos
            // 
            this.timerPagos.Tick += new System.EventHandler(this.timerPagos_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 528);
            this.Controls.Add(this.Pagos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bodegas);
            this.Controls.Add(this.lbBitacora);
            this.Controls.Add(this.ActualizarPrecios);
            this.Controls.Add(this.InventarioVTEX);
            this.Controls.Add(this.InsertarInventario);
            this.Controls.Add(this.InsercionFacturasSAP);
            this.Controls.Add(this.checkBoxFac);
            this.Controls.Add(this.lbEstadoActual);
            this.Controls.Add(this.lbErrores);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Middleware";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerFacturas;
        private System.Windows.Forms.ListBox lbErrores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEstadoActual;
        private System.Windows.Forms.Timer timerSAPfacturas;
        private System.Windows.Forms.Timer timerInsertarInventario;
        private System.Windows.Forms.Timer timerInvVT;
        private System.Windows.Forms.Timer timerPrecios;
        private System.Windows.Forms.CheckBox checkBoxFac;
        private System.Windows.Forms.CheckBox InsercionFacturasSAP;
        private System.Windows.Forms.CheckBox InsertarInventario;
        private System.Windows.Forms.CheckBox InventarioVTEX;
        private System.Windows.Forms.CheckBox ActualizarPrecios;
        private System.Windows.Forms.ListBox lbBitacora;
        private System.Windows.Forms.Timer timerBodega;
        private System.Windows.Forms.CheckBox Bodegas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Pagos;
        private System.Windows.Forms.Timer timerPagos;
    }
}

