using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Ahorrantes: Clientes
    {
        public override double calculoComision()
        {
            Comision = Monto * 0.40;
            return Comision;
        }
        public override string tipoCliente()
        {
            return "Tipo de Cliente Ahorrante";
        }
    }
}
