using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class HorarioNegocio
    {
        private HorarioDatos horarioDatos = new HorarioDatos();

        public bool RegistrarHorario(string diaSemana, TimeSpan horaInicio, TimeSpan horaFin, int idVeterinario)
        {
            HorarioDatos horarioDatos = new HorarioDatos();
            return horarioDatos.InsertarHorario(diaSemana, horaInicio, horaFin, idVeterinario);
        }
        public DataTable ObtenerHorarios()
        {
            return horarioDatos.ObtenerHorarios();
        }
        public bool EliminarHorario(int idHorario)
        {
            HorarioDatos horarioDatos = new HorarioDatos();
            return horarioDatos.EliminarHorario(idHorario);
        }

    }
}
