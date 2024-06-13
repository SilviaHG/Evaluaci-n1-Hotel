using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación1_Hotel.Forms
{
    internal class ClassHotel
    {
        //atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad {  get; set; }
        public string Pais { get; set; }
        public int Estrellas { get; set; }
        // Habitaciones<list>

        //constructor 
        public ClassHotel() { }

        //constructor lleno 
        public ClassHotel(int Id_p, string Nombre_p, string Direccion_p, string ciudad_p, string pais_p, int stars_p )
        {
            this.Pais = pais_p;
            this.Id = Id_p;
            this.Nombre = Nombre_p;
            this.Direccion = Direccion_p;
            this.Ciudad = ciudad_p;
            this.Estrellas = stars_p;
        }

        //funcion para obtener el hotel completo
        public string ObtenerHotel()
        {
            return $"{Id} {Nombre} {Direccion} {Ciudad} {Pais} {Estrellas}";
        }
    }
}
