using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación1_Hotel.Clases
{
    internal class ClassCliente
    {
        public int Cedula { get; set; }
        public string C_Nombre { get; set; }
        public string C_Apellidos { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public ClassCliente() { }

        public ClassCliente(int cedula_p, string nombre_p, string apellidos_p, string email_p, int telefono_p, string direccion_p)
        {
            this.Cedula = cedula_p;
            this.C_Nombre = nombre_p;
            this.C_Apellidos = apellidos_p;
            this.Email = email_p;
            this.Telefono = telefono_p;
            this.Direccion = direccion_p;
        }
    }
}
