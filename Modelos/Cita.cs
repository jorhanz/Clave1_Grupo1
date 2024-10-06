using System;

namespace VeterinariaCatDog.Modelos
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdDuenio { get; set; }
        public int IdMascota { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; } // Puede ser 'Agendada', 'Cancelada', 'Completada', 'Reprogramada'
        public object MascotaId { get; internal set; }
    }
}
