using System;
using PracticaPoo;

namespace PracticaPoo{
    class MainExecutor{
    static void Main(string[] args)
    {
        ISeguro vida = new Automovil(180000, 2006);

        Console.WriteLine(vida.CalcularMonto());

        Console.WriteLine(vida.CalcularCuotaMensual());


    }
    }

}