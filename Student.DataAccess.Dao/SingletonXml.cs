using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using log4net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccess.Dao
{
    public sealed class SingletonXml
    {
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static SingletonXml instance = null;
        private static readonly object padlock = new object();
        private readonly List<Alumno> students;

        private SingletonXml()
        {
            Log.Debug("Cargamos la lista el archiva"); 
            StudentDaoXml Sx = new StudentDaoXml();
            students = Sx.GetAll();
        }
        public List<Alumno> GetList()
        {
            Log.Debug("Devuelve la lista cargada");
            return students;
        }

        public static SingletonXml Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonXml();
                        }
                    }
                }
                return instance;
            }
        }

        public List<Alumno> Filtrar(string value)
        {
            var alumnosfiltrado =
                from alumno in students
                where alumno.Nombre == value
                select alumno;
            return alumnosfiltrado.ToList();
        }
    }
}
