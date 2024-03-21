namespace Diamante_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor ímpar para gerar o diamante:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("O número não é ímpar. Por favor, insira um número ímpar.");
            }
            else
            {
                int espacos = n / 2;
                int asteriscos = 1;

                // Parte superior do diamante
                for (int i = 0; i < (n / 2) + 1; i++)
                {
                    Console.Write(new string(' ', espacos));
                    Console.WriteLine(new string('X', asteriscos));
                    espacos--;
                    asteriscos += 2;
                }

                espacos = 1;
                asteriscos = n - 2;

                // Parte inferior do diamante
                for (int i = (n / 2); i > 0; i--)
                {
                    Console.Write(new string(' ', espacos));
                    Console.WriteLine(new string('X', asteriscos));
                    espacos++;
                    asteriscos -= 2;
                }
            }

            Console.ReadLine();
        }
    }
}
