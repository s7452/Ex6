using Ex6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex6.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
