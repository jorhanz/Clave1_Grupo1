using System;

namespace VeterinariaCatDog.Modelos
{
    public class Expediente
    {
        public int IdExpediente { get; set; }
        public int IdMascota { get; set; }
        public string DetallesConsulta { get; set; }
        public DateTime FechaConsulta { get; set; }
    }
}
