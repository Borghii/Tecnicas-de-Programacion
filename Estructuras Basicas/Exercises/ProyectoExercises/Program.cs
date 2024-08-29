using System;
using HolaMundo;


namespace HolaMundo{
    class Program
    {
    static void Main(string[] args)
    {
        //ExerciseTwo();
        //ExerciseThree();
        //ExerciseFour();

        //Console.WriteLine(Exercise6.run(29));

        Cuadrado cuad = new Cuadrado();
        cuad.Incializar();
        cuad.Perimetro();
        cuad.Area();
        
    }

    public static void ExerciseTwo(){
        long numero;
        bool esNumeroValido;

        do
        {
            Console.Write("Ingrese un número entero positivo: ");
            esNumeroValido = long.TryParse(Console.ReadLine() ,out numero);
        } while (!esNumeroValido || numero <= 0);

        String result = numero.ToString();

        Console.Write("Tiene "+result.Length+" caracteres");
    }
    
    /*
    3. Cláusula Switch
    Escribir un programa que permita ingresar dos números por teclado y luego indicar
    la operación que se desea realizar entre estos dos números (1-Suma, 2-Resta, 3-
    Multiplicación, 4-División) y calcular el resultado
    */
    public static void ExerciseThree(){

        long firstNumber;
        long secondNumber;

        Boolean isValidFirstNumber;
        Boolean isValidSecondNumber;


        do{
            Console.WriteLine("Ingrese el primer numero: ");
            isValidFirstNumber = long.TryParse(Console.ReadLine() ,out firstNumber);

            Console.WriteLine("Ingrese el segundo numero: ");
            isValidSecondNumber = long.TryParse(Console.ReadLine() ,out secondNumber);

        }while(!isValidFirstNumber || !isValidSecondNumber);

        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);


        bool error;
        do
        {
            error = false;

            Console.WriteLine(("1-Suma, 2-Resta, 3-Multiplicación, 4-División"));
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion){

            case 1:
                Console.WriteLine("La suma es igual a: "+(firstNumber+secondNumber));
                break;
            case 2:
                Console.WriteLine("La resta es igual a: "+(firstNumber-secondNumber));
                break;
            case 3:
                Console.WriteLine("La multiplicacion es igual a: "+(firstNumber*secondNumber));
                break;
            case 4:
                Console.WriteLine("La division es igual a: "+(firstNumber/secondNumber));
                break;
            default:
                Console.WriteLine("Opcion no disponible");
                error = true;
                break;
            }
        }while(error);
    }

        /*
        4. Realizar un programa que permita ingresar n números enteros por el teclado y se
        desea conocer:
            a) La cantidad de números positivos.
            b) La cantidad de números negativos.
            c) La cantidad de números pares.
            d)La cantidad de números impares
    */
}

}