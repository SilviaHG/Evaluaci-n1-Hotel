using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación1_Hotel.Clases
{
    internal class ClassEmpleado
    {
        public int CedulaEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public string PosicionEmpleado { get; set; }
        public string EmailEmpleado { get; set; }
        public int TelefonoEmpleado { get; set; }

        public ClassEmpleado() { }

        public ClassEmpleado(int cedulaEmpleado, string nombreEmpleado, string apellidosEmpleado, string posicionEmpleado, string emailEmpleado, int telefonoEmpleado)
        {
            this.CedulaEmpleado = cedulaEmpleado;
            this.NombreEmpleado = nombreEmpleado;
            this.ApellidosEmpleado = apellidosEmpleado;
            this.PosicionEmpleado = posicionEmpleado;
            this.EmailEmpleado = emailEmpleado;
            this.TelefonoEmpleado = telefonoEmpleado;
        }

        public string ObtenerEmpleados()
        {
            return $"{CedulaEmpleado} {NombreEmpleado} {ApellidosEmpleado} {PosicionEmpleado} {EmailEmpleado} {TelefonoEmpleado}";
        }
    }
}
