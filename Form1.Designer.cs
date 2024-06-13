namespace Evaluación1_Hotel
{
    partial class Login
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
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnIniciar = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.HideSelection = true;
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(77, 231);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PrefixSuffixText = null;
            this.txtUser.ReadOnly = false;
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(250, 48);
            this.txtUser.TabIndex = 0;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.HideSelection = true;
            this.txtPass.LeadingIcon = null;
            this.txtPass.Location = new System.Drawing.Point(77, 302);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PrefixSuffixText = null;
            this.txtPass.ReadOnly = false;
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(250, 48);
            this.txtPass.TabIndex = 1;
            this.txtPass.TabStop = false;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TrailingIcon = null;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciar.Depth = 0;
            this.btnIniciar.HighEmphasis = true;
            this.btnIniciar.Icon = null;
            this.btnIniciar.Location = new System.Drawing.Point(121, 381);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciar.Size = new System.Drawing.Size(128, 36);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciar.UseAccentColor = false;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.Image = global::Evaluación1_Hotel.Properties.Resources.icons8_usuario_96__1_;
            this.label1.Location = new System.Drawing.Point(123, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 108);
            this.label1.TabIndex = 3;
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlert.Location = new System.Drawing.Point(77, 451);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(250, 33);
            this.lblAlert.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 512);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Name = "Login";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtUser;
        private MaterialSkin.Controls.MaterialTextBox2 txtPass;
        private MaterialSkin.Controls.MaterialButton btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlert;
    }
}

