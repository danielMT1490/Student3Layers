using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Student.Common.Logic.FileUtils
{
    public static class FormatUtil
    {
        public static void ChangeFormat(string format)
        {
            string valueAppConfig = ConfigurationManager.AppSettings["Format"];
            Environment.SetEnvironmentVariable(valueAppConfig , format, EnvironmentVariableTarget.User);
        }
        public static string Format()
        {
            string valueAppConfig = ConfigurationManager.AppSettings["Format"];
            string varilabre= Environment.GetEnvironmentVariable(valueAppConfig, EnvironmentVariableTarget.User);
            return varilabre;
        }
    }
}
