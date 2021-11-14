using DoctorVet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorVet.WebApi.Controllers
{
    public class RazaController : ApiController
    {
        DoctorVetContext BD = new DoctorVetContext();

        [HttpGet]
        public IEnumerable<Raza> Get()
        {
            var listadoRazas = BD.Raza.ToList();
            return listadoRazas;
        }
        [HttpGet]
        public Raza Get(int id)
        {
            var raza = BD.Raza.FirstOrDefault(x => x.idRaza == id);
            return raza;
        }

        [HttpPost]
        public bool Post(Raza raza)
        {
            BD.Raza.Add(raza);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Raza raza)
        {
            var razaActualizar = BD.Raza.FirstOrDefault(x => x.idRaza == raza.idRaza);
            razaActualizar.nombre = raza.nombre;
            razaActualizar.caracteristicas = raza.caracteristicas;
            razaActualizar.tipoMascota = raza.tipoMascota;
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int idRaza)
        {
            var razaEliminar = BD.Raza.FirstOrDefault(x => x.idRaza == idRaza);
            BD.Raza.Remove(razaEliminar);
            return BD.SaveChanges() > 0;
        }
    }
}
