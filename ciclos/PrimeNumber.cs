/*Problema 3 – Escreva um programa que pede ao utilizador para introduzir um número 
primo. O programa deve repetir o pedido até o utilizador introduzir um número válido.*/

class PrimeNumber{
    public static void PrimeNumber1(){
        while(true){
            Console.WriteLine("Digite um número primo");
            int num= Convert.ToInt32(Console.ReadLine());
            bool isPrime= true;
            for(int i=2; i<num; i++){
                if(num%i==0){
                    isPrime= false;
                }
                if(isPrime){
                    Console.WriteLine($"O número {num} é primo");
                    break;
                }
            }

        }
        
       
    }
}