using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8_Serie___Videojuego
{
    class Serie
    {
        public string Titulo { get; set; }
        public int Temporadas { get; set; }
        public bool Entregado { get; set; }
        public string Genero { get; set; }
        public string Creador { get; set; }
        // Constructor por defecto
        public Serie()
        {
            Titulo = "Sin título";
            Temporadas = 3;
            Entregado = false;
            Genero = "Sin género";
            Creador = "Sin creador";
        }
        // Constructor con título y creador
        public Serie(string titulo, string creador)
        {
            Titulo = titulo;
            Temporadas = 3;
            Entregado = false;
            Genero = "Sin género";
            Creador = creador;
        }
        // Constructor con todos los atributos excepto entregado
        public Serie(string titulo, int temporadas, string genero, string creador)
        {
            Titulo = titulo;
            Temporadas = temporadas;
            Entregado = false;
            Genero = genero;
            Creador = creador;

        }
        // Métodos get
        public string GetTitulo() => Titulo;
        public int GetTemporadas() => Temporadas;
        public string GetGenero() => Genero;
        public string GetCreador() => Creador;
        // Métodos set
        public void SetTitulo(string titulo) => Titulo = titulo;
        public void SetTemporadas(int temporadas) => Temporadas = temporadas;
        public void SetGenero(string genero) => Genero = genero;
        public void SetCreador(string creador) => Creador = creador;
        // Método toString
        public override string ToString()
        {
            return $"Título: {Titulo}, Temporadas: {Temporadas}, Entregado: {Entregado}, Género: {Genero}, Creador: {Creador}";
        }
        // Método Entregar
        public void Entregar()
        {
            Entregado = true;
        }
        // Método Devolver
        public void Devolver()
        {
            Entregado = false;
        }
        // Método IsEntregado
        public bool IsEntregado()
        {
            return Entregado;
        }
        // Método para comparar series por número de temporadas
        public int CompareTo(Serie other)
        {
            if (other == null) return 1;
            return Temporadas.CompareTo(other.Temporadas);
        }
        // Método para comparar series por título
        public int CompareToTitulo(Serie other)
        {
            if (other == null) return 1;
            return string.Compare(Titulo, other.Titulo, StringComparison.OrdinalIgnoreCase);
        }
        // Método para comparar series por creador
        public int CompareToCreador(Serie other)
        {
            if (other == null) return 1;
            return string.Compare(Creador, other.Creador, StringComparison.OrdinalIgnoreCase);
        }
        // Método para comparar series por género
        public int CompareToGenero(Serie other)
        {
            if (other == null) return 1;
            return string.Compare(Genero, other.Genero, StringComparison.OrdinalIgnoreCase);
        }
        // Método para comparar series por estado de entrega
        public int CompareToEntregado(Serie other)
        {
            if (other == null) return 1;
            return Entregado.CompareTo(other.Entregado);
        }
        // Método para comparar series por título y número de temporadas
        public int CompareToTituloTemporadas(Serie other)
        {
            if (other == null) return 1;
            int titleComparison = string.Compare(Titulo, other.Titulo, StringComparison.OrdinalIgnoreCase);
            if (titleComparison != 0) return titleComparison;
            return Temporadas.CompareTo(other.Temporadas);
        }
        // Método para comparar series por título, número de temporadas y creador
        public int CompareToTituloTemporadasCreador(Serie other)
        {
            if (other == null) return 1;
            int titleComparison = string.Compare(Titulo, other.Titulo, StringComparison.OrdinalIgnoreCase
);
            if (titleComparison != 0) return titleComparison;
            int seasonComparison = Temporadas.CompareTo(other.Temporadas);
            if (seasonComparison != 0) return seasonComparison;
            return string.Compare(Creador, other.Creador, StringComparison.OrdinalIgnoreCase);
        }
        // Método para comparar series por título, número de temporadas, creador y género
        public int CompareToTituloTemporadasCreadorGenero(Serie other)
        {
            if (other == null) return 1;
            int titleComparison = string.Compare(Titulo, other.Titulo, StringComparison.OrdinalIgnoreCase);
            if (titleComparison != 0) return titleComparison;
            int seasonComparison = Temporadas.CompareTo(other.Temporadas);
            if (seasonComparison != 0) return seasonComparison;
            int creatorComparison = string.Compare(Creador, other.Creador, StringComparison.OrdinalIgnoreCase);
            if (creatorComparison != 0) return creatorComparison;
            return string.Compare(Genero, other.Genero, StringComparison.OrdinalIgnoreCase);
        }
        // Método para comparar series por título, número de temporadas, creador, género y estado de entrega
        public int CompareToTituloTemporadasCreadorGeneroEntregado(Serie other)
        {
            if (other == null) return 1;
            int titleComparison = string.Compare(Titulo, other.Titulo, StringComparison.OrdinalIgnoreCase);
            if (titleComparison != 0) return titleComparison;
            int seasonComparison = Temporadas.CompareTo(other.Temporadas);
            if (seasonComparison != 0) return seasonComparison;
            int creatorComparison = string.Compare(Creador, other.Creador, StringComparison.OrdinalIgnoreCase);
            if (creatorComparison != 0) return creatorComparison;
            int genreComparison = string.Compare(Genero, other.Genero, StringComparison.OrdinalIgnoreCase);
            if (genreComparison != 0) return genreComparison;
            return Entregado.CompareTo(other.Entregado);
        }
    }
}