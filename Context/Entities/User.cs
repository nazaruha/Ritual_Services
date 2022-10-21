using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Entities
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Login { get; set; }
        [Required, StringLength(100)]
        public string Password { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
    }
}
