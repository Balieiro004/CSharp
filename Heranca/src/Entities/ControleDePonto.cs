using System;

namespace Heranca.src.Entities
{
    public class ControleDePonto
    {
        public void RegistraEntrada (Gerente g){
            DateTime agora = DateTime.Now;
            string horario = string.Format("{0:d/m/yyyy HH:mm:ss}", agora);

            System.Console.WriteLine($"Entrada: {g.Codigo}")
            System.Console.WriteLine($"Data: {this.horario}");
        }
    }
}