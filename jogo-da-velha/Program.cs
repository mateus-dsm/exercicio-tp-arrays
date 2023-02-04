internal class Program
{
    static bool GameOver(int[,] jogoDaVelha)
    {
        for (int i = 0; i < 3; i++)
        {
            if (jogoDaVelha[i, 0] == jogoDaVelha[i, 1] && jogoDaVelha[i, 0] == jogoDaVelha[i, 2] && jogoDaVelha[i, 0] != 0)
            {
                Console.WriteLine($"O jogador {jogoDaVelha[i, 0]} ganhou!");
                return true;
            }
        }
        for (int j = 0; j < 3; j++)
        {
            if (jogoDaVelha[0, j] == jogoDaVelha[1, j] && jogoDaVelha[0, j] == jogoDaVelha[2, j] && jogoDaVelha[0, j] != 0)
            {
                Console.WriteLine($"O jogador {jogoDaVelha[0, j]} ganhou!");
                return true;
            }
        }
        if (jogoDaVelha[0, 0] == jogoDaVelha[1, 1] && jogoDaVelha[0, 0] == jogoDaVelha[2, 2] && jogoDaVelha[0, 0] != 0)
        {
            Console.WriteLine($"O jogador {jogoDaVelha[0, 0]} ganhou!");
            return true;
        }
        else if (jogoDaVelha[0, 2] == jogoDaVelha[1, 1] && jogoDaVelha[0, 2] == jogoDaVelha[2, 0] && jogoDaVelha[0, 2] != 0)
        {
            Console.WriteLine($"O jogador {jogoDaVelha[0, 2]} ganhou!");
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[,] jogoDaVelha = new int[3, 3];

        bool gameOver = false;
        bool vezJogador1 = true;
        while(!gameOver)
        {
            if (vezJogador1)
            {
                bool repetirJogada = true;
                do
                {
                    Console.WriteLine("Jogador 1, digite a posicao da sua jogada (linha e depois coluna): ");
                    int.TryParse(Console.ReadLine(), out int linha);
                    int.TryParse(Console.ReadLine(), out int coluna);
                    if (jogoDaVelha[linha, coluna] != 0) Console.WriteLine("Essa posicao ja esta ocupada!");
                    else
                    {
                        jogoDaVelha[linha, coluna] = 1;
                        repetirJogada = false;
                    }
                } while (repetirJogada);
                vezJogador1 = false;
            }
            else
            {
                bool repetirJogada = true;
                do
                {
                    Console.WriteLine("Jogador 2, digite a posicao da sua jogada (linha e depois coluna): ");
                    int.TryParse(Console.ReadLine(), out int linha);
                    int.TryParse(Console.ReadLine(), out int coluna);
                    if (jogoDaVelha[linha, coluna] != 0) Console.WriteLine("Essa posicao ja esta ocupada!");
                    else
                    {
                        jogoDaVelha[linha, coluna] = 2;
                        repetirJogada = false;
                    }
                } while (repetirJogada);
                vezJogador1 = true;
            }

            Console.WriteLine();
            Console.WriteLine($"{jogoDaVelha[0, 0]} {jogoDaVelha[0, 1]} {jogoDaVelha[0, 2]}");
            Console.WriteLine($"{jogoDaVelha[1, 0]} {jogoDaVelha[1, 1]} {jogoDaVelha[1, 2]}");
            Console.WriteLine($"{jogoDaVelha[2, 0]} {jogoDaVelha[2, 1]} {jogoDaVelha[2, 2]}");

            gameOver = GameOver(jogoDaVelha);
        }
    }
}