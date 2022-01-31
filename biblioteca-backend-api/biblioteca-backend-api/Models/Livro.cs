namespace biblioteca_backend_api.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
    }
}

