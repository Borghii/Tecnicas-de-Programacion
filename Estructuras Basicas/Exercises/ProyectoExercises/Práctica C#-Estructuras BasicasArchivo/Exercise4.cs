using System;

namespace HolaMundo{
    class Exercise4{

    public static void run(){
        int nNumbers;
        bool isNumber;

        do{
            Console.WriteLine("Ingrese la cantidad de numeros a ingresar: ");
            isNumber = int.TryParse(Console.ReadLine() ,out nNumbers);
        }while(!isNumber);

        int number;
        int positive=0;
        int negative=0;
        int pair=0;
        int odd=0;

        for (int i = 0; i < nNumbers; i++)
        {
            Console.WriteLine("Ingrese el numero "+i+" :");
            if(!int.TryParse(Console.ReadLine() ,out number))continue;
            if(number>=0){
                positive++;
            }else{ 
                negative++;
            };

            if(number%2==0){
                pair++;
            }else{
                odd++;
            }
        }
        Console.WriteLine("positivos: "+positive+" negativos: "+negative+" pares: "+pair+" impares: "+odd);
    }

    }

}
