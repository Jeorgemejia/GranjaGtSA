namespace CapaPresentacion
{
    partial class frmRoles
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
            this.cboxFormConsul = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblCodigoRol = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaSistema = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFormConsul = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.cboxFormDel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxAccesoConfiguracion = new System.Windows.Forms.ComboBox();
            this.cboxAccesoReportes = new System.Windows.Forms.ComboBox();
            this.cboxAccesoDashboard = new System.Windows.Forms.ComboBox();
            this.cboxFormAdd = new System.Windows.Forms.ComboBox();
            this.cboxFormEdi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxFormConsul
            // 
            this.cboxFormConsul.FormattingEnabled = true;
            this.cboxFormConsul.Items.AddRange(new object[] {
            "Consumo",
            "Limpieza",
            "Mantenimiento",
            "Cocina",
            "Librería"});
            this.cboxFormConsul.Location = new System.Drawing.Point(94, 65);
            this.cboxFormConsul.Name = "cboxFormConsul";
            this.cboxFormConsul.Size = new System.Drawing.Size(169, 21);
            this.cboxFormConsul.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label8.Location = new System.Drawing.Point(285, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Acceso Reportes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(285, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Acceso Dashboard";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(285, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "FormDel";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Location = new System.Drawing.Point(674, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 35);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
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
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.Location = new System.Drawing.Point(44, 425);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 35);
            this.btnMenu.TabIndex = 59;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // lblCodigoRol
            // 
            this.lblCodigoRol.AutoSize = true;
            this.lblCodigoRol.Location = new System.Drawing.Point(75, 20);
            this.lblCodigoRol.Name = "lblCodigoRol";
            this.lblCodigoRol.Size = new System.Drawing.Size(25, 13);
            this.lblCodigoRol.TabIndex = 29;
            this.lblCodigoRol.Text = "cod";
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // dgvRoles
            // 
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(-3, 216);
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(843, 203);
            this.dgvRoles.TabIndex = 56;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Roles";
            // 
            // lblFechaSistema
            // 
            this.lblFechaSistema.AutoSize = true;
            this.lblFechaSistema.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSistema.Location = new System.Drawing.Point(670, 2);
            this.lblFechaSistema.Name = "lblFechaSistema";
            this.lblFechaSistema.Size = new System.Drawing.Size(55, 22);
            this.lblFechaSistema.TabIndex = 58;
            this.lblFechaSistema.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(617, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 57;
            this.label10.Text = "Fecha:";
            // 
            // labelFormConsul
            // 
            this.labelFormConsul.AutoSize = true;
            this.labelFormConsul.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelFormConsul.Location = new System.Drawing.Point(6, 67);
            this.labelFormConsul.Name = "labelFormConsul";
            this.labelFormConsul.Size = new System.Drawing.Size(86, 16);
            this.labelFormConsul.TabIndex = 25;
            this.labelFormConsul.Text = "FormConsul";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(94, 40);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(169, 20);
            this.txtNombreRol.TabIndex = 20;
            // 
            // cboxFormDel
            // 
            this.cboxFormDel.FormattingEnabled = true;
            this.cboxFormDel.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxFormDel.Location = new System.Drawing.Point(417, 35);
            this.cboxFormDel.Name = "cboxFormDel";
            this.cboxFormDel.Size = new System.Drawing.Size(169, 21);
            this.cboxFormDel.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cboxAccesoConfiguracion);
            this.groupBox1.Controls.Add(this.cboxAccesoReportes);
            this.groupBox1.Controls.Add(this.cboxAccesoDashboard);
            this.groupBox1.Controls.Add(this.cboxFormAdd);
            this.groupBox1.Controls.Add(this.cboxFormEdi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxFormConsul);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCodigoRol);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.labelFormConsul);
            this.groupBox1.Controls.Add(this.txtNombreRol);
            this.groupBox1.Controls.Add(this.cboxFormDel);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-3, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 183);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(656, 36);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(149, 21);
            this.cboxEstado.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label12.Location = new System.Drawing.Point(600, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Estado";
            // 
            // cboxAccesoConfiguracion
            // 
            this.cboxAccesoConfiguracion.FormattingEnabled = true;
            this.cboxAccesoConfiguracion.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxAccesoConfiguracion.Location = new System.Drawing.Point(417, 114);
            this.cboxAccesoConfiguracion.Name = "cboxAccesoConfiguracion";
            this.cboxAccesoConfiguracion.Size = new System.Drawing.Size(169, 21);
            this.cboxAccesoConfiguracion.TabIndex = 44;
            // 
            // cboxAccesoReportes
            // 
            this.cboxAccesoReportes.FormattingEnabled = true;
            this.cboxAccesoReportes.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxAccesoReportes.Location = new System.Drawing.Point(417, 88);
            this.cboxAccesoReportes.Name = "cboxAccesoReportes";
            this.cboxAccesoReportes.Size = new System.Drawing.Size(169, 21);
            this.cboxAccesoReportes.TabIndex = 43;
            // 
            // cboxAccesoDashboard
            // 
            this.cboxAccesoDashboard.FormattingEnabled = true;
            this.cboxAccesoDashboard.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxAccesoDashboard.Location = new System.Drawing.Point(418, 61);
            this.cboxAccesoDashboard.Name = "cboxAccesoDashboard";
            this.cboxAccesoDashboard.Size = new System.Drawing.Size(169, 21);
            this.cboxAccesoDashboard.TabIndex = 42;
            // 
            // cboxFormAdd
            // 
            this.cboxFormAdd.FormattingEnabled = true;
            this.cboxFormAdd.Items.AddRange(new object[] {
            "Consumo",
            "Limpieza",
            "Mantenimiento",
            "Cocina",
            "Librería"});
            this.cboxFormAdd.Location = new System.Drawing.Point(94, 93);
            this.cboxFormAdd.Name = "cboxFormAdd";
            this.cboxFormAdd.Size = new System.Drawing.Size(169, 21);
            this.cboxFormAdd.TabIndex = 41;
            // 
            // cboxFormEdi
            // 
            this.cboxFormEdi.FormattingEnabled = true;
            this.cboxFormEdi.Items.AddRange(new object[] {
            "Consumo",
            "Limpieza",
            "Mantenimiento",
            "Cocina",
            "Librería"});
            this.cboxFormEdi.Location = new System.Drawing.Point(94, 120);
            this.cboxFormEdi.Name = "cboxFormEdi";
            this.cboxFormEdi.Size = new System.Drawing.Size(169, 21);
            this.cboxFormEdi.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "FormAdd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "FormEdi";
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label7.Location = new System.Drawing.Point(285, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Acceso Config.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaSistema);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRoles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxFormConsul;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblCodigoRol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaSistema;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFormConsul;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.ComboBox cboxFormDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxFormEdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxFormAdd;
        private System.Windows.Forms.ComboBox cboxAccesoConfiguracion;
        private System.Windows.Forms.ComboBox cboxAccesoReportes;
        private System.Windows.Forms.ComboBox cboxAccesoDashboard;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label12;
    }
}