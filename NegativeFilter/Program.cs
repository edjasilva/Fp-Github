// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

/*
    * Crie uma função que recebe um Array de inteiros (negativos e positivos)
    * e retorna um Array com os números negativos filtrados.
    * Exemplo: Input: [-1, 0, 1, 2, 3] -> Resultado: [0, 1, 2 ,3]
*/


class NegativeFilter {

    public static int[] negativeFilter(int[] numbers) {
        // Your code goes here...
        int[] aux = new int[numbers.Length];
        int count=0;
        for(int i=0; i<numbers.Length; i++) {
            if(!(numbers[i]<0)){
                aux[i]= numbers[i];
                count++;
                
            }
            
        }

        int []result= new int [count];
        for(int i =0; i<count; i++){
            result[i]= aux[i];
        }

        return result;
    }


    public static void Main(string[] args) {
        
        Console.WriteLine();
        Console.WriteLine("******Filtro de números negativos******");

        int count=0;
        if (!negativeFilter([-1, 0, 1, 2, 3]).SequenceEqual([1, 2, 3]) ) count++;
        if (!negativeFilter([-1, -5, -2, -3]).SequenceEqual([]) ) count++;
        if (!negativeFilter([0, -1, -2, 4, 5, -3, 3, 4, -4]).SequenceEqual([4, 5, 3, 4]) ) count++;

        Console.WriteLine(">>> " + count + " Erros de 3");
        Console.WriteLine();
    }
}