using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VersityWebApp.Gateway;
using VersityWebApp.Model;

namespace VersityWebApp.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway gateway = new DepartmentGateway();

        public List<Department> GetAllDepartments()
        {
            return gateway.GetAllDepartments();
        }
    }
}