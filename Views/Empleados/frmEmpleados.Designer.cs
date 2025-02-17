namespace Empleados4G.Views
{
    partial class frmEmpleados
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.gvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1693, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 33);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Salir";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gvEmpleados
            // 
            this.gvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmpleados.Location = new System.Drawing.Point(15, 137);
            this.gvEmpleados.Name = "gvEmpleados";
            this.gvEmpleados.RowHeadersWidth = 51;
            this.gvEmpleados.RowTemplate.Height = 24;
            this.gvEmpleados.Size = new System.Drawing.Size(1797, 471);
            this.gvEmpleados.TabIndex = 16;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(44, 16);
            this.lblBienvenido.TabIndex = 17;
            this.lblBienvenido.Text = "label1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1455, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 47);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1576, 73);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 47);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1697, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 47);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(1334, 73);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(115, 47);
            this.btnExportar.TabIndex = 21;
            this.btnExportar.Text = "Exportar XLS";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 633);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.gvEmpleados);
            this.Controls.Add(this.btnLogout);
            this.Name = "frmEmpleados";
            this.Text = "Empleados 4G";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView gvEmpleados;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
    }
}