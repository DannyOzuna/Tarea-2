using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class MedioTiempo:Empleado
    {
        public override double cobrar()
        {
            Salario = PrecioHora * 4;
            return Salario;
        }
        public override string tipoEmpleado()
        {
            return "Medio Tiempo";
        }
        public override string metodoPago()
        {
            return "Este empleado cobra por cuenta bancaria";
        }
    }
}
