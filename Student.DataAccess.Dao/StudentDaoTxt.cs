using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;
using System.IO;

namespace Student.DataAccess.Dao
{
    public class StudentDaoTxt : IStudentDao
    {
        private readonly string Path = FileUtils.Path("txt");

        public Alumno Add(Alumno student)
        {
            if (FileUtils.FileExists(Path))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Path,FileMode.Append,FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            sw.WriteLine(student.ToString());
                           
                        }
                        catch (FileNotFoundException)
                        {
                            return null;
                            throw ;
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
                    throw ;
                }
                finally
                {
                    if (fs!=null) fs.Close();
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
                            sw.WriteLine(student.ToString());
                           
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
                        string[] props = new string[8];
                        string linea = "";
                        while ((linea = sr.ReadLine()) != null)
                        {
                            props = linea.Split(',');
                        }
                        alumnoDS = new Alumno(Guid.Parse(props[0]), Convert.ToInt32(props[1]), props[2], props[3], props[4], Convert.ToInt32(props[5]), props[6], props[7]);
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
