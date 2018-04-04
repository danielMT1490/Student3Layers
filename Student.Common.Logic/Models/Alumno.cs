using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Student.Common.Logic.Models
{
    public class Alumno : VuelingObject
    {
        #region Constructors
        public Alumno()
        {
            this.Guid = Guid.NewGuid();
        }
        public Alumno(Guid guid, int id, string dni ,string nombre, string apellidos,  int edad,string fechaNacimiento, string fechaRegistro)
        {
            this.Guid = guid;
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.DateBorn = Convert.ToDateTime(fechaNacimiento);
            this.DateRegistry = Convert.ToDateTime(fechaRegistro);
            this.Edad = edad;
        } 
        #endregion

        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        [JsonIgnore]
        [XmlIgnore]
        public DateTime DateBorn { get; set; }
        [JsonIgnore]
        [XmlIgnore]
        public DateTime DateRegistry { get; set; }
        public string DateRegistryString { get; set; }
        public int Edad { get; set; }
        public string DateBornString { get; set; }
        #endregion

        #region Metodos
        public override string ToJson()
        {
            this.ConvertDate();
            return JsonConvert.SerializeObject(this);
        }

        public override string ToString()
        {
            StringBuilder Sbt = new StringBuilder();
            string studentserializer = String.Format($"{Guid},{Id},{Dni},{Nombre},{Apellidos},{Edad},{DateBorn},{DateRegistry}");
            return Sbt.Insert(0, studentserializer, 1).ToString();
        }

        public override bool Equals(object obj)
        {
            Alumno student = obj as Alumno;
            return student != null &&
                   Id == student.Id &&
                   Nombre == student.Nombre &&
                   Apellidos == student.Apellidos &&
                   Dni == student.Dni && Guid == student.Guid
                   && student.Edad == Edad;
        }

        public override int GetHashCode()
        {
            var hashCode = -818402288;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Edad.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Guid.ToString());
            return hashCode;
        }
        public void ConvertDate()
        {
            this.DateBornString = DateBorn.ToShortDateString();
            this.DateRegistryString = DateRegistry.ToShortDateString();
        }
        #endregion
    }   
}
