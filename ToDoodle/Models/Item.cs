namespace ToDoodle.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool? Complete { get; set; }

        public bool? Deleted { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateUpdated { get; set; }
        
        public User User { get; set; }
        
        public List List { get; set; }

    }
}
