namespace BD.DATOS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Departamentos
    {
        [Key]
        public int IdDepartamento { get; set; }

        [StringLength(50)]
        public string NombreDepartamento { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
