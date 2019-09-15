using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VersityWebApp.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string RegistaionNo { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
    }
}