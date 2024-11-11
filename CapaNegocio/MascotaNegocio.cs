using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class MascotaNegocio
    {
        private MascotaDatos mascotaDatos = new MascotaDatos();

        // Método para obtener todas las mascotas
        public DataTable ObtenerMascotas()
        {
            return mascotaDatos.ObtenerMascotas();
        }

        // Método para registrar una mascota
        public bool RegistrarMascota(int idDuenio, string nombre, string especie, string raza, DateTime fechaNacimiento)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(especie))
                throw new ArgumentException("El nombre de la mascota y la especie son obligatorios.");

            return mascotaDatos.InsertarMascota(idDuenio, nombre, especie, raza, fechaNacimiento);
        }
    }
}
