using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    public class MyDbExecutionStrategy : DbExecutionStrategy
    {
        private static int times;


        public MyDbExecutionStrategy(int maxRetryCount, TimeSpan maxDelay) : base(maxRetryCount, maxDelay)
        {
            
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override TimeSpan? GetNextDelay(Exception lastException)
        {
            return base.GetNextDelay(lastException);
        }

        protected override bool ShouldRetryOn(Exception ex)
        {
            bool retry = false;

            SqlException sqlException = ex as SqlException;

            if (sqlException != null)
            {
                int[] errorsToRetry =
                {
                    1205 // deadlock
                    , -2 //timeout
                   // ,2601 //primary key violation
                };
                if (sqlException.Errors.Cast<SqlError>().Any(x => errorsToRetry.Contains((x.Number))))
                {
                    times++;
                    retry = true;
                    Console.WriteLine("Zapytanie nie zostało wykonane, próbuję ponownie. Próba: {0}. \n {1}",times, ex.Message);
                    
                }
                else
                {
                    
                    //gdy wystapi jakis inny blad
                }
            }
            if (ex is TimeoutException)
            {
                retry = true;
            }
            times = 0;
            return retry;

        }
    }
    public class MyDbConfiguration : DbConfiguration
    {
        
        public MyDbConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new MyDbExecutionStrategy(5, TimeSpan.FromSeconds(0.5)));
        }
    }
}
