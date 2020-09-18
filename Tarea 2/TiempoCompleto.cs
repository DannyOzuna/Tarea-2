using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class TiempoCompleto:Empleado
    {
        public override double cobrar()
        {
            Salario = PrecioHora * 8;
            return Salario;
        }
        public override string tipoEmpleado()
        {
            return "Tiempo Completo";
        }
        public override string metodoPago()
        {
            return "Este empleador cobra por cuenta bancaria";
        }
    }
}
