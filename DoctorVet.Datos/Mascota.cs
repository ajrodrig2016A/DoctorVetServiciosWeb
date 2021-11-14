namespace DoctorVet.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mascota")]
    public partial class Mascota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mascota()
        {
            //Cita = new HashSet<Cita>();
        }

        [Key]
        public int idMascota { get; set; }

        public int idRaza { get; set; }

        public int idCliente { get; set; }

        [StringLength(64)]
        public string nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaNacimiento { get; set; }

        [Required]
        [StringLength(45)]
        public string genero { get; set; }

        public bool? esterilizado { get; set; }

        [StringLength(30)]
        public string color { get; set; }

        [Column(TypeName = "image")]
        public byte[] foto { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Cita> Cita { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Raza Raza { get; set; }
    }
}
