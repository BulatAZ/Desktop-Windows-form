﻿using System;
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
            public string Name { get; set; }
       
    }
}
