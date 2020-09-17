using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Ahorrantes: Clientes
    {
        public Ahorrantes(string nombre, int nCuenta, double monto)
        {
            Nombre = nombre;
            NCuenta = nCuenta;
            Monto = monto;
        }
        public override double calculoComision()
        {
            Comision = Monto * 0.40;
            return Comision;
        }
    }
}
