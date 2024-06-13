using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación1_Hotel.Clases
{
    internal class ClassHabitacion
    {
        // habitacion atributos

        public int Id { get; set;}
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public double PrecioPoNoche { get; set; }
        public int HotelId {  get; set; }

        public ClassHabitacion() { }

        public ClassHabitacion(int id_p, int numero_p, string tipo_p, int capacidad_p, double precio_p, int HotelId_p)
        {
            this.Id = id_p;
            this.Numero = numero_p;
            this.Tipo = tipo_p;
            this.Capacidad = capacidad_p;
            this.PrecioPoNoche = precio_p;
            this.HotelId = HotelId_p;
        }
    }
}
