namespace JCD1._5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas entradas você deseja fazer?");
            int numeroDeEntradas = Convert.ToInt32(Console.ReadLine());

            // Criar um array para armazenar as informações
            string[] informacoes = new string[numeroDeEntradas];

            // Preencher o array com as informações fornecidas pelo usuário
            for (int i = 0; i < numeroDeEntradas; i++)
            {
                Console.Write($"Digite a informação {i + 1}: ");
                informacoes[i] = Console.ReadLine();
            }

            do
            {
                // Solicitar ao usuário a posição da informação desejada
                Console.Write("Digite o número da informação que deseja recuperar (1 a {0}): ", numeroDeEntradas);
                int posicao = Convert.ToInt32(Console.ReadLine());

                // Verificar se a posição fornecida é válida
                if (posicao >= 1 && posicao <= numeroDeEntradas)
                {
                    // Recuperar e exibir a informação correspondente
                    Console.WriteLine($"Informação {posicao}: {informacoes[posicao - 1]}");
                }
                else
                {
                    Console.WriteLine("Posição inválida. Tente novamente.");
                }

                // Perguntar se o usuário deseja fazer outra recuperação
                Console.Write("Deseja fazer outra recuperação? (S/N): ");
            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}