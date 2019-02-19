namespace EjemplosC2
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.nudedad = new System.Windows.Forms.NumericUpDown();
            this.rbmas = new System.Windows.Forms.RadioButton();
            this.rbfem = new System.Windows.Forms.RadioButton();
            this.mtbsueldo = new System.Windows.Forms.MaskedTextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudedad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de Empleado";
            // 
            // gbdatos
            // 
            this.gbdatos.Controls.Add(this.label6);
            this.gbdatos.Controls.Add(this.label5);
            this.gbdatos.Controls.Add(this.label4);
            this.gbdatos.Controls.Add(this.label3);
            this.gbdatos.Controls.Add(this.label2);
            this.gbdatos.Controls.Add(this.dtpfecha);
            this.gbdatos.Controls.Add(this.mtbsueldo);
            this.gbdatos.Controls.Add(this.rbfem);
            this.gbdatos.Controls.Add(this.rbmas);
            this.gbdatos.Controls.Add(this.nudedad);
            this.gbdatos.Controls.Add(this.txtnombre);
            this.gbdatos.Location = new System.Drawing.Point(41, 70);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(431, 173);
            this.gbdatos.TabIndex = 1;
            this.gbdatos.TabStop = false;
            this.gbdatos.Text = "Datos Personales";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(41, 249);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(431, 48);
            this.btnmostrar.TabIndex = 2;
            this.btnmostrar.Text = "Mostar Datos";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(135, 26);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(251, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // nudedad
            // 
            this.nudedad.Location = new System.Drawing.Point(135, 49);
            this.nudedad.Name = "nudedad";
            this.nudedad.Size = new System.Drawing.Size(251, 20);
            this.nudedad.TabIndex = 1;
            // 
            // rbmas
            // 
            this.rbmas.AutoSize = true;
            this.rbmas.Location = new System.Drawing.Point(135, 92);
            this.rbmas.Name = "rbmas";
            this.rbmas.Size = new System.Drawing.Size(73, 17);
            this.rbmas.TabIndex = 2;
            this.rbmas.TabStop = true;
            this.rbmas.Text = "Masculino";
            this.rbmas.UseVisualStyleBackColor = true;
            // 
            // rbfem
            // 
            this.rbfem.AutoSize = true;
            this.rbfem.Location = new System.Drawing.Point(135, 72);
            this.rbfem.Name = "rbfem";
            this.rbfem.Size = new System.Drawing.Size(71, 17);
            this.rbfem.TabIndex = 3;
            this.rbfem.TabStop = true;
            this.rbfem.Text = "Femenino";
            this.rbfem.UseVisualStyleBackColor = true;
            // 
            // mtbsueldo
            // 
            this.mtbsueldo.Location = new System.Drawing.Point(135, 135);
            this.mtbsueldo.Mask = "99999.99";
            this.mtbsueldo.Name = "mtbsueldo";
            this.mtbsueldo.Size = new System.Drawing.Size(251, 20);
            this.mtbsueldo.TabIndex = 4;
            this.mtbsueldo.ValidatingType = typeof(int);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(135, 112);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(251, 20);
            this.dtpfecha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sueldo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 322);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.gbdatos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.MaskedTextBox mtbsueldo;
        private System.Windows.Forms.RadioButton rbfem;
        private System.Windows.Forms.RadioButton rbmas;
        private System.Windows.Forms.NumericUpDown nudedad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

