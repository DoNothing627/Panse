using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Panse.Models
{
    public class RePassword
    {
        [Key]
        public String pass { get; set; }
    }
}
