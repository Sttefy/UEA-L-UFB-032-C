using System;
using System.Collections.Generic;

class Vehiculo
{
    public string Placa { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public int Anio { get; set; }
    public decimal Precio {get; set; }

    public override string ToString()
    {
        return $"Placa: {Placa}, Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}, Precio: {Precio:C}";
    }
}

class Program
{
    static LinkedList<Vehiculo> listaVehiculos = new LinkedList<Vehiculo>();
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n---Menú---");
            Console.WriteLine("1. Agregar vehiculo");
            Console.WriteLine("2. Buscar vehiculo por placa");
            Console.WriteLine("3. Ver vehiculos por año");
            Console.WriteLine("4. Ver todos los vehiculos registrados");
            Console.WriteLine("5. Eliminar vehiculo registrado");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Seleccione una opción");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarVehiculo();
                    break;
                case 2:
                    BuscarVehiculoPorPlaca();
                    break;
                case 3:
                    VerVehiculosPorAnio();
                    break;
                case 4:
                    VerTodosLosVehiculosRegistrados();
                    break;
                case 5:
                    EliminarVehiculoRegistrado();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no valida, intente nuevamente.");
                    break;
            }
        }
        while (opcion != 6);
    }
    static void AgregarVehiculo()
    {
        Console.WriteLine("Ingresar la placa: ");
        string? placa = Console.ReadLine();

        Console.WriteLine("Ingresar marca: ");
        string? marca = Console.ReadLine();

        Console.WriteLine("Ingresar modelo: ");
        string? modelo = Console.ReadLine();

        Console.WriteLine("Ingresar el año: ");
        string? inputAnio = Console.ReadLine();
        int anio;
        if(int.TryParse(inputAnio, out anio))
        {
            Console.WriteLine($"El año que ingresaste es: {anio}");
        }
        else
        {
            Console.WriteLine("El año que ingresaste no es correcto.");
            return;
        }

        Console.WriteLine("Ingresar el precio: ");
        string? inputPrecio = Console.ReadLine();
        decimal precio;
        if (decimal.TryParse(inputPrecio, out precio))
        {
            Console.WriteLine($"El precio ingresado es: {precio}");
        }
        else
        {
            Console.WriteLine("El precio ingresado no es válido.");
            return;
        }

        Vehiculo vehiculo = new Vehiculo { Placa = placa, Marca = marca, Modelo = modelo, Anio = anio, Precio = precio };
        listaVehiculos.AddLast(vehiculo);

        Console.WriteLine("El vehiculo se agrego correctamente.");
    }

    static void BuscarVehiculoPorPlaca()
    {
        Console.Write("Ingresar la placa del vehiculo a buscar: ");
        string? placa = Console.ReadLine();

        foreach (Vehiculo vehiculo in listaVehiculos)
        {
            if (string.Equals(placa, vehiculo.Placa, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Vehiculo encontrado:");
                Console.WriteLine(vehiculo);
                return;
            }
        }
        Console.WriteLine("Vehiculo no encontrado.");
    }
    static void VerVehiculosPorAnio()
    {
        Console.Write("Ingresar el año del vehiculo a buscar: ");
        string? inputAnio = Console.ReadLine();
        int anio;
        if(int.TryParse(inputAnio, out anio))
        {
            Console.WriteLine($"El año que ingresaste es: {anio}");
        }
        else
        {
            Console.WriteLine("El año que ingresaste no es correcto.");
            return;
        }


        bool encontrado = false;
        foreach (Vehiculo vehiculo in listaVehiculos)
        {
            if (vehiculo.Anio == anio)
            {
                Console.WriteLine(vehiculo);
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("No se han encontrado vehiculos en el año requerido.");
        }
    }
    static void VerTodosLosVehiculosRegistrados()
    {
        if (listaVehiculos.Count == 0)
        {
            Console.WriteLine("No hay vehiculos registrados.");
            return;
        }
        Console.WriteLine("Vehiculos registrados:");
        foreach (Vehiculo vehiculo in listaVehiculos)
        {
            Console.WriteLine(vehiculo);
        }
    }
    static void EliminarVehiculoRegistrado()
    {
        Console.Write("Ingresar la placa del vehiculo a eliminar: ");
        string? placa = Console.ReadLine();

#pragma warning disable CS8600 
        LinkedListNode<Vehiculo> current = listaVehiculos.First;
#pragma warning restore CS8600 
        while (current != null)
        {
            if (!string.IsNullOrEmpty(current.Value?.Placa) && 
    current.Value.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase))
            {
                listaVehiculos.Remove(current);
                Console.WriteLine("El vehiculo ha sido eliminado correctamente.");
                return;
            }
#pragma warning disable CS8600 
            current = current.Next;
#pragma warning restore CS8600 
        }
        Console.WriteLine("El vehiculo no ha sido encontrado.");
    }
}