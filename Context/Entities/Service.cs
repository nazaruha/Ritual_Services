using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Entities
{
    [Table("tblServices")]
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(300)]
        public string NameEng { get; set; }
        [Required, StringLength(300)]
        public string NameUkr { get; set; }
        [Required]
        public int Price { get; set; }
        [Required, StringLength(2000)]
        public string Description { get; set; }
        [ForeignKey("ServiceType")]
        public int ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
