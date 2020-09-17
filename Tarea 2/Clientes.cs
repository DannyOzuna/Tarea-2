using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    abstract class Clientes
    {
        private string nombre;
        private int nCuenta;
        private double monto, comision, inversion;
        public string Nombre { get => nombre; set => nombre = value; }
        public int NCuenta { get => nCuenta; set => nCuenta = value; }
        public double Monto { get => monto; set => monto = value; }
        public double Inversion { get => inversion; set => inversion = value; }
        public double Comision { get => comision; set => comision =  value; }
        public abstract double calculoComision();
    }
}
