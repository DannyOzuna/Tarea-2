using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public int NumeroCuenta { get; set; }
        public double PrecioHora { get; set; }
        public int HoraTrabajo { get; set; }
        public double Salario { get; set; }
        public abstract double cobrar();
        public abstract string tipoEmpleado();
        public abstract string metodoPago();
    }
}
