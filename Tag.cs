namespace Tp1_PlataformasDesarrollo
{
    public class Tag
    {
        public int Id { get; set; }

        public string Palabra { get; set; }

        public Tag() { }
        public Tag(string palabra)
        {
            Palabra = palabra;
        }

        public List<Post> Posts { get; set; }
    }
}