using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class CreadorEmpleado
    {
        public const int tiempoCompleto = 8, medioTiempo = 4, temporero = 6;
        public static Empleado creadorEmpleado(int horaTrabajo)
        {
            switch (horaTrabajo)
            {
                case tiempoCompleto:
                    return new TiempoCompleto();
                case medioTiempo:
                    return new MedioTiempo();
                case temporero:
                    return new Temporero();
                default:
                    return null;
            }
        }
    }
}
