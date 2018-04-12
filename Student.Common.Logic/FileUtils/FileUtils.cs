using System;
using System.IO;
using Student.Common.Logic.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Common.Logic.FileUtils
{
    public static class FileUtils
    {
        public static string Path(string format)
        {
            return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Format.Registro + format);
        }
        public static bool FileExists(string path)
        {
            bool exists = File.Exists(path);
            return exists ;
        }
    }
}
