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
        ClassReservacion reservaciones = new ClassReservacion();
        //creamos una las listas
        List<ClassHotel> hoteles = new List<ClassHotel>();
        List<ClassHabitacion> habitaciones = new List<ClassHabitacion>();
        int contHotel = 1;
        int contHabitacion = 1;

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
        /// <summary>
        /// Mostramos los hoteles en el datagrid
        /// </summary>
        public void mostrarHoteles()
        {

            dtHoteles.Rows.Clear();
            for (int i = 0; i < hoteles.Count; i++)
            {
                dtHoteles.Rows.Add(hoteles[i].Id, hoteles[i].Nombre, hoteles[i].Direccion, hoteles[i].Ciudad, hoteles[i].Pais, hoteles[i].Estrellas);
            }



        }
        public void mostrarHabitaciones()
        {
            dtHabitaciones.Rows.Clear();
            for (int i = 0; i < habitaciones.Count; i++)
            {
                dtHabitaciones.Rows.Add(habitaciones[i].Id, habitaciones[i].Numero, habitaciones[i].Tipo, habitaciones[i].Capacidad, habitaciones[i].PrecioPoNoche, habitaciones[i].HotelId);
            }
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtxPais.Text = "";
            SliderStars.Value = 0;

            cbNumeroHabitacion.SelectedIndex = 0;
            cbTipoHabitacion.SelectedIndex = 0;
            cbCapacidadHabitacion.SelectedIndex = 0;
            cbNumHotel.SelectedIndex = 0;
            txtPrecio.Text = "";
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblID.Text = "N°: " + contHotel;
            lblH.Text = "Nº: " + contHabitacion;
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
            }

        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarReservacion_Click(object sender, EventArgs e)
        {

        }
    }
}
