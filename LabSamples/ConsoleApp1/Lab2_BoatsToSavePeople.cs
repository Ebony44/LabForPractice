using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_881
{
    class Lab2_BoatsToSavePeople
    {
        #region explanation
        /*
         * You are given an array people where people[i] is the weight of the ith person, 
         * and an infinite number of boats where each boat can carry a maximum weight of limit. 
         * Each boat carries at most two people at the same time, provided the sum of the weight of those people is at most limit.

Return the minimum number of boats to carry every given person.

 

Example 1:

Input: people = [1,2], limit = 3
Output: 1
Explanation: 1 boat (1, 2)

Example 2:

Input: people = [3,2,2,1], limit = 3
Output: 3
Explanation: 3 boats (1, 2), (2) and (3)

Example 3:

Input: people = [3,5,3,4], limit = 5
Output: 4
Explanation: 4 boats (3), (3), (4), (5)

 

Constraints:

    1 <= people.length <= 5 * 104
    1 <= people[i] <= limit <= 3 * 104


        public int NumRescueBoats(int[] people, int limit) 

         */
        #endregion

        public static int NumRescueBoats(int[] people, int limit)
        {

            var maxWeight = 3 * 104;
            var maxLength = 5 * 104;
            Dictionary<int, int> peopleAsWeight = new Dictionary<int, int>(capacity: maxWeight); // key as weight, value as people count
            // System.Collections.Specialized.OrderedDictionary peopleAsWeightOrdered = new System.Collections.Specialized.OrderedDictionary(capacity: maxWeight);

            for (int i = 0; i < people.Length; i++)
            {
                if(peopleAsWeight.ContainsKey(people[i]) == false)
                {
                    peopleAsWeight.Add(people[i], 1);
                }
                else
                {
                    peopleAsWeight[people[i]]++; // count increment
                }
            }
            var tempMax = peopleAsWeight.Keys.Max();
            
            var tempListForSortedWeight = new List<int>(capacity: maxWeight);
            foreach (var item in peopleAsWeight)
            {
                tempListForSortedWeight.Add(item.Key);
            }
            tempListForSortedWeight = tempListForSortedWeight.OrderByDescending(x => x).ToList();

            var noMoreLeft = false;

            int assertIteration = 0;
            const int MAX_ASSERTION = 5 * 104 * 40000;
            const int INNER_MAX_ASSERTION = 5 * 104 * 20000;
            
            int boatOnRideWeight = 0;
            int boatRideCount = 0;

            var tempStartIndex = 0;

            //List<List<int>> tempOnlyDisplayList = new List<List<int>>();
            //for (int i = 0; i < 500; i++)
            //{
            //    tempOnlyDisplayList.Add(new List<int>(capacity: 50));
            //}
            

            while (noMoreLeft == false)
            {
                // 1. get max of left of dictionary
                if (peopleAsWeight.Count == 0)
                {
                    noMoreLeft = true;
                    break;
                }
                var tempCurrentMax = peopleAsWeight.Keys.Max();

                boatOnRideWeight = 0;
                
                if (peopleAsWeight[tempCurrentMax] > 0)
                {
                    // boatOnRideWeight += peopleAsWeight[tempCurrentMax];
                    boatOnRideWeight += tempCurrentMax;
                    peopleAsWeight[tempCurrentMax]--;

                    // tempStartIndex = tempListForSortedWeight.FindIndex(x => x == peopleAsWeight[tempCurrentMax]);
                    tempStartIndex = tempListForSortedWeight.FindIndex(x => x == tempCurrentMax);

                    if (peopleAsWeight[tempCurrentMax] == 0)
                    {
                        peopleAsWeight.Remove(tempCurrentMax); // remove from dic
                        tempListForSortedWeight.Remove(tempCurrentMax); // remove from list

                        if(peopleAsWeight.Count != 0)
                        {
                            var tempChangedMax = peopleAsWeight.Keys.Max();
                            // tempStartIndex = tempListForSortedWeight.FindIndex(x => x == peopleAsWeight[tempChangedMax]);
                            tempStartIndex = tempListForSortedWeight.FindIndex(x => x == tempChangedMax);
                        }

                        
                    }
                    

                }
                else
                {
                    Console.WriteLine("ERROR, MAX should be recalculated");
                    if(peopleAsWeight.Count == 0)
                    {
                        noMoreLeft = true;
                        break;
                    }
                    continue;
                }
                // 2. plus on going for that value
                var tempRideDone = false;
                // var maxStartIndex = -1;
                // var maxCurrentStartIndex = -1;

                var tempCurrentWeight = boatOnRideWeight;
                
                var excludedIndexes = new List<int>(capacity: maxLength);
                var innerAssertIteration = 0;
                var tempDic = new Dictionary<int, int>(peopleAsWeight);

                if(tempListForSortedWeight.Count == 0)
                {
                    // tempOnlyDisplayList[boatRideCount].Add(boatOnRideWeight);
                    boatRideCount++;

                    // ShowBoatRider(tempOnlyDisplayList);
                    return boatRideCount;
                }
                var tempInnerCurrentMax = tempListForSortedWeight[tempStartIndex];

                while (tempRideDone == false)
                {
                    // var tempSubDic = new Dictionary<int, int>(tempDic);
                    if (boatOnRideWeight == limit) // iteration done when it's fit
                    {
                        // tempOnlyDisplayList[boatRideCount].Add(boatOnRideWeight);
                        boatRideCount++;
                        tempRideDone = true;
                        break;
                    }
                    else
                    {
                        if(peopleAsWeight.Count == 0)
                        {
                            // tempOnlyDisplayList[boatRideCount].Add(boatOnRideWeight);
                            boatRideCount++;
                            tempRideDone = true;
                            break; // reach the limit
                        }
                        if(peopleAsWeight[tempInnerCurrentMax] != 0) // if current weight of people count isn't 0
                        {
                            var tempCheckValue = boatOnRideWeight + tempInnerCurrentMax;
                            if(tempCheckValue == limit)
                            {
                                // tempOnlyDisplayList[boatRideCount].Add(boatOnRideWeight);
                                // tempOnlyDisplayList[boatRideCount].Add(tempInnerCurrentMax);
                                boatRideCount++;
                                tempRideDone = true;
                                
                                peopleAsWeight[tempInnerCurrentMax]--; // minus that people
                                if(peopleAsWeight[tempInnerCurrentMax] == 0)
                                {
                                    // var tempIndex = tempListForSortedWeight.FindIndex(x => x == tempInnerCurrentMax);

                                    peopleAsWeight.Remove(tempInnerCurrentMax);
                                    tempListForSortedWeight.Remove(tempInnerCurrentMax);
                                    
                                    
                                }

                                break;
                            }
                            else if(tempCheckValue < limit) // plus more if any weight of people left
                            {
                                // boatRideCount++;
                                // tempRideDone = true;
                                // tempOnlyDisplayList[boatRideCount].Add(tempInnerCurrentMax);
                                boatOnRideWeight = tempCheckValue;
                                peopleAsWeight[tempInnerCurrentMax]--; // minus that people
                                if (peopleAsWeight[tempInnerCurrentMax] == 0)
                                {
                                    peopleAsWeight.Remove(tempInnerCurrentMax);
                                    tempListForSortedWeight.Remove(tempInnerCurrentMax);
                                    if(tempStartIndex == 0)
                                    {
                                        tempStartIndex = 0;
                                    }
                                    else
                                    {
                                        tempStartIndex -= 1;
                                    }
                                    if (CheckIndexInList(tempListForSortedWeight, (tempStartIndex)) == true)
                                    {
                                        // tempStartIndex++;
                                        if (tempListForSortedWeight.Count <= tempStartIndex)
                                        {
                                            Console.WriteLine("something wrong");
                                        }
                                        tempInnerCurrentMax = tempListForSortedWeight[tempStartIndex];
                                    }

                                }
                                // continue;
                                boatRideCount++;
                                tempRideDone = true;
                                break; // if 2, break anyway...
                            }
                            else if(tempCheckValue > limit) // move on to next weight
                            {
                                if(CheckIndexInList(tempListForSortedWeight,(tempStartIndex + 1) ) == true)
                                {
                                    tempStartIndex++;
                                    if (tempListForSortedWeight.Count <= tempStartIndex)
                                    {
                                        Console.WriteLine("something wrong");
                                    }
                                    tempInnerCurrentMax = tempListForSortedWeight[tempStartIndex];
                                }
                                else
                                {
                                    // tempOnlyDisplayList[boatRideCount].Add(boatOnRideWeight);
                                    boatRideCount++;
                                    tempRideDone = true;
                                    break; // reach the limit
                                }
                            }
                            // boatOnRideWeight += tempDic[tempInnerCurrentMax];
                            
                        }
                        else // no one left for that weight
                        {
                            // if (tempListForSortedWeight.Count > tempStartIndex)
                            if (CheckIndexInList(tempListForSortedWeight, (tempStartIndex + 1)) == true)
                            {

                            }
                            else
                            {
                                break; // iteration done
                            }
                            continue;
                        }
                        
                    }

                    if (innerAssertIteration >= INNER_MAX_ASSERTION)
                    {
                        // Console.WriteLine("ASSERT FAILED, inner while loop iteration count " + assertIteration);
                        break;
                    }
                    innerAssertIteration++;

                }
                // 3. reach limit or no more least value left, stop it

                if(assertIteration >= MAX_ASSERTION)
                {
                    Console.WriteLine("ASSERT FAILED, iteration count " + assertIteration);
                    break;
                }
                assertIteration++;
            }
            // ShowBoatRider(tempOnlyDisplayList);
            return boatRideCount;
        }

        public static int NumRescueBoats_Temp(int[] people, int limit)
        {
            var maxWeight = 3 * 104;
            var maxLength = 5 * 104;
            Dictionary<int, int> peopleAsWeight = new Dictionary<int, int>(capacity: maxWeight); // key as weight, value as people count
            // var peopleAsWeight = new Dictionary<LinkedList<int>, int> (capacity: maxWeight); // key as weight, value as people count
            var noMoreLeft = false;

            int assertIteration = 0;
            const int MAX_ASSERTION = 5 * 104 * 10;
            const int INNER_MAX_ASSERTION = 5 * 104;

            int boatOnRideWeight = 0;
            int boatRideCount = 0;

            LinkedList<int> tempPeopleList = new LinkedList<int>();

            for (int i = 0; i < people.Length; i++)
            {
                if (peopleAsWeight.ContainsKey(people[i]) == false)
                {
                    peopleAsWeight.Add(people[i], 1);
                }
                else
                {
                    peopleAsWeight[people[i]]++; // count increment
                }
            }

            var tempList = people.OrderByDescending(x => x).ToList();
            
            // tempPeopleList.AddFirst(templ)
            

            var tempMax = peopleAsWeight.Keys.Max();
            while(noMoreLeft == false)
            {
                
            }

            return 0;
        }

        public static void GrabMaxValueFromDic(ref Dictionary<int, int> tempDic, int tempCurrentMax)
        {
            if (tempDic[tempCurrentMax] > 0)
            {
                // boatOnRideWeight += tempDic[tempCurrentMax];
                tempDic[tempCurrentMax]--;
                if (tempDic[tempCurrentMax] == 0)
                {
                    tempDic.Remove(tempCurrentMax);
                }


            }
        }

        public static bool CheckIndexInList(List<int> srcList, int index)
        {
            if(srcList.Count > index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ShowBoatRider(List<List<int>> tempList)
        {
            
            for (int i = 0; i < tempList.Count; i++)
            {
                string log = string.Empty;
                log += " boat is " + i;
                for (int k = 0; k < tempList[i].Count; k++)
                {
                    log += " and " + k + " person's weight " + tempList[i][k];
                }
                Console.WriteLine(log);
                if(tempList[i].Count == 0)
                {
                    return;
                }
            }
        }

    }
}
