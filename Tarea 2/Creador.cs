using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Creador
    {
        public const int accionista = 1, ahorrantes = 2, inversionista = 3;
        public static Clientes creadorCliente(int tipo)
        {
            switch (tipo)
            {
                case accionista:
                    return new Accionistas();
                case ahorrantes:
                    return new Ahorrantes();
                case inversionista:
                    return new Inversionista();
                default:
                    return null;
            }
        }
    }
}
