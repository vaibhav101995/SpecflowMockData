﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Models
{
    public class DepartmentWithEmployeeCount
    {
        public long DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DeptLocation { get; set; }
        public int TotalEmployees { get; set; }
    }
}
