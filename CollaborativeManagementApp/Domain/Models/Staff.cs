using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeManagementApp.Domain.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string StaffName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int StaffNumber { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsClockedIn { get; set; }

        public bool IsActive { get; set; }

        public bool IsloggedIn { get; set; }
    }
}
