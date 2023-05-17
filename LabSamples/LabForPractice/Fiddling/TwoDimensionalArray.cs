using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.Fiddling
{
    class TwoDimensionalArray
    {
        public void TestDeclareTwoDimensionalArray()
        {
            int[,] tempArray = new int[3, 5]; // 3 row, 5 column
            // which could be
            // {0,1,2,3,4},
            // {1,2,3,4,5},
            // {2,3,4,5,6}

            // {0,1,2,3,4},
            // {10,11,12,13,14},
            // {20,21,22,23,24}

            tempArray[1, 2] = 30;

            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                Console.Write("current row value is " + i + " element is ");
                for (int k = 0; k < tempArray.GetLength(1); k++)
                {
                    tempArray[i, k] = i * 10 + k;
                    var tempValue = tempArray[i, k];
                    Console.Write(tempValue + ", ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
