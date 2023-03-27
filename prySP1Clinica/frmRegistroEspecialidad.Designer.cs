namespace prySP1Clinica
{
    partial class frmRegistroEspecialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEspecialidad));
            this.mrcRegistroEspecialidad = new System.Windows.Forms.GroupBox();
            this.btnRegistrarEspecialidad = new System.Windows.Forms.Button();
            this.txtNumeroID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumeroEspecialidad = new System.Windows.Forms.Label();
            this.lblNombreEspecialidad = new System.Windows.Forms.Label();
            this.btnSalirRegEsp = new System.Windows.Forms.Button();
            this.mrcRegistroEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistroEspecialidad
            // 
            this.mrcRegistroEspecialidad.Controls.Add(this.btnRegistrarEspecialidad);
            this.mrcRegistroEspecialidad.Controls.Add(this.txtNumeroID);
            this.mrcRegistroEspecialidad.Controls.Add(this.txtNombre);
            this.mrcRegistroEspecialidad.Controls.Add(this.lblNumeroEspecialidad);
            this.mrcRegistroEspecialidad.Controls.Add(this.lblNombreEspecialidad);
            this.mrcRegistroEspecialidad.Location = new System.Drawing.Point(12, 21);
            this.mrcRegistroEspecialidad.Name = "mrcRegistroEspecialidad";
            this.mrcRegistroEspecialidad.Size = new System.Drawing.Size(301, 136);
            this.mrcRegistroEspecialidad.TabIndex = 0;
            this.mrcRegistroEspecialidad.TabStop = false;
            this.mrcRegistroEspecialidad.Text = "Registro";
            // 
            // btnRegistrarEspecialidad
            // 
            this.btnRegistrarEspecialidad.Location = new System.Drawing.Point(208, 98);
            this.btnRegistrarEspecialidad.Name = "btnRegistrarEspecialidad";
            this.btnRegistrarEspecialidad.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarEspecialidad.TabIndex = 4;
            this.btnRegistrarEspecialidad.Text = "&Registrar";
            this.btnRegistrarEspecialidad.UseVisualStyleBackColor = true;
            this.btnRegistrarEspecialidad.Click += new System.EventHandler(this.btnRegistrarEspecialidad_Click);
            // 
            // txtNumeroID
            // 
            this.txtNumeroID.Location = new System.Drawing.Point(122, 63);
            this.txtNumeroID.Name = "txtNumeroID";
            this.txtNumeroID.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroID.TabIndex = 3;
            this.txtNumeroID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroID_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNumeroEspecialidad
            // 
            this.lblNumeroEspecialidad.AutoSize = true;
            this.lblNumeroEspecialidad.Location = new System.Drawing.Point(7, 63);
            this.lblNumeroEspecialidad.Name = "lblNumeroEspecialidad";
            this.lblNumeroEspecialidad.Size = new System.Drawing.Size(87, 13);
            this.lblNumeroEspecialidad.TabIndex = 1;
            this.lblNumeroEspecialidad.Text = "N° identificatorio:";
            // 
            // lblNombreEspecialidad
            // 
            this.lblNombreEspecialidad.AutoSize = true;
            this.lblNombreEspecialidad.Location = new System.Drawing.Point(7, 33);
            this.lblNombreEspecialidad.Name = "lblNombreEspecialidad";
            this.lblNombreEspecialidad.Size = new System.Drawing.Size(109, 13);
            this.lblNombreEspecialidad.TabIndex = 0;
            this.lblNombreEspecialidad.Text = "Nombre especialidad:";
            // 
            // btnSalirRegEsp
            // 
            this.btnSalirRegEsp.Location = new System.Drawing.Point(276, 172);
            this.btnSalirRegEsp.Name = "btnSalirRegEsp";
            this.btnSalirRegEsp.Size = new System.Drawing.Size(75, 23);
            this.btnSalirRegEsp.TabIndex = 1;
            this.btnSalirRegEsp.Text = "&Salir";
            this.btnSalirRegEsp.UseVisualStyleBackColor = true;
            this.btnSalirRegEsp.Click += new System.EventHandler(this.btnSalirRegEsp_Click);
            // 
            // frmRegistroEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 211);
            this.Controls.Add(this.btnSalirRegEsp);
            this.Controls.Add(this.mrcRegistroEspecialidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Nueva Especialidad";
            this.Load += new System.EventHandler(this.frmRegistroEspecialidad_Load);
            this.mrcRegistroEspecialidad.ResumeLayout(false);
            this.mrcRegistroEspecialidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistroEspecialidad;
        private System.Windows.Forms.Button btnRegistrarEspecialidad;
        private System.Windows.Forms.TextBox txtNumeroID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumeroEspecialidad;
        private System.Windows.Forms.Label lblNombreEspecialidad;
        private System.Windows.Forms.Button btnSalirRegEsp;
    }
}