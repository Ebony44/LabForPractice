using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice
{
    public static class HelperClass
    {
        public static Array GetEnumValues<T>()
        {
            // var tempValues = Enum.GetValues(typeof(T));
            return Enum.GetValues(typeof(T));
        }
    }
}
