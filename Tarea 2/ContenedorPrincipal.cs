using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class ContenedorPrincipal
    {
        //Listado de empleados
        List<Empleado> ListadoEmpleado = new List<Empleado>();
        List<Clientes> ListadoCliente = new List<Clientes>();
        //Referencias de instancia de clases
        Empleado empleado;
        Clientes clientes;
        //Atributos
        private int opcion;
        //Requerimiento A
        public void MenuPrincipal()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 3)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Principal");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Empleados");
                Console.WriteLine("2. Clientes");
                Console.WriteLine("3. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MenuRegistro();
                        break;
                    case 2:
                        MenuRegistroCliente();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public void MenuRegistro()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 4)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Registro Empleado");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Ver Listado de Empleado");
                Console.WriteLine("3. Volver Menu Principal");
                Console.WriteLine("4. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 0;
                        Console.Clear();
                        Console.WriteLine("*------Sistema Bancario------*\n");
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.WriteLine("Trabaja por 8 horas, Tiempo Completo");
                        Console.WriteLine("Trabaja por 4 horas, Medio Tiempo");
                        Console.WriteLine("Trabaja por 6 horas, Temporero");
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.Write("Horas Empleado: ");
                        opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 8:
                                empleado = CreadorEmpleado.creadorEmpleado(CreadorEmpleado.tiempoCompleto);
                                empleado.HoraTrabajo = opcion;
                                break;
                            case 4:
                                empleado = CreadorEmpleado.creadorEmpleado(CreadorEmpleado.medioTiempo);
                                empleado.HoraTrabajo = opcion;
                                break;
                            case 6:
                                empleado = CreadorEmpleado.creadorEmpleado(CreadorEmpleado.temporero);
                                empleado.HoraTrabajo = opcion;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine("Este horario de trabajo no existe");
                                Console.WriteLine("Presione un tecla para volver!...");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.ReadKey();
                                MenuRegistro();
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("*------Sistema Bancario------*\n");
                        Console.Write("Nombre: ");
                        empleado.Nombre = Console.ReadLine();
                        Console.Write("Numero Cuenta: ");
                        empleado.NumeroCuenta = int.Parse(Console.ReadLine());
                        Console.Write("Precio por Hora: ");
                        empleado.PrecioHora = double.Parse(Console.ReadLine());
                        empleado.cobrar();
                        ListadoEmpleado.Add(empleado);
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.WriteLine("Se ha registrado correctamente!...");
                        Console.WriteLine("Presione una tecla para volver....");
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.ReadKey();
                        MenuRegistro();
                        break;
                    case 2:
                        if (ListadoEmpleado.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("*------Sistema Bancario------*\n");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.WriteLine("No hay Empleado de Tiempo Completo Registrado!...");
                            Console.WriteLine("Presiona una Tecla para volver....");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.ReadKey();
                            MenuRegistro();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("*------Sistema Bancario------*\n");
                            foreach (Empleado i in ListadoEmpleado)
                            {
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine($"Tipo Empleado: {i.tipoEmpleado()}");
                                Console.WriteLine($"Nombre: {i.Nombre}");
                                Console.WriteLine($"Numero de Cuenta: {i.NumeroCuenta}");
                                Console.WriteLine($"Horas de Trabajo: {i.HoraTrabajo}");
                                Console.WriteLine($"Precio Por Hora: {i.PrecioHora}");
                                Console.WriteLine($"Metodo de Pago: {i.metodoPago()}");
                                Console.WriteLine($"Salario: {i.Salario}");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|\n");
                            }
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.WriteLine("Presiona una Tecla para volver....");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.ReadKey();
                            MenuRegistro();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        //Requerimiento B
        public void MenuRegistroCliente()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 4)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Regitro Cliente");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Ver Listado de Cliente");
                Console.WriteLine("3. Volver Menu Principal");
                Console.WriteLine("4. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        opcion = 0;
                        Console.WriteLine("*------Sistema Bancario------*\n");
                        do
                        {
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.WriteLine("Los ahorrantes aportan hasta RD$999");
                            Console.WriteLine("Los Inversionistas aportan hasta RD$1999");
                            Console.WriteLine("Los Accionistas aportan a partir de RD$2000");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.Write("Aporte: ");
                            opcion = int.Parse(Console.ReadLine());
                        } while (opcion <= 0);
                        if (opcion > 0 && opcion <= 999)
                        {
                            clientes = Creador.creadorCliente(Creador.ahorrantes);
                            clientes.Inversion = opcion;
                        }
                        else if (opcion > 999 && opcion <= 1999)
                        {
                            clientes = Creador.creadorCliente(Creador.inversionista);
                            clientes.Inversion = opcion;
                        }
                        else
                        {
                            clientes = Creador.creadorCliente(Creador.accionistas);
                            clientes.Inversion = opcion;
                        }
                        Console.Clear();
                        Console.WriteLine("*------Sistema Bancario------*\n");
                        Console.Write("Nombre: ");
                        clientes.Nombre = Console.ReadLine();
                        Console.Write("Numero de Cuenta: ");
                        clientes.NCuenta = int.Parse(Console.ReadLine());
                        Console.Write("Monton: ");
                        clientes.Monto = double.Parse(Console.ReadLine());
                        clientes.calculoComision();
                        ListadoCliente.Add(clientes);
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.WriteLine("Se ha registrado correctamente!...");
                        Console.WriteLine("Presione una tecla para volver....");
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.ReadKey();
                        MenuRegistroCliente();
                        break;
                    case 2:
                        if (ListadoCliente.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("*------Sistema Bancario------*\n");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.WriteLine("No hay Cliente registrado!...");
                            Console.WriteLine("Presiona una Tecla para volver....");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.ReadKey();
                            MenuRegistroCliente();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("*------Sistema Bancario------*\n");
                            foreach (Clientes i in ListadoCliente)
                            {
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine(i.tipoCliente());
                                Console.WriteLine($"Nombre: {i.Nombre}");
                                Console.WriteLine($"Numero de Cuenta: {i.NCuenta}");
                                Console.WriteLine($"Monto: {i.Monto}");
                                Console.WriteLine($"Comision: {i.Comision}");
                                Console.WriteLine($"Inversion: {i.Inversion}");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|\n");
                            }
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.WriteLine("Presiona una Tecla para volver....");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.ReadKey();
                            MenuRegistroCliente();
                        }
                        break;
                    case 3:
                        MenuPrincipal();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
