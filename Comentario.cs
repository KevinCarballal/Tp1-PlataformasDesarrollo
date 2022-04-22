using System.ComponentModel.DataAnnotations;

namespace Tp1_PlataformasDesarrollo
{
    public class Comentario
    {
        
        public int Id { get; set; }

        public string Contenido { get; set; }

        [Display(Name = "Fecha de Comentario")]
        public DateTime FechaComentario { get; set; }

        public Comentario() { }
        public Comentario(string contenido, DateTime fecha)
        {
            Contenido = contenido;
            FechaComentario = fecha;
        }

        public Usuario Usuario { get; set; }

        public Post Post { get; set; }
    }
}