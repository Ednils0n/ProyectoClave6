
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenu3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio de Reservacion de Salas";
            // 
            // dgvReserva
            // 
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(89, 207);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(680, 130);
            this.dgvReserva.TabIndex = 1;
            // 
            // nupMenu1
            // 
            this.nupMenu1.Location = new System.Drawing.Point(191, 90);
            this.nupMenu1.Name = "nupMenu1";
            this.nupMenu1.Size = new System.Drawing.Size(41, 20);
            this.nupMenu1.TabIndex = 2;
            // 
            // nupMenu2
            // 
            this.nupMenu2.Location = new System.Drawing.Point(190, 116);
            this.nupMenu2.Name = "nupMenu2";
            this.nupMenu2.Size = new System.Drawing.Size(42, 20);
            this.nupMenu2.TabIndex = 3;
            // 
            // nupMenu3
            // 
            this.nupMenu3.Location = new System.Drawing.Point(190, 142);
            this.nupMenu3.Name = "nupMenu3";
            this.nupMenu3.Size = new System.Drawing.Size(41, 20);
            this.nupMenu3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menu 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Selecciones los asistentes que quieran el menu que sin exceder 25\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(501, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dia de Reservacion";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}