using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeManagementApp.Domain.Models
{
    internal class Company
    {
        [Key]
        public int Id { get; set; }
        List<Staff> staffsList;
        List<Admin> adminLists;
    }
}
