namespace Empleados4G
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRegistrar = new System.Windows.Forms.TableLayoutPanel();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtPasswordReg = new System.Windows.Forms.TextBox();
            this.lblConfirmarPassword = new System.Windows.Forms.Label();
            this.lblUsuarioReg = new System.Windows.Forms.Label();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.txtUsuarioReg = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordReg = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.pnlLogin.SuspendLayout();
            this.pnlRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(175, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(33, 30);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(337, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyUp);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(164, 60);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(33, 87);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(337, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(111, 123);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(182, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrar.Location = new System.Drawing.Point(167, 222);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(69, 16);
            this.lblRegistrar.TabIndex = 5;
            this.lblRegistrar.Text = "Regístrate";
            this.lblRegistrar.Click += new System.EventHandler(this.lblRegistrar_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.ColumnCount = 1;
            this.pnlLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlLogin.Controls.Add(this.lblUsuario, 0, 0);
            this.pnlLogin.Controls.Add(this.lblRegistrar, 0, 5);
            this.pnlLogin.Controls.Add(this.txtUsuario, 0, 1);
            this.pnlLogin.Controls.Add(this.btnLogin, 0, 4);
            this.pnlLogin.Controls.Add(this.lblPassword, 0, 2);
            this.pnlLogin.Controls.Add(this.txtPassword, 0, 3);
            this.pnlLogin.Location = new System.Drawing.Point(53, 44);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.RowCount = 6;
            this.pnlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.148149F));
            this.pnlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.92843F));
            this.pnlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.361829F));
            this.pnlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31412F));
            this.pnlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.30815F));
            this.pnlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.53877F));
            this.pnlLogin.Size = new System.Drawing.Size(404, 296);
            this.pnlLogin.TabIndex = 7;
            // 
            // pnlRegistrar
            // 
            this.pnlRegistrar.ColumnCount = 1;
            this.pnlRegistrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRegistrar.Controls.Add(this.lblRol, 0, 6);
            this.pnlRegistrar.Controls.Add(this.txtPasswordReg, 0, 3);
            this.pnlRegistrar.Controls.Add(this.lblConfirmarPassword, 0, 4);
            this.pnlRegistrar.Controls.Add(this.lblUsuarioReg, 0, 0);
            this.pnlRegistrar.Controls.Add(this.lblIniciarSesion, 0, 9);
            this.pnlRegistrar.Controls.Add(this.txtUsuarioReg, 0, 1);
            this.pnlRegistrar.Controls.Add(this.btnRegistrar, 0, 8);
            this.pnlRegistrar.Controls.Add(this.txtConfirmPassword, 0, 5);
            this.pnlRegistrar.Controls.Add(this.lblPasswordReg, 0, 2);
            this.pnlRegistrar.Controls.Add(this.cbRol, 0, 7);
            this.pnlRegistrar.Location = new System.Drawing.Point(53, 44);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.RowCount = 10;
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.6F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.733333F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.066667F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.533334F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.066667F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.266666F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.933333F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.333333F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.46667F));
            this.pnlRegistrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.73333F));
            this.pnlRegistrar.Size = new System.Drawing.Size(404, 375);
            this.pnlRegistrar.TabIndex = 8;
            this.pnlRegistrar.Visible = false;
            // 
            // lblRol
            // 
            this.lblRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(188, 156);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 16);
            this.lblRol.TabIndex = 10;
            this.lblRol.Text = "Rol";
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordReg.Location = new System.Drawing.Point(33, 74);
            this.txtPasswordReg.MaxLength = 30;
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.PasswordChar = '*';
            this.txtPasswordReg.Size = new System.Drawing.Size(337, 22);
            this.txtPasswordReg.TabIndex = 9;
            this.txtPasswordReg.UseSystemPasswordChar = true;
            // 
            // lblConfirmarPassword
            // 
            this.lblConfirmarPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmarPassword.AutoSize = true;
            this.lblConfirmarPassword.Location = new System.Drawing.Point(134, 102);
            this.lblConfirmarPassword.Name = "lblConfirmarPassword";
            this.lblConfirmarPassword.Size = new System.Drawing.Size(136, 16);
            this.lblConfirmarPassword.TabIndex = 9;
            this.lblConfirmarPassword.Text = "Confirmar Contraseña";
            // 
            // lblUsuarioReg
            // 
            this.lblUsuarioReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuarioReg.AutoSize = true;
            this.lblUsuarioReg.Location = new System.Drawing.Point(175, 2);
            this.lblUsuarioReg.Name = "lblUsuarioReg";
            this.lblUsuarioReg.Size = new System.Drawing.Size(54, 16);
            this.lblUsuarioReg.TabIndex = 0;
            this.lblUsuarioReg.Text = "Usuario";
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIniciarSesion.Location = new System.Drawing.Point(158, 314);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(87, 16);
            this.lblIniciarSesion.TabIndex = 5;
            this.lblIniciarSesion.Text = "Iniciar Sesión";
            this.lblIniciarSesion.Click += new System.EventHandler(this.lblIniciarSesion_Click);
            // 
            // txtUsuarioReg
            // 
            this.txtUsuarioReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuarioReg.Location = new System.Drawing.Point(33, 24);
            this.txtUsuarioReg.MaxLength = 20;
            this.txtUsuarioReg.Name = "txtUsuarioReg";
            this.txtUsuarioReg.Size = new System.Drawing.Size(337, 22);
            this.txtUsuarioReg.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.Location = new System.Drawing.Point(111, 222);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(182, 37);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Location = new System.Drawing.Point(33, 124);
            this.txtConfirmPassword.MaxLength = 30;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(337, 22);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordReg
            // 
            this.lblPasswordReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordReg.AutoSize = true;
            this.lblPasswordReg.Location = new System.Drawing.Point(164, 51);
            this.lblPasswordReg.Name = "lblPasswordReg";
            this.lblPasswordReg.Size = new System.Drawing.Size(76, 16);
            this.lblPasswordReg.TabIndex = 2;
            this.lblPasswordReg.Text = "Contraseña";
            // 
            // cbRol
            // 
            this.cbRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(33, 182);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(337, 24);
            this.cbRol.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 439);
            this.Controls.Add(this.pnlRegistrar);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Empleados 4G";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.btnLogin_Click);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegistrar.ResumeLayout(false);
            this.pnlRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.TableLayoutPanel pnlLogin;
        private System.Windows.Forms.TableLayoutPanel pnlRegistrar;
        private System.Windows.Forms.Label lblUsuarioReg;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.TextBox txtUsuarioReg;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPasswordReg;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPasswordReg;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbRol;
    }
}

