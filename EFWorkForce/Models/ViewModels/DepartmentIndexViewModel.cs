﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkForce.Models.ViewModels
{
    public class DepartmentIndexViewModel
    {
        public List<Department> Departments { get; set; }
        public List<int> EmployeeCounts { get; set; }
    }
}
