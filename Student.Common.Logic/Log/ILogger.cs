using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Common.Logic.Log
{
    public interface ILogger
    {
        void Debug(object mensaje);
        void Error(object mensaje);
        void Info(object mensaje);
        void Error(Exception ex);
    }
}
