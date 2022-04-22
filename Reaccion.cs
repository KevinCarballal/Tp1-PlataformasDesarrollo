using System.ComponentModel.DataAnnotations;

namespace Tp1_PlataformasDesarrollo
{
    public class Reaccion
    {
        
        public int Id { get; set; }

        public enum Tipo
        {
            Me_Gusta = 1,
            Me_Encanta = 2,
            Me_Importa = 3,
            Me_Divierte = 4,
            Me_Asombra = 5,
            Me_Entristece = 6,
            Me_Enoja = 7,
        }

        public Usuario Usuario { get; set; }

        public Post Post { get; set; }
    }
}