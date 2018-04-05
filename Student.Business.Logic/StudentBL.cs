using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic;

using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;
using Student.DataAccess.Dao;
using log4net;

namespace Student.Business.Logic
{
    public class StudentBL : IStudentBL
    {
        private IStudentDao IStudentDao { get; set; }
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Alumno Add(Alumno student,TypeFormat typeFormat)
        {
            student.DateRegistry = DateTime.Now;
            Log.Debug("Fecha actual calculada");
            student.Edad = Age.AreAge(student.DateBorn,student.DateRegistry);
            IStudentDao = ChangeFormat(typeFormat);
            Log.Debug("Formato pasado la capa Dao");
            return IStudentDao.Add(student);
        }

        public IStudentDao ChangeFormat(TypeFormat typeformat)
        {
            switch (typeformat)
            {
                case TypeFormat.Txt:
                    return new StudentDaoTxt();
                case TypeFormat.Json:
                    return new StudentDaoJson();
                case TypeFormat.Xml:
                    return new StudentDaoXml();
                default:
                    return new StudentDaoTxt();

            }
        }
    }
}
