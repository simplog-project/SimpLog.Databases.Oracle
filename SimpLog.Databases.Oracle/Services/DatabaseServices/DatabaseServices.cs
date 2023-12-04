using SimpLog.Databases.Oracle.Entities;
using SimpLog.Databases.Oracle.Models;
using SimpLog.Databases.Oracle.Models.AppSettings;

namespace SimpLog.Databases.Oracle.Services.DatabaseServices
{
    internal class DatabaseServices
    {
        public static Configuration conf = ConfigurationServices.ConfigService.BindConfigObject();

        /// <summary>
        /// Depending on the name of the DB, goes to the function for that stuff.
        /// </summary>
        /// <param name="DbName"></param>
        /// <param name="storeLog"></param>
        /// <param name="isEmailSend"></param>
        /// <param name="saveInDatabase"></param>
        public static void SaveIntoDatabase(string DbName, StoreLog storeLog, bool? isEmailSend, bool? saveInDatabase)
        {
            if(DbName.Equals(Global_Database_Type.Oracle.DisplayName()))
                InsertIntoOracle(storeLog, isEmailSend);
            else
                return;
        }

        public static void InsertIntoOracle(StoreLog storeLog, bool? isEmailSend)
        {
            //  To be implemented
        }
    }
}
