namespace CursoNelio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao aluguel de carros");
            Console.WriteLine("1- Ver os carros disponiveis");
            Console.WriteLine("2- sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {
                Console.WriteLine("os carros disponiveis são: ");
                Console.WriteLine("1- Toyota Corolla 2022");
                Console.WriteLine("2. Honda Civic 2023");
                Console.WriteLine("3. Ford Mustang 2021");
                Console.WriteLine("4. Chevrolet Camaro 2022");
                Console.WriteLine("5. Volkswagen Golf 2023");
                int carro = int.Parse(Console.ReadLine());
                if (carro == 1)
                {
                    Console.WriteLine("voce alugou o carro, parabens");
                    return;
                }
                else if(carro == 2)
                {
                    Console.WriteLine("voce alugou o carro, parabens");
                    return;
                }
                else if (carro == 3)
                {
                    Console.WriteLine("voce alugou o carro, parabens");
                    return;
                }
                else if (carro == 4)
                {
                    Console.WriteLine("voce alugou o carro, parabens");
                    return;
                }
                else if (carro == 5)
                {
                    Console.WriteLine("voce alugou o carro, parabens");
                    return;
                }
                else
                {
                    Console.WriteLine("algo está incorreto");
                }
            }
            else if (opcao == 2)
            {
                Console.WriteLine("encerrando programa");
                return;
            }
            else
            {
                Console.WriteLine("escolha uma opção correta por favor!");
            }

        }
    }
}
