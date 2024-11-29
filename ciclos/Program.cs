// Inicialização do jogo
int playerLife = 100;
int enemyLife = 100;
bool inPlay = true;

Console.WriteLine("Jogo iniciado!");

while (inPlay) {

    //função estado 
    string  Estado(int playerLife, int enemyLife) {
          return $"Vida do jogador: {playerLife}\nVida do Inimigo: {enemyLife}";
    }

    Console.Write("Escolha ação:\n\t0. estado\n\t1. Atacar\n\t2. Defender\n> ");
    int playerAction = Convert.ToInt32(Console.ReadLine());
    switch (playerAction){
        case 0:
            Console.WriteLine(Estado(playerLife, enemyLife));
            break;
        case 1:
            Console.WriteLine("Ataqueeeeee");
            break;
        case 2:
            Console.WriteLine("DEfesaaaaaaaaaa");
            break;
        default:
            Console.WriteLine("Escreva uma opção válida");
            break;


    }

// inimigo um random e duas funçoes caso for 1, caso for 2
    //switch com as opções 
    // Ação do jogador
    
    
/*
    

    // Ataque do jogador este
    if (playerAction == 1) {
        // A expressão new Random().Next(a, b) gera um número aleatório entre a e b-1.
        int damage = new Random().Next(10, 20);  // Dano aleatório entre 10 e 19
        enemyLife -= damage;
        Console.WriteLine($"Ataque com {damage} de dano!\nVida do inimigo: {enemyLife}");
    }

    // Defesa do jogador
    else if (playerAction == 2) {
        Console.WriteLine("Defesa!");
        int healing = new Random().Next(5, 10);  // Cura aleatória entre 5 e 9
        playerLife += healing;
        Console.WriteLine($"Recuperação de {healing}!\nVida restante: {playerLife}");
    }
    else {
        Console.WriteLine("Operação inválida.");
    }

    // Verificar se o inimigo foi derrotado
    if (enemyLife <= 0) {
        Console.WriteLine("Inimigo derrotado! Ganhou!");
        inPlay = false;
    }

    // Ação do inimigo
    int acaoInimigo = new Random().Next(1, 3);

    // Ataque do inimigo este
    if (acaoInimigo == 1) {
        int danoInimigo = new Random().Next(10, 20);
        playerLife -= danoInimigo;
        Console.WriteLine($"Inimigo atacou com {danoInimigo} de dano!\nVida restante: {playerLife}");
    }
    // Defesa do inimigo este
    else {
        Console.WriteLine("Inimigo defende!");
        int curaInimigo = new Random().Next(1, 6);
        enemyLife += curaInimigo;
        Console.WriteLine($"Inimigo recuperou {curaInimigo} de vida!\nVida do inimigo: {enemyLife}");
    }

    // Verificar se o jogador foi derrotado
    if (playerLife <= 0) {
        Console.WriteLine("Foi derrotado! Perdeu!");
        inPlay = false;
    }
    */
}