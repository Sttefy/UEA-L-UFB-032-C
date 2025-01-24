using System;

namespace EstructuradeDatos
{
    public class Vehiculo
    {
        public string Placa { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;

        public Vehiculo(string placa, string marca, string modelo)
        {
            if (string.IsNullOrWhiteSpace(placa) || string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo))
            {
                throw new ArgumentException("Ningún valor puede ser nulo o vacío.");
            }

            Placa = placa;
            Marca = marca;
            Modelo = modelo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese la placa del vehículo:");
                string? placa = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(placa))
                {
                    throw new ArgumentException("La placa no puede estar vacía.");
                }

                Console.WriteLine("Ingrese la marca del vehículo:");
                string? marca = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(marca))
                {
                    throw new ArgumentException("La marca no puede estar vacía.");
                }

                Console.WriteLine("Ingrese el modelo del vehículo:");
                string? modelo = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(modelo))
                {
                    throw new ArgumentException("El modelo no puede estar vacío.");
                }

                Vehiculo vehiculo = new Vehiculo(placa, marca, modelo);
                Console.WriteLine($"Vehículo registrado: {vehiculo.Placa}, {vehiculo.Marca}, {vehiculo.Modelo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
