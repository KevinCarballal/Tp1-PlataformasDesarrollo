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

        public List<Post> Posts { get; set; }

        public List<Tag> Tags { get; set; }

        public Usuario UsuarioActual { get; set; }

        /*public void agregarUsuario(string user, string apellido, string dni, string pass, string mail)
        {
            usuarios.Add(new Usuario(id, user, apellido, dni, pass, mail));

        }*/

        public void agregarUsuario( Usuario user)
        {
            
            Usuario otro = new Usuario(user.Id, user.Nombre, user.Apellido,  user.Email, user.Password, user.Dni);
            usuarios.Add(otro);
            IdUsuarios++;
            user.Id = IdUsuarios;
            
            MessageBox.Show(usuarios[0].Nombre);
            MessageBox.Show(usuarios[0].Password);
            MessageBox.Show(usuarios.Count.ToString());


        }
        public bool iniciarSesion(string usuario, string pass)
        {
            bool encontre = false;
            MessageBox.Show(usuarios.Count.ToString());
            MessageBox.Show(usuario, pass);

            foreach (Usuario user in usuarios)
            {
                if (user.Nombre.Equals(usuario) && user.Password.Equals(pass))
                {
                    
                    encontre = true;
                    
                }
                return encontre;
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
        
        public void EliminarUsuario()
        {
            usuarioLogged = null;
        }
        public void CerrarSesion()
        {
            usuarioLogged = null;
        }
        public void QuitarAmigo(in Usuario ExAmigo)
        {
            //Quita el usuario UsuarioActual de la lista de amigos de
            //ExAmigo y a la vez quita ExAmigo de la lista de amigos del usuario UsuarioActual.
        }
        public void Postear(in Post post, in Tag tag )
        {
            /*Agrega el Post p a la lista de posts, agrega el post a la lista del
            usuario UsuarioActual. Revisa los tags, si no están en la lista de tags los agrega, luego para cada
            tag agrega el post p a su lista de posts y agrega los tags en t a la lista de tags del post p.*/
        }
        public void ModificarPost(in Post post)
        {
            //Idem modificar usuario pero con datos de post.
        }
        public void EliminarPost(in Post post)
        {
            //Elimina comentarios y reacciones asociadas a p, luego elimina el post.
        }
        public void Comentar(in Post post, in Comentario comentario)
        {
            //Alta de comentario c del UsuarioActual en el post p.
        }
        public void ModificarComentario(in Comentario comentario)
        {
            //Idem modificar usuario pero con datos de comentario.
        }
        public void QuitarComentario(in Post post, in Comentario comentario)
        {
            //Elimina el comentario c en el post p.
        }
        public void Reaccionar(in Post post, in Reaccion reaccion)
        {
            //Alta de reacción r del UsuarioActual en el post p.
        }
        public void ModificarReaccion(in Reaccion reaccion)
        {
            //Idem modificar usuario pero con datos de reacción.
        }
        public void QuitarReaccion(in Post post, in Reaccion reaccion)
        {
            //Elimina la reacción r del post p.
        }
        public void MostrarDatos()
        {
            //Muestra los datos del usuario UsuarioActual. Devuelve un usuario.
        }
        public void MostrarPost()
        {
            //Muestra los posts del usuario UsuarioActual. Devuelve una lista de posts.
        }
        public void MostrarPostAmigos()
        {
            //Muestra los posts de los amigos del usuario UsuarioActual. Devuelve
            //una lista de posts.
        }
        public void BuscarPost(in string Contenido, in DateTime FechaDesde, in DateTime FechaHasta, in Tag tags)
        {
            /*El
            usuario puede buscar posts por contenido, fecha (desde/hasta) o por los tags. El sistema revisa
            cada uno de estos inputs, si es nulo lo saltea. El filtrado se realiza sobre la lista completa de
            posts. Devuelve una lista de posts (filtrada).*/
        }

    }
}
