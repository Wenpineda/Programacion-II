using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlaylist
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }

        public Usuario() { }

        public Usuario(int id, string nombre, string pass)
        {
            Id = id;
            Nombre = nombre;
            Pass = pass;
        }
    }
}
