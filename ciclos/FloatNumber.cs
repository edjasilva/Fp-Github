/*Escreva um programa que permite introduzir um número real por linha até
encontrar uma linha vazia. O programa mostra a média do valores introduzidos
*/

using System.Globalization;

class FloatNumber{
    public static void FloatNumber1(){
        Console.WriteLine("Digite um número real");
        int count=0;
        double avg=0.0;
        double sum=0.0;
        
        
        while(true){
             string input= Console.ReadLine();

              if (string.IsNullOrWhiteSpace(input)) { // Verifica se a entrada é uma linha vazia ou contém apenas espaços
                break; 
            }

            if(double.TryParse(input, out double num)){
                count++;
                sum=sum+num;

            }
                
            
            else if(num==0){
                break;
            }
            
            
            
        }
        avg=sum/count;
            Console.WriteLine($"O valor de count é {count}");
            Console.WriteLine($"A média é {avg} ");     
        

        }

    }
