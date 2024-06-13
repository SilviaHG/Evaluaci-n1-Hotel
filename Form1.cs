using Evaluación1_Hotel.Forms;
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

namespace Evaluación1_Hotel
{
    public partial class Login : MaterialForm
    {
        string[] user = { "Admin", "a" };
        string[] password = { "1", "1" };
        public Login()
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
        /// Funcion que verifica si los campos estan vacíos
        /// </summary>
        /// <param name="campos">Campos a verificar de txt</param>
        /// <param name="combos">Campos a verificar de combo</param>
        /// <returns></returns>
        public static bool camposVacios(object[] campos, object[] combos = null)
        {
            bool vacios = false;
            for (int i = 1; i < campos.Length; i++)
            {
                // convertimos la posicion actual del objects a campos de tesxtbox
                MaterialTextBox2 campo = (MaterialTextBox2)campos[i];
                if (string.IsNullOrEmpty(campo.Text))
                {
                    // MessageBox.Show($"El campo {campo.Hint} está vacío");
                    vacios = true;
                    break;
                }
            }

            if (combos != null)
            {
                for (int i = 0; i < combos.Length; i++)
                {
                    MaterialComboBox combo = (MaterialComboBox)combos[i];
                    if (combo.SelectedIndex == 0)
                    {
                        vacios = true;
                        // MessageBox.Show("Debes seleccionar un valor de la fila desplegable");
                        break;
                    }
                }
            }

            return vacios;
        } // termina la funcion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contra = txtPass.Text;
            // que no haya espacios en blanco
            if (camposVacios(new Object[] { txtUser, txtPass }))
            {
                lblAlert.ForeColor = Color.Red;
                lblAlert.Text = "No puede dejar campos vacíos";
            }
            else
            {
                bool exisUser = Array.Exists(user, s => s == usuario);
                bool existContra = Array.Exists(password, s => s == contra);

                if (existContra || exisUser)
                {
                    //MessageBox.Show("Entra");
                    Principal prin = new Principal();
                    prin.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o/y contraseña incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }
    }
}
