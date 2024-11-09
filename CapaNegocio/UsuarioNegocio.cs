﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();

        public bool RegistrarUsuario(string nombreCompleto, string correo, string clave, int idRol)
        {
            // Lógica de negocio: aquí podrías agregar validaciones, por ejemplo:
            if (string.IsNullOrWhiteSpace(nombreCompleto) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave))
            {
                throw new ArgumentException("Todos los campos son obligatorios");
            }

            return usuarioDatos.InsertarUsuario(nombreCompleto, correo, clave, idRol);
        }
    }
}
