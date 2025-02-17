namespace Empleados4G.Views.Empleados
{
    partial class frmEmpleado
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSalarioCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoSangre = new System.Windows.Forms.ComboBox();
            this.cbEPS = new System.Windows.Forms.ComboBox();
            this.cbARL = new System.Windows.Forms.ComboBox();
            this.cbPensiones = new System.Windows.Forms.ComboBox();
            this.txtTotalSalario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtDevengadoEPS = new System.Windows.Forms.TextBox();
            this.txtDevengadoARL = new System.Windows.Forms.TextBox();
            this.txtDevengadoPensiones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPorcentajePensiones = new System.Windows.Forms.TextBox();
            this.txtPorcentajeARL = new System.Windows.Forms.TextBox();
            this.txtPorcentajeEPS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(516, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(81, 129);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(183, 22);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(399, 129);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(198, 22);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtSalarioCompleto
            // 
            this.txtSalarioCompleto.Location = new System.Drawing.Point(81, 187);
            this.txtSalarioCompleto.Name = "txtSalarioCompleto";
            this.txtSalarioCompleto.Size = new System.Drawing.Size(516, 22);
            this.txtSalarioCompleto.TabIndex = 7;
            this.txtSalarioCompleto.Text = "0";
            this.txtSalarioCompleto.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtSalarioCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de sangre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "EPS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ARL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fondo de pensiones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Salario completo";
            // 
            // cbTipoSangre
            // 
            this.cbTipoSangre.FormattingEnabled = true;
            this.cbTipoSangre.Location = new System.Drawing.Point(286, 127);
            this.cbTipoSangre.Name = "cbTipoSangre";
            this.cbTipoSangre.Size = new System.Drawing.Size(96, 24);
            this.cbTipoSangre.TabIndex = 16;
            // 
            // cbEPS
            // 
            this.cbEPS.FormattingEnabled = true;
            this.cbEPS.Location = new System.Drawing.Point(81, 242);
            this.cbEPS.Name = "cbEPS";
            this.cbEPS.Size = new System.Drawing.Size(183, 24);
            this.cbEPS.TabIndex = 17;
            this.cbEPS.SelectedIndexChanged += new System.EventHandler(this.cbEPS_SelectedIndexChanged);
            // 
            // cbARL
            // 
            this.cbARL.FormattingEnabled = true;
            this.cbARL.Location = new System.Drawing.Point(81, 298);
            this.cbARL.Name = "cbARL";
            this.cbARL.Size = new System.Drawing.Size(183, 24);
            this.cbARL.TabIndex = 18;
            this.cbARL.SelectedIndexChanged += new System.EventHandler(this.cbARL_SelectedIndexChanged);
            // 
            // cbPensiones
            // 
            this.cbPensiones.FormattingEnabled = true;
            this.cbPensiones.Location = new System.Drawing.Point(81, 352);
            this.cbPensiones.Name = "cbPensiones";
            this.cbPensiones.Size = new System.Drawing.Size(183, 24);
            this.cbPensiones.TabIndex = 19;
            this.cbPensiones.SelectedIndexChanged += new System.EventHandler(this.cbPensiones_SelectedIndexChanged);
            // 
            // txtTotalSalario
            // 
            this.txtTotalSalario.Location = new System.Drawing.Point(81, 411);
            this.txtTotalSalario.Name = "txtTotalSalario";
            this.txtTotalSalario.ReadOnly = true;
            this.txtTotalSalario.Size = new System.Drawing.Size(516, 22);
            this.txtTotalSalario.TabIndex = 20;
            this.txtTotalSalario.Text = "0";
            this.txtTotalSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total salario devengado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Porcentaje EPS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Porcentaje ARL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Porc. pensiones";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(158, 472);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 61);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(350, 472);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 61);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtDevengadoEPS
            // 
            this.txtDevengadoEPS.Location = new System.Drawing.Point(399, 242);
            this.txtDevengadoEPS.Name = "txtDevengadoEPS";
            this.txtDevengadoEPS.ReadOnly = true;
            this.txtDevengadoEPS.Size = new System.Drawing.Size(198, 22);
            this.txtDevengadoEPS.TabIndex = 30;
            this.txtDevengadoEPS.Text = "0";
            this.txtDevengadoEPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtDevengadoARL
            // 
            this.txtDevengadoARL.Location = new System.Drawing.Point(399, 298);
            this.txtDevengadoARL.Name = "txtDevengadoARL";
            this.txtDevengadoARL.ReadOnly = true;
            this.txtDevengadoARL.Size = new System.Drawing.Size(198, 22);
            this.txtDevengadoARL.TabIndex = 31;
            this.txtDevengadoARL.Text = "0";
            this.txtDevengadoARL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtDevengadoPensiones
            // 
            this.txtDevengadoPensiones.Location = new System.Drawing.Point(399, 356);
            this.txtDevengadoPensiones.Name = "txtDevengadoPensiones";
            this.txtDevengadoPensiones.ReadOnly = true;
            this.txtDevengadoPensiones.Size = new System.Drawing.Size(198, 22);
            this.txtDevengadoPensiones.TabIndex = 32;
            this.txtDevengadoPensiones.Text = "0";
            this.txtDevengadoPensiones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Valor devengado EPS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "Valor devengado ARL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(396, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "Valor devengado Pensiones";
            // 
            // txtPorcentajePensiones
            // 
            this.txtPorcentajePensiones.Location = new System.Drawing.Point(286, 354);
            this.txtPorcentajePensiones.MaxLength = 3;
            this.txtPorcentajePensiones.Name = "txtPorcentajePensiones";
            this.txtPorcentajePensiones.ReadOnly = true;
            this.txtPorcentajePensiones.Size = new System.Drawing.Size(96, 22);
            this.txtPorcentajePensiones.TabIndex = 24;
            this.txtPorcentajePensiones.Text = "0";
            this.txtPorcentajePensiones.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtPorcentajePensiones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtPorcentajeARL
            // 
            this.txtPorcentajeARL.Location = new System.Drawing.Point(286, 300);
            this.txtPorcentajeARL.MaxLength = 3;
            this.txtPorcentajeARL.Name = "txtPorcentajeARL";
            this.txtPorcentajeARL.ReadOnly = true;
            this.txtPorcentajeARL.Size = new System.Drawing.Size(96, 22);
            this.txtPorcentajeARL.TabIndex = 23;
            this.txtPorcentajeARL.Text = "0";
            this.txtPorcentajeARL.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtPorcentajeARL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtPorcentajeEPS
            // 
            this.txtPorcentajeEPS.Location = new System.Drawing.Point(286, 242);
            this.txtPorcentajeEPS.MaxLength = 3;
            this.txtPorcentajeEPS.Name = "txtPorcentajeEPS";
            this.txtPorcentajeEPS.ReadOnly = true;
            this.txtPorcentajeEPS.Size = new System.Drawing.Size(96, 22);
            this.txtPorcentajeEPS.TabIndex = 22;
            this.txtPorcentajeEPS.Text = "0";
            this.txtPorcentajeEPS.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtPorcentajeEPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 586);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDevengadoPensiones);
            this.Controls.Add(this.txtDevengadoARL);
            this.Controls.Add(this.txtDevengadoEPS);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPorcentajePensiones);
            this.Controls.Add(this.txtPorcentajeARL);
            this.Controls.Add(this.txtPorcentajeEPS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalSalario);
            this.Controls.Add(this.cbPensiones);
            this.Controls.Add(this.cbARL);
            this.Controls.Add(this.cbEPS);
            this.Controls.Add(this.cbTipoSangre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalarioCompleto);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmEmpleado";
            this.Text = "Empleados 4G";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSalarioCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoSangre;
        private System.Windows.Forms.ComboBox cbEPS;
        private System.Windows.Forms.ComboBox cbARL;
        private System.Windows.Forms.ComboBox cbPensiones;
        private System.Windows.Forms.TextBox txtTotalSalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtDevengadoEPS;
        private System.Windows.Forms.TextBox txtDevengadoARL;
        private System.Windows.Forms.TextBox txtDevengadoPensiones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPorcentajePensiones;
        private System.Windows.Forms.TextBox txtPorcentajeARL;
        private System.Windows.Forms.TextBox txtPorcentajeEPS;
    }
}