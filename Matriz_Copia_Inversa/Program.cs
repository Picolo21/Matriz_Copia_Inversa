internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[3, 3];

        Console.Write("Aperte ENTER para começar a inserir os valores na matriz");
        Console.ReadKey();

        char escolha;
        do
        {
            Console.Clear();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"Digite um valor na posição mat[{i}, {j}] = ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            double[,] matI = new double[3, 3];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    matI[((mat.GetLength(0) - 1) - i), ((mat.GetLength(1) - 1) - j)] = mat[i, j];
                }
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j].ToString().PadRight(5) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(matI[i, j].ToString().PadRight(5) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Deseja preencher uma nova matriz [Y / N]? ");
            escolha = char.Parse(Console.ReadLine());
        } while ((escolha.Equals('y')) || (escolha.Equals('Y')));
        Console.WriteLine();

        Console.WriteLine("Fim do programa!");
    }
}