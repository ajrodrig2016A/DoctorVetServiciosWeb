namespace DoctorVet.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Raza")]
    public partial class Raza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raza()
        {
            //Mascota = new HashSet<Mascota>();
        }

        [Key]
        public int idRaza { get; set; }

        [Required]
        [StringLength(64)]
        public string nombre { get; set; }

        [StringLength(200)]
        public string caracteristicas { get; set; }

        [StringLength(45)]
        public string tipoMascota { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
