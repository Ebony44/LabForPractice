using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.Fiddling
{
    public class FiddlingClass
    {
        OtherFiddlingClass tempOtherClass;

        public void TestShow()
        {
            var tempClass = tempOtherClass;
            tempOtherClass = new OtherFiddlingClass();
            var tempClass2 = tempOtherClass;
            tempOtherClass = null;
        }

    }
    public class OtherFiddlingClass
    {

    }
}
