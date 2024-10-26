class Problem{
    public static void Problem4() {
        // Escreva um programa que permite introduzir um número real por linha até encontrar uma linha vazia. O programa mostra a média do valores introduzidos.
        double values = 0.0;
        int counter = 0;
        while (true) {
            string line = Console.ReadLine();
            if (line.Length == 0) {
                // Mostrar a média!
                Console.WriteLine($"Média: {values / counter}");
                break;
            }
            else {
                // Somar valores.
                values += Convert.ToDouble(line);
                // Aumentar a contagem.
                counter++;
            }
        }
    }
}