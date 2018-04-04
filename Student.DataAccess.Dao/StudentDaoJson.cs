using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.Models;
using System.IO;
using Student.Common.Logic.FileUtils;
using Newtonsoft.Json;

namespace Student.DataAccess.Dao
{
    public class StudentDaoJson : IStudentDao
    {
        private readonly string Path = FileUtils.Path("json");
        private List<Alumno> students = new List<Alumno>();
        public Alumno Add(Alumno student)
        {
            if (FileUtils.FileExists(Path))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        try
                        {
                            string lista = sr.ReadToEnd();  
                            students = JsonConvert.DeserializeObject<List<Alumno>>(lista);
                        }
                        catch (FileNotFoundException)
                        {
                            throw;
                        }
                        finally
                        {
                            sr.Close();
                            fs = null;
                        }
                    }
                    fs = new FileStream(Path,FileMode.Create,FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            student.ConvertDate();
                            students.Add(student);
                            string lista = JsonConvert.SerializeObject(students);
                            sw.WriteLine(lista);

                        }
                        catch (FileNotFoundException)
                        {
                            return null;
                            throw;
                        }
                        finally
                        {
                            sw.Close();
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    return null;
                    throw;
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
                return Deserialize();
               
            }
            else
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Path, FileMode.Create, FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            sw.WriteLine($"[{student.ToJson()}]");

                        }
                        catch (FileNotFoundException)
                        {
                            return null;
                            throw;
                        }
                        finally
                        {
                            sw.Close();
                        }
                    }
                }
                catch (FileLoadException)
                {
                    return null;
                    throw;
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
                return Deserialize();

            }
        }

        public Alumno Deserialize()
        {
            Alumno alumnoDS;
            FileStream fs = null;
            try
            {
                fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fs))
                {
                    try
                    {
                        string lista = sr.ReadToEnd();
                        students = JsonConvert.DeserializeObject<List<Alumno>>(lista);
                        alumnoDS = students.Last();
                        return alumnoDS;
                    }
                    catch (FileNotFoundException)
                    {
                        return null;
                        throw;
                    }
                    finally
                    {
                        sr.Close();
                    }
                }
            }
            catch (FileLoadException)
            {
                return null;
                throw;
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
