using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.Fiddling
{
    public class ReflectionPracticeClass : ReflectionBaseClass
    {
        private int childInt;

        public ReflectionPracticeClass()
        {

        }

        public ReflectionPracticeClass(int paramChild,int paramBase)
        {
            childInt = paramChild;
            base.baseIntProp = paramBase;
        }

    }

    public class ReflectionBaseClass
    {
        protected int baseIntProp 
        { 
            get
            {
                return baseInt;
            }
            set
            {
                baseInt = value;
            }
        }
        private int baseInt;

    }
}
