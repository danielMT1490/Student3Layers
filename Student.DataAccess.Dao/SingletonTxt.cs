using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Log;
using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccess.Dao
{
    public sealed class SingletonTxt : ISingleton
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static SingletonTxt instance = null;
        private static readonly object padlock = new object();
        private readonly List<Alumno> students;

        public SingletonTxt()
        {
            Log.Debug("Cargamos la lista el archiva");
            StudentDaoTxt Js = new StudentDaoTxt();
            students = Js.GetAll();
        }
        public List<Alumno> GetList()
        {
            Log.Debug("Devuelve la lista cargada");
            return students;
        }

        public static SingletonTxt Instance
        {
            get
            {
                Log.Debug("Comporvamos el que SingletonTxt no este instanciado");
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonTxt();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
