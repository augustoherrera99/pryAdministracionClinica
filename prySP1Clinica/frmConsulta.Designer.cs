namespace prySP1Clinica
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegistroEspecialidad = new System.Windows.Forms.Button();
            this.btnRegistroMedico = new System.Windows.Forms.Button();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.mrcConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(20, 32);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(169, 13);
            this.lblSeleccionar.TabIndex = 0;
            this.lblSeleccionar.Text = "Seleccione especialidad a buscar:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(195, 32);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 1;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsulta.Location = new System.Drawing.Point(23, 96);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.Size = new System.Drawing.Size(303, 150);
            this.dgvConsulta.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matrícula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido y Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(20, 65);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(62, 13);
            this.lblMedicos.TabIndex = 3;
            this.lblMedicos.Text = "Médicos de";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(80, 65);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(0, 13);
            this.lblEspecialidad.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(350, 137);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRegistroEspecialidad
            // 
            this.btnRegistroEspecialidad.Location = new System.Drawing.Point(492, 55);
            this.btnRegistroEspecialidad.Name = "btnRegistroEspecialidad";
            this.btnRegistroEspecialidad.Size = new System.Drawing.Size(101, 35);
            this.btnRegistroEspecialidad.TabIndex = 6;
            this.btnRegistroEspecialidad.Text = "&Registrar Especialidad";
            this.btnRegistroEspecialidad.UseVisualStyleBackColor = true;
            this.btnRegistroEspecialidad.Click += new System.EventHandler(this.btnRegistroEspecialidad_Click);
            // 
            // btnRegistroMedico
            // 
            this.btnRegistroMedico.Location = new System.Drawing.Point(492, 108);
            this.btnRegistroMedico.Name = "btnRegistroMedico";
            this.btnRegistroMedico.Size = new System.Drawing.Size(101, 35);
            this.btnRegistroMedico.TabIndex = 7;
            this.btnRegistroMedico.Text = "&Registrar Médico";
            this.btnRegistroMedico.UseVisualStyleBackColor = true;
            this.btnRegistroMedico.Click += new System.EventHandler(this.btnRegistroMedico_Click);
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.btnActualizar);
            this.mrcConsulta.Controls.Add(this.btnLimpiar);
            this.mrcConsulta.Controls.Add(this.lblSeleccionar);
            this.mrcConsulta.Controls.Add(this.cmbEspecialidad);
            this.mrcConsulta.Controls.Add(this.lblMedicos);
            this.mrcConsulta.Controls.Add(this.btnConsultar);
            this.mrcConsulta.Controls.Add(this.lblEspecialidad);
            this.mrcConsulta.Controls.Add(this.dgvConsulta);
            this.mrcConsulta.Location = new System.Drawing.Point(12, 23);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Size = new System.Drawing.Size(455, 276);
            this.mrcConsulta.TabIndex = 8;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta Médico";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(350, 32);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "&Actualizar Especialidades";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(350, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(518, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 325);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.btnRegistroMedico);
            this.Controls.Add(this.btnRegistroEspecialidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Consulta Médico por Especialidad";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegistroEspecialidad;
        private System.Windows.Forms.Button btnRegistroMedico;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnActualizar;
    }
}

