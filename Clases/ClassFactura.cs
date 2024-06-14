using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación1_Hotel.Clases
{
    internal class ClassFactura
    {

        public int FacturaId { get; set; }
        public int ReservaID_Factura { get; set; }
        public int Cliente_Factura { get; set; }
        public int Empleado_Factura { get; set; }
        public int MontoTotal_Fcatura { get; set; }
        public string FechaEmision_Factura { get; set; }
        public ClassFactura() { }

        public ClassFactura(int facturaId, int reservaID_Factura, int cliente_Factura, int empleado_Factura, int montoTotal_Fcatura, string fechaEmision_Factura)
        {
            FacturaId = facturaId;
            ReservaID_Factura = reservaID_Factura;
            Cliente_Factura = cliente_Factura;
            Empleado_Factura = empleado_Factura;
            MontoTotal_Fcatura = montoTotal_Fcatura;
            FechaEmision_Factura = fechaEmision_Factura;
        }
    }
}
