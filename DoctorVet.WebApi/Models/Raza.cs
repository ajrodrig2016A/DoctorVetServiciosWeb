﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorVet.WebApi.Models
{
    public class Raza
    {
        public int idRaza { get; set; }
        public string nombre { get; set; }
        public string caracteristicas { get; set; }
        public string tipoMascota { get; set; }
    }
}