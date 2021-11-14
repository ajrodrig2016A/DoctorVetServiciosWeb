namespace DoctorVet.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cita")]
    public partial class Cita
    {
        [Key]
        public int idCita { get; set; }

        public int idMascota { get; set; }

        public int idCliente { get; set; }

        public int idUsuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public TimeSpan hora { get; set; }

        [StringLength(250)]
        public string diagnostico { get; set; }

        [Required]
        [StringLength(16)]
        public string estado { get; set; }

        [StringLength(100)]
        public string direccion { get; set; }

        [StringLength(150)]
        public string coordenadas { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Mascota Mascota { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
