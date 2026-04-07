using System.Runtime.Intrinsics.Arm;
using Sonica.Dominio.Entidades;

static void Main() { }
//ENTIDAD BASE CAPA 1

namespace Sonica.Dominio.Entidades
{
    public abstract class EntidadBase
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }

        protected EntidadBase()
        {
            FechaRegistro = DateTime.Now;
        }

        public abstract string ObtenerResumen();

    }
}

//CANCION CAPA 1
namespace Sonica.Dominio.Entidades
{
    public class Cancion : EntidadBase
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Genero { get; set; }
        public string LinkVideo { get; set; }
        public string ImagenArtista { get; set; }

        // Constructor vacío
        public Cancion()
        {
            Titulo = string.Empty;
            Artista = string.Empty;
            Genero = string.Empty;
            LinkVideo = string.Empty;
            ImagenArtista = string.Empty;
        }

        // Constructor básico — sobrecarga 1
        public Cancion(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
            Genero = string.Empty;
            LinkVideo = string.Empty;
            ImagenArtista = string.Empty;
        }

        // Constructor completo — sobrecarga 2
        public Cancion(string titulo, string artista, string genero)
        {
            Titulo = titulo;
            Artista = artista;
            Genero = genero;
            LinkVideo = string.Empty;
            ImagenArtista = string.Empty;
        }

        // Constructor con todos los campos — sobrecarga 3
        public Cancion(string titulo, string artista, string genero,
                       string linkVideo, string imagenArtista)
        {
            Titulo = titulo;
            Artista = artista;
            Genero = genero;
            LinkVideo = linkVideo;
            ImagenArtista = imagenArtista;
        }

        // Implementación del método abstracto de EntidadBase
        public override string ObtenerResumen()
        {
            return $"[{Id}] {Titulo} — {Artista} ({Genero}) | Registrada: {FechaRegistro:dd/MM/yyyy}";
        }

        public override string ToString()
        {
            return ObtenerResumen();
        }
    }
}

//GENERO CAPA 1
namespace Sonica.Dominio.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Genero()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }

        public Genero(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
