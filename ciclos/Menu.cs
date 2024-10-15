class Menu{
    public static void Menu1(){
   
        //ToDo colocar conversão de letras maiúsculas e minúsculas
        while (true) {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Quadrado");
            Console.WriteLine("2-Triângulo");
            Console.WriteLine("3-Circulo");
            Console.WriteLine("4-Sair \n");
            string option = Console.ReadLine().ToUpper();
            if (option == "1" || option=="QUADRADO") {
                Console.WriteLine($"Quadrado= lado*lado \n");
                
            }
            else if (option == "2" || option== "TRIÂNGULO") {
                Console.WriteLine($"Triângulo= pp \n");
                    
            }
            else if(option == "1" || option== "CIRCULO") {
                Console.WriteLine($"Circulo \n");
                
            }
            else if (option == "SAIR") {
                break;
            }
            
        }
    }
}