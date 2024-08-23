using System;
using System.Security.AccessControl;

/*

5. Cláusula Do while
En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta
corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
finalizar al ingresar un valor negativo en el número de cuenta.
    Se pide realizar un programa que lea los datos de las cuentas corrientes e informe:
    a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo,
    sabiendo que:
        Estado de la cuenta 'Acreedor' si el saldo es >0.
        'Deudor' si el saldo es <0.
        'Nulo' si el saldo es =0.
    b) La suma total de los saldos acreedores.

*/

namespace HolaMundo{
    class Exercise5{
    public static void run(){

        int accountNumber=0;
        int acreedor=0;
        int saldo=0;
        
        do{
            Console.WriteLine("Ingrese el numero de cuenta: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el saldo: ");
            saldo = Convert.ToInt32(Console.ReadLine());

    


        }while(accountNumber>0);




    }

    }

}