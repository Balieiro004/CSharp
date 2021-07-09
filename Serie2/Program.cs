using System;
using Series2.src;
using Series2.src.Entities;


namespace Series2
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = MenuDeOpcao();

            while(opcaoUsuario != "X"){

                switch(opcaoUsuario){
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        System.Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Escolha outra opção");
                }
                opcaoUsuario = MenuDeOpcao();
            }
        }

        private static string MenuDeOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("Menu de opções: ");
            Console.WriteLine("1 - Listar série");
            Console.WriteLine("2 - Inserir Série");
            Console.WriteLine("3 - Alterar série");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - limpar tela");
            Console.WriteLine("X - Sair");

            string escolha = Console.ReadLine().ToUpper();
            return escolha;
        }

        private static void ListarSeries(){
            Console.WriteLine("Listar Série");
           var lista = repositorio.Lista(); 
           if(lista.Count == 0){
               Console.WriteLine("Nenhuma série cadastrada no momento");
           }

           foreach(var serie in lista){
               var excluido = serie.retornaExcluido();
               Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido" : ""));
           }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir Série");
            int entradeGenero, entradaAno;
            string entradaTitulo, entradaDescricao;
            ChamaSerie(out entradeGenero, out entradaTitulo, out entradaDescricao, out entradaAno);

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradeGenero,
                                        nome: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie(){
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            int entradeGenero, entradaAno;
            string entradaTitulo, entradaDescricao;
            ChamaSerie(out entradeGenero, out entradaTitulo, out entradaDescricao, out entradaAno);

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradeGenero,
                                        nome: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void ExcluirSerie(){
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exlui(indiceSerie);
        }

        private static void VisualizarSerie(){
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }
        private static void ChamaSerie(out int entradeGenero, out string entradaTitulo, out string entradaDescricao, out int entradaAno)
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o genero entre as opções acima: ");
            entradeGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome: ");
            entradaTitulo = Console.ReadLine();
            Console.WriteLine("Informe a descrição: ");
            entradaDescricao = Console.ReadLine();
            Console.WriteLine("Informe o ano: ");
            entradaAno = int.Parse(Console.ReadLine());
        }
    }
}
