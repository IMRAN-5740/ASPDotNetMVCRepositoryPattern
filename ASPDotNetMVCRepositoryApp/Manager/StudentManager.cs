using ASPDotNetMVCRepositoryApp.Data;
using ASPDotNetMVCRepositoryApp.Interfaces.Manager;
using ASPDotNetMVCRepositoryApp.Models;
using ASPDotNetMVCRepositoryApp.Repository;
using EF.Repository.Interface.Repository;
using EF.Repository.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDotNetMVCRepositoryApp.Manager
{
    public class StudentManager : CommonManager<Student>, IStudentManager
    {
        public StudentManager() : base(new StudentRepository())
        {

        }

        public bool isExistRegNo(string regNo)
        {
            var student = GetFirstOrDefault(c => c.RegNo.ToLower() == regNo.ToLower());
            if(student == null)
            {
                return false;
            }
            return true;
        }
        public Student GetById(int id)
        {
            var student=GetFirstOrDefault(c => c.Id == id);
            return student;
        }
    }
}