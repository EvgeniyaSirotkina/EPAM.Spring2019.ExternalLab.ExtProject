using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtProject.Web.Models
{
    public class Group
    {
        [Column("GroupID")]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string GroupName { get; set; }

        [Required]
        [MaxLength(75)]
        public string FullGroupName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}