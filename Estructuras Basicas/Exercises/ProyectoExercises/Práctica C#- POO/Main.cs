using System;
using PracticaPoo;

namespace PracticaPoo{
    class MainExecutor{
    static void Main(string[] args)
    {

        Cuenta cuenta = new Cuenta(30000);
        Cliente cliente = new Cliente("44994806","Tomas","Borghi",cuenta);

        Cuenta cuenta2 = new Cuenta(7675.76);
        Cliente cliente2 = new Cliente("44994809","Leonel","Borghi",cuenta2);


        cliente.MostrarSaldo();
        cliente2.MostrarSaldo();

    }
    }

}