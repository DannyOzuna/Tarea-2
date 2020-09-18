using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Temporero:Empleado
    {
        public override double cobrar()
        {
            Salario = PrecioHora * 6;
            return Salario;
        }
        public override string tipoEmpleado()
        {
            return "Temporero";
        }
        public override string metodoPago()
        {
            return "Este empleado cobra por cheque";
        }

    }
}
