using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Inversionista: Clientes
    {
        public Inversionista(string nombre, int nCuenta, double monto, double inversion)
        {
            Nombre = nombre;
            NCuenta = nCuenta;
            Monto = monto;
            Inversion = inversion;
        }
        public override double calculoComision()
        {
            Comision = Monto * 0.40;
            return Comision;
        }
    }
}
