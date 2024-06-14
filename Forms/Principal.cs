using Evaluación1_Hotel.Clases;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación1_Hotel.Forms
{
    public partial class Principal : MaterialForm
    {
        //creamos las instancias
        ClassHotel Hotel = new ClassHotel(1, "Hotel Upala", "Upala", "Upala", "Costa Rica", 4);
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
        int contHotel = 1;
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
        /// <summary>
        /// creamos habitacions de forma predeterminados
        /// </summary>
        public void agregarHabitacionList()
        {
            Random rnd = new Random(); //numeros random

            //creamos una habitacion por defecto
            for (int i = 0; i < 4; i++)
            {
                classHbitacion = new ClassHabitacion(
                    contHabitacion,
                     $"H{i}",
                    "Individual",
                    Convert.ToInt32($"{rnd.Next(10)}"),
                    Convert.ToDouble($"{rnd.Next(2500)}"),
                    685
                    );
                //lo agregamos a la lista de habitaciones
                habitaciones.Add(classHbitacion);
            }

            //
            Hotel.HabitacionesList = habitaciones;

            //agreagmos una habitacion
            /*
            ClassHabitacion guardarHabitacion = new ClassHabitacion(
                contHabitacion,
                Convert.ToInt32(cbNumeroHabitacion.SelectedItem),
               cbTipoHabitacion.SelectedItem.ToString(),
                Convert.ToInt32(cbCapacidadHabitacion.SelectedItem),
                Convert.ToDouble(txtPrecio.Text),
               Convert.ToInt32(cbNumHotel.SelectedItem)
                );
            habitaciones.Add(guardarHabitacion);
            */
        }
        public void CargarHabitaciones()
        {
            //agregamos las habitaciones a las listas
            agregarHabitacionList();
            //hacemos una funcion de cargar habitaciones al cbBoxDe hotel

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
                dtRersevacion.Rows.Add(Reservaciones[i].ReservaId, Reservaciones[i].ClienteId, Reservaciones[i].Habitacion, Reservaciones[i].FInicio, Reservaciones[i].FFin, Reservaciones[i].Estado);
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

            //clientes
            txtCedula.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoC.Text = "";
            txtEmailC.Text = "";
            txtTel.Text = "";
            txtDireccionC.Text = "";

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

            //facturas
            txtMontoFacturacion.Text = "";
            cbReservacionFactura.SelectedIndex = 0;
            cbClienteFacturacion.SelectedIndex = 0;
            cbEmpleadoFacturacion.SelectedIndex = 0;
            dateTimeFechaFactura.Value = DateTime.Now;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            lblID.Text = "N°: " + contHotel;
            lblH.Text = "Nº: " + contHabitacion;
            lblNumReservacion.Text = "N°: " + contReservacion;
            lblNumPago.Text = "N°: " + contPagos;
            lblNumFactura.Text = "N° " + contFacturas;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
            label6.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label8.ForeColor = Color.Red;
            label9.ForeColor = Color.Red;

            //cargamos las habitaciones a los combo box
            CargarHabitaciones();

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
                    lblID.Text = "N°: " + contHotel;

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
                // agregarHabitacionList();
                //CargarHabitaciones();
                mostrarHabitaciones();
                limpiar();
                contHabitacion += 1;
                lblH.Text = "Nº: " + contHabitacion;

                // limpiamos el combo box para que no se dupliquen

                
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
                agregarReservacionList();
                mostrarReservaciones();
                limpiar();
                //-----------


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
                lblNumReservacion.Text = "N°: " + contReservacion;
            }
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {


            if (Login.camposVacios(new object[] { txtCedula, txtNombreCliente, txtApellidoC, txtEmailC, txtTel, txtDireccionC }))
            {
                lblMsjCliente.ForeColor = Color.Red;
                lblMsjCliente.Text = "No puede dejar campos vacíos";
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
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            if (Login.camposVacios(new object[] { txtCedEmpleado, txtNombreEmpleado, txtApellidoEmpleado, txtEmailEmpleado, txtTelEmpleado }, new object[] { cbPosicion }))
            {
                lblMsjEmpleado.ForeColor = Color.Red;
                lblMsjEmpleado.Text = "No puede dejar campos vacíos";
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
        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (Login.camposVacios(new object[] { txtMontoPago }, new object[] { cbReservaPagos, cbMetodosPago }))
            {
                lblMsjPago.ForeColor = Color.Red;
                lblMsjPago.Text = "No puede dejar campos vacíos";
            }
            else
            {

                agregarPagoList();
                mostrarPagos();
                limpiar();
            }
        }
        private void btnAgregarFactura_Click(object sender, EventArgs e)
        {
            agregarFacturaList();
            mostrarFacturas();
            limpiar();

        }
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

                if (esNumero)
                {
                    lblMsj.Text = "...";
                    btnAgregarHabitacion.Enabled = true;
                }
                else
                {
                    txtPrecio.Hint = "Debe ser número";
                    lblMsjHabitacion.ForeColor = Color.Red;
                    lblMsjHabitacion.Text = $"En la casilla 'Monto' debe de ingresar solo números";
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

                if (esNumero )
                {
                    lblMsjCliente.Text = "...";
                    btnAgregarCliente.Enabled = true;
                }
                else
                {
                    txtCedula.Hint = "Debe ser número";
                    lblMsjCliente.ForeColor = Color.Red;
                    lblMsjCliente.Text = $"En la casilla 'Cédula y teléfono' debe de ingresar solo números";
                    btnAgregarCliente.Enabled = false;
                    //txtPrecio.SelectAll();
                    // txtMontoHRservacion.Focus();
                    // txtMontoHRservacion.BackColor = Color.Red;
                }
            }
        }

        private void txtTel_Click(object sender, EventArgs e)
        {
            if ( txtTel.Text.Length >= 0)
            {
                int numero = 0;
                bool num = int.TryParse(txtTel.Text, out numero);

                if (num)
                {
                    lblMsjCliente.Text = "...";
                    btnAgregarCliente.Enabled = true;
                }
                else
                {
                    txtTel.Hint = "Debe ser número";
                    lblMsjCliente.ForeColor = Color.Red;
                    lblMsjCliente.Text = $"En la casilla 'Cédula y teléfono' debe de ingresar solo números";
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

                if (num)
                {
                    lblMsjPago.Text = "...";
                    btnAgregarPago.Enabled = true;
                }
                else
                {
                    txtMontoPago.Hint = "Debe ser número";
                    lblMsjPago.ForeColor = Color.Red;
                    lblMsjPago.Text = $"En la casilla 'Cédula y teléfono' debe de ingresar solo números";
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

                if (num)
                {
                    lblMsjFactura.Text = "...";
                    btnAgregarFactura.Enabled = true;
                }
                else
                {
                    txtMontoFacturacion.Hint = "Debe ser número";
                    lblMsjFactura.ForeColor = Color.Red;
                    lblMsjFactura.Text = $"En la casilla 'Cédula y teléfono' debe de ingresar solo números";
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

                if (num)
                {
                    lblMsjEmpleado.Text = "...";
                    btnAgregarEmpleado.Enabled = true;
                }
                else
                {
                    txtCedEmpleado.Hint = "Debe ser número";
                    lblMsjEmpleado.ForeColor = Color.Red;
                    lblMsjEmpleado.Text = $"En la casilla 'Cédula y teléfono' debe de ingresar solo números";
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

                if (num)
                {
                    lblMsjEmpleado.Text = "...";
                    btnAgregarEmpleado.Enabled = true;
                }
                else
                {
                    txtTelEmpleado.Hint = "Debe ser número";
                    lblMsjEmpleado.ForeColor = Color.Red;
                    lblMsjEmpleado.Text = $"En la casilla 'Cédula y teléfono' debe de ingresar solo números";
                    btnAgregarEmpleado.Enabled = false;
                    //txtPrecio.SelectAll();
                    // txtMontoHRservacion.Focus();
                    // txtMontoHRservacion.BackColor = Color.Red;
                }
            }
        }
    }
}
