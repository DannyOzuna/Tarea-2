using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Inversionista: Clientes
    {
        public override double calculoComision()
        {
            Comision = Monto * 0.40;
            return Comision;
        }
    }
}
