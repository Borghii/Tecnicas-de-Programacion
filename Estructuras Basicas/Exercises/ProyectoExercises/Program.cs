using System;

class Program
{
    static void Main(string[] args)
    {
        ExerciseTwo();
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
    
    
    
}

