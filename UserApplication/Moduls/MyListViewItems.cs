using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UserApplication.Moduls
{
    public class MyListViewItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public int ServiceTypeId { get; set; }
    }
}
