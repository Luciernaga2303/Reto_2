using Microsoft.AspNetCore.Mvc;
using Reto.NewFolder;

namespace Reto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public class Musica
        {
            public String titulo;
            public String artista;
            public int duracion;

            public Musica(String titulo, String artista, int duracion)
            {
                this.titulo = titulo;
                this.artista = artista;
                this.duracion = duracion;
            }

            public String getTitulo()
            {
                return titulo;
            }

            public void setTitulo(String titulo)
            {
                this.titulo = titulo;
            }

            public String getArtista()
            {
                return artista;
            }

            public void setArtista(String artista)
            {
                this.artista = artista;
            }

            public int getDuracion()
            {
                return duracion;
            }

            public void setDuracion(int duracion)
            {
                this.duracion = duracion;
            }

            public void reproducir()
            {
                System.out.println("Reproduciendo: " + titulo + " - " + artista);
            }

            public static void main(String[] args)
            {

                Musica cancion1 = new Musica("Shape of You", "Ed Sheeran", 234);
                cancion1.reproducir();
            }
        }
    }
}