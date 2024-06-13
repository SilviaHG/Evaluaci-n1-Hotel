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
            this.lbl_IdHabitacion = new MaterialSkin.Controls.MaterialTabControl();
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
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblIDhABITACION = new MaterialSkin.Controls.MaterialLabel();
            this.cbNumeroHabitacion = new MaterialSkin.Controls.MaterialComboBox();
            this.cbCapacidadHabitacion = new MaterialSkin.Controls.MaterialComboBox();
            this.cbTipoHabitacion = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.cbNumHotel = new MaterialSkin.Controls.MaterialComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarHabitacion = new MaterialSkin.Controls.MaterialButton();
            this.dtHabitaciones = new System.Windows.Forms.DataGridView();
            this.lblMsjHabitacion = new System.Windows.Forms.Label();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_IdHabitacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoteles)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IdHabitacion
            // 
            this.lbl_IdHabitacion.Controls.Add(this.tabPage1);
            this.lbl_IdHabitacion.Controls.Add(this.tabPage2);
            this.lbl_IdHabitacion.Controls.Add(this.tabPage3);
            this.lbl_IdHabitacion.Controls.Add(this.tabPage4);
            this.lbl_IdHabitacion.Controls.Add(this.tabPage5);
            this.lbl_IdHabitacion.Controls.Add(this.tabPage6);
            this.lbl_IdHabitacion.Controls.Add(this.tabPage7);
            this.lbl_IdHabitacion.Depth = 0;
            this.lbl_IdHabitacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_IdHabitacion.Location = new System.Drawing.Point(3, 64);
            this.lbl_IdHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_IdHabitacion.Multiline = true;
            this.lbl_IdHabitacion.Name = "lbl_IdHabitacion";
            this.lbl_IdHabitacion.SelectedIndex = 0;
            this.lbl_IdHabitacion.Size = new System.Drawing.Size(772, 523);
            this.lbl_IdHabitacion.TabIndex = 1;
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
            this.panel1.Location = new System.Drawing.Point(575, 17);
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
            this.dtHoteles.Location = new System.Drawing.Point(52, 251);
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
            this.lblID.Location = new System.Drawing.Point(124, 19);
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
            this.SliderStars.Location = new System.Drawing.Point(319, 165);
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
            this.txtxPais.Location = new System.Drawing.Point(319, 83);
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
            this.txtCiudad.Location = new System.Drawing.Point(319, 14);
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
            this.txtDireccion.Location = new System.Drawing.Point(43, 157);
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
            this.txtNombre.Location = new System.Drawing.Point(43, 83);
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
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Habitación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(764, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reserva";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(764, 497);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cliente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(764, 497);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pago";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(764, 497);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Factura";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(764, 497);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Empleado";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(232, 415);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(250, 31);
            this.lblMsj.TabIndex = 11;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblMsjHabitacion);
            this.materialCard2.Controls.Add(this.dtHabitaciones);
            this.materialCard2.Controls.Add(this.panel2);
            this.materialCard2.Controls.Add(this.cbNumHotel);
            this.materialCard2.Controls.Add(this.txtPrecio);
            this.materialCard2.Controls.Add(this.cbTipoHabitacion);
            this.materialCard2.Controls.Add(this.cbCapacidadHabitacion);
            this.materialCard2.Controls.Add(this.cbNumeroHabitacion);
            this.materialCard2.Controls.Add(this.lblIDhABITACION);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(758, 491);
            this.materialCard2.TabIndex = 0;
            // 
            // lblIDhABITACION
            // 
            this.lblIDhABITACION.AutoSize = true;
            this.lblIDhABITACION.Depth = 0;
            this.lblIDhABITACION.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIDhABITACION.Location = new System.Drawing.Point(119, 23);
            this.lblIDhABITACION.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIDhABITACION.Name = "lblIDhABITACION";
            this.lblIDhABITACION.Size = new System.Drawing.Size(1, 0);
            this.lblIDhABITACION.TabIndex = 0;
            // 
            // cbNumeroHabitacion
            // 
            this.cbNumeroHabitacion.AutoResize = false;
            this.cbNumeroHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNumeroHabitacion.Depth = 0;
            this.cbNumeroHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNumeroHabitacion.DropDownHeight = 174;
            this.cbNumeroHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroHabitacion.DropDownWidth = 121;
            this.cbNumeroHabitacion.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNumeroHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNumeroHabitacion.FormattingEnabled = true;
            this.cbNumeroHabitacion.Hint = "Número";
            this.cbNumeroHabitacion.IntegralHeight = false;
            this.cbNumeroHabitacion.ItemHeight = 43;
            this.cbNumeroHabitacion.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900"});
            this.cbNumeroHabitacion.Location = new System.Drawing.Point(53, 54);
            this.cbNumeroHabitacion.MaxDropDownItems = 4;
            this.cbNumeroHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNumeroHabitacion.Name = "cbNumeroHabitacion";
            this.cbNumeroHabitacion.Size = new System.Drawing.Size(121, 49);
            this.cbNumeroHabitacion.StartIndex = 0;
            this.cbNumeroHabitacion.TabIndex = 1;
            // 
            // cbCapacidadHabitacion
            // 
            this.cbCapacidadHabitacion.AutoResize = false;
            this.cbCapacidadHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCapacidadHabitacion.Depth = 0;
            this.cbCapacidadHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCapacidadHabitacion.DropDownHeight = 174;
            this.cbCapacidadHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapacidadHabitacion.DropDownWidth = 121;
            this.cbCapacidadHabitacion.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCapacidadHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCapacidadHabitacion.FormattingEnabled = true;
            this.cbCapacidadHabitacion.Hint = "Capacidad";
            this.cbCapacidadHabitacion.IntegralHeight = false;
            this.cbCapacidadHabitacion.ItemHeight = 43;
            this.cbCapacidadHabitacion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbCapacidadHabitacion.Location = new System.Drawing.Point(53, 138);
            this.cbCapacidadHabitacion.MaxDropDownItems = 4;
            this.cbCapacidadHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCapacidadHabitacion.Name = "cbCapacidadHabitacion";
            this.cbCapacidadHabitacion.Size = new System.Drawing.Size(121, 49);
            this.cbCapacidadHabitacion.StartIndex = 0;
            this.cbCapacidadHabitacion.TabIndex = 2;
            // 
            // cbTipoHabitacion
            // 
            this.cbTipoHabitacion.AutoResize = false;
            this.cbTipoHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoHabitacion.Depth = 0;
            this.cbTipoHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoHabitacion.DropDownHeight = 174;
            this.cbTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoHabitacion.DropDownWidth = 121;
            this.cbTipoHabitacion.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoHabitacion.FormattingEnabled = true;
            this.cbTipoHabitacion.Hint = "Tipo";
            this.cbTipoHabitacion.IntegralHeight = false;
            this.cbTipoHabitacion.ItemHeight = 43;
            this.cbTipoHabitacion.Items.AddRange(new object[] {
            "Sencilla",
            "Doble",
            "Matrimoniales",
            "Suite",
            "Junior Suite",
            "Presidencial"});
            this.cbTipoHabitacion.Location = new System.Drawing.Point(251, 54);
            this.cbTipoHabitacion.MaxDropDownItems = 4;
            this.cbTipoHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoHabitacion.Name = "cbTipoHabitacion";
            this.cbTipoHabitacion.Size = new System.Drawing.Size(121, 49);
            this.cbTipoHabitacion.StartIndex = 0;
            this.cbTipoHabitacion.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.Hint = "₡";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(251, 139);
            this.txtPrecio.MaxLength = 50;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 50);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "";
            this.txtPrecio.TrailingIcon = null;
            // 
            // cbNumHotel
            // 
            this.cbNumHotel.AutoResize = false;
            this.cbNumHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNumHotel.Depth = 0;
            this.cbNumHotel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNumHotel.DropDownHeight = 174;
            this.cbNumHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumHotel.DropDownWidth = 121;
            this.cbNumHotel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNumHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNumHotel.FormattingEnabled = true;
            this.cbNumHotel.Hint = "N° Hotel";
            this.cbNumHotel.IntegralHeight = false;
            this.cbNumHotel.ItemHeight = 43;
            this.cbNumHotel.Items.AddRange(new object[] {
            "1"});
            this.cbNumHotel.Location = new System.Drawing.Point(423, 87);
            this.cbNumHotel.MaxDropDownItems = 4;
            this.cbNumHotel.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNumHotel.Name = "cbNumHotel";
            this.cbNumHotel.Size = new System.Drawing.Size(121, 49);
            this.cbNumHotel.StartIndex = 0;
            this.cbNumHotel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnAgregarHabitacion);
            this.panel2.Location = new System.Drawing.Point(565, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 197);
            this.panel2.TabIndex = 6;
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.AutoSize = false;
            this.btnAgregarHabitacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarHabitacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarHabitacion.Depth = 0;
            this.btnAgregarHabitacion.HighEmphasis = true;
            this.btnAgregarHabitacion.Icon = null;
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(19, 9);
            this.btnAgregarHabitacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(99, 36);
            this.btnAgregarHabitacion.TabIndex = 0;
            this.btnAgregarHabitacion.Text = "Agregar";
            this.btnAgregarHabitacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarHabitacion.UseAccentColor = false;
            this.btnAgregarHabitacion.UseVisualStyleBackColor = true;
            this.btnAgregarHabitacion.Click += new System.EventHandler(this.btnAgregarHabitacion_Click);
            // 
            // dtHabitaciones
            // 
            this.dtHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dtHabitaciones.Location = new System.Drawing.Point(55, 236);
            this.dtHabitaciones.Name = "dtHabitaciones";
            this.dtHabitaciones.Size = new System.Drawing.Size(649, 150);
            this.dtHabitaciones.TabIndex = 7;
            // 
            // lblMsjHabitacion
            // 
            this.lblMsjHabitacion.Location = new System.Drawing.Point(296, 401);
            this.lblMsjHabitacion.Name = "lblMsjHabitacion";
            this.lblMsjHabitacion.Size = new System.Drawing.Size(122, 35);
            this.lblMsjHabitacion.TabIndex = 8;
            this.lblMsjHabitacion.Text = "...";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Id";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Número";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tipo";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Capacidad";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Precio";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "N° Hotel";
            this.Column12.Name = "Column12";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 590);
            this.Controls.Add(this.lbl_IdHabitacion);
            this.DrawerTabControl = this.lbl_IdHabitacion;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.lbl_IdHabitacion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHoteles)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHabitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl lbl_IdHabitacion;
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
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblIDhABITACION;
        private MaterialSkin.Controls.MaterialComboBox cbNumHotel;
        private MaterialSkin.Controls.MaterialTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialComboBox cbTipoHabitacion;
        private MaterialSkin.Controls.MaterialComboBox cbCapacidadHabitacion;
        private MaterialSkin.Controls.MaterialComboBox cbNumeroHabitacion;
        private System.Windows.Forms.DataGridView dtHabitaciones;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnAgregarHabitacion;
        private System.Windows.Forms.Label lblMsjHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}