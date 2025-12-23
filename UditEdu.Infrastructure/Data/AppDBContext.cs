using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Entities;

namespace UditEdu.Infrastructure.Data
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {
        public DbSet<EmployeeEntity> Employees { get; set; } 
    }
}
