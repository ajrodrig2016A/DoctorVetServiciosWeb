using DoctorVet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorVet.WebApi.Controllers
{
    public class MascotaController : ApiController
    {
        DoctorVetContext BD = new DoctorVetContext();

        [HttpGet]
        public IEnumerable<Mascota> Get()
        {
            var listadoMascotas = BD.Mascota.ToList();
            return listadoMascotas;
        }
        [HttpGet]
        public Mascota Get(int id)
        {
            var mascota = BD.Mascota.FirstOrDefault(x => x.idMascota == id);
            return mascota;
        }

        [HttpPost]
        public bool Post(Mascota mascota)
        {
            BD.Mascota.Add(mascota);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Mascota mascota)
        {
            var mascotaActualizar = BD.Mascota.FirstOrDefault(x => x.idMascota == mascota.idMascota);
            mascotaActualizar.idRaza = mascota.idRaza;
            mascotaActualizar.idCliente = mascota.idCliente;
            mascotaActualizar.nombre = mascota.nombre;
            mascotaActualizar.fechaNacimiento = mascota.fechaNacimiento;
            mascotaActualizar.genero = mascota.genero;
            mascotaActualizar.esterilizado = mascota.esterilizado;
            mascotaActualizar.color = mascota.color;
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int idMascota)
        {
            var mascotaEliminar = BD.Mascota.FirstOrDefault(x => x.idMascota == idMascota);
            BD.Mascota.Remove(mascotaEliminar);
            return BD.SaveChanges() > 0;
        }
    }
}
