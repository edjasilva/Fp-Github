//Calcule o fatorial de um número sem recorrer a funções de Math

class Fatorial{
    public static void Fatorial1(){
        Console.WriteLine("Digite um número");
        int num = Convert.ToInt32(Console.ReadLine());
        int fat=1;
        for(int i =num; i>0; i--){
            fat*=i;
        }
        Console.WriteLine($"O fatorial de {num} é {fat}");
        
    }
}