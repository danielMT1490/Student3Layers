using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Common.Logic.Models
{
    public abstract class VuelingObject
    {
        public Guid Guid { get; set; }

        public new virtual string ToString()
        {
            StringBuilder Stb = new StringBuilder();
            string guidserializer = $"{Guid},";
            return Stb.Insert(0,guidserializer,1).ToString();
        }
        public  virtual string ToJson()
        {
            StringBuilder Stb = new StringBuilder();
            string guidserializer = $"[{{\"Guid\":\"{Guid}\"}}]";
            return Stb.Insert(0, guidserializer, 1).ToString();
        }
        public  virtual string ToXml()
        {
            StringBuilder Stb = new StringBuilder();
            string guidserializer = $"[<Guid>{Guid}</Guid>]";
            return Stb.Insert(0, guidserializer, 1).ToString();
        }
    }
}
