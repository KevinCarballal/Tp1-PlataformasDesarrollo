using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_PlataformasDesarrollo
{
    public class RedSocial
    {
        public List<Usuario> usuarios;

        private int IdUsuarios;

        private Usuario usuarioLogged;

        public RedSocial()
        {
            usuarios = new List<Usuario>();
            IdUsuarios = 0;

        }

        public List<Post> Pots { get; set; }

        public List<Tag> Tags { get; set; }

        public Usuario UsuarioActual { get; set; }

        public void agregarUsuario(string user, string pass)
        {
            usuarios.Add(new Usuario(user, pass));

        }
        public void agregarUsuario(Usuario user)
        {
            Usuario otro = new Usuario(user.Nombre, user.Password);
            usuarios.Add(otro);
            IdUsuarios++;
            otro.id = IdUsuarios;
        }
        public bool iniciarSesion(string usuario, string pass)
        {
            bool encontre = false;
            foreach (Usuario user in usuarios)
            {
                if (user.Nombre.Equals(usuario) && user.Password.Equals(pass))
                {
                    encontre = true;
                    usuarioLogged = user;
                }
            }
            return encontre;
        }
        public List<Usuario> obtenerUsuarios()
        {
            return usuarios;
        }
        public void agregarAmigo(Usuario amigo)
        {
            if (usuarioLogged != null)
            {
                usuarioLogged.Amigos.Add(amigo);
            }
        }
    }
}
