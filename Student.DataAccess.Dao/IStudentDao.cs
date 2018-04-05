using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccess.Dao
{
    public interface IStudentDao
    {
        Alumno Add(Alumno student);
        Alumno Deserialize();
        List<Alumno> GetAll();
    }
}
