using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        // Task<Usuario> ObterUsuarioComLivrosAsync(int livroId);
    }
}