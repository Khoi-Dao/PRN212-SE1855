using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Reuse_As_Library
{
    public static class YourUtils
    {
        public static int TinhTuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.BirthDate.Year+1;
        }
    }
}
