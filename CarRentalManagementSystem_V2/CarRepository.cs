using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V2
{
    public class CarRepository
    {
         //connection = new SqlServerConnection("Server=(localdb)\\MSSQLLocalDB; Database = CarRentalManagement ; Trusted_Connection = True; TrustServerCertificate = True ");
         public void AddCars(Car car)
        {
            using (SqlServerConnection connection =new SqlServerConnection("Server=(localdb)\\MSSQLLocalDB; Database = CarRentalManagement ; Trusted_Connection = True; TrustServerCertificate = True "))
            {

            }
        }
    }
}
