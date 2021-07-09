namespace Heranca.src.Entities
{
    public class Telefonista: Funcionario
    {
        public int EstacaoDeTrabalho {get; set;}
        
        public override void DadosFuncionario(){
            base.DadosFuncionario();
            System.Console.WriteLine($"Estação de Trabalho: {this.EstacaoDeTrabalho}");
        }
    }
}