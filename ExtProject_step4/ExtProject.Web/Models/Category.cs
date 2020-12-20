using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtProject.Web.Models
{
    public class Category
    {
        [Column("CategoryID")]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string CategoryName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}