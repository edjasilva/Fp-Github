//Escreva um programa que leia um número inteiro e imprima todos os números pares entre 0 e esse número.
class EvenNumber{
    public static void EvenNumber1(){
        Console.WriteLine("Introduza um número");
        int num= Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<num; i+=2){
            Console.WriteLine(i);

        }
        
    }

}

