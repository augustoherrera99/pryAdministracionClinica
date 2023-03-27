namespace prySP1Clinica
{
    partial class frmRegistroMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroMedico));
            this.mrcRegistroMedico = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblNumeroEspecialidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcRegistroMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistroMedico
            // 
            this.mrcRegistroMedico.Controls.Add(this.cmbEspecialidad);
            this.mrcRegistroMedico.Controls.Add(this.btnRegistrar);
            this.mrcRegistroMedico.Controls.Add(this.txtNombre);
            this.mrcRegistroMedico.Controls.Add(this.txtMatricula);
            this.mrcRegistroMedico.Controls.Add(this.lblNumeroEspecialidad);
            this.mrcRegistroMedico.Controls.Add(this.lblNombre);
            this.mrcRegistroMedico.Controls.Add(this.lblMatricula);
            this.mrcRegistroMedico.Location = new System.Drawing.Point(12, 22);
            this.mrcRegistroMedico.Name = "mrcRegistroMedico";
            this.mrcRegistroMedico.Size = new System.Drawing.Size(310, 157);
            this.mrcRegistroMedico.TabIndex = 0;
            this.mrcRegistroMedico.TabStop = false;
            this.mrcRegistroMedico.Text = "Registro";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(95, 94);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(103, 21);
            this.cmbEspecialidad.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(220, 118);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(117, 31);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 3;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // lblNumeroEspecialidad
            // 
            this.lblNumeroEspecialidad.AutoSize = true;
            this.lblNumeroEspecialidad.Location = new System.Drawing.Point(7, 97);
            this.lblNumeroEspecialidad.Name = "lblNumeroEspecialidad";
            this.lblNumeroEspecialidad.Size = new System.Drawing.Size(82, 13);
            this.lblNumeroEspecialidad.TabIndex = 2;
            this.lblNumeroEspecialidad.Text = "N° Especialidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(7, 34);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(104, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula profesional";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(270, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRegistroMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 227);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcRegistroMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Nuevo Médico";
            this.Load += new System.EventHandler(this.frmRegistroMedico_Load);
            this.mrcRegistroMedico.ResumeLayout(false);
            this.mrcRegistroMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistroMedico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblNumeroEspecialidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}