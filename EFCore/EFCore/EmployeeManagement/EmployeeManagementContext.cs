using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeManagementContext: DbContext
    {
        public EmployeeManagementContext(DbContextOptions<EmployeeManagementContext> options): base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<FileInfo> FileInfos { get; set; }
    }
}
