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
        //creamos una instancia de hotel
        ClassHotel Hotel = new ClassHotel();
        //creamos una lista de tipo hotel
        List<ClassHotel> hoteles = new List<ClassHotel>();
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
        /// Funcion para establecer los valores a la clase
        /// </summary>
        public void establecerValore()
        {
            Hotel.Id = 0;
            Hotel.Nombre = txtNombre.Text;
            Hotel.Direccion = txtDireccion.Text;
            Hotel.Ciudad = txtCiudad.Text;
            Hotel.Pais = txtxPais.Text;
            Hotel.Estrellas = SliderStars.Value;
        }
        /// <summary>
        /// agregar los hoteles a la lista
        /// </summary>

        public void agregarHotelesList()
        {
            //agrergamos los animales a la lista
            ClassHotel guardarHotel = new ClassHotel(
                cont, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, txtxPais.Text, SliderStars.Value
                );

            hoteles.Add(guardarHotel);
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
                agregarHotelesList();
                // mostrar hoteles al datagried
                mostrarHoteles();
                limpiar();
                cont += 1;
                lblID.Text = "N°: " + cont;
            }

           
        }
    }
}
