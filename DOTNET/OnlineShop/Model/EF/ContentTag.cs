namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContentTag")]
    public partial class ContentTag
    {
        [Key]
        public long ContentID { get; set; }

        public long? TagID { get; set; }
    }
}
