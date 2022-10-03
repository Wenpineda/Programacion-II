using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlaylist
{
    internal class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }

        public Cancion() { }

        public Cancion(int id, string nombre, string artista)
        {
            Id = id;
            Nombre = nombre;
            Artista = artista;
        }

        public string imprimir() {
            return Id + " - " + Nombre + " " + Artista;
        }
    }
}
