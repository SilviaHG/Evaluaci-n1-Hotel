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
        ClassHotel Hotel = new ClassHotel();
        ClassHabitacion habitacion = new ClassHabitacion();
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

        }

        /// <summary>
        /// agregar los hoteles a la lista
        /// </summary>
        public void agregarHotelList()
        {
            //agrergamos los animales a la lista
            ClassHotel guardarHotel = new ClassHotel(
                contHotel, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, txtxPais.Text, SliderStars.Value
                );

            hoteles.Add(guardarHotel);


        }


        public void agregarHabitacionList()
        {

            //agreagmos una habitacion
            ClassHabitacion guardarHabitacion = new ClassHabitacion(
                contHabitacion,
                Convert.ToInt32(cbNumeroHabitacion.SelectedItem),
               cbTipoHabitacion.SelectedItem.ToString(),
                Convert.ToInt32(cbCapacidadHabitacion.SelectedItem),
                Convert.ToDouble(txtPrecio.Text),
               Convert.ToInt32(cbNumHotel.SelectedItem)
                );
            habitaciones.Add(guardarHabitacion);
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
                Convert.ToInt32(cbHabitacion.SelectedItem),
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
                dtHoteles.Rows.Add(hoteles[i].Id, hoteles[i].Nombre, hoteles[i].Direccion, hoteles[i].Ciudad, hoteles[i].Pais, hoteles[i].Estrellas);
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



            //clientes
            txtCedula.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoC.Text = "";
            txtEmailC.Text = "";
            txtTel.Text = "";
            txtDireccionC.Text = "";

            //empleados
            txtCedEmpleado.Text = "";
            txtApellidoEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
            txtEmailEmpleado.Text = "";
            txtTelEmpleado.Text = "";
            cbPosicion.SelectedIndex = 0;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblID.Text = "N°: " + contHotel;
            lblH.Text = "Nº: " + contHabitacion;
            lblNumReservacion.Text = "N°: " + contReservacion;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
            label6.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label8.ForeColor = Color.Red;
            label9.ForeColor = Color.Red;

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
                agregarHabitacionList();
                mostrarHabitaciones();
                limpiar();
                contHabitacion += 1;
                lblH.Text = "Nº: " + contHabitacion;

                // limpiamos el combo box para que no se dupliquen

                cbHabitacion.Items.Clear();
                cbHabitacion.Items.Add(0);
                //agregamos los hoteles al combo box de habitaciones
                foreach (var h in habitaciones)
                {
                    cbHabitacion.Items.Add(h.Id);
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
                agregarReservacionList();
                mostrarReservaciones();
                //-----------
                //reservaciones
                cbClientes.SelectedIndex = 0;
                cbHabitacion.SelectedIndex = 0;
                cbEstado.SelectedIndex = 0;

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

                cbClientes.Items.Clear();
                cbClientes.Items.Add(0);
                //agregamos los clientes al combo box de reservacion
                foreach (var c in CClientes)
                {
                    cbClientes.Items.Add(c.C_Nombre);
                }
            }

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            if (Login.camposVacios(new object[] { txtCedEmpleado, txtNombreEmpleado, txtApellidoEmpleado, txtEmailEmpleado, txtTelEmpleado}, new object[] {cbPosicion }))
            {
                lblMsjEmpleado.ForeColor = Color.Red;
                lblMsjEmpleado.Text = "No puede dejar campos vacíos";
            }
            else
            {
                agregarEmpleado();
                mostrarEmpleados();
                limpiar();
            }
        }
    }
}
