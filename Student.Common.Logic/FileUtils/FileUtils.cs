using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Common.Logic.FileUtils
{
    public static class FileUtils
    {
        public static string Path(string Format)
        {
            return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Registro." + Format);
        }
        public static bool FileExists(string path)
        {
            bool exists = File.Exists(path);
            return exists ;
        }
    }
}
