namespace MantenimientodeNotaperiodisticas
{
    partial class FrmLogin
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
            this.lblusuarios = new MetroFramework.Controls.MetroLabel();
            this.txtusuario = new MetroFramework.Controls.MetroTextBox();
            this.txtpass = new MetroFramework.Controls.MetroTextBox();
            this.lblpass = new MetroFramework.Controls.MetroLabel();
            this.btningresar = new MetroFramework.Controls.MetroButton();
            this.btnregistrar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblusuarios
            // 
            this.lblusuarios.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblusuarios.Location = new System.Drawing.Point(37, 117);
            this.lblusuarios.Name = "lblusuarios";
            this.lblusuarios.Size = new System.Drawing.Size(89, 25);
            this.lblusuarios.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblusuarios.TabIndex = 0;
            this.lblusuarios.Text = "Usuario :";
            // 
            // txtusuario
            // 
            this.txtusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.txtusuario.CustomButton.Image = null;
            this.txtusuario.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtusuario.CustomButton.Name = "";
            this.txtusuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusuario.CustomButton.TabIndex = 1;
            this.txtusuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusuario.CustomButton.UseSelectable = true;
            this.txtusuario.CustomButton.Visible = false;
            this.txtusuario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtusuario.Lines = new string[0];
            this.txtusuario.Location = new System.Drawing.Point(132, 119);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.PromptText = "Username";
            this.txtusuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.ShortcutsEnabled = true;
            this.txtusuario.Size = new System.Drawing.Size(189, 23);
            this.txtusuario.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtusuario.TabIndex = 1;
            this.txtusuario.UseSelectable = true;
            this.txtusuario.WaterMark = "Username";
            this.txtusuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtpass
            // 
            this.txtpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.txtpass.CustomButton.Image = null;
            this.txtpass.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtpass.CustomButton.Name = "";
            this.txtpass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpass.CustomButton.TabIndex = 1;
            this.txtpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpass.CustomButton.UseSelectable = true;
            this.txtpass.CustomButton.Visible = false;
            this.txtpass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtpass.Lines = new string[0];
            this.txtpass.Location = new System.Drawing.Point(132, 201);
            this.txtpass.MaxLength = 8;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.PromptText = "Password";
            this.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.Size = new System.Drawing.Size(189, 23);
            this.txtpass.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtpass.TabIndex = 3;
            this.txtpass.UseSelectable = true;
            this.txtpass.WaterMark = "Password";
            this.txtpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblpass
            // 
            this.lblpass.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblpass.Location = new System.Drawing.Point(23, 199);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(103, 25);
            this.lblpass.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "Password :";
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btningresar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btningresar.Location = new System.Drawing.Point(132, 273);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(74, 30);
            this.btningresar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseCustomBackColor = true;
            this.btningresar.UseCustomForeColor = true;
            this.btningresar.UseSelectable = true;
            this.btningresar.UseStyleColors = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnregistrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnregistrar.Location = new System.Drawing.Point(247, 273);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(74, 30);
            this.btnregistrar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnregistrar.TabIndex = 5;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseCustomBackColor = true;
            this.btnregistrar.UseCustomForeColor = true;
            this.btnregistrar.UseSelectable = true;
            this.btnregistrar.UseStyleColors = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 326);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuarios);
            this.Name = "FrmLogin";
            this.Text = "Mantenimiento de Usuarios";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblusuarios;
        private MetroFramework.Controls.MetroTextBox txtusuario;
        private MetroFramework.Controls.MetroTextBox txtpass;
        private MetroFramework.Controls.MetroLabel lblpass;
        private MetroFramework.Controls.MetroButton btningresar;
        private MetroFramework.Controls.MetroButton btnregistrar;
    }
}

