using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCaoEmEquilibrio.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> Listar();
        Task Inserir(TEntity e);
        Task<TEntity> BuscarPorId(int id);
        Task Editar(int id, TEntity e);
        Task Excluir(int id);
        Task<bool> Existe(int id);

    }
}
