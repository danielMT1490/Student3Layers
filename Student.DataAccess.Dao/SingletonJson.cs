using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;

namespace Student.DataAccess.Dao
{
    public sealed class SingletonJson : ISingleton
    {
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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

        public List<Alumno> Filtro(Campo campo, string value)
        {
            switch (campo)
            {
                case Campo.Guid:
                    return SelectGuid(value);
                case Campo.ID:
                    return SelectId(value);
                case Campo.Nombre:
                    return SelectNombre(value);
                case Campo.Apellidos:
                    return SelectApellido(value);
                case Campo.Edad:
                    return SelectEdad(value);
                case Campo.Fecha_de_Nacimiento:
                    return SelectDateBorn(value);
                case Campo.Fecha_de_Registro:
                    return SelectDateRegistry(value);
                default:
                    return students;
            }
        }
        private List<Alumno> SelectGuid(string value)
        {
            var alumnosfiltrado =
                from alumno in students
                where alumno.Guid == Guid.Parse(value)
                select alumno;
            return alumnosfiltrado.ToList();
        }
        private List<Alumno> SelectId(string value)
        {
            var alumnosfiltrado =
                from alumno in students
                where alumno.Id == Convert.ToInt32(value)
                select alumno;
            return alumnosfiltrado.ToList();
        }
        private List<Alumno> SelectNombre(string value)
        {
            var alumnosfiltrado =
                from alumno in students
                where alumno.Nombre == value
                select alumno;
            return alumnosfiltrado.ToList();
        }
        private List<Alumno> SelectApellido(string value)
        {
            var alumnosfiltrado =
                from alumno in students
                where alumno.Apellidos == value
                select alumno;
            return alumnosfiltrado.ToList();
        }
        private List<Alumno> SelectEdad(string value)
        {
            var alumnosfiltrado =
                from alumno in students
                where alumno.Edad == Convert.ToInt32(value)
                select alumno;
            return alumnosfiltrado.ToList();
        }
        private List<Alumno> SelectDateBorn(string value)
        {
            var alumnosfiltrado =
                from alumno in students
                where alumno.DateBornString == value
                select alumno;
            return alumnosfiltrado.ToList();
        }
        private List<Alumno> SelectDateRegistry(string value)
        {
            var alumnosfiltrado =
                from alumno in students
                where alumno.DateRegistryString == value
                select alumno;
            return alumnosfiltrado.ToList();
        }
    }
}
