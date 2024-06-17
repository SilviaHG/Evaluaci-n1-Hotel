using Evaluación1_Hotel.Clases;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación1_Hotel.Forms
{
    public partial class Principal : MaterialForm
    {
        // para los tabpages
        private Dictionary<Form, TabPage> lastOpenedTabs = new Dictionary<Form, TabPage>();


        //creamos las instancias
        ClassHotel Hotel = new ClassHotel(2, "Hotel Largarta", "Nosara", "Guanacaste", "Costa Rica", 4);
        ClassHotel Hotel1 = new ClassHotel(1, "Hotel Las Amapolas", "Liberia", "Guanacaste", "Costa Rica", 3);
        ClassHabitacion classHbitacion;

        //ClassHabitacion habitacion = new ClassHabitacion();
        ClassReservacion reservacion = new ClassReservacion();
        ClassCliente ClaseClientes = new ClassCliente();
        ClassPago Pago = new ClassPago();
        ClassFactura Factura = new ClassFactura();
        ClassEmpleado Em = new ClassEmpleado();
        //creamos una las listas
        List<ClassHotel> hoteles = new List<ClassHotel>();
        List<ClassHabitacion> habitaciones = new List<ClassHabitacion>();
        List<ClassReservacion> Reservaciones = new List<ClassReservacion>();
        List<ClassCliente> CClientes = new List<ClassCliente>();
        List<ClassPago> Pagos = new List<ClassPago>();
        List<ClassFactura> Facturas = new List<ClassFactura>();
        List<ClassEmpleado> Empleados = new List<ClassEmpleado>();
        int contHotel = 3;
        int contHabitacion = 1;
        int contReservacion = 1;
        int contPagos = 1;
        int contFacturas = 1;

        public Principal()
        {
            InitializeComponent();

            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);

            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(
                Primary.Red800, Primary.Red900,
                Primary.Red800, Accent.Red700, TextShade.WHITE
            );
            //txtMontoPago.TextChanged += (t,y) => MessageBox.Show("Hola");
        }

        /// <summary>
        /// agregar los hoteles a la lista
        /// </summary>
        public void agregarHotelList()
        {
            //agrergamos los hoteles a la lista
            ClassHotel guardarHotel = new ClassHotel(
                 contHotel, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, txtxPais.Text, SliderStars.Value

                 );
            hoteles.Add(guardarHotel);
        }
        public void agregarHabitacion()
        {
            //agreagmos una habitacion

            ClassHabitacion guardarHabitacion = new ClassHabitacion(
                contHabitacion,
               cbNumeroHabitacion.SelectedItem.ToString(),
               cbTipoHabitacion.SelectedItem.ToString(),
                Convert.ToInt32(cbCapacidadHabitacion.SelectedItem),
                Convert.ToDouble(txtPrecio.Text),
               Convert.ToInt32(cbNumHotel.SelectedItem)
                );
            habitaciones.Add(guardarHabitacion);

            //
            Hotel.HabitacionesList = habitaciones;
        }
        /// <summary>
        /// creamos habitacions de forma predeterminados
        /// </summary>
        public void agregarHabitacionList()
        {
            Random rnd = new Random(); //numeros random
            habitaciones.Clear(); //limpiamos para que no se dupliquen
            //creamos una habitacion por defecto
            for (int i = 0; i < 4; i++)
            {
                classHbitacion = new ClassHabitacion(
                    contHabitacion,
                     $"H{i}",
                    "Individual",
                    Convert.ToInt32($"{rnd.Next(10)}"),
                    Convert.ToDouble($"{rnd.Next(2500)}"),
                    Convert.ToInt32($"{rnd.Next(2)}")
                    );
                //lo agregamos a la lista de habitaciones
                habitaciones.Add(classHbitacion);
                contHabitacion += 1;
            }
            //
            Hotel.HabitacionesList = habitaciones;

        }
        public void CargarHabitaciones()
        {
            //agregamos las habitaciones a las listas
            agregarHabitacionList();
            //hacemos una funcion de cargar habitaciones al cbBoxDe hotel
            cbNumeroHabitacion.Items.Clear();
            cbNumeroHabitacion.Items.Add(0);
            //agregamos los hoteles al combo box de habitaciones
            for (int i = 0; i < habitaciones.Count; i++)
            {
                // cbHabitacionesHotel.Items.Add(habitaciones[i].Numero);
                cbNumeroHabitacion.Items.Add(habitaciones[i].Numero);

            }

            // limpiamos el combo box para que no se dupliquen
            cbHabitacion.Items.Clear();
            cbHabitacion.Items.Add(0);
            //agregamos los hoteles al combo box de habitaciones
            for (int i = 0; i < habitaciones.Count; i++)
            {
                // cbHabitacionesHotel.Items.Add(habitaciones[i].Numero);
                cbHabitacion.Items.Add(habitaciones[i].Numero);

            }
        }
        public void agregarReservacionList()
        {
            // Obtener la fecha seleccionada
            DateTime Inicio = dateTimeInicio.Value;
            DateTime Fin = dateTimeFin.Value;
            //agregamos una reservacion a la lista
            ClassReservacion guardarReservacion = new ClassReservacion(
                contReservacion,
                cbClientes.SelectedItem.ToString(),
                cbHabitacion.SelectedItem.ToString(),
                Inicio.ToString(),
                Fin.ToString(),
                cbEstado.SelectedItem.ToString()
                );
            Reservaciones.Add(guardarReservacion);
        }
        public void agregarClienteList()
        {
            //agregamos un cliente a la lista
            ClassCliente guardarCliente = new ClassCliente(
                Convert.ToInt32(txtCedula.Text),
                txtNombreCliente.Text,
                txtApellidoC.Text,
                txtEmailC.Text,
                Convert.ToInt32(txtTel.Text),
                txtDireccionC.Text
                );
            CClientes.Add(guardarCliente);
        }

        public void agregarPagoList()
        {
            DateTime fechaPago = dateTimePagos.Value;
            //agregamos los pagos a la lista
            ClassPago guardarPago = new ClassPago(
                contPagos, Convert.ToInt32(cbReservaPagos.SelectedItem),
                Convert.ToInt32(txtMontoPago.Text),
                fechaPago.ToString(), cbMetodosPago.Text
                );

            Pagos.Add(guardarPago);
        }
        public void agregarFacturaList()
        {
            //capturamos la fecha
            DateTime fechaFactura = dateTimeFechaFactura.Value;
            //agregamos la factura a la lista
            ClassFactura guardarFactura = new ClassFactura(
                contFacturas, Convert.ToInt32(cbReservacionFactura.SelectedItem),
                Convert.ToInt32(cbClienteFacturacion.SelectedItem), Convert.ToInt32(cbEmpleadoFacturacion.SelectedItem),
                Convert.ToInt32(txtMontoFacturacion.Text),
                fechaFactura.ToString()
                );
            Facturas.Add(guardarFactura);
        }
        public void agregarEmpleado()
        {
            ClassEmpleado guardarEmpleado = new ClassEmpleado(
                Convert.ToInt32(txtCedEmpleado.Text),
                txtNombreEmpleado.Text,
                txtApellidoEmpleado.Text,
                cbPosicion.SelectedItem.ToString(),
                txtEmailEmpleado.Text,
                Convert.ToInt32(txtTelEmpleado.Text)
                );
            Empleados.Add(guardarEmpleado);
        }
        /// <summary>
        /// Mostramos los hoteles en el datagrid
        /// </summary>
        public void mostrarHoteles()
        {
            //en el data grid
            dtHoteles.Rows.Clear();
            for (int i = 0; i < hoteles.Count; i++)
            {
                dtHoteles.Rows.Add(hoteles[i].Id, hoteles[i].Nombre, hoteles[i].Direccion, hoteles[i].Ciudad, hoteles[i].Pais, hoteles[i].Estrellas, hoteles[i].HabitacionesList);
            }
        }
        public void mostrarHabitaciones()
        {
            //en el data gried
            dtHabitaciones.Rows.Clear();
            for (int i = 0; i < habitaciones.Count; i++)
            {
                dtHabitaciones.Rows.Add(habitaciones[i].Id, habitaciones[i].Numero, habitaciones[i].Tipo, habitaciones[i].Capacidad, habitaciones[i].PrecioPoNoche, habitaciones[i].HotelId);
            }
        }
        public void mostrarReservaciones()
        {
            //en el data gried
            dtRersevacion.Rows.Clear();
            for (int i = 0; i < Reservaciones.Count; i++)
            {
                dtRersevacion.Rows.Add(Reservaciones[i].ReservaId, Reservaciones[i].ClienteId, Reservaciones[i].Habitacion, Reservaciones[i].Estado, Reservaciones[i].FInicio, Reservaciones[i].FFin);
            }
        }
        public void mostrarClientes()
        {
            //en el datagrid
            dtC.Rows.Clear();

            for (int i = 0; i < CClientes.Count; i++)
            {
                dtC.Rows.Add(CClientes[i].Cedula, CClientes[i].C_Nombre, CClientes[i].C_Apellidos, CClientes[i].Email, CClientes[i].Telefono, CClientes[i].Direccion);
            }
        }
        public void mostrarPagos()
        {
            // agregamos al datagridview
            dtPagos.Rows.Clear();
            for (int i = 0; i < Pagos.Count; i++)
            {
                dtPagos.Rows.Add(
                    Pagos[i].PagoId, Pagos[i].Reservacion_Pagos,
                    Pagos[i].MetodoPago, Pagos[i].MontoPago, Pagos[i].FechaPago
                    );
            }
        }
        public void mostrarFacturas()
        {
            //agregamos al datagried
            dtFactura.Rows.Clear();
            for (int i = 0; i < Facturas.Count; i++)
            {
                dtFactura.Rows.Add(Facturas[i].FacturaId, Facturas[i].ReservaID_Factura, Facturas[i].Cliente_Factura,
                    Facturas[i].Empleado_Factura, Facturas[i].MontoTotal_Factura, Facturas[i].FechaEmision_Factura
                    );
            }
        }
        public void mostrarEmpleados()
        {
            dtEmpleado.Rows.Clear();

            for (int i = 0; i < Empleados.Count; i++)
            {
                dtEmpleado.Rows.Add(Empleados[i].CedulaEmpleado, Empleados[i].NombreEmpleado, Empleados[i].ApellidosEmpleado, Empleados[i].PosicionEmpleado, Empleados[i].EmailEmpleado, Empleados[i].TelefonoEmpleado
                   );
            }
        }
        public void limpiar()
        {
            //hotel
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtxPais.Text = "";
            SliderStars.Value = 0;

            //habitaciones
            cbNumeroHabitacion.SelectedIndex = 0;
            cbTipoHabitacion.SelectedIndex = 0;
            cbCapacidadHabitacion.SelectedIndex = 0;
            cbNumHotel.SelectedIndex = 0;
            txtPrecio.Text = "";

            //reservaciones
            cbClientes.SelectedIndex = 0;
            cbHabitacion.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            dateTimeInicio.Value = DateTime.Now;
            dateTimeFin.Value = DateTime.Now;
            //reservaciones campos de Habitaciones
            txtxTipoHReservacion.Text = "";
            txtCapacidadHReservacion.Text = "";
            txtMontoHRservacion.Text = "";

            //clientes
            txtCedula.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoC.Text = "";
            txtEmailC.Text = "";
            txtTel.Text = "";
            txtDireccionC.Text = "";
            txtCedula.Enabled = true;

            //pagos
            txtMontoPago.Text = "";
            cbReservaPagos.SelectedIndex = 0;
            cbMetodosPago.SelectedIndex = 0;
            dateTimePagos.Value = DateTime.Now;

            //empleados
            txtCedEmpleado.Text = "";
            txtApellidoEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
            txtEmailEmpleado.Text = "";
            txtTelEmpleado.Text = "";
            cbPosicion.SelectedIndex = 0;
            txtCedEmpleado.Enabled = true;

            //facturas
            txtMontoFacturacion.Text = "";
            cbReservacionFactura.SelectedIndex = 0;
            cbClienteFacturacion.SelectedIndex = 0;
            cbEmpleadoFacturacion.SelectedIndex = 0;
            dateTimeFechaFactura.Value = DateTime.Now;

            //refresco los comboBox
            RefreshCombos();
        }
        public void DesactivarBotones()
        {
            //cosas para tabpage
            // para que esconda el boton de regresar
            btnRegresarCliente.Visible = false;
            btnRegresarPago_Reservacion.Visible = false;
            btnRegresarEmpleado_Facturacion.Visible = false;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            //desactiva los botones
            DesactivarBotones();


            //mostrar los hoteles por defecto

            hoteles.Add(Hotel1);
            hoteles.Add(Hotel);
            mostrarHoteles();
            Console.WriteLine(hoteles.Count);
            //cargamos las habitaciones a los combo box
            CargarHabitaciones();
            //mostramos las habitaciones al datagried
            mostrarHabitaciones();

            lblID.Text = contHotel.ToString();
            lblH.Text = contHabitacion.ToString();
            lblNumReservacion.Text = contReservacion.ToString();
            lblNumPago.Text = contPagos.ToString();
            lblNumFactura.Text = contFacturas.ToString();
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
            label6.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label8.ForeColor = Color.Red;
            label9.ForeColor = Color.Red;

            // limpiamos el combo box para que no se dupliquen
            cbNumHotel.Items.Clear();
            cbNumHotel.Items.Add(0);
            //agregamos los hoteles al combo box de habitaciones
            foreach (var h in hoteles)
            {
                cbNumHotel.Items.Add(h.Id);
            }

        }
        private void btnAgregarHotel_Click(object sender, EventArgs e)
        {

            if (Login.camposVacios(new object[] { txtNombre, txtDireccion, txtCiudad, txtxPais }))
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                bool exist = hoteles.Exists(s => s.Nombre == txtNombre.Text);

                if (exist)
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Este hotel ya existe";
                }
                else
                {
                    //agregamos hoteles
                    agregarHotelList();
                    //agregarHabitacionList();
                    // mostrar hoteles al datagried
                    mostrarHoteles();
                    limpiar();
                    contHotel += 1;
                    lblID.Text = contHotel.ToString();

                    // limpiamos el combo box para que no se dupliquen
                    cbNumHotel.Items.Clear();
                    cbNumHotel.Items.Add(0);
                    //agregamos los hoteles al combo box de habitaciones
                    foreach (var h in hoteles)
                    {
                        cbNumHotel.Items.Add(h.Id);
                    }

                }
            }
        }
        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            if (Login.camposVacios(new object[] { txtPrecio }, new object[] { cbNumeroHabitacion, cbTipoHabitacion, cbNumHotel, cbCapacidadHabitacion }))
            {
                lblMsjHabitacion.ForeColor = Color.Red;
                lblMsjHabitacion.Text = "No puede dejar campos vacíos";
            }
            else
            {

                bool exist = habitaciones.Exists(s => s.Id == Convert.ToInt32(lblH.Text));

                if (exist)
                {
                    lblMsjHabitacion.ForeColor = Color.Red;
                    lblMsjHabitacion.Text = "Este ID de habitación ya existe";
                }
                else
                {
                    agregarHabitacion();
                    //CargarHabitaciones();
                    mostrarHabitaciones();
                    limpiar();
                    contHabitacion += 1;
                    lblH.Text = contHabitacion.ToString();
                }
            }

        }
        private void btnAgregarReservacion_Click(object sender, EventArgs e)
        {
            if (Login.camposVacios(new object[] { }, new object[] { cbClientes, cbHabitacion, cbEstado }))
            {
                lblMsjReserevacion.ForeColor = Color.Red;
                lblMsjReserevacion.Text = "No puede dejar campos vacíos";
            }
            else
            {
                bool exist = Reservaciones.Exists(s => s.ReservaId == Convert.ToInt32(lblNumReservacion.Text));

                if (exist)
                {
                    lblMsjReserevacion.ForeColor = Color.Red;
                    lblMsjReserevacion.Text = "Este ID de reservación ya existe";
                }
                else
                {
                    agregarReservacionList();
                    mostrarReservaciones();
                    limpiar();
                    // limpiamos el combo box para que no se dupliquen
                    cbReservaPagos.Items.Clear();
                    cbReservacionFactura.Items.Clear();
                    cbReservacionFactura.Items.Add(0);
                    cbReservaPagos.Items.Add(0); //agregamos el primer indice 0 para que si es 0 no dejd agregar nada
                                                 //agregamos los reservaciones al combo box de pagos
                                                 //agregamos las reservaciones al combo box de facturas
                    foreach (var r in Reservaciones)
                    {
                        cbReservaPagos.Items.Add(r.ReservaId);
                        cbReservacionFactura.Items.Add(r.ReservaId);
                    }
                    //-----------
                    contReservacion += 1;
                    lblNumReservacion.Text = contReservacion.ToString();
                }

            }
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string cedulaCliente = txtCedula.Text;

            if (Login.camposVacios(new object[] { txtCedula, txtNombreCliente, txtApellidoC, txtEmailC, txtTel, txtDireccionC }))
            {
                lblMsjCliente.ForeColor = Color.Red;
                lblMsjCliente.Text = "No puede dejar campos vacíos";
            }
            else
            {
                bool existeClient = CClientes.Exists(cliente => cliente.Cedula == Convert.ToInt32(cedulaCliente));
                if (existeClient)
                {
                    lblMsjCliente.ForeColor = Color.Red;
                    lblMsjCliente.Text = "Este cliente ya existe en la BD";
                }
                else
                {
                    agregarClienteList();
                    mostrarClientes();
                    limpiar();

                    // limpiamos el combo box para que no se dupliquen
                    cbClienteFacturacion.Items.Clear();
                    cbClientes.Items.Clear();
                    cbClienteFacturacion.Items.Add(0);
                    cbClientes.Items.Add(0);
                    //agregamos los clientes al combo box de reservacion
                    //agregamos los clientes al combo box de facturacion
                    foreach (var c in CClientes)
                    {
                        cbClientes.Items.Add(c.C_Nombre);
                        cbClienteFacturacion.Items.Add(c.Cedula);
                    }
                }


            }

        }
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string buscaEmpleado = txtCedEmpleado.Text;

            if (Login.camposVacios(new object[] { txtCedEmpleado, txtNombreEmpleado, txtApellidoEmpleado, txtEmailEmpleado, txtTelEmpleado }, new object[] { cbPosicion }))
            {
                lblMsjEmpleado.ForeColor = Color.Red;
                lblMsjEmpleado.Text = "No puede dejar campos vacíos";
            }
            else
            {
                bool existeEmpleado = Empleados.Exists(emple => emple.CedulaEmpleado == Convert.ToInt32(buscaEmpleado));

                if (existeEmpleado)
                {
                    lblMsjEmpleado.ForeColor = Color.Red;
                    lblMsjEmpleado.Text = "Este empleado ya existe en la BD";
                }
                else
                {
                    agregarEmpleado();
                    mostrarEmpleados();
                    limpiar();

                    // limpiamos el combo box para que no se dupliquen
                    cbEmpleadoFacturacion.Items.Clear();
                    cbEmpleadoFacturacion.Items.Add(0);
                    //agregamos los empleados al combo box de facturacion
                    foreach (var empleado in Empleados)
                    {
                        cbEmpleadoFacturacion.Items.Add(empleado.CedulaEmpleado);
                    }
                }
            }
        }
        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (Login.camposVacios(new object[] { txtMontoPago }, new object[] { cbReservaPagos, cbMetodosPago }))
            {
                lblMsjPago.ForeColor = Color.Red;
                lblMsjPago.Text = "No puede dejar campos vacíos";
            }
            else
            {
                bool exist = Pagos.Exists(s => s.PagoId == Convert.ToInt32(lblNumPago.Text));

                if (exist)
                {
                    lblMsjPago.ForeColor = Color.Red;
                    lblMsjPago.Text = "Este ID de pago ya existe";
                }
                else
                {
                    agregarPagoList();
                    mostrarPagos();
                    limpiar();
                    contPagos += 1;
                    lblNumPago.Text = contPagos.ToString();
                }
            }
        }
        private void btnAgregarFactura_Click(object sender, EventArgs e)
        {
            if (Login.camposVacios(new object[] { txtMontoFacturacion }, new object[] { cbReservacionFactura, cbClienteFacturacion, cbEmpleadoFacturacion }))
            {
                lblMsjFactura.ForeColor = Color.Red;
                lblMsjFactura.Text = "No puede dejar campos vacíos";
            }
            else
            {
                bool exist = Facturas.Exists(s => s.FacturaId == Convert.ToInt32(lblNumFactura.Text));

                if (exist)
                {
                    lblMsjFactura.ForeColor = Color.Red;
                    lblMsjFactura.Text = "Este ID de factura ya existe";
                }
                else
                {

                    agregarFacturaList();
                    mostrarFacturas();
                    limpiar();
                    contFacturas += 1;
                    lblNumFactura.Text = contFacturas.ToString();
                }
            }
        }
        /// <summary>
        /// Funcion que muestra los datos de capacidad,tipo y monto de la habitacion cuando
        /// se selecciona una habitacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pos = cbHabitacion.SelectedItem.ToString();
            string p = cbHabitacion.SelectedIndex.ToString();

            foreach (var h in habitaciones)
            {
                if (h.Numero.ToString() == pos)
                {
                    txtCapacidadHReservacion.Text = h.Capacidad.ToString();
                    txtxTipoHReservacion.Text = h.Tipo.ToString();
                    txtMontoHRservacion.Text = h.PrecioPoNoche.ToString();
                }
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {

            if (txtPrecio.Text.Length >= 0)
            {
                int numero = 0;
                bool esNumero = int.TryParse(txtPrecio.Text, out numero);

                if (esNumero && Convert.ToInt32(txtPrecio.Text) > 0)
                {
                    // si es numero y mayor que 0
                    lblMsj.Text = "...";
                    txtPrecio.Hint = "₡";
                    btnAgregarHabitacion.Enabled = true;
                }
                else
                {
                    txtPrecio.Hint = "Debe ser número positivo";
                    lblMsjHabitacion.ForeColor = Color.Red;
                    lblMsjHabitacion.Text = $"En la casilla 'Monto' debe de ingresar solo números positivos";
                    //txtPrecio.SelectAll();
                    // txtPrecio.Focus();
                    txtPrecio.BackColor = Color.Red;
                    btnAgregarHabitacion.Enabled = false;
                }
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length >= 0)
            {
                int numero = 0;
                bool esNumero = int.TryParse(txtCedula.Text, out numero);

                if (esNumero && Convert.ToInt32(txtCedula.Text) > 0)
                {
                    lblMsjCliente.Text = "...";
                    txtCedula.Hint = "Cédula";
                    btnAgregarCliente.Enabled = true;
                }
                else
                {
                    txtCedula.Hint = "Debe ser número positivo";
                    lblMsjCliente.ForeColor = Color.Red;
                    lblMsjCliente.Text = $"En la casilla 'Cédula' debe de ingresar solo números positivos";
                    btnAgregarCliente.Enabled = false;
                    //txtPrecio.SelectAll();
                    // txtMontoHRservacion.Focus();
                    // txtMontoHRservacion.BackColor = Color.Red;
                }
            }
        }

        private void txtMontoPago_Leave(object sender, EventArgs e)
        {
            if (txtMontoPago.Text.Length >= 0)
            {
                int numero = 0;
                bool num = int.TryParse(txtMontoPago.Text, out numero);

                if (num && Convert.ToInt32(txtMontoPago.Text) > 0)
                {
                    lblMsjPago.Text = "...";
                    txtMontoPago.Hint = "₡";
                    btnAgregarPago.Enabled = true;
                }
                else
                {
                    txtMontoPago.Hint = "Debe ser número positivos";
                    lblMsjPago.ForeColor = Color.Red;
                    lblMsjPago.Text = $"En la casilla 'Monto' debe de ingresar solo números positivos";
                    btnAgregarPago.Enabled = false;
                    //txtPrecio.SelectAll();
                    // txtMontoHRservacion.Focus();
                    // txtMontoHRservacion.BackColor = Color.Red;
                }
            }
        }

        private void txtMontoFacturacion_Leave(object sender, EventArgs e)
        {
            if (txtMontoFacturacion.Text.Length >= 0)
            {
                int numero = 0;
                bool num = int.TryParse(txtMontoFacturacion.Text, out numero);

                if (num && Convert.ToInt32(txtMontoFacturacion.Text) > 0)
                {
                    lblMsjFactura.Text = "...";
                    txtMontoFacturacion.Hint = "₡";
                    btnAgregarFactura.Enabled = true;
                }
                else
                {
                    txtMontoFacturacion.Hint = "Debe ser número positivo";
                    lblMsjFactura.ForeColor = Color.Red;
                    lblMsjFactura.Text = $"En la casilla 'Monto' debe de ingresar solo números";
                    btnAgregarFactura.Enabled = false;
                    //txtPrecio.SelectAll();
                    // txtMontoHRservacion.Focus();
                    // txtMontoHRservacion.BackColor = Color.Red;
                }
            }
        }
        private void txtCedEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtCedEmpleado.Text.Length >= 0)
            {
                int numero = 0;
                bool num = int.TryParse(txtCedEmpleado.Text, out numero);

                if (num && Convert.ToInt32(txtCedEmpleado.Text) > 0)
                {
                    lblMsjEmpleado.Text = "...";
                    txtCedEmpleado.Hint = "Cédula";
                    btnAgregarEmpleado.Enabled = true;
                }
                else
                {
                    txtCedEmpleado.Hint = "Debe ser número positivos";
                    lblMsjEmpleado.ForeColor = Color.Red;
                    lblMsjEmpleado.Text = $"En la casilla 'Cédula' debe de ingresar solo números positivos";
                    btnAgregarEmpleado.Enabled = false;
                    //txtPrecio.SelectAll();
                    // txtMontoHRservacion.Focus();
                    // txtMontoHRservacion.BackColor = Color.Red;
                }
            }
        }

        private void txtTelEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtTelEmpleado.Text.Length >= 0)
            {
                int numero = 0;
                bool num = int.TryParse(txtTelEmpleado.Text, out numero);

                if (num && Convert.ToInt32(txtTelEmpleado.Text) > 0)
                {
                    lblMsjEmpleado.Text = "...";
                    txtTelEmpleado.Hint = "Teléfono";
                    btnAgregarEmpleado.Enabled = true;
                }
                else
                {
                    txtTelEmpleado.Hint = "Debe ser número positivo";
                    lblMsjEmpleado.ForeColor = Color.Red;
                    lblMsjEmpleado.Text = $"En la casilla 'Teléfono' debe de ingresar solo números positivos";
                    btnAgregarEmpleado.Enabled = false;
                    //txtPrecio.SelectAll();
                    // txtMontoHRservacion.Focus();
                    // txtMontoHRservacion.BackColor = Color.Red;
                }
            }
        }




        //eventos para tabpage
        private TabPage lastOpenedTabPage;
        public int numPage = 0;

        // Llama a este método para abrir un TabPage y recordar el último abierto
        private void OpenTabPageAndRememberLast(TabPage tabPage)
        {
            // Abrir el nuevo TabPage
            tabControl.SelectedTab = tabPage;
        }


        private void btnAgregarCliente_Reservacion_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage4;
            btnRegresarCliente.Visible = true;
            numPage = 3;
            // desactivo el menu hamburguesa para que no se vea

        }

        private void btnRegresarCliente_Click(object sender, EventArgs e)
        {
            btnRegresarCliente.Visible = false;
            // Si estamos actualmente en tabPage4
            if (numPage == 6)
            { //regresa a factura
                OpenTabPageAndRememberLast(tabPage6);

            }
            else if (numPage == 3)
            {
                //regresa a reservacion
                OpenTabPageAndRememberLast(tabPage3);

            }
        }

        private void btnAgregarPago_Reservacion_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage3;
            btnRegresarPago_Reservacion.Visible = true;
            numPage = 5;
        }

        private void btnRegresarPago_Reservacion_Click(object sender, EventArgs e)
        {
            if (numPage == 3)
            {   // regresa a facturacion
                OpenTabPageAndRememberLast(tabPage6);

            }
            else if (numPage == 5)
            {
                //regresa a pago
                OpenTabPageAndRememberLast(tabPage5);// abre tabPage4 y lo registra como el último abierto.

                btnRegresarPago_Reservacion.Visible = false;

            }
        }

        private void btnRegresarEmpleado_Facturacion_Click(object sender, EventArgs e)
        {
            btnRegresarEmpleado_Facturacion.Visible = false;
            // Abre el último TabPage 
            OpenTabPageAndRememberLast(tabPage6); // abre tabPage4 y lo registra como el último abierto.

        }
        private void btnAgregarEmpleado_Facturacion_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage7;
            btnRegresarEmpleado_Facturacion.Visible = true;
        }

        private void btnAgregarCliente_Facturacion_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage4;
            btnRegresarCliente.Visible = true;
            numPage = 6;
        }

        private void btnAgregarReservacion_Facturacion_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage3;
            btnRegresarPago_Reservacion.Visible = true;
            numPage = 3;
        }

        /// <summary>
        /// eventos para cuando se haga click a la tabla
        /// que se muestren los datos en los txt o los comboBox
        /// </summary>

        string nombreHotelEliminar = "";
        string numHabitacionEliminar = "";
        string numReservacionEliminar = "";
        string numClienteEliminar = "";
        string numPagosEliminar = "";
        string numFacturaEliminar = "";
        string numEmpleadoEliminar = "";

        private void dtHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            Console.WriteLine(dtHoteles.Rows.Count);
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtHoteles.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar
            lblID.Text = fila.Cells[0].Value.ToString();
            nombreHotelEliminar = fila.Cells[1].Value.ToString();
            txtNombre.Text = nombreHotelEliminar;
            txtDireccion.Text = fila.Cells[2].Value.ToString();
            txtCiudad.Text = fila.Cells[3].Value.ToString();
            txtxPais.Text = fila.Cells[4].Value.ToString();
            SliderStars.Value = int.Parse(fila.Cells[5].Value.ToString());


            Console.WriteLine(nombreHotelEliminar);

        }

        private void dtHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dtHabitaciones.Rows.Count);
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtHabitaciones.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar
            lblH.Text = fila.Cells[0].Value.ToString();
            numHabitacionEliminar = fila.Cells[0].Value.ToString();
            cbNumeroHabitacion.SelectedItem = fila.Cells[1].Value.ToString();
            cbTipoHabitacion.SelectedItem = fila.Cells[2].Value.ToString();
            cbCapacidadHabitacion.SelectedItem = fila.Cells[3].Value.ToString();
            txtPrecio.Text = fila.Cells[4].Value.ToString();
            cbNumHotel.SelectedItem = fila.Cells[5].Value.ToString();
            RefreshCombos();
        }

        private void dtRersevacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dtRersevacion.Rows.Count);
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtRersevacion.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar
            lblNumReservacion.Text = fila.Cells[0].Value.ToString();
            numReservacionEliminar = fila.Cells[0].Value.ToString();
            cbClientes.SelectedItem = fila.Cells[1].Value.ToString();
            cbHabitacion.SelectedItem = fila.Cells[2].Value.ToString();
            cbEstado.SelectedItem = fila.Cells[3].Value.ToString();
            // Convertir el valor de la celda a DateTime usando TryParse y asignarlo al DateTimePicker


            dateTimeInicio.Value = DateTime.Parse(fila.Cells[4].Value.ToString());
            dateTimeFin.Value = DateTime.Parse(fila.Cells[5].Value.ToString());

            cbHabitacion_SelectedIndexChanged(sender, e);
            RefreshCombos();

        }

        private void dtC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Enabled = false;
            txtCedula.Hint = "Cédula";
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtC.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar
            numClienteEliminar = fila.Cells[0].Value.ToString();
            txtCedula.Text = numClienteEliminar;
            txtNombreCliente.Text = fila.Cells[1].Value.ToString();
            txtApellidoC.Text = fila.Cells[2].Value.ToString();
            txtEmailC.Text = fila.Cells[3].Value.ToString();
            txtTel.Text = fila.Cells[4].Value.ToString();
            txtDireccionC.Text = fila.Cells[5].Value.ToString();


            Console.WriteLine(numClienteEliminar);
        }

        private void dtPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dtPagos.Rows.Count);
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtPagos.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar
            lblNumPago.Text = fila.Cells[0].Value.ToString();
            numPagosEliminar = fila.Cells[0].Value.ToString();
            cbReservaPagos.SelectedItem = fila.Cells[1].Value.ToString();
            cbMetodosPago.SelectedItem = fila.Cells[2].Value.ToString();
            txtMontoPago.Text = fila.Cells[3].Value.ToString();
            dateTimePagos.Value = DateTime.Parse(fila.Cells[4].Value.ToString());
            RefreshCombos();
        }

        private void dtFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dtFactura.Rows.Count);
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtFactura.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar


            lblNumFactura.Text = fila.Cells[0].Value.ToString();
            numFacturaEliminar = fila.Cells[0].Value.ToString();
            cbReservacionFactura.SelectedItem = fila.Cells[1].Value.ToString();
            cbClienteFacturacion.SelectedItem = fila.Cells[2].Value.ToString();
            cbEmpleadoFacturacion.SelectedItem = fila.Cells[3].Value.ToString();
            txtMontoFacturacion.Text = fila.Cells[4].Value.ToString();
            dateTimeFechaFactura.Value = DateTime.Parse(fila.Cells[5].Value.ToString());
            RefreshCombos();
        }

        private void dtEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedEmpleado.Enabled = false;
            txtCedEmpleado.Hint = "Cédula";
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtEmpleado.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar
            numEmpleadoEliminar = fila.Cells[0].Value.ToString();
            txtCedEmpleado.Text = numEmpleadoEliminar;
            txtNombreEmpleado.Text = fila.Cells[1].Value.ToString();
            txtApellidoEmpleado.Text = fila.Cells[2].Value.ToString();
            cbPosicion.SelectedItem = fila.Cells[3].Value.ToString();
            txtEmailEmpleado.Text = fila.Cells[4].Value.ToString();
            txtTelEmpleado.Text = fila.Cells[5].Value.ToString();
            RefreshCombos();


            Console.WriteLine(numEmpleadoEliminar);
        }
        /// <summary>
        /// Funcion para refrescar los comboBox cada vez que hago cambios,
        /// agrego un dato, o selecciono en la tabla
        /// </summary>
        public void RefreshCombos()
        {

            cbNumeroHabitacion.Refresh();
            cbCapacidadHabitacion.Refresh();
            cbNumHotel.Refresh();
            cbTipoHabitacion.Refresh();
            cbClientes.Refresh();
            cbHabitacion.Refresh();
            cbEstado.Refresh();
            cbReservaPagos.Refresh();
            cbMetodosPago.Refresh();
            cbReservacionFactura.Refresh();
            cbClienteFacturacion.Refresh();
            cbEmpleadoFacturacion.Refresh();
            cbPosicion.Refresh();
        }
        /// <summary>
        /// Empiezan los eventos de eliminar
        /// </summary>

        private void btnEliminar_Click(object sender, EventArgs e)
        { //elimina el hotel
            int cantFilaSeleccionada = dtHoteles.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(nombreHotelEliminar))
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = hoteles.Exists(s => s.Nombre == txtNombre.Text);
                    string name = txtNombre.Text;
                    if (exist)
                    {
                        DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar el hotel {nombreHotelEliminar}?",
                              "Advertencia", MessageBoxButtons.YesNo);
                        switch (opcionUsuario)
                        {
                            case DialogResult.Yes:

                                // Encuentra el hotel que coincide con el nombre
                                ClassHotel hotelAEliminar = hoteles.Find(s => s.Nombre == txtNombre.Text);

                                // Remueve el hotel de la lista
                                hoteles.Remove(hotelAEliminar);
                                MessageBox.Show($"El hotel {txtNombre.Text} fue eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                mostrarHoteles();

                                if (contHotel > 1)
                                {
                                    contHotel -= 1;

                                    lblID.Text = contHotel.ToString();
                                }

                                break;
                            case DialogResult.No:
                                lblMsj.ForeColor = Color.Red;
                                lblMsj.Text = "No se ha eliminado ningún Hotel";
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"El hotel {txtNombre.Text} no existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }

        }

        private void btnEliminarHabitacion_Click(object sender, EventArgs e)
        {
            int cantFilaSeleccionada = dtHabitaciones.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjHabitacion.ForeColor = Color.Red;
                lblMsjHabitacion.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numHabitacionEliminar))
                {
                    lblMsjHabitacion.ForeColor = Color.Red;
                    lblMsjHabitacion.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = habitaciones.Exists(s => s.Id == Convert.ToInt32(numHabitacionEliminar));
                    string name = lblH.Text;
                    if (exist)
                    {
                        DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar la habitación # {numHabitacionEliminar}?",
                              "Advertencia", MessageBoxButtons.YesNo);
                        switch (opcionUsuario)
                        {
                            case DialogResult.Yes:

                                // Encuentra el hotel que coincide con el nombre
                                ClassHabitacion habitacionAEliminar = habitaciones.Find(s => s.Id == Convert.ToInt32(numHabitacionEliminar));

                                // Remueve el hotel de la lista
                                habitaciones.Remove(habitacionAEliminar);
                                MessageBox.Show($"La habitación #{numHabitacionEliminar} fue eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                mostrarHabitaciones();

                                if (contHabitacion > 1)
                                {
                                    contHabitacion -= 1;

                                    lblH.Text = contHabitacion.ToString();
                                }

                                break;
                            case DialogResult.No:
                                lblMsjHabitacion.ForeColor = Color.Red;
                                lblMsjHabitacion.Text = "No se ha eliminado ninguna habitación";
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"La habitación #{numHabitacionEliminar} no existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }

        private void btnEliminarReservacion_Click(object sender, EventArgs e)
        {
            int cantFilaSeleccionada = dtRersevacion.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjReserevacion.ForeColor = Color.Red;
                lblMsjReserevacion.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numReservacionEliminar))
                {
                    lblMsjReserevacion.ForeColor = Color.Red;
                    lblMsjReserevacion.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = Reservaciones.Exists(s => s.ReservaId == Convert.ToInt32(numReservacionEliminar));
                    string name = lblH.Text;
                    if (exist)
                    {
                        DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar la reservación #{numReservacionEliminar}?",
                              "Advertencia", MessageBoxButtons.YesNo);
                        switch (opcionUsuario)
                        {
                            case DialogResult.Yes:

                                // Encuentra el hotel que coincide con el nombre
                                ClassReservacion reservacionAEliminar = Reservaciones.Find(s => s.ReservaId == Convert.ToInt32(numReservacionEliminar));

                                // Remueve el hotel de la lista
                                Reservaciones.Remove(reservacionAEliminar);
                                MessageBox.Show($"La reservación #{numReservacionEliminar} fue eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                mostrarReservaciones();

                                if (contReservacion > 1)
                                {
                                    contReservacion -= 1;

                                    lblNumReservacion.Text = contReservacion.ToString();
                                }

                                break;
                            case DialogResult.No:
                                lblMsjReserevacion.ForeColor = Color.Red;
                                lblMsjReserevacion.Text = "No se ha eliminado ninguna reservación";
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"La reservación #{numReservacionEliminar} no existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int cantFilaSeleccionada = dtC.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjCliente.ForeColor = Color.Red;
                lblMsjCliente.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numClienteEliminar))
                {
                    lblMsjCliente.ForeColor = Color.Red;
                    lblMsjCliente.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = CClientes.Exists(s => s.Cedula == Convert.ToInt32(numClienteEliminar));

                    if (exist)
                    {
                        DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar al cliente con la cédula #{numClienteEliminar}?",
                              "Advertencia", MessageBoxButtons.YesNo);
                        switch (opcionUsuario)
                        {
                            case DialogResult.Yes:

                                // Encuentra el hotel que coincide con el nombre
                                ClassCliente clienteAEliminar = CClientes.Find(s => s.Cedula == Convert.ToInt32(numClienteEliminar));

                                // Remueve el hotel de la lista
                                CClientes.Remove(clienteAEliminar);
                                MessageBox.Show($"El cliente con cédula #{numClienteEliminar} fue eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                mostrarClientes();


                                break;
                            case DialogResult.No:
                                lblMsjCliente.ForeColor = Color.Red;
                                lblMsjCliente.Text = "No se ha eliminado ninguna reservación";
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"El cliente con la cédula #{numClienteEliminar} no existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            int cantFilaSeleccionada = dtPagos.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjPago.ForeColor = Color.Red;
                lblMsjPago.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numPagosEliminar))
                {
                    lblMsjPago.ForeColor = Color.Red;
                    lblMsjPago.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = Pagos.Exists(s => s.PagoId == Convert.ToInt32(numPagosEliminar));

                    if (exist)
                    {
                        DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar el pago #{numPagosEliminar}?",
                              "Advertencia", MessageBoxButtons.YesNo);
                        switch (opcionUsuario)
                        {
                            case DialogResult.Yes:

                                // Encuentra el hotel que coincide con el nombre
                                ClassPago pagoAEliminar = Pagos.Find(s => s.PagoId == Convert.ToInt32(numPagosEliminar));

                                // Remueve el hotel de la lista
                                Pagos.Remove(pagoAEliminar);
                                MessageBox.Show($"El pago #{numPagosEliminar} fue eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                mostrarPagos();


                                if (contPagos > 1)
                                {
                                    contPagos -= 1;

                                    lblNumPago.Text = contPagos.ToString();
                                }


                                break;
                            case DialogResult.No:
                                lblMsjPago.ForeColor = Color.Red;
                                lblMsjPago.Text = "No se ha eliminado ningún pago";
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"El pago con el #{numPagosEliminar} no existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            int cantFilaSeleccionada = dtFactura.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjFactura.ForeColor = Color.Red;
                lblMsjFactura.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numFacturaEliminar))
                {
                    lblMsjFactura.ForeColor = Color.Red;
                    lblMsjFactura.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = Facturas.Exists(s => s.FacturaId == Convert.ToInt32(numFacturaEliminar));

                    if (exist)
                    {
                        DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar la factura #{numFacturaEliminar}?",
                              "Advertencia", MessageBoxButtons.YesNo);
                        switch (opcionUsuario)
                        {
                            case DialogResult.Yes:

                                // Encuentra el hotel que coincide con el nombre
                                ClassFactura facturaAEliminar = Facturas.Find(s => s.FacturaId == Convert.ToInt32(numFacturaEliminar));

                                // Remueve el hotel de la lista
                                Facturas.Remove(facturaAEliminar);
                                MessageBox.Show($"La factura #{numFacturaEliminar} fue eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                mostrarFacturas();


                                if (contFacturas > 1)
                                {
                                    contFacturas -= 1;

                                    lblNumFactura.Text = contFacturas.ToString();
                                }
                                break;
                            case DialogResult.No:
                                lblMsjFactura.ForeColor = Color.Red;
                                lblMsjFactura.Text = "No se ha eliminado ninguna factura";
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"El pago con la factura #{numFacturaEliminar} no existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            int cantFilaSeleccionada = dtEmpleado.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjEmpleado.ForeColor = Color.Red;
                lblMsjEmpleado.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numEmpleadoEliminar))
                {
                    lblMsjEmpleado.ForeColor = Color.Red;
                    lblMsjEmpleado.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = Empleados.Exists(s => s.CedulaEmpleado == Convert.ToInt32(numEmpleadoEliminar));

                    if (exist)
                    {
                        DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar el empleado con la cédula #{numEmpleadoEliminar}?",
                              "Advertencia", MessageBoxButtons.YesNo);
                        switch (opcionUsuario)
                        {
                            case DialogResult.Yes:

                                // Encuentra el hotel que coincide con el nombre
                                ClassEmpleado empleadoAEliminar = Empleados.Find(s => s.CedulaEmpleado == Convert.ToInt32(numEmpleadoEliminar));

                                // Remueve el hotel de la lista
                                Empleados.Remove(empleadoAEliminar);
                                MessageBox.Show($"El empleado con la cédula #{numEmpleadoEliminar} fue eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                mostrarEmpleados();

                                break;
                            case DialogResult.No:
                                lblMsjEmpleado.ForeColor = Color.Red;
                                lblMsjEmpleado.Text = "No se ha eliminado ningún empleado";
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"El empleado con la cédula #{numEmpleadoEliminar} no existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }
        /// <summary>
        /// Se crean los eventos de actualizar
        /// </summary>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //actualiza el hotel
            int cantFilaSeleccionada = dtHoteles.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(nombreHotelEliminar))
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = hoteles.Exists(s => s.Id == Convert.ToInt32(lblID.Text));

                    if (exist)
                    {
                        DialogResult optUser = MessageBox.Show($"Desea actualizar el Hotel {nombreHotelEliminar}?", //mensaje que pregunta
                                           "Advertencia", // el titulo de la ventana
                                             MessageBoxButtons.YesNo); //opciones que van a salir de la ventana

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                // Buscar el hotel en la lista por su ContHotel (o cualquier otra propiedad única)
                                ClassHotel hotelAActualizar = hoteles.FirstOrDefault(h => h.Id == Convert.ToInt32(lblID.Text));

                                if (hotelAActualizar != null)
                                {
                                    // Actualizar las propiedades del hotel con los nuevos valores
                                    hotelAActualizar.Nombre = txtNombre.Text;
                                    hotelAActualizar.Direccion = txtDireccion.Text;
                                    hotelAActualizar.Ciudad = txtCiudad.Text;
                                    hotelAActualizar.Pais = txtxPais.Text;
                                    hotelAActualizar.Estrellas = SliderStars.Value;

                                    lblMsj.ForeColor = Color.Red;
                                    lblMsj.Text = $"Hotel {hotelAActualizar.Nombre} actualizado correctamente.";
                                    limpiar();
                                    lblID.Text = contHotel.ToString();
                                }

                                dtHoteles.Rows.Clear();// limpiamos el data grid
                                mostrarHoteles(); //volvemos a cargar el datagried
                                break;
                            case DialogResult.No:
                                MessageBox.Show("No se actualizó ningún hotel");
                                break;
                        }
                    }
                    else
                    {
                        lblMsj.ForeColor = Color.Red;
                        lblMsj.Text = "No existe este Hotel, o ya fue eliminado";

                    }
                }

            }
        }

        private void btnActualizarHabitacion_Click(object sender, EventArgs e)
        {
            //actualiza el habitacion
            int cantFilaSeleccionada = dtHabitaciones.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjHabitacion.ForeColor = Color.Red;
                lblMsjHabitacion.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numHabitacionEliminar))
                {
                    lblMsjHabitacion.ForeColor = Color.Red;
                    lblMsjHabitacion.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = habitaciones.Exists(s => s.Id == Convert.ToInt32(lblH.Text));

                    if (exist)
                    {
                        DialogResult optUser = MessageBox.Show($"Desea actualizar la habitación #{numHabitacionEliminar}?", //mensaje que pregunta
                        "Advertencia", // el titulo de la ventana
                        MessageBoxButtons.YesNo); //opciones que van a salir de la ventana

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                // Buscar el hotel en la lista por su ContHotel (o cualquier otra propiedad única)
                                ClassHabitacion habitacionAActualizar = habitaciones.FirstOrDefault(s => s.Id == Convert.ToInt32(lblH.Text));

                                if (habitacionAActualizar != null)
                                {
                                    // Actualizar las propiedades de la habitacion con los nuevos valores
                                    habitacionAActualizar.Numero = cbNumeroHabitacion.SelectedItem.ToString();
                                    habitacionAActualizar.Tipo = cbTipoHabitacion.SelectedItem.ToString();
                                    habitacionAActualizar.Capacidad = Convert.ToInt32(cbCapacidadHabitacion.SelectedItem);
                                    habitacionAActualizar.PrecioPoNoche = Convert.ToDouble(txtPrecio.Text);
                                    habitacionAActualizar.HotelId = Convert.ToInt32(cbNumHotel.SelectedItem);

                                    lblMsjHabitacion.ForeColor = Color.Red;
                                    lblMsjHabitacion.Text = $"Hotel {habitacionAActualizar.Id} actualizado correctamente.";
                                    limpiar();
                                    lblH.Text = contHabitacion.ToString();
                                }

                                dtHabitaciones.Rows.Clear();// limpiamos el data grid
                                mostrarHabitaciones(); //volvemos a cargar el datagried
                                break;
                            case DialogResult.No:
                                MessageBox.Show("No se actualizó ninguna habitación");
                                break;
                        }
                    }
                    else
                    {
                        lblH.ForeColor = Color.Red;
                        lblH.Text = "No existe esta habitación, o ya fue eliminada";

                    }
                }

            }
        }

        private void btnActualizarReservacion_Click(object sender, EventArgs e)
        {
            //actualiza reservación
            int cantFilaSeleccionada = dtRersevacion.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjReserevacion.ForeColor = Color.Red;
                lblMsjReserevacion.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numReservacionEliminar))
                {
                    lblMsjReserevacion.ForeColor = Color.Red;
                    lblMsjReserevacion.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = Reservaciones.Exists(s => s.ReservaId == Convert.ToInt32(lblNumReservacion.Text));

                    if (exist)
                    {
                        DialogResult optUser = MessageBox.Show($"Desea actualizar la habitación #{lblNumReservacion.Text}?", //mensaje que pregunta
                        "Advertencia", // el titulo de la ventana
                        MessageBoxButtons.YesNo); //opciones que van a salir de la ventana

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                // Buscar el hotel en la lista por su ContHotel (o cualquier otra propiedad única)
                                ClassReservacion reservacionAActualizar = Reservaciones.FirstOrDefault(s => s.ReservaId == Convert.ToInt32(lblNumReservacion.Text));

                                if (reservacionAActualizar != null)
                                {
                                    // Obtener la fecha seleccionada
                                    DateTime Inicio = dateTimeInicio.Value;
                                    DateTime Fin = dateTimeFin.Value;
                                    //agregamos una reservacion a la lista
                                    reservacionAActualizar.ClienteId = cbClientes.SelectedItem.ToString();
                                    reservacionAActualizar.Habitacion = cbHabitacion.SelectedItem.ToString();
                                    reservacionAActualizar.FInicio = Inicio.ToString();
                                    reservacionAActualizar.FFin = Fin.ToString();
                                    reservacionAActualizar.Estado = cbEstado.SelectedItem.ToString();

                                    lblMsjReserevacion.ForeColor = Color.Red;
                                    lblMsjReserevacion.Text = $"Reservación {lblMsjReserevacion.Text} actualizado correctamente.";
                                    limpiar();
                                    lblNumReservacion.Text = contReservacion.ToString();
                                }

                                dtRersevacion.Rows.Clear();// limpiamos el data grid
                                mostrarReservaciones(); //volvemos a cargar el datagried
                                break;
                            case DialogResult.No:
                                MessageBox.Show("No se actualizó ninguna reservación");
                                break;
                        }
                    }
                    else
                    {
                        lblMsjReserevacion.ForeColor = Color.Red;
                        lblMsjReserevacion.Text = "No existe esta reservación, o ya fue eliminada";

                    }
                }

            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            //actualiza el cliente
            int cantFilaSeleccionada = dtC.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjCliente.ForeColor = Color.Red;
                lblMsjCliente.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numClienteEliminar))
                {
                    lblMsjCliente.ForeColor = Color.Red;
                    lblMsjCliente.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = CClientes.Exists(s => s.Cedula == Convert.ToInt32(txtCedula.Text));

                    if (exist)
                    {
                        DialogResult optUser = MessageBox.Show($"Desea actualizar al cliente con la cédula #{txtCedula.Text}?", //mensaje que pregunta
                        "Advertencia", // el titulo de la ventana
                        MessageBoxButtons.YesNo); //opciones que van a salir de la ventana

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                // Buscar el hotel en la lista por su ContHotel (o cualquier otra propiedad única)
                                ClassCliente clienteAActualizar = CClientes.FirstOrDefault(s => s.Cedula == Convert.ToInt32(txtCedula.Text));

                                if (clienteAActualizar != null)
                                {
                                    clienteAActualizar.C_Nombre = txtNombreCliente.Text;
                                    clienteAActualizar.C_Apellidos = txtApellidoC.Text;
                                    clienteAActualizar.Email = txtEmailC.Text;
                                    clienteAActualizar.Telefono = Convert.ToInt32(txtTel.Text);
                                    clienteAActualizar.Direccion = txtDireccionC.Text;

                                    lblMsjCliente.ForeColor = Color.Red;
                                    lblMsjCliente.Text = $"Cliente actualizado correctamente.";
                                    limpiar();
                                }

                                dtC.Rows.Clear();// limpiamos el data grid
                                mostrarClientes(); //volvemos a cargar el datagried
                                break;
                            case DialogResult.No:
                                MessageBox.Show("No se actualizó ningún cliente");
                                break;
                        }
                    }
                    else
                    {
                        lblMsjCliente.ForeColor = Color.Red;
                        lblMsjCliente.Text = "No existe este cliente, o ya fue eliminada";

                    }
                }

            }
        }

        private void btnActualizarPago_Click(object sender, EventArgs e)
        {
            //actualiza el pago
            int cantFilaSeleccionada = dtPagos.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjPago.ForeColor = Color.Red;
                lblMsjPago.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numPagosEliminar))
                {
                    lblMsjPago.ForeColor = Color.Red;
                    lblMsjPago.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = Pagos.Exists(s => s.PagoId == Convert.ToInt32(lblNumPago.Text));

                    if (exist)
                    {
                        DialogResult optUser = MessageBox.Show($"Desea actualizar el pago  #{lblNumPago.Text}?", //mensaje que pregunta
                        "Advertencia", // el titulo de la ventana
                        MessageBoxButtons.YesNo); //opciones que van a salir de la ventana

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                // Buscar el hotel en la lista por su ContHotel (o cualquier otra propiedad única)
                                ClassPago pagoAActualizar = Pagos.FirstOrDefault(s => s.PagoId == Convert.ToInt32(lblNumPago.Text));

                                if (pagoAActualizar != null)
                                {
                                    DateTime fechaPago = dateTimePagos.Value;
                                    pagoAActualizar.Reservacion_Pagos = Convert.ToInt32(cbReservaPagos.SelectedItem);
                                    pagoAActualizar.MontoPago = Convert.ToInt32(txtMontoPago.Text);
                                    pagoAActualizar.FechaPago = fechaPago.ToString();
                                    pagoAActualizar.MetodoPago = cbMetodosPago.Text;

                                    lblMsjPago.ForeColor = Color.Red;
                                    lblMsjPago.Text = $"Pago #{lblNumPago.Text} actualizado correctamente.";
                                    limpiar();
                                    lblNumPago.Text = contPagos.ToString();

                                }

                                dtPagos.Rows.Clear();// limpiamos el data grid
                                mostrarPagos(); //volvemos a cargar el datagried
                                break;
                            case DialogResult.No:
                                MessageBox.Show("No se actualizó ningún pago");
                                break;
                        }
                    }
                    else
                    {
                        lblMsjPago.ForeColor = Color.Red;
                        lblMsjPago.Text = "No existe este pago, o ya fue eliminada";

                    }
                }

            }
        }

        private void btnActualizaFacturación_Click(object sender, EventArgs e)
        {
            //actualiza factura
            int cantFilaSeleccionada = dtFactura.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjFactura.ForeColor = Color.Red;
                lblMsjFactura.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numFacturaEliminar))
                {
                    lblMsjFactura.ForeColor = Color.Red;
                    lblMsjFactura.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = Facturas.Exists(s => s.FacturaId == Convert.ToInt32(lblNumFactura.Text));

                    if (exist)
                    {
                        DialogResult optUser = MessageBox.Show($"Desea actualizar la factura  #{lblNumFactura.Text}?", //mensaje que pregunta
                        "Advertencia", // el titulo de la ventana
                        MessageBoxButtons.YesNo); //opciones que van a salir de la ventana

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                // Buscar el hotel en la lista por su ContHotel (o cualquier otra propiedad única)
                                ClassFactura facturaAActualizar = Facturas.FirstOrDefault(s => s.FacturaId == Convert.ToInt32(lblNumFactura.Text));

                                if (facturaAActualizar != null)
                                {
                                    //capturamos la fecha
                                    DateTime fechaFactura = dateTimeFechaFactura.Value;

                                    facturaAActualizar.ReservaID_Factura = Convert.ToInt32(cbReservacionFactura.SelectedItem);
                                    facturaAActualizar.Cliente_Factura = Convert.ToInt32(cbClienteFacturacion.SelectedItem);
                                    facturaAActualizar.Empleado_Factura = Convert.ToInt32(cbEmpleadoFacturacion.SelectedItem);
                                    facturaAActualizar.MontoTotal_Factura = Convert.ToInt32(txtMontoFacturacion.Text);
                                    facturaAActualizar.FechaEmision_Factura = fechaFactura.ToString();

                                    lblMsjFactura.ForeColor = Color.Red;
                                    lblMsjFactura.Text = $"Factura #{lblNumFactura.Text} actualizado correctamente.";
                                    limpiar();
                                    lblNumFactura.Text = contFacturas.ToString();

                                }

                                dtFactura.Rows.Clear();// limpiamos el data grid
                                mostrarFacturas(); //volvemos a cargar el datagried
                                break;
                            case DialogResult.No:
                                MessageBox.Show("No se actualizó ninguna factura");
                                break;
                        }
                    }
                    else
                    {
                        lblMsjFactura.ForeColor = Color.Red;
                        lblMsjFactura.Text = "No existe esta factura, o ya fue eliminada";

                    }
                }

            }
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            //actualiza el empleado
            int cantFilaSeleccionada = dtEmpleado.SelectedRows.Count;

            if (cantFilaSeleccionada <= 0)
            {
                lblMsjEmpleado.ForeColor = Color.Red;
                lblMsjEmpleado.Text = "Debes seleccionar una fila";
            }
            else
            {

                if (string.IsNullOrEmpty(numEmpleadoEliminar))
                {
                    lblMsjEmpleado.ForeColor = Color.Red;
                    lblMsjEmpleado.Text = "No has seleccionado un producto de la tabla, primero presiónalo";
                }
                else
                {
                    bool exist = Empleados.Exists(s => s.CedulaEmpleado == Convert.ToInt32(txtCedEmpleado.Text));

                    if (exist)
                    {
                        DialogResult optUser = MessageBox.Show($"Desea actualizar el empleado con la cédula  #{txtCedEmpleado.Text}?", //mensaje que pregunta
                        "Advertencia", // el titulo de la ventana
                        MessageBoxButtons.YesNo); //opciones que van a salir de la ventana

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                // Buscar el hotel en la lista por su ContHotel (o cualquier otra propiedad única)
                                ClassEmpleado empleadoAActualizar = Empleados.FirstOrDefault(s => s.CedulaEmpleado == Convert.ToInt32(txtCedEmpleado.Text));

                                if (empleadoAActualizar != null)
                                {
                                    empleadoAActualizar.NombreEmpleado = txtNombreEmpleado.Text;
                                    empleadoAActualizar.ApellidosEmpleado = txtApellidoEmpleado.Text;
                                    empleadoAActualizar.PosicionEmpleado = cbPosicion.SelectedItem.ToString();
                                    empleadoAActualizar.EmailEmpleado = txtEmailEmpleado.Text;
                                    empleadoAActualizar.TelefonoEmpleado = Convert.ToInt32(txtTelEmpleado.Text);

                                    lblMsjEmpleado.ForeColor = Color.Red;
                                    lblMsjEmpleado.Text = $"Empleado con la cédula #{txtCedEmpleado.Text} actualizado correctamente.";
                                    limpiar();
                                }

                                dtEmpleado.Rows.Clear();// limpiamos el data grid
                                mostrarEmpleados(); //volvemos a cargar el datagried
                                break;
                            case DialogResult.No:
                                MessageBox.Show("No se actualizó ningún empleado");
                                break;
                        }
                    }
                    else
                    {
                        lblMsjEmpleado.ForeColor = Color.Red;
                        lblMsjEmpleado.Text = "No existe un empleado con está cedula, o ya fue eliminada";

                    }
                }

            }
        }
    }
}
