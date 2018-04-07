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
using Student.Common.Logic.Log;

namespace Student.Business.Logic
{
    public class StudentBL : IStudentBL
    {
        private IStudentDao IStudentDao { get; set; }
        private ISingleton ISingleton { get; set; }
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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
        public List<Alumno> GetSelect(TypeFormat type, string value, Campo campo)
        {
            try
            {
                switch (type)
                {
                    case TypeFormat.Txt:
                        Log.Debug("select hecho en Txt");
                        IStudentDao = new StudentDaoTxt();
                        return IStudentDao.Filtro(campo,value);
                    case TypeFormat.Json:
                        Log.Debug("select hecho en  Json");
                        ISingleton = new SingletonJson();
                        return ISingleton.Filtro(campo,value);
                    case TypeFormat.Xml:
                        Log.Debug("select hecho en  Xml");
                        ISingleton = new SingletonXml();
                        return ISingleton.Filtro(campo, value);
                    default:
                        IStudentDao = new StudentDaoTxt();
                        return IStudentDao.Filtro(campo, value);

                }
            }
            catch (FormatException e)
            {
                Log.Error("el Enum no es correcto " + e);
                throw;
            }
        }
        public List<Alumno> GetAll(TypeFormat typeFormat)
        {
            try
            {
                switch (typeFormat)
                {
                    case TypeFormat.Txt:
                        Log.Debug("select hecho en Txt");
                        IStudentDao = new StudentDaoTxt();
                        return IStudentDao.GetAll();
                    case TypeFormat.Json:
                        Log.Debug("select hecho en  Json");
                        ISingleton = new SingletonJson();
                        return ISingleton.GetList();
                    case TypeFormat.Xml:
                        Log.Debug("select hecho en  Xml");
                        ISingleton = new SingletonXml();
                        return ISingleton.GetList();
                    default:
                        IStudentDao = new StudentDaoTxt();
                        return IStudentDao.GetAll();

                }
            }
            catch (FormatException e)
            {
                Log.Error("el Enum no es correcto " + e);
                throw;
            }
        }
    }
}
