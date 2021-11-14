using DoctorVet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorVet.WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        DoctorVetContext BD = new DoctorVetContext();

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            var listadoClientes = BD.Cliente.ToList();
            return listadoClientes;
        }
        [HttpGet]
        public Cliente Get(int id)
        {
            var cliente = BD.Cliente.FirstOrDefault(x => x.idCliente == id);
            return cliente;
        }

        [HttpPost]
        public bool Post(Cliente cliente)
        {
            BD.Cliente.Add(cliente);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Cliente cliente)
        {
            var clienteActualizar = BD.Cliente.FirstOrDefault(x => x.idCliente == cliente.idCliente);
            clienteActualizar.numeroDocumento = cliente.numeroDocumento;
            clienteActualizar.nombres = cliente.nombres;
            clienteActualizar.apellidos = cliente.apellidos;
            clienteActualizar.fechaRegistro = cliente.fechaRegistro;
            clienteActualizar.direccion = cliente.direccion;
            clienteActualizar.email = cliente.email;
            clienteActualizar.numeroContacto = cliente.numeroContacto;
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int idCliente)
        {
            var clienteEliminar = BD.Cliente.FirstOrDefault(x => x.idCliente == idCliente);
            BD.Cliente.Remove(clienteEliminar);
            return BD.SaveChanges() > 0;
        }
    }
}
