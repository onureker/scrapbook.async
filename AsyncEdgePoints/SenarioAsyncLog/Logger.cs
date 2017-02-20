using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Threading.Tasks;
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

        //LogDb methodu Task dönmeli çünkü void olursa ve hata alırsa application crash olur.
        //Ama eğer async olsun istiyorsa, çağıran await etmesine gerek yoktur
        public async Task LogDb(LogModel log)
        {
            string connectionString = @"data source=Demo.db3; Version=3;";
            using (var dbConnection = new SQLiteConnection(connectionString))
            {
                // Await edilmezse patlar aslında çünkü, async olan iş bitine kadar connection uçuyor olabilir.
                await dbConnection.InsertAsync(log);
            }
        }

        public async Task LogConsole(LogModel log)
        {
            await Task.Run(() =>
            {
                Console.WriteLine(log.Message);
            });
        }

        public Task LogTrace(LogModel log)
        {
            return Task.Run(() =>
            {
                Trace.WriteLine(log.Message);
            });
        }
    }
}
