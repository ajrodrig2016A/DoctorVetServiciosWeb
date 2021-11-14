using DoctorVet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorVet.WebApi.Controllers
{
    public class CitaController : ApiController
    {
        DoctorVetContext BD = new DoctorVetContext();

        [HttpGet]
        public IEnumerable<Cita> Get()
        {
            var listadoCitas = BD.Cita.ToList();
            return listadoCitas;
        }
        [HttpGet]
        public Cita Get(int id)
        {
            var cita = BD.Cita.FirstOrDefault(x => x.idCita == id);
            return cita;
        }

        [HttpPost]
        public bool Post(Cita cita)
        {
            BD.Cita.Add(cita);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Cita cita)
        {
            var citaActualizar = BD.Cita.FirstOrDefault(x => x.idCita == cita.idCita);
            citaActualizar.idMascota = cita.idMascota;
            citaActualizar.idCliente = cita.idCliente;
            citaActualizar.idUsuario = cita.idUsuario;
            citaActualizar.fecha = cita.fecha;
            citaActualizar.hora = cita.hora;
            citaActualizar.diagnostico = cita.diagnostico;
            citaActualizar.estado = cita.estado;
            citaActualizar.direccion = cita.direccion;
            citaActualizar.coordenadas = cita.coordenadas;
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int idCita)
        {
            var citaEliminar = BD.Cita.FirstOrDefault(x => x.idCita == idCita);
            BD.Cita.Remove(citaEliminar);
            return BD.SaveChanges() > 0;
        }
    }
}
