namespace ToDoodle.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public User() {
            this.Lists = new HashSet<List>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string LoginName { get; set; }

        [MaxLength(64)]
        public byte[] LoginPassword { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(32)]
        public string UserMobile { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateUpdated { get; set; }
        
        public virtual ICollection<List> Lists { get; set; }
    }
}
