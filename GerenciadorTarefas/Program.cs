using System.Reflection;
using System.Runtime.CompilerServices;



public class Program
{
    private static Task CreateTask(string description) => new(description); 
   public static void Main(string[] args){

    List<Task> tasks = [];

    while(true){
        string line = Console.ReadLine();
        string command = line.Split([' '], 2)[0];

        if(command=="RT"){
            string description = line.Split([' '], 2)[1];

            Task newTask = CreateTask(description);
            tasks.Add(newTask);
            Console.WriteLine($"Tarefa criada com o id {newTask.Id}");

        }
        
        else if(command== "LT"){

        }else if(command=="MT"){

        }else if(command=="Q"){
            break;
        }else{
            Console.WriteLine("Opção inválida.");
        }

    }

        



   }


}
  