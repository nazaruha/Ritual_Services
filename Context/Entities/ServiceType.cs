using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Entities
{
    [Table("tblServicesTypes")]
    public class ServiceType
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string NameEng { get; set; }
        [Required, StringLength(50)]
        public string NameUkr { get; set; }
    }
}
