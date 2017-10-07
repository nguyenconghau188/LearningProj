namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public int? DisplayOder { get; set; }

        [StringLength(250)]
        public string Link { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        [StringLength(50)]
        public string ModifierBy { get; set; }

        public DateTime? ModifierDate { get; set; }

        public bool? status { get; set; }
    }
}
