namespace CapaPresentacion
{
    partial class frmCultivo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dgvCultivos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaCosecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaSiembra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxCodigoGranja = new System.Windows.Forms.ComboBox();
            this.txtCantidadCosecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigoCultivo = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTipoCultivo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaProducto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCultivos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Location = new System.Drawing.Point(703, 442);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 35);
            this.btnSalir.TabIndex = 67;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.Location = new System.Drawing.Point(57, 444);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 35);
            this.btnMenu.TabIndex = 66;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // dgvCultivos
            // 
            this.dgvCultivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCultivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCultivos.Location = new System.Drawing.Point(11, 229);
            this.dgvCultivos.Name = "dgvCultivos";
            this.dgvCultivos.ReadOnly = true;
            this.dgvCultivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCultivos.Size = new System.Drawing.Size(843, 203);
            this.dgvCultivos.TabIndex = 63;
            this.dgvCultivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCultivos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpFechaCosecha);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFechaSiembra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboxCodigoGranja);
            this.groupBox1.Controls.Add(this.txtCantidadCosecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCodigoCultivo);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtTipoCultivo);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 183);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(514, 116);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(169, 20);
            this.txtObservacion.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label11.Location = new System.Drawing.Point(450, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Estado";
            // 
            // dtpFechaCosecha
            // 
            this.dtpFechaCosecha.Location = new System.Drawing.Point(173, 146);
            this.dtpFechaCosecha.Name = "dtpFechaCosecha";
            this.dtpFechaCosecha.Size = new System.Drawing.Size(169, 20);
            this.dtpFechaCosecha.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label9.Location = new System.Drawing.Point(428, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ubicacion";
            // 
            // dtpFechaSiembra
            // 
            this.dtpFechaSiembra.Location = new System.Drawing.Point(173, 116);
            this.dtpFechaSiembra.Name = "dtpFechaSiembra";
            this.dtpFechaSiembra.Size = new System.Drawing.Size(169, 20);
            this.dtpFechaSiembra.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label8.Location = new System.Drawing.Point(453, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio";
            // 
            // cboxCodigoGranja
            // 
            this.cboxCodigoGranja.FormattingEnabled = true;
            this.cboxCodigoGranja.Location = new System.Drawing.Point(173, 47);
            this.cboxCodigoGranja.Name = "cboxCodigoGranja";
            this.cboxCodigoGranja.Size = new System.Drawing.Size(169, 21);
            this.cboxCodigoGranja.TabIndex = 32;
            // 
            // txtCantidadCosecha
            // 
            this.txtCantidadCosecha.Location = new System.Drawing.Point(514, 20);
            this.txtCantidadCosecha.Name = "txtCantidadCosecha";
            this.txtCantidadCosecha.Size = new System.Drawing.Size(169, 20);
            this.txtCantidadCosecha.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(378, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cantidad Cosecha";
            // 
            // lblCodigoCultivo
            // 
            this.lblCodigoCultivo.AutoSize = true;
            this.lblCodigoCultivo.Location = new System.Drawing.Point(170, 24);
            this.lblCodigoCultivo.Name = "lblCodigoCultivo";
            this.lblCodigoCultivo.Size = new System.Drawing.Size(25, 13);
            this.lblCodigoCultivo.TabIndex = 29;
            this.lblCodigoCultivo.Text = "cod";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(514, 83);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(169, 20);
            this.txtUbicacion.TabIndex = 28;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.Location = new System.Drawing.Point(751, 102);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 35);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTipoCultivo
            // 
            this.txtTipoCultivo.Location = new System.Drawing.Point(173, 83);
            this.txtTipoCultivo.Name = "txtTipoCultivo";
            this.txtTipoCultivo.Size = new System.Drawing.Size(169, 20);
            this.txtTipoCultivo.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.textBox1.Location = new System.Drawing.Point(71, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 16);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Tipo Cultivo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(514, 48);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(169, 20);
            this.txtPrecio.TabIndex = 20;
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(514, 146);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(169, 21);
            this.cboxEstado.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(751, 142);
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
            this.btnEditar.Location = new System.Drawing.Point(751, 61);
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
            this.btnGuardar.Location = new System.Drawing.Point(751, 20);
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
            this.label7.Location = new System.Drawing.Point(413, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Observacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(60, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha Cosecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(63, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Siembra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(60, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo Granja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(56, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Cultivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "CULTIVOS";
            // 
            // lblFechaProducto
            // 
            this.lblFechaProducto.AutoSize = true;
            this.lblFechaProducto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaProducto.Location = new System.Drawing.Point(765, 16);
            this.lblFechaProducto.Name = "lblFechaProducto";
            this.lblFechaProducto.Size = new System.Drawing.Size(55, 22);
            this.lblFechaProducto.TabIndex = 65;
            this.lblFechaProducto.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(699, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 64;
            this.label10.Text = "Fecha:";
            // 
            // frmCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(864, 489);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvCultivos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaProducto);
            this.Controls.Add(this.label10);
            this.Name = "frmCultivo";
            this.Text = "frmCultivo";
            this.Load += new System.EventHandler(this.frmCultivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCultivos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dgvCultivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaCosecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaSiembra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxCodigoGranja;
        private System.Windows.Forms.TextBox txtCantidadCosecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigoCultivo;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTipoCultivo;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label11;
    }
}