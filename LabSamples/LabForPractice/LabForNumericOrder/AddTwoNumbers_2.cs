using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
    /*
     * 
     * You are given two non-empty linked lists representing two non-negative integers. 
     * The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
     * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
     * 
     * Input: l1 = [2,4,3], l2 = [5,6,4]
    Output: [7,0,8]
    Explanation: 342 + 465 = 807.
     * 
     * 
     * Input: l1 = [0], l2 = [0]
Output: [0]

     * 
     * Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
     * 
     * 
    The number of nodes in each linked list is in the range [1, 100].
    0 <= Node.val <= 9
    It is guaranteed that the list represents a number that does not have leading zeros.

     * 
     * 
     * [9,9,9,9,9,9,9]
       [9,9,9,9]
    8,9,9,9,0,0,0,1
    8,9,9,9,0,0,0

            [8,9,9,9,0,0,0]
Expected    [8,9,9,9,0,0,0,1]

     */

    class AddTwoNumbers_2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            return new ListNode(0);
        }

        public static ListNode AddTwoNumbers_Temp(ListNode l1, ListNode l2)
        {
            // 1. 
            // 2. 
            var tempBool = false;
            var firstNode = l1;
            var secondNode = l2;
            var tempBool2 = firstNode != null || secondNode != null;
            ListNode returningNode = new ListNode(0);

            int tempAssertion = 0;
            const int MAX_ASSERTION = 100;

            int tempInt = 0;
            while (tempBool2)
            {
                if(firstNode != null)
                {
                    tempInt += firstNode.val;
                    firstNode = firstNode.next;
                }
                else
                {
                    firstNode = null;
                }
                if(secondNode != null)
                {
                    tempInt += secondNode.val;
                    secondNode = secondNode.next;
                }
                else
                {
                    secondNode = null;
                }

                // firstNode = firstNode.next;
                // secondNode = secondNode.next;
                
                if(tempAssertion >= MAX_ASSERTION)
                {
                    Console.WriteLine("it's broken for assertion");
                    break;
                }
                tempAssertion++;
            }

            return returningNode;
        }

        public static ListNode AddTwoNumbers_Temp2(ListNode l1, ListNode l2)
        {
            // 1. 
            // 2. 
            var tempBool = false;
            var firstNode = l1;
            var secondNode = l2;
            var tempBool2 = firstNode != null || secondNode != null;
            ListNode returningNode = new ListNode(0);
            var originNode = returningNode;

            int tempAssertion = 0;
            const int MAX_ASSERTION = 100;

            int tempInt = 0;
            int succeededInt = 0;
            while (firstNode != null || secondNode != null
                || succeededInt == 0)
            {
                // 0. init sum of two nodes
                tempInt = 0;
                if(succeededInt >= 1)
                {
                    tempInt += 1;
                    succeededInt = 0;
                }

                if (firstNode != null)
                {
                    tempInt += firstNode.val;
                    firstNode = firstNode.next;
                }
                else
                {
                    firstNode = null;
                }
                if (secondNode != null)
                {
                    tempInt += secondNode.val;
                    secondNode = secondNode.next;
                }
                else
                {
                    secondNode = null;
                }
                if(tempInt >= 10)
                {
                    succeededInt = 1;
                    tempInt -= 10;
                }
                returningNode.val = tempInt;
                if (succeededInt != 0
                    && (firstNode == null && secondNode == null))
                {
                    returningNode.next = new ListNode(succeededInt);
                    return originNode;
                }
                else if(succeededInt == 0
                    && (firstNode == null && secondNode == null))
                {
                    return originNode;
                }


                // returningNode.val = tempInt;
                if (firstNode == null && secondNode == null) // pre-check for no 0 next...
                {

                }
                else
                {
                    returningNode.next = new ListNode(0);
                    returningNode = returningNode.next;
                }



                // firstNode = firstNode.next;
                // secondNode = secondNode.next;

                //if (tempAssertion >= MAX_ASSERTION)
                //{
                //    Console.WriteLine("it's broken for assertion");
                //    break;
                //}
                //tempAssertion++;

            }

            return originNode;
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                {
                    this.val = val;
                    this.next = next;
                }
            }
        }


        public static void TempTest()
        {
            ListNode tempNodeFirst = new ListNode(2);
            ListNode tempNodeSecond = new ListNode(4);

            var tempNodeStoredFirst = tempNodeFirst;
            var tempNodeStoredSecond = tempNodeSecond;

            //for (int i = 0; i < 4; i++)
            //{
            //    tempNodeFirst.next = new ListNode(4 + i);
            //    tempNodeFirst = tempNodeFirst.next;
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    tempNodeSecond.next = new ListNode(1 + i);
            //    tempNodeSecond = tempNodeSecond.next;
            //}
            // AddTwoNumbers_Temp(tempNodeFirst, tempNodeSecond);
            // AddTwoNumbers_Temp(tempNodeStored, tempNodeSecond);
            // 2,4,5,6,7
            // 4,1,2,3,4,5,6
            // 6,5,7,9,1,6,

            #region
            //for (int i = 0; i < 4; i++)
            //{
            //    tempNodeFirst.next = new ListNode(9);
            //    tempNodeFirst = tempNodeFirst.next;
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    tempNodeSecond.next = new ListNode(1);
            //    tempNodeSecond = tempNodeSecond.next;
            //}
            // 2,9,9,9,9
            // 4,1,1,1,1,1,1
            // 6,0,1,1,1,2,1
            #endregion
            #region
            //for (int i = 0; i < 4; i++)
            //{
            //    tempNodeFirst.next = new ListNode(9);
            //    tempNodeFirst = tempNodeFirst.next;
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    tempNodeSecond.next = new ListNode(9);
            //    tempNodeSecond = tempNodeSecond.next;
            //}
            //// 2,9,9,9,9
            //// 4,9,9,9,9,9,9
            //// 6,8,9,9,9,0,0
            // [9,9,9,9,9,9,9]
            // [9,9,9,9]
            #endregion
            #region case 4
            //// [9,9,9,9,9,9,9]
            //// [9,9,9,9]
            //tempNodeFirst.val = 9;
            //tempNodeSecond.val = 9;
            //for (int i = 0; i < 6; i++)
            //{
            //    tempNodeFirst.next = new ListNode(9);
            //    tempNodeFirst = tempNodeFirst.next;
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    tempNodeSecond.next = new ListNode(9);
            //    tempNodeSecond = tempNodeSecond.next;
            //}
            //// 9,9,9,9,9,9,9
            //// 9,9,9,9
            //// 8,9,9,9,0,0,0,1
            #endregion
            #region case 5
            //// [9,9,9,9,9,9,9]
            //// [9,9,9,9]
            //tempNodeFirst.val = 9;
            //tempNodeSecond.val = 9;
            //for (int i = 0; i < 6; i++)
            //{
            //    tempNodeFirst.next = new ListNode(9);
            //    tempNodeFirst = tempNodeFirst.next;
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    tempNodeSecond.next = new ListNode(9);
            //    tempNodeSecond = tempNodeSecond.next;
            //}
            //// 9,9,9,9,9,9,9
            //// 9,9,9,9,9,9,9
            //// 8,9,9,9,9,9,9,1
            #endregion
            #region case 6
            // [0,0,0,0,0,0,1]
            // [0,0,0,1]
            tempNodeFirst.val = 0;
            tempNodeSecond.val = 0;
            for (int i = 0; i < 5; i++)
            {
                tempNodeFirst.next = new ListNode(0);
                tempNodeFirst = tempNodeFirst.next;
            }
            tempNodeFirst.next = new ListNode(1);
            // tempNodeFirst = tempNodeFirst.next;
            for (int i = 0; i < 2; i++)
            {
                tempNodeSecond.next = new ListNode(0);
                tempNodeSecond = tempNodeSecond.next;
            }
            tempNodeSecond.next = new ListNode(1);
            
            // 0,0,0,0,0,0,1
            // 0,0,0,1
            // 0,0,0,1,0,0,1
            #endregion
            var testNode = AddTwoNumbers_Temp2(tempNodeStoredFirst, tempNodeStoredSecond);

            int tempAssertion = 0;
            const int MAX_ASSERTION = 100;
            var testNodeWhileLoop = testNode;
            var tempInt = 0;
            while (testNodeWhileLoop != null)
            {
                Console.WriteLine(tempInt + "'s value is " + testNodeWhileLoop.val);
                testNodeWhileLoop = testNodeWhileLoop.next;
                if (tempAssertion >= MAX_ASSERTION)
                {
                    Console.WriteLine("it's broken for assertion");
                    break;
                }
                tempAssertion++;
                tempInt++;
            }
        }

    }
}
