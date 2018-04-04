using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.Models;
using System.IO;
using Student.Common.Logic.FileUtils;
using System.Xml.Serialization;

namespace Student.DataAccess.Dao
{
    public class StudentDaoXml : IStudentDao
    {
        private readonly string Path = FileUtils.Path("xml");
        private List<Alumno> students = new List<Alumno>();
        public Alumno Add(Alumno student)
        {
            XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
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
                            String xml = sr.ReadToEnd();
                            StringReader stringReader = new StringReader(xml);
                            students = (List<Alumno>)xSeriz.Deserialize(stringReader);
                            student.ConvertDate();
                            students.Add(student);
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
                    fs = new FileStream(Path, FileMode.Create, FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            xSeriz.Serialize(sw,students);

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
                            student.ConvertDate();
                            students.Add(student);
                            xSeriz.Serialize(sw,students);

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
            XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
            Alumno alumnoDS;
            FileStream fs = null;
            try
            {
                fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fs))
                {
                    try
                    {
                        String xml = sr.ReadToEnd();
                        StringReader stringReader = new StringReader(xml);
                        students = (List<Alumno>)xSeriz.Deserialize(stringReader);
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
