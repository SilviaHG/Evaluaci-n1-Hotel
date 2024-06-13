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
        //creamos una las listas
        List<ClassHotel> hoteles = new List<ClassHotel>();
        List<ClassHabitacion> habitaciones = new List<ClassHabitacion>();
        int cont = 1;

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
                cont, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, txtxPais.Text, SliderStars.Value
                );

            hoteles.Add(guardarHotel);

           
        }
        public void agregarHabitacionList()
        {
            //agreagmos una habitacion
            ClassHabitacion guardarHabitacion = new ClassHabitacion(
                0,
                Convert.ToInt32( cbNumeroHabitacion.SelectedItem),
               cbTipoHabitacion.SelectedItem.ToString(),
              
                Convert.ToInt32( cbCapacidadHabitacion.SelectedItem),
                Convert.ToDouble(txtPrecio.Text),
               
               Convert.ToInt32( cbNumHotel.SelectedItem)
                );
            habitaciones.Add(guardarHabitacion);
        }
        /// <summary>
        /// Mostramos los hoteles en el datagrid
        /// </summary>
        public void mostrarHoteles()
        {

            dtHoteles.Rows.Clear();
            for( int i = 0; i < hoteles.Count; i++ )
            {
                dtHoteles.Rows.Add(hoteles[i].Id, hoteles[i].Nombre, hoteles[i].Direccion, hoteles[i].Ciudad, hoteles[i].Pais, hoteles[i].Estrellas );
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
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblID.Text = "N°: " + cont;
        }

        private void btnAgregarHotel_Click(object sender, EventArgs e)
        {

            if(Login.camposVacios(new object[] { txtNombre , txtDireccion, txtCiudad, txtxPais }))
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }else
            {
                //agregamos hoteles
                agregarHotelList();
                // mostrar hoteles al datagried
                mostrarHoteles();
                limpiar();
                cont += 1;
                lblID.Text = "N°: " + cont;
            }

           
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            agregarHabitacionList();
            mostrarHabitaciones();

            lblIDhABITACION.Text = "N°: " + cont; 
        }
    }
}
