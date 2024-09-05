using System;
using PracticaPoo;

namespace PracticaPoo
{
    public class Cuadrado{

    private double Lado;

    public void Incializar(){
        Console.WriteLine("Ingrese lado: ");
        Lado = Convert.ToInt32(Console.ReadLine());
    }

    public void Perimetro(){
        Console.WriteLine("El perimetro es: "+Lado*4);
    }

    public void Area(){
        Console.WriteLine("El perimetro es: "+Lado*Lado);
    }

    }
    
}

