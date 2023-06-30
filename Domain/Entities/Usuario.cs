namespace Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }
    }
}