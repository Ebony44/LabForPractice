using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{

    /*
     * 
     * You are given a list of bombs. The range of a bomb is defined as the area where its effect can be felt. 
     * This area is in the shape of a circle with the center as the location of the bomb.

        The bombs are represented by a 0-indexed 2D integer array bombs where bombs[i] = [xi, yi, ri]. 
    xi and yi denote the X-coordinate and Y-coordinate of the location of the ith bomb, whereas ri denotes the radius of its range.
        
        You may choose to detonate a single bomb. When a bomb is detonated, 
    it will detonate all bombs that lie in its range. These bombs will further detonate the bombs that lie in their ranges.
        
        Given the list of bombs, return the maximum number of bombs that can be detonated if you are allowed to detonate only one bomb.
    
     * 
     * Input: bombs = [[2,1,3],[6,1,4]]
        Output: 2
        Explanation:
        The above figure shows the positions and ranges of the 2 bombs.
        If we detonate the left bomb, the right bomb will not be affected.
        But if we detonate the right bomb, both bombs will be detonated.
        So the maximum bombs that can be detonated is max(1, 2) = 2.
     * 
     * 
     * Input: bombs = [[1,1,5],[10,10,5]]
Output: 1
Explanation:
Detonating either bomb will not detonate the other bomb, so the maximum number of bombs that can be detonated is 1.
     * 
     * 
     * Input: bombs = [[1,2,3],[2,3,1],[3,4,2],[4,5,3],[5,6,4]]
Output: 5
Explanation:
The best bomb to detonate is bomb 0 because:
- Bomb 0 detonates bombs 1 and 2. The red circle denotes the range of bomb 0.
- Bomb 2 detonates bomb 3. The blue circle denotes the range of bomb 2.
- Bomb 3 detonates bomb 4. The green circle denotes the range of bomb 3.
Thus all 5 bombs are detonated.

    
    1 <= bombs.length <= 100
    bombs[i].length == 3
    1 <= xi, yi, ri <= 105

     * 
     */
    class Detonate_the_Maximum_Bombs_2101
    {

        public int MaximumDetonation(int[][] bombs)
        {
            // guess this process time complexity should be O(n)
            int result = 0;

            List<int> bombDetonateResult = new List<int>(bombs.Length);
            int maximumExplosion = 0;
            #region
            for (int i = 0; i < bombs.Length; i++)
            {
                int[] currentBomb = bombs[i];
                // 0. store bomb's detonate result
                int nodeIndex = 0;
                while(false)
                {
                    Distance(currentBomb, bombs[nodeIndex]);
                    nodeIndex++;
                }
                //Distance(currentBomb,)

                // 1. use prev result to avoid duplicate search...

                // x. find best result bomb
            }
            #endregion


            return result;



        }

        public struct float2
        {
            public float x;
            public float y;

            public float2(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

        }

        public float Distance(float2 a, float2 b)
        {
            float result = ((a.x - b.x) * (a.x - b.x)) + ((a.y - b.y) * (a.y - b.y));
            return (float)Math.Sqrt(result);
        }
        public float Distance(int[] a, int[] b)
        {
            int x = 0;
            int y = 1;
            float result = ((a[x] - b[x]) * (a[x] - b[x])) + ((a[y] - b[y]) * (a[y] - b[y]));
            return (float)Math.Sqrt(result);
        }
    }

    
}
