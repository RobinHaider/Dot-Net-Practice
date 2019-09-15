using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using VersityWebApp.Model;
using System.Data.SqlClient;

namespace VersityWebApp.Gateway
{
    public class DepartmentGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;

        public List<Department> GetAllDepartments()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Departments";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Department> departments = new List<Department>();

            while (reader.Read())
            {
                Department department = new Department();
                department.Id = Convert.ToInt32(reader["Id"]);
                department.Code = reader["Code"].ToString();
                department.Name = reader["Name"].ToString();

                departments.Add(department);
            }

            reader.Close();
            connection.Close();

            return departments;
        }
    }
}