using System.ComponentModel.DataAnnotations;

namespace Tp1_PlataformasDesarrollo
{
    public class Post
    {
        public int Id { get; set; }

        public string Contenido { get; set; }

        [Display(Name = "Fecha de Tag")]
        public DateTime Fecha { get; set; }

        public Post() { }
        public Post(string contenido, DateTime fecha)
        {
            Contenido = contenido;
            Fecha = fecha;
        }

        public Usuario Usuario { get; set; }

        public List<Comentario> Comentarios { get; set; }

        public List<Reaccion> Reacciones { get; set; }

        public List<Tag> Tags { get; set; }
    }
}