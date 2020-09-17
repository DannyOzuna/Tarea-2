using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class ContenedorPrincipal
    {
        //Listado de empleados
        List<TiempoCompleto> EmpleadoTiempoC = new List<TiempoCompleto>();
        List<MedioTiempo> EmpleadoMedioT = new List<MedioTiempo>();
        List<Temporero> EmpleadoTemp = new List<Temporero>();
        List<Clientes> ListadoCliente = new List<Clientes>();
        //Referencias de instancia de clases
        TiempoCompleto empleadoTiempoC;
        MedioTiempo empleadoMedioT;
        Clientes clientes;
        //Atributos
        private int opcion;
        private string status;
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
                        status = "Add";
                        MenuEmpleado();
                        break;
                    case 2:
                        status = "Show";
                        MenuEmpleado();
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
        public void MenuEmpleado()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 5)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Registro Empleado");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Tiempo Completo");
                Console.WriteLine("2. Medio Tiempo");
                Console.WriteLine("3. Temporero");
                Console.WriteLine("4. Volver Menu Registro");
                Console.WriteLine("5. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    //Tiempo Completo
                    case 1:
                        switch (status)
                        {
                            case "Add":
                                Console.Clear();
                                Console.WriteLine("*------Sistema Bancario------*\n");
                                empleadoTiempoC = new TiempoCompleto("Tiempo Completo", "Lisandro Ozuna", 46846, 100, "Este empleado cobra por cuenta bancaria", 8);
                                empleadoTiempoC.TipoEmpleado = "Tiempo Completo";
                                empleadoTiempoC.MetodoPago = "Este empleado cobra por cuenta bancaria";
                                empleadoTiempoC.HoraTrabajo = 8;
                                Console.Write("Nombre: ");
                                empleadoTiempoC.Nombre = Console.ReadLine();
                                Console.Write("Numero Cuenta: ");
                                empleadoTiempoC.NumeroCuenta = int.Parse(Console.ReadLine());
                                Console.Write("Precio por Hora: ");
                                empleadoTiempoC.PrecioHora = double.Parse(Console.ReadLine());
                                empleadoTiempoC.cobrar();
                                EmpleadoTiempoC.Add(empleadoTiempoC);
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine("Se ha registrado correctamente!...");
                                Console.WriteLine("Presione una tecla para volver....");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.ReadKey();
                                MenuRegistro();
                                break;
                            case "Show":
                                if (EmpleadoTiempoC.Count == 0)
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
                                    foreach (TiempoCompleto i in EmpleadoTiempoC)
                                    {
                                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                        Console.WriteLine($"Tipo Empleado: {i.TipoEmpleado}");
                                        Console.WriteLine($"Nombre: {i.Nombre}");
                                        Console.WriteLine($"Numero de Cuenta: {i.NumeroCuenta}");
                                        Console.WriteLine($"Horas de Trabajo: {i.HoraTrabajo}");
                                        Console.WriteLine($"Precio Por Hora: {i.PrecioHora}");
                                        Console.WriteLine($"Metodo de Pago: {i.MetodoPago}");
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

                        }
                        break;
                    //Medio Tiempo
                    case 2:
                        switch (status)
                        {
                            case "Add":
                                Console.Clear();
                                Console.WriteLine("*------Sistema Bancario------*\n");
                                empleadoMedioT = new MedioTiempo("Medio Tiempo", "Lisandro Ozuna", 46846, 100, "Este empleado cobra por cuenta bancaria", 4);
                                empleadoMedioT.TipoEmpleado = "Medio Tiempo";
                                empleadoMedioT.MetodoPago = "Este empleado cobra por cuenta bancaria";
                                empleadoMedioT.HoraTrabajo = 4;
                                Console.Write("Nombre: ");
                                empleadoMedioT.Nombre = Console.ReadLine();
                                Console.Write("Numero Cuenta: ");
                                empleadoMedioT.NumeroCuenta = int.Parse(Console.ReadLine());
                                Console.Write("Precio por Hora: ");
                                empleadoMedioT.PrecioHora = double.Parse(Console.ReadLine());
                                empleadoMedioT.cobrar();
                                EmpleadoMedioT.Add(empleadoMedioT);
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine("Se ha registrado correctamente!...");
                                Console.WriteLine("Presione una tecla para volver....");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.ReadKey();
                                MenuRegistro();
                                break;
                            case "Show":
                                if (EmpleadoMedioT.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("No hay Empleado de Medio Tiempo Registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistro();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    foreach (MedioTiempo i in EmpleadoMedioT)
                                    {
                                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                        Console.WriteLine($"Tipo Empleado: {i.TipoEmpleado}");
                                        Console.WriteLine($"Nombre: {i.Nombre}");
                                        Console.WriteLine($"Numero de Cuenta: {i.NumeroCuenta}");
                                        Console.WriteLine($"Horas de Trabajo: {i.HoraTrabajo}");
                                        Console.WriteLine($"Precio Por Hora: {i.PrecioHora}");
                                        Console.WriteLine($"Metodo de Pago: {i.MetodoPago}");
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
                        }
                        break;
                    //Temporero
                    case 3:
                        switch (status)
                        {
                            case "Add":
                                if (EmpleadoTemp.Count != 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("Ya existe un empleado Temporero registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistro();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Temporero temporero = Temporero.GetTemporero("Temporero", "Lisandro Ozuna", 46846, 100, "Este empleado cobra por cheque", 9);
                                    temporero.TipoEmpleado = "Temporero";
                                    temporero.MetodoPago = "Este empleado cobra por cheque";
                                    temporero.HoraTrabajo = 9;
                                    Console.Write("Nombre: ");
                                    temporero.Nombre = Console.ReadLine();
                                    Console.Write("Numero Cuenta: ");
                                    temporero.NumeroCuenta = int.Parse(Console.ReadLine());
                                    Console.Write("Precio por Hora: ");
                                    temporero.PrecioHora = double.Parse(Console.ReadLine());
                                    temporero.cobrar();
                                    EmpleadoTemp.Add(temporero);
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("Se ha registrado correctamente!...");
                                    Console.WriteLine("Presione una tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistro();
                                }
                                break;
                            case "Show":
                                if (EmpleadoTemp.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("No hay Empleado de Medio Tiempo Registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistro();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    foreach (Temporero i in EmpleadoTemp)
                                    {
                                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                        Console.WriteLine($"Tipo Empleado: {i.TipoEmpleado}");
                                        Console.WriteLine($"Nombre: {i.Nombre}");
                                        Console.WriteLine($"Numero de Cuenta: {i.NumeroCuenta}");
                                        Console.WriteLine($"Horas de Trabajo: {i.HoraTrabajo}");
                                        Console.WriteLine($"Precio Por Hora: {i.PrecioHora}");
                                        Console.WriteLine($"Metodo de Pago: {i.MetodoPago}");
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
                        }
                        break;
                    case 4:
                        Console.Clear();
                        MenuRegistro();
                        break;
                    case 5:
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
