using DoctorVet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorVet.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        DoctorVetContext BD = new DoctorVetContext();

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            var listadoUsuarios = BD.Usuario.ToList();
            return listadoUsuarios;
        }
        [HttpGet]
        public Usuario Get(int id)
        {
            var usuario = BD.Usuario.FirstOrDefault(x => x.idUsuario == id);
            return usuario;
        }

        [HttpPost]
        public bool Post(Usuario usuario)
        {
            BD.Usuario.Add(usuario);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Usuario usuario)
        {
            var usuarioActualizar = BD.Usuario.FirstOrDefault(x => x.idUsuario == usuario.idUsuario);
            usuarioActualizar.numeroDocumento = usuario.numeroDocumento;
            usuarioActualizar.nombres = usuario.nombres;
            usuarioActualizar.apellidos = usuario.apellidos;
            usuarioActualizar.fechaRegistro = usuario.fechaRegistro;
            usuarioActualizar.cargo = usuario.cargo;
            usuarioActualizar.email = usuario.email;
            usuarioActualizar.telefono = usuario.telefono;
            usuarioActualizar.rol = usuario.rol;
            usuarioActualizar.password = usuario.password;
            usuarioActualizar.direccion = usuario.direccion;
            usuarioActualizar.coordenadas = usuario.coordenadas;
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int idUsuario)
        {
            var usuarioEliminar = BD.Usuario.FirstOrDefault(x => x.idUsuario == idUsuario);
            BD.Usuario.Remove(usuarioEliminar);
            return BD.SaveChanges() > 0;
        }
    }
}
