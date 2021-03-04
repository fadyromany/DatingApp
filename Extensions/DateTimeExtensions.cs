using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var Today = DateTime.Now;
            var age = Today.Year - dob.Year;
            if (dob.Date > Today.AddYears(-age))
                age--;
            return age;
        }
    }
}
