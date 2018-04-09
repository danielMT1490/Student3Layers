using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Log;
using Student.Common.Logic.Models;

namespace Student.DataAccess.Dao
{
    public sealed class SingletonJson : ISingleton
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static SingletonJson instance = null;
        private static readonly object padlock = new object();
        private readonly List<Alumno> students;

        public SingletonJson()
        {
            Log.Debug("Cargamos la lista el archiva");
            StudentDaoJson Js = new StudentDaoJson();
            students = Js.GetAll();
        }
        public List<Alumno> GetList()
        {
            Log.Debug("Devuelve la lista cargada");
            return students;
        }

        public static SingletonJson Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonJson();
                        }
                    }
                }
                return instance;
            }
        }

       
    }
}
