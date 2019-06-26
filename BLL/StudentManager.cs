using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public static class StudentManager
    {
        public static List<Student> GetAll()
        {
            return StudentDal.GetAll();
        }
    }
}
