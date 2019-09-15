using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityWebApp.Gateway;
using UniversityWebApp.Model;

namespace UniversityWebApp.BLL
{
    public class StudentManager
    {
       StudentGateway gateway = new StudentGateway();

        public string Save(Student student){
            bool regExist = gateway.DoesRegNoExist(student.RegistaionNo);

            if(regExist){
                return "Registation number already exist";
            }
            else{
                int rowAffacted = gateway.Save(student);
                if(rowAffacted>0){
                    return "Saved Successfully";
                }
                else{
                    return "Saving Failed";
                }
            }
        }

        public string Update(Student student)
        {
            int rowAffacted = gateway.Update(student);
            if(rowAffacted>0){
               return "Update Successfully";
            }
            else{
                return "Update Failed";
            }
        }

        public Student GetStudent(string regNo){
           Student student = gateway.GetStudent(regNo);
            return student;
        }

        public List<Student> PopulateStudentList(){
            return gateway.PopulateStudentList();
        }

        
    }
}