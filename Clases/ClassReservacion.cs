using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación1_Hotel.Clases
{
    internal class ClassReservacion
    {
        public int ReservaId { get; set; }
        public string ClienteId { get; set; }
        public string Habitacion { get; set; }
        public string FInicio { get; set; }
        public string FFin { get; set; }
        public string Estado { get; set; }

        public ClassReservacion() { }

        public ClassReservacion( int Reservacionid_p, string cliente_p, string habitacion_p, string inicio_p, string fin_p, string estado_p ) 
        {
            this.ReservaId = Reservacionid_p;
            this.ClienteId = cliente_p;
            this.Habitacion = habitacion_p;
            this.FInicio = inicio_p;
            this.FFin = fin_p;
            this.Estado = estado_p;
        }
    }
}
