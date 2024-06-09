using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeManagementApp.Domain.Models
{
    public class Admin : Staff
    {
        
        public int AdminNumber { get; set; }
    }
}
