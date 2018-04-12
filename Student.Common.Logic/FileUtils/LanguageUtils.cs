using Student.Common.Logic.Resources;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Common.Logic.FileUtils
{
    public static class LanguageUtils
    {
        public static void ChangeLanguageConfig(string language)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[ConfigVariable.Language].Value= language;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(ConfigVariable.Language);
        }
        public static string GetLanguageConfig()
        {
           return ConfigurationManager.AppSettings[ConfigVariable.Language];
        }
    }
}
