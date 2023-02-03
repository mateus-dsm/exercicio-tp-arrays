internal class Program
{
    public static int[] retornaRanks(int[] pontuacoes)
    {
        int[] ranks = new int[pontuacoes.Length];
        for(int i = 0; i < pontuacoes.Length; i++)
        {
            int rank = 1;
            foreach (int elemento in pontuacoes)
            {
                if(elemento > pontuacoes[i]) rank++;
            }
            ranks[i] = rank;
        }
        return ranks;
    }

    static void Main(string[] args)
    {
        int[] ints = { 1, 2, 2, 1 };
        int[] ints2 = retornaRanks(ints);
        foreach (int elemento in ints2) Console.WriteLine(elemento);
    }
}
