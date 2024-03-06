using System;

class Vehiculo
{
    public virtual void Conducir()
    {
        Console.WriteLine("Conduciendo un vehículo...");
    }
}

class Carro : Vehiculo
{
    public override void Conducir()
    {
        Console.WriteLine("Conduciendo un carro...");
    }
}

class Camion : Vehiculo
{
    public override void Conducir()
    {
        Console.WriteLine("Conduciendo un camión...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehiculo vehiculo;

        vehiculo = new Carro();
        vehiculo.Conducir(); // Salida: Conduciendo un carro...

        vehiculo = new Camion();
        vehiculo.Conducir(); // Salida: Conduciendo un camión...
    }
}
