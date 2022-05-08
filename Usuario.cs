using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_PlataformasDesarrollo
{
    public class Usuario
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo{0} es requerido")]
        [MinLength(7, ErrorMessage = "El campo{0} admite un mínimo de {1} caracteres")]
        [MaxLength(9, ErrorMessage = "El campo{0} admite un máximo de {1} caracteres")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "El campo{0} admite sólo caracteres numericos")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "El campo{0} es requerido")]
        [MinLength(3, ErrorMessage = "El campo{0} admite un mínimo de {1} caracteres")]
        [MaxLength(30, ErrorMessage = "El campo{0} admite un máximo de {1} caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo{0} admite sólo caracteres alfabéticos")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo{0} es requerido")]
        [MinLength(3, ErrorMessage = "El campo{0} admite un mínimo de {1} caracteres")]
        [MaxLength(30, ErrorMessage = "El campo{0} admite un máximo de {1} caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo{0} admite sólo caracteres alfabéticos")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [RegularExpression(@"[0-9 a-zA-Z áéíóú ._-]{3,50}\@[0-9 a-zA-Z áéíóú .]{8,20}", ErrorMessage = "El {0} admite la siguiente estructura ejemplo@ejemplo.com")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public string Password { get; set; }

        public int IntentosFallidos { get; set; }

        public bool Bloqueado { get; set; }

        public Usuario() { }
        public Usuario(int id,string nombre, string apellido, string dni, string pass, string mail)
        {
            Id = id;    
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            
            Password = pass;
            Email = mail;

        }

        public List<Usuario> Amigos { get; set; }

        public List<Post> MisPost { get; set; }

        public List<Comentario> MisComentarios { get; set; }

        public List<Reaccion> MisReacciones { get; set; }

       
    }
}
