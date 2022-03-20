using System;

namespace ExAluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeQuartos = 9;
            DadosPessoais[] cliente = new DadosPessoais[quantidadeQuartos];
            Console.WriteLine("Quantos quartos vão ser alugados? ");
            int quantidade = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < quantidade; cont++)
            {
                Console.WriteLine($"Aluguel #{cont}");
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Email: ");
                String email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                cliente[quarto] = new DadosPessoais(nome, email, quarto);
            }


            for(int cont = 0; cont <= quantidade; cont++)
            {
                if (cliente[cont] == null) 
                {

                }else
                {
                    Console.WriteLine(cliente[cont].ToString());
                }

            }
        }
    }
}
