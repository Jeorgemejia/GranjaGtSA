namespace CapaPresentacion
{
    partial class frmDetalleVenta
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCodigoDetalleVenta = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaSistema = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.cboxCodigoAnimal = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxCodigoVenta = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboxCodigoCultivo = new System.Windows.Forms.ComboBox();
            this.cboxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.tstDescuento = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(457, 72);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(88, 20);
            this.txtTotal.TabIndex = 28;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.Location = new System.Drawing.Point(741, 84);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 35);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(348, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio unitario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Location = new System.Drawing.Point(688, 444);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 35);
            this.btnSalir.TabIndex = 74;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblCodigoDetalleVenta
            // 
            this.lblCodigoDetalleVenta.AutoSize = true;
            this.lblCodigoDetalleVenta.BackColor = System.Drawing.Color.White;
            this.lblCodigoDetalleVenta.Location = new System.Drawing.Point(140, 18);
            this.lblCodigoDetalleVenta.Name = "lblCodigoDetalleVenta";
            this.lblCodigoDetalleVenta.Size = new System.Drawing.Size(177, 13);
            this.lblCodigoDetalleVenta.TabIndex = 29;
            this.lblCodigoDetalleVenta.Text = "CodigoDetalle                                  |";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.Location = new System.Drawing.Point(58, 444);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 35);
            this.btnMenu.TabIndex = 73;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label8.Location = new System.Drawing.Point(348, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(348, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Total";
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Location = new System.Drawing.Point(11, 235);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.ReadOnly = true;
            this.dgvDetalleVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVentas.Size = new System.Drawing.Size(843, 203);
            this.dgvDetalleVentas.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 68;
            this.label1.Text = "Detalle Ventas";
            // 
            // lblFechaSistema
            // 
            this.lblFechaSistema.AutoSize = true;
            this.lblFechaSistema.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSistema.Location = new System.Drawing.Point(684, 16);
            this.lblFechaSistema.Name = "lblFechaSistema";
            this.lblFechaSistema.Size = new System.Drawing.Size(55, 22);
            this.lblFechaSistema.TabIndex = 72;
            this.lblFechaSistema.Text = "Fecha";
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(635, 47);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(79, 21);
            this.cboxEstado.TabIndex = 43;
            // 
            // cboxCodigoAnimal
            // 
            this.cboxCodigoAnimal.FormattingEnabled = true;
            this.cboxCodigoAnimal.Location = new System.Drawing.Point(143, 68);
            this.cboxCodigoAnimal.Name = "cboxCodigoAnimal";
            this.cboxCodigoAnimal.Size = new System.Drawing.Size(169, 21);
            this.cboxCodigoAnimal.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 71;
            this.label10.Text = "Fecha:";
            // 
            // cboxCodigoVenta
            // 
            this.cboxCodigoVenta.FormattingEnabled = true;
            this.cboxCodigoVenta.Location = new System.Drawing.Point(143, 43);
            this.cboxCodigoVenta.Name = "cboxCodigoVenta";
            this.cboxCodigoVenta.Size = new System.Drawing.Size(169, 21);
            this.cboxCodigoVenta.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.textBox1.Location = new System.Drawing.Point(10, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 16);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Codigo cultivo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(741, 123);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Location = new System.Drawing.Point(741, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 35);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label7.Location = new System.Drawing.Point(579, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo Animal";
            // 
            // lblcl
            // 
            this.lblcl.AutoSize = true;
            this.lblcl.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblcl.Location = new System.Drawing.Point(10, 45);
            this.lblcl.Name = "lblcl";
            this.lblcl.Size = new System.Drawing.Size(96, 16);
            this.lblcl.TabIndex = 3;
            this.lblcl.Text = "Codigo Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtTotalVenta);
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.tstDescuento);
            this.groupBox1.Controls.Add(this.txtPrecioUnitario);
            this.groupBox1.Controls.Add(this.cboxCodigoProducto);
            this.groupBox1.Controls.Add(this.cboxCodigoCultivo);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.cboxCodigoVenta);
            this.groupBox1.Controls.Add(this.cboxCodigoAnimal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCodigoDetalleVenta);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblcl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 183);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.Location = new System.Drawing.Point(741, 47);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 35);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Codigo producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label9.Location = new System.Drawing.Point(348, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Descuento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label11.Location = new System.Drawing.Point(348, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Impuesto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label12.Location = new System.Drawing.Point(551, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Total venta";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(457, 11);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(88, 20);
            this.txtCantidad.TabIndex = 48;
            // 
            // cboxCodigoCultivo
            // 
            this.cboxCodigoCultivo.FormattingEnabled = true;
            this.cboxCodigoCultivo.Location = new System.Drawing.Point(143, 98);
            this.cboxCodigoCultivo.Name = "cboxCodigoCultivo";
            this.cboxCodigoCultivo.Size = new System.Drawing.Size(169, 21);
            this.cboxCodigoCultivo.TabIndex = 49;
            // 
            // cboxCodigoProducto
            // 
            this.cboxCodigoProducto.FormattingEnabled = true;
            this.cboxCodigoProducto.Location = new System.Drawing.Point(143, 128);
            this.cboxCodigoProducto.Name = "cboxCodigoProducto";
            this.cboxCodigoProducto.Size = new System.Drawing.Size(169, 21);
            this.cboxCodigoProducto.TabIndex = 50;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(457, 45);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(88, 20);
            this.txtPrecioUnitario.TabIndex = 51;
            // 
            // tstDescuento
            // 
            this.tstDescuento.Location = new System.Drawing.Point(457, 97);
            this.tstDescuento.Name = "tstDescuento";
            this.tstDescuento.Size = new System.Drawing.Size(88, 20);
            this.tstDescuento.TabIndex = 52;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(457, 128);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(88, 20);
            this.txtImpuesto.TabIndex = 53;
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(635, 14);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(79, 20);
            this.txtTotalVenta.TabIndex = 54;
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(864, 489);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvDetalleVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaSistema);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDetalleVenta";
            this.Text = "frmDetalleVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCodigoDetalleVenta;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDetalleVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaSistema;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.ComboBox cboxCodigoAnimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxCodigoVenta;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox tstDescuento;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.ComboBox cboxCodigoProducto;
        private System.Windows.Forms.ComboBox cboxCodigoCultivo;
        private System.Windows.Forms.TextBox txtTotalVenta;
    }
}