using CollaborativeManagementApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeManagementApp.Data_Access.DataContext
{
    internal class StaffManagementContext : DbContext
    {
        DbSet<Staff> Staff { get; set; }
        DbSet<Admin>Admin { get; set; }
        DbSet <Company>Company { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-04DUL3J\\SQLEXPRESS; Database= Staff-Management; Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
