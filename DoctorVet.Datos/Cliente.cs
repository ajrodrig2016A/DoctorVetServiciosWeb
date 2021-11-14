namespace DoctorVet.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            //Cita = new HashSet<Cita>();
            //Mascota = new HashSet<Mascota>();
        }

        [Key]
        public int idCliente { get; set; }

        [Required]
        [StringLength(13)]
        public string numeroDocumento { get; set; }

        [StringLength(64)]
        public string nombres { get; set; }

        [StringLength(64)]
        public string apellidos { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaRegistro { get; set; }

        [StringLength(100)]
        public string direccion { get; set; }

        [StringLength(64)]
        public string email { get; set; }

        [Required]
        [StringLength(20)]
        public string numeroContacto { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Cita> Cita { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
