using System;
using System.Collections;

namespace CadastroMatriz
{
    class Program
    {

        static String[,] listaNome = new string[3, 2];
        enum Menu {Adicionar = 1, ListaCompleta, ListarLinha, ListarColuna, Pesquisa, Ordenar, Sair };
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Menu de opções");
                Console.WriteLine("1-Adicionar\n2-Lista Completa\n3-Lista Linha\n4-Lista Coluna\n5-Pesquisa\n6-Ordenar\n7-Sair");
                Menu op = (Menu)int.Parse(Console.ReadLine());
                switch (op)
                {
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.ListaCompleta:
                        ListarCompleto();
                        break;
                    case Menu.ListarLinha:
                        ListarLinha();
                        break;
                    case Menu.ListarColuna:
                        ListarColuna();
                        break;
                    case Menu.Pesquisa:
                        PesquisaNome();
                        break;
                    case Menu.Ordenar:
                        OrdenarLinha();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida, escolha outra.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void Adicionar()
        {
            Console.WriteLine("Adicionar");
            for (int linha = 0; linha < listaNome.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < listaNome.GetLength(1); coluna++)
                {
                    Console.Write($"Nome [{linha}][{coluna}]: ");
                    listaNome[linha, coluna] = Console.ReadLine();
                }
            }
        }
        public static void ListarCompleto()
        {
            if(listaNome[0,0] == null)
            {
                Console.WriteLine("Lista Vazia");
            }
            else
            {
                Console.WriteLine("Lista completa");
                for (int linha = 0; linha < listaNome.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < listaNome.GetLength(1); coluna++)
                    {
                        Console.Write($" {listaNome[linha, coluna]}");
                    }
                    Console.Write("\n");
                }
            }


        }
        public static void ListarLinha()
        {
            Console.Write("informe a linha que deseja exibir: ");
            int linhaExbibicao = int.Parse(Console.ReadLine());

            if (listaNome[0, 0] == null)
            {
                Console.WriteLine("Lista Vazia");
            }
            else
            {
                for (int linha = 0; linha < listaNome.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < listaNome.GetLength(1); coluna++)
                    {
                        if (linhaExbibicao == linha)
                        {
                            Console.Write($" {listaNome[linha, coluna]}");
                        }
                    }

                }
            }

        }
        public static void ListarColuna()
        {
            Console.WriteLine("Listar coluna");
            Console.Write("Informe a coluna que deseja exibir: ");
            int exibirColuna = int.Parse(Console.ReadLine());

            if (listaNome[0, 0] == null)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                for (int linha = 0; linha < listaNome.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < listaNome.GetLength(1); coluna++)
                    {
                        if (coluna == exibirColuna)
                        {
                            Console.Write($" {listaNome[linha, coluna]}");
                        }
                    }
                    Console.Write("\n");
                }
            }           
        }
        public static void PesquisaNome()
        {
            if (listaNome[0, 0] == null)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Console.WriteLine("Pesquisa");
                Console.Write("Nome: ");
                String pesquisaNome = Console.ReadLine();
                int cont = 0;

                for (int linha = 0; linha < listaNome.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < listaNome.GetLength(1); coluna++)
                    {
                        if (pesquisaNome == listaNome[linha, coluna])
                        {
                            Console.WriteLine($"Posição[{linha}][{coluna}]: {listaNome[linha, coluna]}");
                            cont++;
                        }
                    }
                }
                if (cont == 0)
                {
                    Console.WriteLine("O nome não está na matriz.");
                }

            }
        }
        public static void OrdenarLinha()
        {
              
        }
    }
}


