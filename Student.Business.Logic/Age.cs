using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Student.Common.Logic.Log;

namespace Student.Business.Logic
{
    public static class Age
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static int AreAge(DateTime dateBorn, DateTime dateRegis)
        {
            try
            {
                if (dateBorn.Month > dateRegis.Month)
                {
                    Log.Debug("Edad calculada");
                    return Convert.ToInt32((dateRegis.Year - dateBorn.Year) - 1);
                }
                else
                {
                    if (dateBorn.Month == dateRegis.Month && dateBorn.Day > dateRegis.Day)
                    {
                        return Convert.ToInt32((dateRegis.Year - dateBorn.Year) - 1);
                    }
                    Log.Debug("Edad calculada");
                    return Convert.ToInt32(dateRegis.Year - dateBorn.Year);
                }
            }
            catch (FormatException e)
            {
                Log.Debug("Formato de fecha erroneo"+e);
                throw;
            }
         
            
        }
    }
}
