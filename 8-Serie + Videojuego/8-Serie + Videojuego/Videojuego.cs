using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8_Serie___Videojuego
{
    class Videojuego
    {
        public string Titulo { get; set; }
        public int HorasEstimadas { get; set; }
        public bool Entregado { get; set; }
        public string Genero { get; set; }
        public string Compania { get; set; }
        // Constructor por defecto
        public Videojuego()
        {
            Titulo = "Sin título";
            HorasEstimadas = 10;
            Entregado = false;
            Genero = "Sin género";
            Compania = "Sin compañía";
        }
        // Constructor con título y horas estimadas
        public Videojuego(string titulo, int horasEstimadas)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Entregado = false;
            Genero = "Sin género";
            Compania = "Sin compañía";
        }
        // Constructor con todos los atributos excepto entregado
        public Videojuego(string titulo, int horasEstimadas, string genero, string compania)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Entregado = false;
            Genero = genero;
            Compania = compania;
        }
        // Métodos get
        public string GetTitulo() => Titulo;
        public int GetHorasEstimadas() => HorasEstimadas;
        public string GetGenero() => Genero;
        public string GetCompania() => Compania;
        // Métodos set
        public void SetTitulo(string titulo) => Titulo = titulo;
        public void SetHorasEstimadas(int horasEstimadas) => HorasEstimadas = horasEstimadas;
        public void SetGenero(string genero) => Genero = genero;
        public void SetCompania(string compania) => Compania = compania;
        // Método toString
        public override string ToString()
        {
            return $"Título: {Titulo}, Horas Estimadas: {HorasEstimadas}, Entregado: {Entregado}, Género: {Genero}, Compañía: {Compania}";
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
        // Método para comparar horas estimadas
        public int CompareTo(Videojuego otro)
        {
            if (otro == null) return 1;
            return this.HorasEstimadas.CompareTo(otro.HorasEstimadas);
        }
        // Método para comparar por título
        public int CompareToTitulo(Videojuego otro)
        {
            if (otro == null) return 1;
            return string.Compare(this.Titulo, otro.Titulo, StringComparison.OrdinalIgnoreCase);
        }
        // Método para comparar por compañía
        public int CompareToCompania(Videojuego otro)
        {
            if (otro == null) return 1;
            return string.Compare(this.Compania, otro.Compania, StringComparison.OrdinalIgnoreCase);
        }
        // Método para comparar por género
        public int CompareToGenero(Videojuego otro)
        {
            if (otro == null) return 1;
            return string.Compare(this.Genero, otro.Genero, StringComparison.OrdinalIgnoreCase);
        }
        // Método para comparar por horas estimadas
        public int CompareToHorasEstimadas(Videojuego otro)
        {
            if (otro == null) return 1;
            return this.HorasEstimadas.CompareTo(otro.HorasEstimadas);
        }
    }
}