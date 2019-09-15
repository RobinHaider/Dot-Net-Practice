using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VersityWebApp.Gateway;
using VersityWebApp.Model;

namespace VersityWebApp.BLL
{
    public class StudentManager
    {
        StudentGateway gateway = new StudentGateway();

        public string Save(Student student)
        {
            bool regExist = gateway.DoesRegNoExist(student.RegistaionNo);

            if (regExist)
            {
                return "Registation number already exist";
            }
            else
            {
                int rowAffacted = gateway.Save(student);
                if (rowAffacted > 0)
                {
                    return "Saved Successfully";
                }
                else
                {
                    return "Saving Failed";
                }
            }
        }

        internal StudentWithDepartmentVM GetStudentById(int id)
        {
            return gateway.GetStudentById(id);
        }

        public string Update(Student student)
        {
            int rowAffacted = gateway.Update(student);
            if (rowAffacted > 0)
            {
                return "Update Successfully";
            }
            else
            {
                return "Update Failed";
            }
        }

        public StudentWithDepartmentVM GetStudent(string regNo)
        {
            StudentWithDepartmentVM student = gateway.GetStudent(regNo);
            return student;
        }

        public List<StudentWithDepartmentVM> PopulateStudentList()
        {
            return gateway.PopulateStudentList();
        }

        internal void DeleteStudent(int id)
        {
            gateway.DeleteStudent(id);
        }
    }
}