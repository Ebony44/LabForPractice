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
        // public List<BombNode> collectedBombNodes = new List<BombNode>(64);
        public Dictionary<int,BombNode> collectedBombNodes = new Dictionary<int,BombNode>(64);

        public int MaximumDetonation(int[][] bombs)
        {
            // guess this process time complexity should be O(n).. or O(2n), O(3n) = O(n) anyway
            int result = 0;

            // List<int> bombDetonateResult = new List<int>(bombs.Length);
            Dictionary<int, List<int>> bombDetonateResultDic = new Dictionary<int, List<int>>(bombs.Length);
            //Dictionary<int, int> bombDetonateResultDic = new Dictionary<int, int>(bombs.Length);
            // key's for index, list for that bomb's explosion results...

            int maximumExplosion = 0;
            #region
            for (int i = 0; i < bombs.Length; i++)
            {
                int[] currentBomb = bombs[i];
                // 0. store bomb's detonate result
                int nodeIndex = 0;
                if (bombDetonateResultDic.ContainsKey(i) == false)
                {
                    bombDetonateResultDic.Add(key: i, value: new List<int>(bombs.Length));
                }
                while (nodeIndex < bombs.Length)
                {
                    var tempDist = Distance(currentBomb, bombs[nodeIndex]);
                    // 
                    if(tempDist <= currentBomb[2])
                    {
                        // bomb explosion area reaches this bomb
                        bombDetonateResultDic[i].Add(nodeIndex);
                        // bombDetonateResultDic.Add(key: i, value: nodeIndex);


                    }
                    nodeIndex++;
                }
                //Distance(currentBomb,)

                // 1. use prev result to avoid duplicate search...

                // x. find best result bomb
            }

            //var tempStatementIndex = 0;
            //var tempTraverseList = new List<int>(bombDetonateResultDic.Count);
            //foreach (var item in bombDetonateResultDic)
            //{

            //    tempStatementIndex++;
            //}
            #region
            // var currentNode = bombDetonateResultDic[0];
            //var leftNode = new List<int>(64);
            //var traversedNode = new List<int>(64);
            //traversedNode.Add(0);
            //leftNode.AddRange(currentNode);
            //for (int i = 0; i < traversedNode.Count; i++)
            //{
            //    leftNode.Remove(traversedNode[i]);
            //}
            //var tempStatementIndex = 1;
            //while (leftNode.Count != 0)
            //{
            //    currentNode = bombDetonateResultDic[tempStatementIndex];
            //    leftNode.AddRange(currentNode);
            //    for (int i = 0; i < traversedNode.Count; i++)
            //    {
            //        leftNode.Remove(traversedNode[i]);
            //    }
            //    // tempStatementIndex++;
            //}
            #endregion

            var currentNode = bombDetonateResultDic[0];
            HashSet<int> leftNode = new HashSet<int>();
            foreach (var item in leftNode)
            {

            }
            #endregion


            return result;

        }


        public BombNode TraverseNode(int[][] bombs, BombNode node, int startIndex)
        // public void TraverseNode(int[][] bombs,ref BombNode node, int startIndex)
        {
            var currentNode = node;
            // 0 -> 0
            // 1 -> 0,1
            // 2 -> 1,2,0
            // {0,0,1}, {2,0,3}, {6,0,15}
            // 
            node.traversedNode.Add(node);
            if(node.leftNode.Count == 0)
            {
                return currentNode;
            }
            else
            {
                currentNode = node.leftNode.Dequeue();
                TraverseNode(bombs, node, startIndex);
            }
            return currentNode;


            #region
            //for (int i = 0; i < bombs.Length; i++)
            //{
            //    if(collectedBombNodes.ContainsKey(i)) //info already has stored, can reuse
            //    {
            //        continue;
            //    }
            //    node.leftNode.Enqueue(i);
            //}
            //var currentBomb = bombs[startIndex];
            //for (int i = 0; i < bombs.Length; i++)
            //{
            //    var tempDist = Distance(currentBomb, bombs[i]);
            //    if (tempDist <= currentBomb[2])
            //    {

            //    }
                
            //}
            //var tempIndex = 0;
            //var tempLoopIndex = 0;
            //while(node.leftNode.Count != 0)
            //{
            //    currentBomb = bombs[tempIndex];
            //    var tempDist = Distance(currentBomb, bombs[tempLoopIndex]);
            //    if (tempDist <= currentBomb[2])
            //    {

            //    }
            //    tempLoopIndex++;
            //}
            #endregion

            //if(node.leftNode.Count > 0)
            //{
            //    // node.leftNode.Dequeue()
            //}


            // return node;
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

        public class BombNode
        {
            public int index;
            // public List<int> traversedNode = new List<int>(64); // it means bomb reaches that node
            public List<BombNode> traversedNode = new List<BombNode>(64); // it means bomb reaches that node

            // List<int> leftNode = new List<int>(64);
            // public Queue<int> leftNode = new Queue<int>(64);
            public Queue<BombNode> leftNode = new Queue<BombNode>(64);


        }

    }

    
}
