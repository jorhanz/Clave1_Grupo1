using System;

namespace VeterinariaCatDog.Modelos
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public int IdDuenio { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; } // Puede ser 'Perro', 'Gato', 'Otro'
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
