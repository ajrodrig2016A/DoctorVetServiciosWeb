namespace DoctorVet.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            //Cita = new HashSet<Cita>();
        }

        [Key]
        public int idUsuario { get; set; }

        [Required]
        [StringLength(13)]
        public string numeroDocumento { get; set; }

        [StringLength(64)]
        public string nombres { get; set; }

        [StringLength(64)]
        public string apellidos { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaRegistro { get; set; }

        [StringLength(64)]
        public string cargo { get; set; }

        [StringLength(64)]
        public string email { get; set; }

        [StringLength(20)]
        public string telefono { get; set; }

        [StringLength(1)]
        public string rol { get; set; }

        [StringLength(16)]
        public string password { get; set; }

        [StringLength(100)]
        public string direccion { get; set; }

        [StringLength(150)]
        public string coordenadas { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Cita> Cita { get; set; }
    }
}
