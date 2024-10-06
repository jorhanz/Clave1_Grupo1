using System;

namespace VeterinariaCatDog.Modelos
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int IdDuenio { get; set; }
        public int? IdProducto { get; set; } // Puede ser nulo
        public int? IdCita { get; set; } // Puede ser nulo
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string TipoPago { get; set; } // Puede ser 'Efectivo', 'Tarjeta', 'Bitcoin'
        public DateTime FechaPago { get; set; }
    }
}
