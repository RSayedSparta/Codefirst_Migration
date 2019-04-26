using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Initialize
    {
        public static EmployeeManagementContext GetContext()
        {
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=EmployeeManagementDB;Trusted_Connection=True;";
            DbContextOptionsBuilder<EmployeeManagementContext> options = new DbContextOptionsBuilder<EmployeeManagementContext>();
            options.UseSqlServer(connectionString);
            return new EmployeeManagementContext(options.Options);
        }
    }
}
