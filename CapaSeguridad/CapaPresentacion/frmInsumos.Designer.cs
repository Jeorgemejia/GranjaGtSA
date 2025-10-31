namespace CapaPresentacion
{
    partial class frmInsumos
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
            this.lblCodigoInsumo = new System.Windows.Forms.Label();
            this.txtCostoUnitarioInsumo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.Label();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.cboxEstadoInsumo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaSistema = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxtipoInsumo = new System.Windows.Forms.ComboBox();
            this.cboxProveedor = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUnidadMedidaInsumo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoInsumo
            // 
            this.lblCodigoInsumo.AutoSize = true;
            this.lblCodigoInsumo.Location = new System.Drawing.Point(75, 20);
            this.lblCodigoInsumo.Name = "lblCodigoInsumo";
            this.lblCodigoInsumo.Size = new System.Drawing.Size(25, 13);
            this.lblCodigoInsumo.TabIndex = 29;
            this.lblCodigoInsumo.Text = "cod";
            // 
            // txtCostoUnitarioInsumo
            // 
            this.txtCostoUnitarioInsumo.Location = new System.Drawing.Point(434, 17);
            this.txtCostoUnitarioInsumo.Name = "txtCostoUnitarioInsumo";
            this.txtCostoUnitarioInsumo.Size = new System.Drawing.Size(169, 20);
            this.txtCostoUnitarioInsumo.TabIndex = 28;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.Location = new System.Drawing.Point(466, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 35);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.textBox1.Location = new System.Drawing.Point(35, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 16);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Tipo";
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Location = new System.Drawing.Point(78, 63);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(169, 20);
            this.txtNombreInsumo.TabIndex = 20;
            // 
            // cboxEstadoInsumo
            // 
            this.cboxEstadoInsumo.FormattingEnabled = true;
            this.cboxEstadoInsumo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstadoInsumo.Location = new System.Drawing.Point(434, 89);
            this.cboxEstadoInsumo.Name = "cboxEstadoInsumo";
            this.cboxEstadoInsumo.Size = new System.Drawing.Size(169, 21);
            this.cboxEstadoInsumo.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(607, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.Location = new System.Drawing.Point(288, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 35);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Location = new System.Drawing.Point(133, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 35);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label7.Location = new System.Drawing.Point(364, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(18, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(5, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 14);
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
            this.btnSalir.TabIndex = 53;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.Location = new System.Drawing.Point(58, 444);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 35);
            this.btnMenu.TabIndex = 52;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(11, 235);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(843, 203);
            this.dgvInsumos.TabIndex = 49;
            this.dgvInsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Insumos";
            // 
            // lblFechaSistema
            // 
            this.lblFechaSistema.AutoSize = true;
            this.lblFechaSistema.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSistema.Location = new System.Drawing.Point(684, 16);
            this.lblFechaSistema.Name = "lblFechaSistema";
            this.lblFechaSistema.Size = new System.Drawing.Size(55, 22);
            this.lblFechaSistema.TabIndex = 51;
            this.lblFechaSistema.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 50;
            this.label10.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(318, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Costo unitario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.cboxtipoInsumo);
            this.groupBox1.Controls.Add(this.cboxProveedor);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtUnidadMedidaInsumo);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCodigoInsumo);
            this.groupBox1.Controls.Add(this.txtCostoUnitarioInsumo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtNombreInsumo);
            this.groupBox1.Controls.Add(this.cboxEstadoInsumo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 183);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxtipoInsumo
            // 
            this.cboxtipoInsumo.FormattingEnabled = true;
            this.cboxtipoInsumo.Items.AddRange(new object[] {
            "Consumo",
            "Limpieza",
            "Mantenimiento",
            "Cocina",
            "Librería"});
            this.cboxtipoInsumo.Location = new System.Drawing.Point(78, 90);
            this.cboxtipoInsumo.Name = "cboxtipoInsumo";
            this.cboxtipoInsumo.Size = new System.Drawing.Size(169, 21);
            this.cboxtipoInsumo.TabIndex = 37;
            // 
            // cboxProveedor
            // 
            this.cboxProveedor.FormattingEnabled = true;
            this.cboxProveedor.Location = new System.Drawing.Point(78, 35);
            this.cboxProveedor.Name = "cboxProveedor";
            this.cboxProveedor.Size = new System.Drawing.Size(169, 21);
            this.cboxProveedor.TabIndex = 36;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(645, 47);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(169, 20);
            this.txtObservacion.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label9.Location = new System.Drawing.Point(688, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Observacion";
            // 
            // txtUnidadMedidaInsumo
            // 
            this.txtUnidadMedidaInsumo.Location = new System.Drawing.Point(434, 40);
            this.txtUnidadMedidaInsumo.Name = "txtUnidadMedidaInsumo";
            this.txtUnidadMedidaInsumo.Size = new System.Drawing.Size(169, 20);
            this.txtUnidadMedidaInsumo.TabIndex = 33;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(434, 63);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(169, 20);
            this.txtPeso.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label8.Location = new System.Drawing.Point(349, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Peso Kg.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(291, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Unidad de medida";
            // 
            // frmInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(864, 489);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaSistema);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInsumos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoInsumo;
        private System.Windows.Forms.TextBox txtCostoUnitarioInsumo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.ComboBox cboxEstadoInsumo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaSistema;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUnidadMedidaInsumo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxtipoInsumo;
        private System.Windows.Forms.ComboBox cboxProveedor;
    }
}