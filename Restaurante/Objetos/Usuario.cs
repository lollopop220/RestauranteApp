using System;

namespace Restaurante.Objetos
{
    internal class Usuario
    {
        public int id { get; set; }
        public string nomUsr { get; set; }
        public string clave { get; set; }
        public int idRol { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int estado { get; set; }
    }
}
