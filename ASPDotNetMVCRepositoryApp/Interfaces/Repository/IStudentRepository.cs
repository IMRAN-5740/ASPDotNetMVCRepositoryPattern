using ASPDotNetMVCRepositoryApp.Models;
using EF.Repository.Interface.Repository;
using EF.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPDotNetMVCRepositoryApp.Interfaces.Repository
{
    internal interface IStudentRepository:ICommonRepository<Student>
    {

    }
}
