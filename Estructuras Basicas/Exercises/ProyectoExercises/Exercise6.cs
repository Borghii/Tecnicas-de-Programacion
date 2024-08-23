using System;
using System.Security.AccessControl;

/*

6. Cláusula While
    Escribir un algoritmo que implemente la búsqueda binaria de un número dentro de
    una lista de números.
    El algoritmo de búsqueda binaria es un excelente método para buscar datos dentro de
    una estructura. Se le da el nombre de búsqueda binaria porque el algoritmo divide en
    dos el arreglo, aludiendo al concepto de bit, el cual puede tener dos estados.
    La única condición para usar este algoritmo es que los datos dentro del arreglo estén
    ordenados de menor a mayor.
    La solución más fácil para realizar una búsqueda es por fuerza bruta, pero este método
    puede resultar bastante ineficiente cuando se tiene una gran cantidad de datos, ya que
    habría que buscar posición por posición hasta encontrar el dato que queremos.
    El código por fuerza bruta es bastante sencillo:
    for(int i=0; i<Arreglo.length; i++)
    if(Arreglo[i] == elemento)
    System.out.println("\nElemento encontrado en la posicion: " + i);
    Solo se recorre todo el arreglo y verificamos si la posición i es igual al dato que
    queremos buscar, el código anterior se puede mejorar simplemente agregándole una
    bandera, pero aun así no es lo suficientemente bueno.
    El algoritmo de búsqueda binaria es el siguiente:
    1. Se declaran los índices superior e inferior. El inferior en 0 y el superior
    con el tamaño del arreglo menos 1.
    2. Se calcula el centro del arreglo con la siguiente formula: centro =
    (superior + inferior) / 2
    3. Verificamos si el arreglo en la posición centro es igual al dato que
    buscamos. Si es igual significa que encontramos el dato y retornamos centro.
    4. Si son diferentes verificamos si el arreglo en la posición centro es
    mayor al dato que queremos buscar. Si es mayor actualizamos superior:
    superior = centro - 1, si no actualizamos inferior: inferior = centro + 1.
    5. Volvemos al paso 2.
    Si cuando ya no se cumpla la condición del ciclo y no se encontró el dato retornamos
    -1 indicando que el dato no se encuentra en el arreglo

*/

namespace HolaMundo{
    class Exercise6{
    public static int run(int number){

        int [] array = new int[] {1,3,4,5,9,34};
        int idxInferior=0;
        int idxSuperior=array.Length-1;

        int centro = (idxInferior+idxSuperior)/2;

        if(array[centro]==number)return centro;
        
        while(idxInferior<idxSuperior){

            
            if(centro>number){
                idxSuperior=centro-1;
            }else{
                idxInferior=centro+1;
            }

            centro = (idxInferior+idxSuperior)/2;

            if(array[centro]==number)return centro;
        }
        return -1;
    }



    }

}