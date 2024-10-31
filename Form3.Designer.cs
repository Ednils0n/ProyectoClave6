
namespace ProyectoClave6
{
    partial class Form3
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
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.nupMenu1 = new System.Windows.Forms.NumericUpDown();
            this.nupMenu2 = new System.Windows.Forms.NumericUpDown();
            this.nupMenu3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmReservacion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReservador = new System.Windows.Forms.TextBox();
            this.btnBorrarReservacion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio de Reservacion de Salas";
            // 
            // dgvReserva
            // 
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(32, 340);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(794, 374);
            this.dgvReserva.TabIndex = 1;
            // 
            // nupMenu1
            // 
            this.nupMenu1.Location = new System.Drawing.Point(451, 90);
            this.nupMenu1.Name = "nupMenu1";
            this.nupMenu1.Size = new System.Drawing.Size(41, 20);
            this.nupMenu1.TabIndex = 2;
            // 
            // nupMenu2
            // 
            this.nupMenu2.Location = new System.Drawing.Point(450, 119);
            this.nupMenu2.Name = "nupMenu2";
            this.nupMenu2.Size = new System.Drawing.Size(42, 20);
            this.nupMenu2.TabIndex = 3;
            // 
            // nupMenu3
            // 
            this.nupMenu3.Location = new System.Drawing.Point(450, 149);
            this.nupMenu3.Name = "nupMenu3";
            this.nupMenu3.Size = new System.Drawing.Size(41, 20);
            this.nupMenu3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu 1: $10.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menu 2: $12.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu 3: $15.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(520, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Selecciones los asistentes que quieran el menu que desee sin exceder 25\r\n";
            // 
            // dtmReservacion
            // 
            this.dtmReservacion.Location = new System.Drawing.Point(436, 201);
            this.dtmReservacion.Name = "dtmReservacion";
            this.dtmReservacion.Size = new System.Drawing.Size(137, 20);
            this.dtmReservacion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dia de Reservacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Confirmar Reserva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre del Reservador";
            // 
            // txtReservador
            // 
            this.txtReservador.Location = new System.Drawing.Point(436, 241);
            this.txtReservador.Name = "txtReservador";
            this.txtReservador.Size = new System.Drawing.Size(137, 20);
            this.txtReservador.TabIndex = 13;
            // 
            // btnBorrarReservacion
            // 
            this.btnBorrarReservacion.Location = new System.Drawing.Point(527, 300);
            this.btnBorrarReservacion.Name = "btnBorrarReservacion";
            this.btnBorrarReservacion.Size = new System.Drawing.Size(281, 34);
            this.btnBorrarReservacion.TabIndex = 14;
            this.btnBorrarReservacion.Text = "Borrar Reservacion";
            this.btnBorrarReservacion.UseVisualStyleBackColor = true;
            this.btnBorrarReservacion.Click += new System.EventHandler(this.btnBorrarReservacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(343, 300);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(178, 34);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(848, 726);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrarReservacion);
            this.Controls.Add(this.txtReservador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtmReservacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupMenu3);
            this.Controls.Add(this.nupMenu2);
            this.Controls.Add(this.nupMenu1);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.NumericUpDown nupMenu1;
        private System.Windows.Forms.NumericUpDown nupMenu2;
        private System.Windows.Forms.NumericUpDown nupMenu3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmReservacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReservador;
        private System.Windows.Forms.Button btnBorrarReservacion;
        private System.Windows.Forms.Button btnSalir;
    }
}