using System;

namespace VeterinariaCatDog.Modelos
{
    public class Vacuna
    {
        public int IdVacuna { get; set; }
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public DateTime ProximaAplicacion { get; set; }
    }
}
