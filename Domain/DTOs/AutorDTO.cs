namespace Domain.DTOs
{
    public class AutorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        /* EF Relations */
        public List<LivroDTO> Livros { get; set; }
    }
}