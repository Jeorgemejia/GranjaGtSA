namespace CapaPresentacion
{
    partial class frmProveedores
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaSistema = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboxEstadoProveedor = new System.Windows.Forms.ComboBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.Label();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(11, 235);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(843, 203);
            this.dgvProveedores.TabIndex = 40;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Proveedores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFechaSistema
            // 
            this.lblFechaSistema.AutoSize = true;
            this.lblFechaSistema.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSistema.Location = new System.Drawing.Point(684, 16);
            this.lblFechaSistema.Name = "lblFechaSistema";
            this.lblFechaSistema.Size = new System.Drawing.Size(55, 22);
            this.lblFechaSistema.TabIndex = 44;
            this.lblFechaSistema.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 43;
            this.label10.Text = "Fecha:";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.Location = new System.Drawing.Point(58, 444);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 35);
            this.btnMenu.TabIndex = 45;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Location = new System.Drawing.Point(688, 444);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 35);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(44, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(10, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(97, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(451, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label7.Location = new System.Drawing.Point(452, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Location = new System.Drawing.Point(101, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 35);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.Location = new System.Drawing.Point(256, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 35);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(575, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboxEstadoProveedor
            // 
            this.cboxEstadoProveedor.FormattingEnabled = true;
            this.cboxEstadoProveedor.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstadoProveedor.Location = new System.Drawing.Point(512, 90);
            this.cboxEstadoProveedor.Name = "cboxEstadoProveedor";
            this.cboxEstadoProveedor.Size = new System.Drawing.Size(169, 21);
            this.cboxEstadoProveedor.TabIndex = 17;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(173, 58);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(169, 20);
            this.txtNombreProveedor.TabIndex = 19;
            this.txtNombreProveedor.TextChanged += new System.EventHandler(this.txtNombreProveedor_TextChanged);
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(173, 102);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(169, 20);
            this.txtTelefonoProveedor.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.textBox1.Location = new System.Drawing.Point(431, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 16);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Dirección";
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(512, 14);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(169, 20);
            this.txtDireccionProveedor.TabIndex = 26;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.Location = new System.Drawing.Point(434, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 35);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(512, 53);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(169, 20);
            this.txtCorreoProveedor.TabIndex = 28;
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Location = new System.Drawing.Point(170, 24);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(25, 13);
            this.lblCodigoProveedor.TabIndex = 29;
            this.lblCodigoProveedor.Text = "cod";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblCodigoProveedor);
            this.groupBox1.Controls.Add(this.txtCorreoProveedor);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtDireccionProveedor);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtTelefonoProveedor);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.cboxEstadoProveedor);
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
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(864, 489);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaSistema);
            this.Controls.Add(this.label10);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmProveedores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaSistema;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboxEstadoProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

