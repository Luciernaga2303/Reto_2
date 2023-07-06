namespace Reto.NewFolder
{
    public class Musica
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int Duracion { get; set; }

        public Musica(string titulo, string artista, int duracion)
        {
            Titulo = titulo;
            Artista = artista;
            Duracion = duracion;
        }

        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo: " + Titulo + " - " + Artista);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Musica cancion1 = new Musica("Shape of You", "Ed Sheeran", 234);
            cancion1.Reproducir();
        }
    }
}