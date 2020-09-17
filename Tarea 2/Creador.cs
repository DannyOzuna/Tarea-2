using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Creador
    {
        public const int ahorrantes = 999, inversionista = 1999, accionistas = 2000;
        public static Clientes creadorCliente(int tipo)
        {
            switch (tipo)
            {
                case ahorrantes:
                    return new Ahorrantes();
                case inversionista:
                    return new Inversionista();
                case accionistas:
                    return new Accionistas();
                default:
                    return null;
            }
        }
    }
}
