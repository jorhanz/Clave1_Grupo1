using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CitaNegocio
    {
        private CitaDatos citaDatos = new CitaDatos();

        public DataTable ObtenerCitas()
        {
            return citaDatos.ObtenerCitas();
        }

        public DataTable ObtenerVeterinarios()
        {
            return citaDatos.ObtenerVeterinarios();
        }

        public DataTable ObtenerMascotasPorCliente(int IdPropietario)
        {
            return citaDatos.ObtenerMascotasPorCliente(IdPropietario);
        }
        public DataTable ObtenerHorariosPorVeterinario(int idVeterinario, string diaSemana)
        {
            return citaDatos.ObtenerHorariosPorVeterinario(idVeterinario, diaSemana);
        }
        public bool RegistrarCita(int idMascota, int idCliente, int idVeterinario, DateTime fechaCita, int idHorario, string motivo)
        {
            return citaDatos.InsertarCita(idMascota, idCliente, idVeterinario, fechaCita, idHorario, motivo);
        }
        public DataTable ObtenerClientes()
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            return usuarioNegocio.ObtenerClientes();
        }
        public DataTable ObtenerHorariosDisponibles(int idVeterinario, string diaSemana)
        {
            return citaDatos.ObtenerHorariosPorVeterinarioYDia(idVeterinario, diaSemana);
        }
    }

        

}
