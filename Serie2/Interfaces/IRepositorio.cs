
using System.Collections.Generic;

namespace Series2.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista(); // metodo que vai retornar uma lista de T
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exlui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}