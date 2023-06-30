using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ILivroRepository : IBaseRepository<Livro>
    {
        Task UpdateAsync(Livro entity);
        // Task<Livro> ObterLivroComAutoresAsync(int livroId);
    }
}