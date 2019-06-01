using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class City
    {        
        [Key]   
        public int Id { get; set; }
        [Display(Name = "Код города")]
        public int Code { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Регион")]
        public string Region { get; set; }

    }
}
