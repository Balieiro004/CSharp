namespace ex6.src.Entities
{
    public class Funcionarios
    {
        public string Nome;
        public double Salario;
        public static double ValeRefeicaoDiario;

        public static void ReajusteValeRefeicao(double taxa){
            Funcionarios.ValeRefeicaoDiario = Funcionarios.ValeRefeicaoDiario * taxa;
        }
    }
}