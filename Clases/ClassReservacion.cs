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
        public int Habitacion { get; set; }
        public DateTime FInicio { get; set; }
        public DateTime FFin { get; set; }
        public string Estado { get; set; }

        public ClassReservacion( int id_p, string cliente_p, int habitacion_p, DateTime inicio_p, DateTime fin_p, string estado_p ) 
        { 
            this.ReservaId = id_p;
            this.ClienteId = cliente_p;
            this.Habitacion = habitacion_p;
            this.FInicio = inicio_p;
            this.FFin = fin_p;
            this.Estado = estado_p;
        }



    }
}
