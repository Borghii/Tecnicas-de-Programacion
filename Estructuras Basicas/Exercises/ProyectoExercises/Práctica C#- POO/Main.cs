using System;
using PracticaPoo;

namespace PracticaPoo{
    class MainExecutor{
    static void Main(string[] args)
    {

       /*Cuenta cuenta = new Cuenta(30000);
        Cliente cliente = new Cliente("44994806","Tomas","Borghi",cuenta);

        Cuenta cuenta2 = new Cuenta(7675.76);
        Cliente cliente2 = new Cliente("44994809","Leonel","Borghi",cuenta2);


        cliente.MostrarSaldo();
        cliente2.MostrarSaldo();

        Complejo a = new Complejo(10,12);
        Complejo b = new Complejo(4,6);
    

        Console.WriteLine(a);
        Console.WriteLine(b);


        Complejo suma = a+b;
        Complejo resta = a-b;

        Console.WriteLine("La suma es: "+suma+" la resta es: "+resta);
        */

    
        List<Herramientas> herramientas = new List<Herramientas>();


        Instrumentos calibreDigital = new Instrumentos{

            Codigo = "34234",
            Descripcion = "Calibre marca Luqstoff",
            FechaUltimaMod = new DateTime(2024,7,27),
            UnidadMedida = "Metros",
            MesesCalibracion = 1

        };

        Maquinas sopladora = new Maquinas(){
            Codigo = "12345",
            Descripcion = "Calibre marca Luqstoff",
            FechaUltimaMod = new DateTime(2025,7,27,2,3,4),
            CantidadUso = 0,
            HsCalibracion = 20
        };

        herramientas.Add(calibreDigital);

        herramientas.Add(sopladora);


        //Console.WriteLine(calibreDigital.NecesitaMM(new DateTime(2024,2,27)));
        //Console.WriteLine(sopladora.NecesitaMM(new DateTime(2024,2,27)));

        foreach (Herramientas herramientas1 in herramientas)
        {
            Console.WriteLine("Codigo de producto: "+herramientas1.Codigo+" Mantenimiento: " +herramientas1.NecesitaMM(new DateTime(2024,10,27)));
        }


    }
    }

}