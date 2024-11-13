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
        public DataTable ObtenerHistorialPorMascota(int idMascota)
        {
            return expedienteDatos.ObtenerHistorialPorMascota(idMascota);
        }
        public bool GuardarExpediente(int idMascota, DateTime fechaConsulta, string descripcion, int idVeterinario)
        {
            // Validaciones básicas
            if (idMascota <= 0 || idVeterinario <= 0 || string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("Valores inválidos para el expediente.");
            }

            try
            {
                bool resultado = expedienteDatos.InsertarExpediente(idMascota, fechaConsulta, descripcion, idVeterinario);
                Console.WriteLine("Resultado de la inserción en base de datos: " + resultado);
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar guardar el expediente: " + ex.Message);
                return false;
            }
        }
    }
}
