using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación1_Hotel.Clases
{
    internal class ClassPago
    {

        public int PagoId { get; set; }
        public int MontoPago { get; set; }
        public string FechaPago { get; set; }
        public string MetodoPago { get; set; }
        public ClassPago() { }

        public ClassPago(int pagoId, int montoPago, string fechaPago, string metodoPago)
        {
            PagoId = pagoId;
            MontoPago = montoPago;
            FechaPago = fechaPago;
            MetodoPago = metodoPago;
        }
    }
}
