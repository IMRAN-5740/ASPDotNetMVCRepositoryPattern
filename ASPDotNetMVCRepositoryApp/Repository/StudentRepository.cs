using ASPDotNetMVCRepositoryApp.Data;
using ASPDotNetMVCRepositoryApp.Interfaces.Repository;
using ASPDotNetMVCRepositoryApp.Models;
using EF.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPDotNetMVCRepositoryApp.Repository
{
    public class StudentRepository : CommonRepository<Student>, IStudentRepository
    {
        public StudentRepository() : base(new ApplicationDbContext())
        {
        }
    }
}