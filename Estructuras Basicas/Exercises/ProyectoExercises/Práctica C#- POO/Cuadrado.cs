using System;

public class Cuadrado{

    private double Lado{get;set;}

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
