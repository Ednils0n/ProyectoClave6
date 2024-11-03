
namespace ProyectoClave6
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CHsipro = new System.Windows.Forms.CheckBox();
            this.CHnooasis = new System.Windows.Forms.CheckBox();
            this.CHsioasis = new System.Windows.Forms.CheckBox();
            this.CHnopro = new System.Windows.Forms.CheckBox();
            this.CHnocafe = new System.Windows.Forms.CheckBox();
            this.CHsicafe = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.cmbTipoSala = new System.Windows.Forms.ComboBox();
            this.btnGuardarSala = new System.Windows.Forms.Button();
            this.dgvGestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Salas de Reunion Work Office ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar el tipo de Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione Equipo a Desear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cafetera\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Oasis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Proyector";
            // 
            // CHsipro
            // 
            this.CHsipro.AutoSize = true;
            this.CHsipro.Location = new System.Drawing.Point(149, 115);
            this.CHsipro.Name = "CHsipro";
            this.CHsipro.Size = new System.Drawing.Size(35, 17);
            this.CHsipro.TabIndex = 6;
            this.CHsipro.Text = "Si";
            this.CHsipro.UseVisualStyleBackColor = true;
            // 
            // CHnooasis
            // 
            this.CHnooasis.AutoSize = true;
            this.CHnooasis.Location = new System.Drawing.Point(189, 141);
            this.CHnooasis.Name = "CHnooasis";
            this.CHnooasis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CHnooasis.Size = new System.Drawing.Size(40, 17);
            this.CHnooasis.TabIndex = 7;
            this.CHnooasis.Text = "No";
            this.CHnooasis.UseVisualStyleBackColor = true;
            // 
            // CHsioasis
            // 
            this.CHsioasis.AutoSize = true;
            this.CHsioasis.Location = new System.Drawing.Point(149, 141);
            this.CHsioasis.Name = "CHsioasis";
            this.CHsioasis.Size = new System.Drawing.Size(35, 17);
            this.CHsioasis.TabIndex = 8;
            this.CHsioasis.Text = "Si";
            this.CHsioasis.UseVisualStyleBackColor = true;
            // 
            // CHnopro
            // 
            this.CHnopro.AutoSize = true;
            this.CHnopro.Location = new System.Drawing.Point(189, 115);
            this.CHnopro.Name = "CHnopro";
            this.CHnopro.Size = new System.Drawing.Size(40, 17);
            this.CHnopro.TabIndex = 9;
            this.CHnopro.Text = "No";
            this.CHnopro.UseVisualStyleBackColor = true;
            // 
            // CHnocafe
            // 
            this.CHnocafe.AutoSize = true;
            this.CHnocafe.Location = new System.Drawing.Point(189, 169);
            this.CHnocafe.Name = "CHnocafe";
            this.CHnocafe.Size = new System.Drawing.Size(40, 17);
            this.CHnocafe.TabIndex = 10;
            this.CHnocafe.Text = "No";
            this.CHnocafe.UseVisualStyleBackColor = true;
            // 
            // CHsicafe
            // 
            this.CHsicafe.AutoSize = true;
            this.CHsicafe.Location = new System.Drawing.Point(149, 170);
            this.CHsicafe.Name = "CHsicafe";
            this.CHsicafe.Size = new System.Drawing.Size(35, 17);
            this.CHsicafe.TabIndex = 11;
            this.CHsicafe.Text = "Si";
            this.CHsicafe.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ubicacion de la Sala";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(302, 103);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(203, 20);
            this.txtUbicacion.TabIndex = 13;
            // 
            // cmbTipoSala
            // 
            this.cmbTipoSala.FormattingEnabled = true;
            this.cmbTipoSala.Location = new System.Drawing.Point(554, 101);
            this.cmbTipoSala.Name = "cmbTipoSala";
            this.cmbTipoSala.Size = new System.Drawing.Size(187, 21);
            this.cmbTipoSala.TabIndex = 14;
            // 
            // btnGuardarSala
            // 
            this.btnGuardarSala.Location = new System.Drawing.Point(149, 193);
            this.btnGuardarSala.Name = "btnGuardarSala";
            this.btnGuardarSala.Size = new System.Drawing.Size(303, 40);
            this.btnGuardarSala.TabIndex = 15;
            this.btnGuardarSala.Text = "Guardar Sala ";
            this.btnGuardarSala.UseVisualStyleBackColor = true;
            this.btnGuardarSala.Click += new System.EventHandler(this.btnGuardarSala_Click);
            // 
            // dgvGestion
            // 
            this.dgvGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestion.Location = new System.Drawing.Point(30, 266);
            this.dgvGestion.Name = "dgvGestion";
            this.dgvGestion.Size = new System.Drawing.Size(737, 220);
            this.dgvGestion.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.dgvGestion);
            this.Controls.Add(this.btnGuardarSala);
            this.Controls.Add(this.cmbTipoSala);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CHsicafe);
            this.Controls.Add(this.CHnocafe);
            this.Controls.Add(this.CHnopro);
            this.Controls.Add(this.CHsioasis);
            this.Controls.Add(this.CHnooasis);
            this.Controls.Add(this.CHsipro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CHsipro;
        private System.Windows.Forms.CheckBox CHnooasis;
        private System.Windows.Forms.CheckBox CHsioasis;
        private System.Windows.Forms.CheckBox CHnopro;
        private System.Windows.Forms.CheckBox CHnocafe;
        private System.Windows.Forms.CheckBox CHsicafe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.ComboBox cmbTipoSala;
        private System.Windows.Forms.Button btnGuardarSala;
        private System.Windows.Forms.DataGridView dgvGestion;
    }
}