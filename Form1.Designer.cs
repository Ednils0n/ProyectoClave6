
namespace ProyectoClave6
{
    partial class Form1
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnSiguienteForms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSesion = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(321, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 46);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(702, 303);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(86, 46);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "ConectarSQL";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnSiguienteForms
            // 
            this.btnSiguienteForms.Location = new System.Drawing.Point(392, 180);
            this.btnSiguienteForms.Name = "btnSiguienteForms";
            this.btnSiguienteForms.Size = new System.Drawing.Size(86, 46);
            this.btnSiguienteForms.TabIndex = 2;
            this.btnSiguienteForms.Text = "Registrate";
            this.btnSiguienteForms.UseVisualStyleBackColor = true;
            this.btnSiguienteForms.Click += new System.EventHandler(this.btnSiguienteForms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicia Sesion";
            // 
            // txtSesion
            // 
            this.txtSesion.Location = new System.Drawing.Point(279, 97);
            this.txtSesion.Name = "txtSesion";
            this.txtSesion.Size = new System.Drawing.Size(168, 20);
            this.txtSesion.TabIndex = 4;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(279, 135);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(168, 20);
            this.txtContra.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(229, 180);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(86, 46);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiguienteForms);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSiguienteForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSesion;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}

