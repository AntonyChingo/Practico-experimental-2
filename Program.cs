using System;
using System.Collections.Generic;

public class Asiento
{
    public int Numero { get; set; }
    public bool EstaAsignado { get; set; }

    public Asiento(int numero)
    {
        Numero = numero;
        EstaAsignado = false;
    }
}

public class Avion
{
    private List<Asiento> asientos;
    private int totalAsientos = 30;

    public Avion()
    {
        asientos = new List<Asiento>();
        for (int i = 1; i <= totalAsientos; i++)
        {
            asientos.Add(new Asiento(i));
        }
    }

    public string AsignarAsiento()
    {
        foreach (var asiento in asientos)
        {
            if (!asiento.EstaAsignado)
            {
                asiento.EstaAsignado = true;
                return $"Asiento {asiento.Numero} asignado con éxito.";
            }
        }
        return "Todos los asientos han sido asignados.";
    }

    public void MostrarAsientos()
    {
        foreach (var asiento in asientos)
        {
            Console.WriteLine($"Asiento {asiento.Numero} - {(asiento.EstaAsignado ? "Asignado" : "Disponible")}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Avion avion = new Avion();
        Console.WriteLine("Asignación de Asientos:");

        for (int i = 0; i < 32; i++) // Intentando asignar 32 asientos, 2 más que el total disponible
        {
            Console.WriteLine(avion.AsignarAsiento());
        }

        Console.WriteLine("\nEstado de los Asientos:");
        avion.MostrarAsientos();
    }
}
