using System;

namespace PrimeiroProjeto
{
    class Program
    {
        enum Menu {Listar = 1, Adicionar, Apagar, Entrada, Saida, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while(!escolheuSair)
            {
                Console.WriteLine("Menu de opções");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Apagar\n4-Entrada\n5-Saída\n6-Sair");
                Menu op = (Menu)int.Parse(Console.ReadLine());

                switch (op) 
                {
                    case Menu.Listar:
                        break;
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Apagar:
                        break;
                    case Menu.Entrada:
                        break;
                    case Menu.Saida:
                        escolheuSair = true;
                        break;
                    case Menu.Sair:
                        break;
                    default:
                        Console.WriteLine("Opção invalida, escolha outra");
                        break;
                }
                Console.WriteLine("Tecle Enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void Adicionar()
        {

        }
    }
}
