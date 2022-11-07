using ASPDotNetMVCRepositoryApp.Models;
using EF.Repository.Interface.Manager;
using EF.Repository.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPDotNetMVCRepositoryApp.Interfaces.Manager
{
    internal interface IStudentManager:ICommonManager<Student>
    {
        bool isExistRegNo(string regNo);
        Student GetById(int id);
    }
}
