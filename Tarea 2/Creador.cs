using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Creador
    {
        public static Clientes creadorCliente(int tipo)
        {
            switch (tipo)
            {
                case 999:
                    return new Ahorrantes();
                case 1999:
                    return new Inversionista();
                case 2000:
                    return new Accionistas();
                default:
                    return null;
            }
        }
    }
}
