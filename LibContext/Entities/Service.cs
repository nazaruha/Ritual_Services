using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibContext.Entities
{
    [Table("tblServices")]
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(300)]
        public string NameEng { get; set; }
        [Required, StringLength(300)]
        public string NameUA { get; set; }
        [Required]
        public int Price { get; set; }
        [Required, StringLength(2000)]
        public string DescriptionEng { get; set; }
        [Required, StringLength(2000)]
        public string DescriptionUA { get; set; }
        [Required, StringLength(500)]
        public string Photo { get; set; }
        [ForeignKey("ServiceType")]
        public int ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
