using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.Log;
using Student.Common.Logic.Models;
using System.Data.SqlClient;
using Student.Common.Logic.Resources;
using Student.DataAccess.Dao.Resources;

namespace Student.DataAccess.Dao
{
    public class StudentDaoSql : IStudentDao 
        
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public List<Alumno> Students { get; set; }
        public Alumno Student { get; set; }
        private SqlConnection _conn { get; set; }
        private SqlCommand _cmd { get; set; }
        private readonly string connectionString;

        public StudentDaoSql()
        {
            _conn = null;
            connectionString = Environment.GetEnvironmentVariable(EnvioremntVariable.Database,EnvironmentVariableTarget.User);
        }

        public Alumno Add(Alumno student)
        {
            student.ConvertDate();
            string sql = Querys.Insert;
            Log.Debug($"Añadimos los datos {student.ToString()}");
            try
            {
                using (_conn=new SqlConnection(connectionString))
                {
                    using (_cmd=new SqlCommand(sql,_conn))
                    {
                        _conn.Open();
                        
                        _cmd.Parameters.AddWithValue("@UUID",student.Guid.ToString());
                        _cmd.Parameters.AddWithValue("@Nombre", student.Nombre);
                        _cmd.Parameters.AddWithValue("@Apellido", student.Apellidos);
                        _cmd.Parameters.AddWithValue("@Dni", student.Dni);
                        _cmd.Parameters.AddWithValue("@DateRegistry", student.DateRegistryString);
                        _cmd.Parameters.AddWithValue("@DateBorn", student.DateBornString);
                        _cmd.Parameters.AddWithValue("@Edad", student.Edad);
                        _cmd.ExecuteNonQuery();
                        _cmd.Parameters.Clear();
                        _cmd.CommandText = "SELECT @@IDENTITY";

                        // Obtenga la última identificación insertada. 
                        student.Id = Convert.ToInt32(_cmd.ExecuteScalar());
                        Log.Debug($"Recuperamos el id {student.Id}");
                        return LastInsert(_conn,student.Guid.ToString());
                    }
                   
                }
            }
            catch (InvalidOperationException ex)
            {
                Log.Error(ex);

                throw;
            }
            catch (SqlException ex)
            {
                Log.Error(ex);

                throw;
            }
           
        }


        public List<Alumno> GetAll()
        {
            Students = new List<Alumno>();
            
            string sql =Querys.SelectAll;

            Log.Debug($"Añadimos los datos a lista Students");
            try
            {
                using (_conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand _cmd = new SqlCommand(sql, _conn))
                    {
                        _conn.Open();
                        using (SqlDataReader srd = _cmd.ExecuteReader())
                        {
                                while (srd.Read())
                                {
                                    Student = new Alumno
                                    {
                                        Guid = Guid.Parse(srd["UUID"].ToString()),
                                        Id = Convert.ToInt32(srd["Id"].ToString()),
                                        Nombre = srd["Nombre"].ToString(),
                                        Apellidos = srd["Apellido"].ToString(),
                                        Dni = srd["Dni"].ToString(),
                                        DateRegistry = Convert.ToDateTime(srd["DateRegistry"].ToString()),
                                        DateBorn = Convert.ToDateTime(srd["DateBorn"].ToString()),
                                        Edad = Convert.ToInt32(srd["Edad"].ToString())
                                    };
                                    Log.Debug($"Añadimos {Student.ToString()} en memoria");
                                    Students.Add(Student);
                                }
                               return Students; 
                            
                        }
 
                        
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Log.Error(ex);

                throw;
            }
            catch (SqlException ex)
            {
                Log.Error(ex);

                throw;
            }
         
        }
        private Alumno LastInsert(SqlConnection conn,string guid)
        {
            string sql = $"select * from dbo.Students where UUID ={guid}";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader srd = cmd.ExecuteReader())
                    {
                        Student = new Alumno
                        {
                            Guid = Guid.Parse(srd["UUID"].ToString()),
                            Id = Convert.ToInt32(srd["Id"].ToString()),
                            Nombre = srd["Nombre"].ToString(),
                            Apellidos = srd["Apellido"].ToString(),
                            Dni = srd["Dni"].ToString(),
                            DateRegistry = Convert.ToDateTime(srd["DateRegistry"].ToString()),
                            DateBorn = Convert.ToDateTime(srd["DateBorn"].ToString()),
                            Edad = Convert.ToInt32(srd["Edad"].ToString())
                        };
                        return Student;
                    }
                }
            }
            catch (SqlException ex)
            {
                Log.Error(ex);
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Log.Error(ex);
                throw;
            }            

        }
        
       public Alumno SelectGuid(string guid)
       {
            try
            {
                string sql = $"select * from dbo.Students where UUID ={guid}";
                using (_conn = new SqlConnection(connectionString))
                {
                    using (_cmd = new SqlCommand(sql, _conn))
                    {
                        _conn.Open();
                        using (SqlDataReader srd = _cmd.ExecuteReader())
                        {
                            if (srd.Read())
                            {
                                Student = new Alumno
                                {
                                    Guid = Guid.Parse(srd["UUID"].ToString()),
                                    Id = Convert.ToInt32(srd["Id"].ToString()),
                                    Nombre = srd["Nombre"].ToString(),
                                    Apellidos = srd["Apellido"].ToString(),
                                    Dni = srd["Dni"].ToString(),
                                    DateRegistry = Convert.ToDateTime(srd["DateRegistry"].ToString()),
                                    DateBorn = Convert.ToDateTime(srd["DateBorn"].ToString()),
                                    Edad = Convert.ToInt32(srd["Edad"].ToString())
                                };
                                Log.Debug($"Añadimos {Student.ToString()} en memoria");
                            }
                            return Student;
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                Log.Error(ex);
                throw;
            }
            catch(InvalidOperationException ex)
            {
                Log.Error(ex);
                throw;
            }
           
       }

        public int Delete(string guid)
        {
            try
            {
                string sql = "Delete from Students where UUID = @UUID";
                using (_conn= new SqlConnection(connectionString))
                {
                    using (_cmd= new SqlCommand(sql,_conn))
                    {
                        _cmd.Parameters.AddWithValue("@UUID",guid);
                       return _cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Log.Error(ex);
                throw;
            }
            catch(InvalidOperationException ex)
            {
                Log.Error(ex);
                throw;
            }
        }

       
        
        
    }
}
