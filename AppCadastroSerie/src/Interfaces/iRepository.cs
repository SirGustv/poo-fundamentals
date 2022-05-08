using System.Collections.Generic;

namespace AppCadastroSerie.Interface
{
    public interface iRepository<T>
    {
        List<T> Lista();
        T ReturnById(int id);
        void Insert(T entity);
        void Exclude(int id);
        void Update(int id, T entity);
        int NextId();
    }
}