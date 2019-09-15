using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VersityWebApp.Model
{
    public class StudentWithDepartmentVM
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public int DeptId { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
    }
}