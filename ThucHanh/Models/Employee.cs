﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThucHanh.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Phong_Ban { get; set; }
        public double TienLuong { get; set; }
    }
}