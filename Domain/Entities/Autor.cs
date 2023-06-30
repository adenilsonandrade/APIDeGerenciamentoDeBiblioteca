namespace Domain.Entities
{
    public class Autor : Entity
    {
        public string Nome { get; set; }
        public List<Livro> Livros { get; } = new();
    }
}