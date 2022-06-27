using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    class CalcClockAngle_Ex
    {
        // calculate angle between Hour and Minutes
        /*
         * 
         *      Input:  
                h = 12:00
                m = 30.00
                Output: 
                165 degree
                
                Input:  
                h = 3.00
                m = 30.00
                Output: 
                75 degree
         * 
         */

        // I firstly try to find some principle or rule in problem

        // 12:00 -> 0 degree
        // 1:00 -> 30 ?
        // 2:00 -> 60 ?
        // 3:00 -> 90
        // 6:00 -> 180
        // 1:45 -> 90 + (30 + (30*.75)) = 142.5
        // -> 90 + 30 + 22.5 = 90 + 52.5 = 142.5

        // 3:30 = 75
        // 90 - 30 *1/2 = 90 - 15 = 75

        // 3:30
        // 3 * 30 - 30 * 0.5, 30*6
        // 90 + 15, 180
        
        // 105, 180
        // 180-105 = 75

        // 12:30
        // 0 + 30*0.5 , 30*6
        
        // 15,180
        // 180-15
        // 165


        // 3:45 = 165 -> 

        // per 1 min, 6 degree changes as min bar
        // per 1min, 0.5 degree changes as hour bar

        // 4:44 => 44 * 6, ((4 * 30) - 44*0.5)
        // => 264, 120-22 => 264, 98
        // 
        // 4:45 => 135


        // 166?

        public float CalculateAngle(int hour, int min)
        {
            float angle = 0f;
            var minuteHandBase = 6f;
            var hourHandMod = 0.5f;
            var hourHandBase = 30f;

            if(hour == 12)
            {
                hour = 0;
            }

            var hourResult = (hour * hourHandBase) + (min * hourHandMod);
            var minResult = min * minuteHandBase;

            float result = 0f;
            if(hourResult > minResult)
            {
                result = hourResult - minResult;
            }
            else
            {
                result = minResult - hourResult;
            }
            if(result > 180)
            {
                result = 360 - result;
            }
            angle = result;
            return angle;
        }

    }
}
