using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panse.Models
{
    public class Password
    {
        public int Id { get; set; }
        public String pass { get; set; }
        public void SetPassword(String _pass)
        {
            pass = _pass;
        }
        public String GetPassword()
        {
            return pass;
        }
    }
}
