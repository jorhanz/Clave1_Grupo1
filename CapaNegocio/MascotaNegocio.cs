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
        public bool RegistrarMascota(int idPropietario, string nombre, int idEspecie, string raza, DateTime fechaNacimiento)
        {
            MascotaDatos mascotaDatos = new MascotaDatos();
            return mascotaDatos.InsertarMascota(idPropietario, nombre, idEspecie, raza, fechaNacimiento);
        }
        public DataTable ObtenerEspecies()
        {
            MascotaDatos mascotaDatos = new MascotaDatos();
            return mascotaDatos.ObtenerEspecies();
        }
        public bool EliminarMascota(int idMascota)
        {
            MascotaDatos mascotaDatos = new MascotaDatos();
            return mascotaDatos.EliminarMascota(idMascota);
        }
    }
}
