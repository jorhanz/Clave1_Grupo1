using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class ExpedienteNegocio
    {
        private ExpedienteDatos expedienteDatos = new ExpedienteDatos();

        public bool RegistrarConsulta(int idMascota, int idVeterinario, DateTime fechaConsulta, string descripcion)
        {
            return expedienteDatos.InsertarConsulta(idMascota, idVeterinario, fechaConsulta, descripcion);
        }

        public DataTable ObtenerHistorialClinico(int idMascota)
        {
            return expedienteDatos.ObtenerHistorialClinico(idMascota);
        }
    }
}
