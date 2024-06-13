namespace Evaluación1_Hotel.Forms
{
    partial class Principal
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarHotel = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.dtHoteles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.SliderStars = new MaterialSkin.Controls.MaterialSlider();
            this.txtxPais = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lblMsj = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(772, 523);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hotel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblMsj);
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Controls.Add(this.dtHoteles);
            this.materialCard1.Controls.Add(this.lblID);
            this.materialCard1.Controls.Add(this.SliderStars);
            this.materialCard1.Controls.Add(this.txtxPais);
            this.materialCard1.Controls.Add(this.txtCiudad);
            this.materialCard1.Controls.Add(this.txtDireccion);
            this.materialCard1.Controls.Add(this.txtNombre);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(758, 491);
            this.materialCard1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregarHotel);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Location = new System.Drawing.Point(595, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 211);
            this.panel1.TabIndex = 10;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = false;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(15, 155);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(89, 40);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarHotel
            // 
            this.btnAgregarHotel.AutoSize = false;
            this.btnAgregarHotel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarHotel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarHotel.Depth = 0;
            this.btnAgregarHotel.HighEmphasis = true;
            this.btnAgregarHotel.Icon = null;
            this.btnAgregarHotel.Location = new System.Drawing.Point(15, 10);
            this.btnAgregarHotel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarHotel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarHotel.Name = "btnAgregarHotel";
            this.btnAgregarHotel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarHotel.Size = new System.Drawing.Size(89, 40);
            this.btnAgregarHotel.TabIndex = 7;
            this.btnAgregarHotel.Text = "Agregar";
            this.btnAgregarHotel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarHotel.UseAccentColor = false;
            this.btnAgregarHotel.UseVisualStyleBackColor = true;
            this.btnAgregarHotel.Click += new System.EventHandler(this.btnAgregarHotel_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(15, 78);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(89, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dtHoteles
            // 
            this.dtHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtHoteles.Location = new System.Drawing.Point(72, 251);
            this.dtHoteles.Name = "dtHoteles";
            this.dtHoteles.Size = new System.Drawing.Size(637, 150);
            this.dtHoteles.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N°";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ciudad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "País";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estrellas";
            this.Column6.Name = "Column6";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Depth = 0;
            this.lblID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblID.Location = new System.Drawing.Point(144, 19);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 19);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Id:";
            // 
            // SliderStars
            // 
            this.SliderStars.Depth = 0;
            this.SliderStars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SliderStars.Location = new System.Drawing.Point(339, 165);
            this.SliderStars.MouseState = MaterialSkin.MouseState.HOVER;
            this.SliderStars.Name = "SliderStars";
            this.SliderStars.RangeMax = 5;
            this.SliderStars.Size = new System.Drawing.Size(250, 40);
            this.SliderStars.TabIndex = 4;
            this.SliderStars.Text = "Estrellas";
            this.SliderStars.Value = 0;
            this.SliderStars.ValueMax = 5;
            // 
            // txtxPais
            // 
            this.txtxPais.AnimateReadOnly = false;
            this.txtxPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtxPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxPais.Depth = 0;
            this.txtxPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtxPais.HideSelection = true;
            this.txtxPais.Hint = "País";
            this.txtxPais.LeadingIcon = null;
            this.txtxPais.Location = new System.Drawing.Point(339, 83);
            this.txtxPais.MaxLength = 32767;
            this.txtxPais.MouseState = MaterialSkin.MouseState.OUT;
            this.txtxPais.Name = "txtxPais";
            this.txtxPais.PasswordChar = '\0';
            this.txtxPais.PrefixSuffixText = null;
            this.txtxPais.ReadOnly = false;
            this.txtxPais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtxPais.SelectedText = "";
            this.txtxPais.SelectionLength = 0;
            this.txtxPais.SelectionStart = 0;
            this.txtxPais.ShortcutsEnabled = true;
            this.txtxPais.Size = new System.Drawing.Size(250, 48);
            this.txtxPais.TabIndex = 3;
            this.txtxPais.TabStop = false;
            this.txtxPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtxPais.TrailingIcon = null;
            this.txtxPais.UseSystemPasswordChar = false;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AnimateReadOnly = false;
            this.txtCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCiudad.Depth = 0;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCiudad.HideSelection = true;
            this.txtCiudad.Hint = "Ciudad";
            this.txtCiudad.LeadingIcon = null;
            this.txtCiudad.Location = new System.Drawing.Point(339, 14);
            this.txtCiudad.MaxLength = 32767;
            this.txtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PasswordChar = '\0';
            this.txtCiudad.PrefixSuffixText = null;
            this.txtCiudad.ReadOnly = false;
            this.txtCiudad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCiudad.SelectedText = "";
            this.txtCiudad.SelectionLength = 0;
            this.txtCiudad.SelectionStart = 0;
            this.txtCiudad.ShortcutsEnabled = true;
            this.txtCiudad.Size = new System.Drawing.Size(250, 48);
            this.txtCiudad.TabIndex = 2;
            this.txtCiudad.TabStop = false;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCiudad.TrailingIcon = null;
            this.txtCiudad.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.HideSelection = true;
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(63, 157);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PrefixSuffixText = null;
            this.txtDireccion.ReadOnly = false;
            this.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(250, 48);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccion.TrailingIcon = null;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(63, 83);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(250, 48);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Habitación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(764, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reserva";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(764, 444);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cliente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(764, 444);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pago";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(764, 444);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Factura";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(764, 444);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Empleado";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(252, 415);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(250, 31);
            this.lblMsj.TabIndex = 11;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 590);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtxPais;
        private MaterialSkin.Controls.MaterialTextBox2 txtCiudad;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccion;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private MaterialSkin.Controls.MaterialSlider SliderStars;
        private System.Windows.Forms.DataGridView dtHoteles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialButton btnAgregarHotel;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private System.Windows.Forms.Label lblMsj;
    }
}