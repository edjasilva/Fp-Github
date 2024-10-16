class Serie1{
    public static void Serie(){
        Console.WriteLine("Digite um número");
        int limit = Convert.ToInt32(Console.ReadLine());
        double result=0.0;
        for(int i=1; i<limit; i++){
            result=result+1/i*(i+1);
        }
        Console.WriteLine($"Resultado: {result}");
    }

}