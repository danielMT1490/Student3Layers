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
using System.IO;

namespace Student.Business.Logic
{
    public class StudentBL : IStudentBL
    {
        private IStudentDao IStudentDao { get; set; }
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Alumno Add(Alumno student,TypeFormat typeFormat)
        {
            try
            {
                student.DateRegistry = DateTime.Now;
                Log.Debug("Fecha actual calculada");
                student.Edad = Age.AreAge(student.DateBorn, student.DateRegistry);
                IStudentDao = ChangeFormat(typeFormat);
                Log.Debug("Formato pasado la capa Dao");
                return IStudentDao.Add(student);
            }
            catch (ArgumentNullException e)
            {
                Log.Error("Falta una instancia" + e);
                throw;
            }
            catch (FileNotFoundException) { throw; }
            catch (FileLoadException)
            {
                throw;
            }
            catch (FormatException)
            {
                throw;
            }

        }

        public IStudentDao ChangeFormat(TypeFormat typeformat)
        {
            try
            {
                switch (typeformat)
                {
                    case TypeFormat.Txt:
                        Log.Debug("Formato cambiado a Txt");
                        return new StudentDaoTxt();
                    case TypeFormat.Json:
                        Log.Debug("Formato cambiado a Json");
                        return new StudentDaoJson();
                    case TypeFormat.Xml:
                        Log.Debug("Formato cambiado a Xml");
                        return new StudentDaoXml();
                    default:
                        return new StudentDaoTxt();

                }
            }
            catch (FormatException e)
            {
                Log.Error("el Enum no es correcto "+e);
                throw;
            }
            
        }
    }
}
