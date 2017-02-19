using System.Data.SQLite;
using Dapper;
using Dapper.Contrib.Extensions;

namespace SenarioAsyncLog
{
    public class Logger
    {
        public Logger()
        {
            try
            {
                string connectionString = @"data source=Demo.db3; Version=3;";
                using (var dbConnection = new SQLiteConnection(connectionString))
                {
                    dbConnection.Execute("CREATE TABLE [LogModels] ([Id] [VARCHAR2(50)], [Message] [VARCHAR2(1000)])");
                    dbConnection.Execute("CREATE INDEX [IX_LOGMODEL_ID] ON [LogModels] ([Id]);");
                }
            }
            catch
            {
            }
        }

        public void Log(LogModel log)
        {
            // Bu şekilde patlar aslında çünkü asyn olan iş bitine kadar connection uçuyor bile (en azından sql server da öyle..)
            string connectionString = @"data source=Demo.db3; Version=3;";
            using (var dbConnection = new SQLiteConnection(connectionString))
            {
                dbConnection.InsertAsync(log);
            }
        }
    }
}
