using System.Collections.Generic;
using Restaurante.Objetos;

namespace RestauranteG1.Logica
{
    internal class Estructuras
    {
        // La lista se crea aquí, una sola vez, y es compartida por todos los formularios
        private static List<Usuario> listaUsuarios = new List<Usuario>();
        private static List<Roles> listaRoles = new List<Roles>();

        public void AgregarUsuario(Usuario miUsuario)
        {
            listaUsuarios.Add(miUsuario);
        }

        public Usuario buscarUsuario(int id)
        {
            foreach (Usuario miUsuario in listaUsuarios)
            {
                if (miUsuario.id == id)
                {
                    return miUsuario;
                }
            }

            return null;
        }

        public Usuario buscarUsuario(string nombre)
        {
            foreach (Usuario miUsuario in listaUsuarios)
            {
                if (miUsuario.nomUsr == nombre)
                {
                    return miUsuario;
                }
            }

            return null;
        }

        public void modificarUsuario(Usuario miUsuario)
        {
            Usuario encontrado = buscarUsuario(miUsuario.id);

            if (encontrado != null)
            {
                encontrado.nomUsr = miUsuario.nomUsr;
                encontrado.clave = miUsuario.clave;
                encontrado.idRol = miUsuario.idRol;
                encontrado.nombre = miUsuario.nombre;
                encontrado.apellidos = miUsuario.apellidos;
                encontrado.correo = miUsuario.correo;
                encontrado.estado = miUsuario.estado;
            }
        }

        public void eliminarUsuario(int id)
        {
            Usuario encontrado = buscarUsuario(id);

            if (encontrado != null)
            {
                listaUsuarios.Remove(encontrado);
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return new List<Usuario>(listaUsuarios);
        }

        public int siguienteUsuario()
        {
            int resultado = 0;

            foreach (Usuario miUsuario in listaUsuarios)
            {
                if (miUsuario.id > resultado)
                {
                    resultado = miUsuario.id;
                }
            }

            return resultado + 1;
        }

        public int validarUsuario(string nomUsr, string clave)
        { 

        
            Usuario encontrado = buscarUsuario(nomUsr);

            if (encontrado == null || !encontrado.clave.Equals(clave))
            {
                return 0;
            }
            //0 activo
            if (encontrado.estado != 0)
            {
                return 2;
            }

            return 1;
        }

        // MÉTODOS DE ROLES

        public void AgregarRol(Roles miRol)
        {
            listaRoles.Add(miRol);
        }

        public Roles buscarRol(int id)
        {
            foreach (Roles miRol in listaRoles)
            {
                if (miRol.id == id)
                {
                    return miRol;
                }
            }

            return null;
        }

        public Roles buscarRol(string nombre)
        {
            foreach (Roles miRol in listaRoles)
            {
                if (miRol.nombre == nombre)
                {
                    return miRol;
                }
            }

            return null;
        }

        public void modificarRol(Roles miRol)
        {
            Roles encontrado = buscarRol(miRol.id);

            if (encontrado != null)
            {
                encontrado.nombre = miRol.nombre;
                encontrado.estado = miRol.estado;

            }
        }

        public void eliminarRol(int id)
        {
            Roles encontrado = buscarRol(id);

            if (encontrado != null)
            {
                listaRoles.Remove(encontrado);
            }
        }

        public List<Roles> ObtenerRoles()
        {
            return new List<Roles>(listaRoles);
        }

        public int siguienteRol()
        {
            int resultado = 0;

            foreach (Roles miRol in listaRoles)
            {
                if (miRol.id > resultado)
                {
                    resultado = miRol.id;
                }
            }

            return resultado + 1;
        }
    }
}