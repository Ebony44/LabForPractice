using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

using LabForPractice.LabForNumericOrder;
using LabForPractice.GfGReferences;
using LabForPractice.Fiddling;
using System.Reflection;
using System.Xml;
using System.IO;
using LabForPractice.Fiddling.OthersWork;
using System.Collections;

namespace RegularExpression1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region regex
            //Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
            ////class Regex Repesents an immutable regular expression.    

            //string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101" };
            ////Input strings for Match valid mobile number.    

            //foreach (string s in str)
            //{
            //    Console.WriteLine("{0} {1} a valid mobile number.", s,
            //        r.IsMatch(s) ? "is" : "is not");
            //    //The IsMatch method is used to validate a string or     
            //    //to ensure that a string conforms to a particular pattern.

            //}

            //Regex r2 = new Regex(@"\?{2,}");

            //string[] str2 = { "?", "??", "???", "abcd","?abcd","abcd?","abcd??","??abcd" };
            //foreach (string s in str2)
            //{
            //    Console.WriteLine("{0} {1} a valid match.", s,
            //        r2.IsMatch(s) ? "is" : "is not");
            //    //The IsMatch method is used to validate a string or     
            //    //to ensure that a string conforms to a particular pattern.

            //}
            #endregion

            #region positive and negative
            string pattern;
            pattern = @"\s*[";
            #endregion

            #region Lab1_TwoSum
            //Lab1.TwoSum_Class twoSum = new Lab1.TwoSum_Class();

            //// var tempList1 = new List<int> { -4, -6, 1, 2, 3, 4, 5 };
            //// var tempList1 = new int[]  { -4, -6, 1, 2, 3, 4, 5 };
            //var tempList1 = new int[] { 3, 3 };
            //var tempTarget = 6;

            //// twoSum.Test()
            //var tempReturn = twoSum.TwoSum(tempList1, tempTarget);
            //// Console.WriteLine(twoSum.Test(tempList1, tempTarget));
            //// Console.WriteLine(tempReturn[0] + ", " + tempReturn[1]);
            //Console.WriteLine("{0},{1}", tempReturn[0], tempReturn[1]);
            #endregion

            #region aggregate for ienumerable
            Dictionary<int, int> tempDic1 = new Dictionary<int, int>(capacity: 32);
            // tempDic1.Aggregate((l, r) => l.Key > r.Key ? l : r).Key;
            tempDic1.Add(1, 1);
            tempDic1.Add(2, 1);
            tempDic1.Add(3, 1);
            var temp = tempDic1.Aggregate((lValue, rValue) => lValue.Key > rValue.Key ? lValue : rValue).Key;
            var temp2 = tempDic1.Aggregate((lValue, rValue) => lValue.Key > rValue.Key ? lValue : rValue);
            //Aggregate  
            string[] MySkills = {
                "C#.net",
                "Asp.net",
                "MVC",
                "Linq",
                "EntityFramework",
                "Swagger",
                "Web-Api",
                "OrcharCMS",
                "Jquery",
                "Sqlserver",
                "Docusign"
            };
            var commaSeperatedString = MySkills.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine("Aggregate : " + commaSeperatedString);
            var stringLongestLength = MySkills.Aggregate((s1, s2) => s1.Length > s2.Length ? s1 : s2);
            Console.WriteLine("Aggregate : " + stringLongestLength
                + " length is " + stringLongestLength.Length);

            #endregion
            #region reversed
            //var tempIntList = new List<int>(capacity: 15);
            //for (int i = tempIntList.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("");
            //}
            #endregion
            #region
            var tempDic = new Dictionary<int, int>(capacity: 10);
            tempDic.Add(11, 3);
            tempDic.Add(1, 3);
            tempDic.Add(7, 3);
            tempDic.Add(4, 3);
            tempDic.Add(17, 3);
            var tempListForSortedWeight = new List<int>(capacity: 10);
            foreach (var item in tempDic)
            {
                tempListForSortedWeight.Add(item.Key);
            }
            tempListForSortedWeight = tempListForSortedWeight.OrderByDescending(x => x).ToList();
            #endregion

            #region
            // PerformanceForIteration.TestCalculate();

            //int[] tempPeople = new int[] { 4, 4, 3, 1, 2, 2, 2, 1, 1, 1 }; // 6
            //int tempLimit = 4;

            //int[] tempPeople = new int[] { 3, 5, 3, 4 };
            //int tempLimit = 5;

            //int[] tempPeople = new int[] { 5, 1, 4, 2 };
            //int tempLimit = 6;

            // int[] tempPeople = new int[] { 8, 4, 4, 3, 1, 2, 1, 2, 3, 4 };
            // int tempLimit = 8;

            //int[] tempPeople = new int[] { 15, 14, 7, 5, 4, 3, 4, 2, 3, 1 };
            //int tempLimit = 15;

            //int[] tempPeople = new int[] { 24, 34, 33, 11, 12, 8, 9, 27, 22, 10 }; // 6
            //int tempLimit = 80;

            //int[] tempPeople = new int[] { 3, 2, 3, 2, 2 };
            //int tempLimit = 6;

            //int[] tempPeople = new int[] { 3, 2, 3, 2, 2 };
            //int tempLimit = 6;

            // {213,794,868,245,523,365,864,586,477,680,985,639,809,812,265,391,199,604,787,416,334,427,722,41,925,662,573,15,87,151,617,560,165,860,333,140,292,751,487,638,270,621,247,14,718,442,302,527,382,808,971,653,39,654,10,400,92,864,27,678,463,510,259,378,433,451,489,835,631,861,516,524,629,712,735,560,400,278,738,60,958,990,897,888,958,601,836,186,460,23,355,435,174,714,177,161,750,911,926,867,199,606,532,52,231,573,859,756,813,455,954,612,280,332,375,131,644,537,824,98,154,338,217,252,353,354,508,740,520,892,64,657,662,933,576,711,460,75,100,456,628,382,185,868,959,345,279,142,974,567,547,314,801,189,666,671,936,834,445,724,508,137,540,720,928,556,266,514,696,285,132,193,301,208,295,43,437,692,11,167,104,420,875,269,402,355,156,92,215,42,394,760,279,990,505,757,568,568,782,785,206,161,185,232,79,232,398,631,28,615,711,892,656,568,299,383,614,803,349,666,364,620,45,102,659,858,311,741,773,69,671,436,201,205,822,678,406,473,162,990,525,74,413,878,321,733,81,768,613,456,193,490,796,52,251,292,295,669,930,591,657,494,472,722,685,367,480,70,309,753,982,464,443,145,690,889,65,648,210,136,666,287,82,730,873,585,768,691,538,456,556,278,6,642,901,352,438,702,33,249,771,652,47,376,597,118,941,174,606,68,252,146,763,980,892,218,641,908,659,62,450,332,646,62,659,48,57,229,864,768,265,10,262,934,556,81,726,629,848,981,847,679,878,621,212,515,299,248,186,68,286,877,509,530,111,958,121,966,187,50,941,32,272,660,573,733,316,753,56,34,234,828,113,736,943,971,92,256,58,763,424,265,902,591,977,681,111,135,118,362,789,918,54,409,942,800,280,898,138,336,205,425,534,73,176,619,841,89,957,501,775,59,358,462,565,963,506,914,968,895,352,868,314,719,698,603,901,795,814,425,886,730,316,423,240,851,374,376,388,560,283,820,670,793,69,377,208,194,338,853,378,64,848,787,549,47,153,358,416,301,768,968,428,171,452,138,464,410,983,353,122,931,704,697,326,204,713,290,616,94,438,636,551,639,231,455,66,77,208,648,796,599,357,8,695,851,10,618,345,411,734,434,550,694,661,476,537,645,14,24,466,708,951,527,675,921,100,128,477,568,304,387,870,532,574,929,596,463,179,192,506,46,510,881,389,839,752,814,339,610,653,100,171,672,721,41,486,480,425,764,971,32,930,737,383,236,588,535,949,975,779,878,692,786,534,701,437,922,916,997,257,218,617,370,397,773,677,854,809,490,105,423,790,368,843,400,818,760,672,8,926,367,93,13,861,419,587,985,936,630,732,644,420,116,208,298,215,932,206,236,696,971,638,294,816,157,650,495,752,486,622,4,844,725,198,947,990,629,836,990,305,185,324,967,296,451,852,178,454,265,420,961,438,62,893,858,343,49,495,641,439,68,94,749,535,650,296,437,342,655,456,112,679,974,413,33,542,638,355,900,951,471,504,426,685,59,306,800,195,539,218,115,405,550,263,340,452,730,150,589,598,974,606,407,483,614,533,675,294,247,979,942,740,982,994,271,346,922,717,150,789,194,206,614,209,382,164,690,616,908,96,987,308,30,350,948,291,493,276,677,372,925,110,627,988,370,536,774,146,476,855,881,527,799,534,682,811,77,94,45,899,220,506,356,390,349,868,106,742,504,586,471,775,544,411,413,426,553,245,978,861,337,532,649,494,173,644,668,587,521,469,979,98,886,2,759,460,533,52,956,181,827,996,887,637,153,593,677,930,687,162,39,808,353,336,350,923,837,791,486,985,579,889,968,602,594,964,31,539,119,819,936,561,299,902,103,790,42,777,764,792,663,183,823,225,829,627,843,539,14,924,568,447,458,567,782,317,429,191,481,777,43,848,160,164,212,741,687,848,190,905,162,161,421,336,760,676,60,110,526,105,562,719,619,10,937,255,458,525,978,310,658,839,565,223,279,131,733,496,330,919,200,127,621,394,380,590,610,20,99,48,34,212,911,77,194,577,379,666,208,690,75,354,428,615,18,33,116,602,440,694,448,8,246,932,833,752,317,722,277,34,391,693,244,989,316,625,106,89,802,598,107,392,629,804,439,459,876,588,772,549,693,807,834,185,705,714,434,304,207,942,686,923,640,310,783,866,816,545,500,820,707,84,760,818,506,223,453,497,826,496,865,425,178,410,800,610,914,710,697,924,719,545,867,921,927,227,500,639,50}
            //int[] tempPeople = new int[] { 213, 794, 868, 245, 523, 365, 864, 586, 477, 680, 985, 639, 809, 812, 265, 391, 199, 604, 787, 416, 334, 427, 722, 41, 925, 662, 573, 15, 87, 151, 617, 560, 165, 860, 333, 140, 292, 751, 487, 638, 270, 621, 247, 14, 718, 442, 302, 527, 382, 808, 971, 653, 39, 654, 10, 400, 92, 864, 27, 678, 463, 510, 259, 378, 433, 451, 489, 835, 631, 861, 516, 524, 629, 712, 735, 560, 400, 278, 738, 60, 958, 990, 897, 888, 958, 601, 836, 186, 460, 23, 355, 435, 174, 714, 177, 161, 750, 911, 926, 867, 199, 606, 532, 52, 231, 573, 859, 756, 813, 455, 954, 612, 280, 332, 375, 131, 644, 537, 824, 98, 154, 338, 217, 252, 353, 354, 508, 740, 520, 892, 64, 657, 662, 933, 576, 711, 460, 75, 100, 456, 628, 382, 185, 868, 959, 345, 279, 142, 974, 567, 547, 314, 801, 189, 666, 671, 936, 834, 445, 724, 508, 137, 540, 720, 928, 556, 266, 514, 696, 285, 132, 193, 301, 208, 295, 43, 437, 692, 11, 167, 104, 420, 875, 269, 402, 355, 156, 92, 215, 42, 394, 760, 279, 990, 505, 757, 568, 568, 782, 785, 206, 161, 185, 232, 79, 232, 398, 631, 28, 615, 711, 892, 656, 568, 299, 383, 614, 803, 349, 666, 364, 620, 45, 102, 659, 858, 311, 741, 773, 69, 671, 436, 201, 205, 822, 678, 406, 473, 162, 990, 525, 74, 413, 878, 321, 733, 81, 768, 613, 456, 193, 490, 796, 52, 251, 292, 295, 669, 930, 591, 657, 494, 472, 722, 685, 367, 480, 70, 309, 753, 982, 464, 443, 145, 690, 889, 65, 648, 210, 136, 666, 287, 82, 730, 873, 585, 768, 691, 538, 456, 556, 278, 6, 642, 901, 352, 438, 702, 33, 249, 771, 652, 47, 376, 597, 118, 941, 174, 606, 68, 252, 146, 763, 980, 892, 218, 641, 908, 659, 62, 450, 332, 646, 62, 659, 48, 57, 229, 864, 768, 265, 10, 262, 934, 556, 81, 726, 629, 848, 981, 847, 679, 878, 621, 212, 515, 299, 248, 186, 68, 286, 877, 509, 530, 111, 958, 121, 966, 187, 50, 941, 32, 272, 660, 573, 733, 316, 753, 56, 34, 234, 828, 113, 736, 943, 971, 92, 256, 58, 763, 424, 265, 902, 591, 977, 681, 111, 135, 118, 362, 789, 918, 54, 409, 942, 800, 280, 898, 138, 336, 205, 425, 534, 73, 176, 619, 841, 89, 957, 501, 775, 59, 358, 462, 565, 963, 506, 914, 968, 895, 352, 868, 314, 719, 698, 603, 901, 795, 814, 425, 886, 730, 316, 423, 240, 851, 374, 376, 388, 560, 283, 820, 670, 793, 69, 377, 208, 194, 338, 853, 378, 64, 848, 787, 549, 47, 153, 358, 416, 301, 768, 968, 428, 171, 452, 138, 464, 410, 983, 353, 122, 931, 704, 697, 326, 204, 713, 290, 616, 94, 438, 636, 551, 639, 231, 455, 66, 77, 208, 648, 796, 599, 357, 8, 695, 851, 10, 618, 345, 411, 734, 434, 550, 694, 661, 476, 537, 645, 14, 24, 466, 708, 951, 527, 675, 921, 100, 128, 477, 568, 304, 387, 870, 532, 574, 929, 596, 463, 179, 192, 506, 46, 510, 881, 389, 839, 752, 814, 339, 610, 653, 100, 171, 672, 721, 41, 486, 480, 425, 764, 971, 32, 930, 737, 383, 236, 588, 535, 949, 975, 779, 878, 692, 786, 534, 701, 437, 922, 916, 997, 257, 218, 617, 370, 397, 773, 677, 854, 809, 490, 105, 423, 790, 368, 843, 400, 818, 760, 672, 8, 926, 367, 93, 13, 861, 419, 587, 985, 936, 630, 732, 644, 420, 116, 208, 298, 215, 932, 206, 236, 696, 971, 638, 294, 816, 157, 650, 495, 752, 486, 622, 4, 844, 725, 198, 947, 990, 629, 836, 990, 305, 185, 324, 967, 296, 451, 852, 178, 454, 265, 420, 961, 438, 62, 893, 858, 343, 49, 495, 641, 439, 68, 94, 749, 535, 650, 296, 437, 342, 655, 456, 112, 679, 974, 413, 33, 542, 638, 355, 900, 951, 471, 504, 426, 685, 59, 306, 800, 195, 539, 218, 115, 405, 550, 263, 340, 452, 730, 150, 589, 598, 974, 606, 407, 483, 614, 533, 675, 294, 247, 979, 942, 740, 982, 994, 271, 346, 922, 717, 150, 789, 194, 206, 614, 209, 382, 164, 690, 616, 908, 96, 987, 308, 30, 350, 948, 291, 493, 276, 677, 372, 925, 110, 627, 988, 370, 536, 774, 146, 476, 855, 881, 527, 799, 534, 682, 811, 77, 94, 45, 899, 220, 506, 356, 390, 349, 868, 106, 742, 504, 586, 471, 775, 544, 411, 413, 426, 553, 245, 978, 861, 337, 532, 649, 494, 173, 644, 668, 587, 521, 469, 979, 98, 886, 2, 759, 460, 533, 52, 956, 181, 827, 996, 887, 637, 153, 593, 677, 930, 687, 162, 39, 808, 353, 336, 350, 923, 837, 791, 486, 985, 579, 889, 968, 602, 594, 964, 31, 539, 119, 819, 936, 561, 299, 902, 103, 790, 42, 777, 764, 792, 663, 183, 823, 225, 829, 627, 843, 539, 14, 924, 568, 447, 458, 567, 782, 317, 429, 191, 481, 777, 43, 848, 160, 164, 212, 741, 687, 848, 190, 905, 162, 161, 421, 336, 760, 676, 60, 110, 526, 105, 562, 719, 619, 10, 937, 255, 458, 525, 978, 310, 658, 839, 565, 223, 279, 131, 733, 496, 330, 919, 200, 127, 621, 394, 380, 590, 610, 20, 99, 48, 34, 212, 911, 77, 194, 577, 379, 666, 208, 690, 75, 354, 428, 615, 18, 33, 116, 602, 440, 694, 448, 8, 246, 932, 833, 752, 317, 722, 277, 34, 391, 693, 244, 989, 316, 625, 106, 89, 802, 598, 107, 392, 629, 804, 439, 459, 876, 588, 772, 549, 693, 807, 834, 185, 705, 714, 434, 304, 207, 942, 686, 923, 640, 310, 783, 866, 816, 545, 500, 820, 707, 84, 760, 818, 506, 223, 453, 497, 826, 496, 865, 425, 178, 410, 800, 610, 914, 710, 697, 924, 719, 545, 867, 921, 927, 227, 500, 639, 50 };
            // int tempLimit = 1000;

            // var tempRideCount = Lab2_881.Lab2_BoatsToSavePeople.NumRescueBoats(tempPeople, tempLimit);

            // TempStaticClass.TempShowListCount();
            // TempStaticClass.TempShowListCount();
            // TempStaticClass.TempShowListCount();
            #endregion

            #region regex instantiation performance test
            //var tempString = "asdf";
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //// RegexPerformanceTest.Uni2ZGWithInstantiation(tempString);
            //RegexPerformanceTest.Uni2ZGWithoutInstantiation(tempString);
            //sw.Stop();
            //Console.WriteLine("Elapsed={0}", sw.Elapsed);

            //sw.Restart();
            //RegexPerformanceTest.Uni2ZGWithInstantiation(tempString);
            //// RegexPerformanceTest.Uni2ZGWithoutInstantiation(tempString);
            //sw.Stop();
            //Console.WriteLine("Elapsed={0}", sw.Elapsed);

            //AddTwoNumbers_2.TempTest();
            #endregion


            #region Lab3_Longest_Substring
            Longest_Substring_3 lab3 = new Longest_Substring_3();
            // lab3.LengthOfLongestSubstring_sec("abcdb");
            // abcdecfgaber
            // abcdaefg
            // lab3.LengthOfLongestSubstring_sec("abcdecfgaber");
            // lab3.LengthOfLongestSubstring_sec("abcdaefg");
            // a123f145cx1a22
            // lab3.LengthOfLongestSubstring_sec("a123f145cx1a22");
            // pwwkew
            // lab3.LengthOfLongestSubstring_sec("abcabcbb");
            // " "
            // lab3.LengthOfLongestSubstring_sec("ad23j89e23j8dawew");
            // lab3.LengthOfLongestSubstring_sec(" ");
            // lab3.LengthOfLongestSubstring_sec(" c  b a d   ");


            // LabForPractice.MergeSort mergeSort = new LabForPractice.MergeSort();
            // int[] tempArray = new int[] { 37, 28 };
            // mergeSort.sort(tempArray, 0, tempArray.Length - 1);

            #endregion

            #region Lab4
            MedianSorted_4 lab4 = new MedianSorted_4();
            // int[] num1 = new int[] { 1, 3 };
            // int[] num2 = new int[] { 2, 4 };

            // int[] num1 = new int[] { 4 };
            // int[] num2 = new int[] { 1, 2, 3, 5, 7 };

            //int[] num1 = new int[] { 2, 32, 64 };
            //int[] num2 = new int[] { 4, 15, 21 };

            // int[] num1 = new int[] { 1, 3 };
            // int[] num2 = new int[] { 2 };

            // int[] num1 = new int[] { 2, 32 };
            // int[] num2 = new int[] { 4, 15, 21 };

            // lab4.FindMedianSortedArrays(num1, num2);
            #endregion

            #region Lab5

            //Palindromic_5 lab5 = new Palindromic_5();
            //// lab5.LongestPalindrome("hello world");
            //string tempString = string.Empty;
            //string tempString1 = "asdfqwerzxcv";
            //string tempString2 = "tgyhqwesdxav";
            //lab5.LongestCommonSubstring(tempString1, tempString2, out tempString);
            #endregion

            #region Lab_Ex_Interview_Question
            // LabForPractice
            CalcClockAngle_Ex LabEx = new CalcClockAngle_Ex();
            // var tempResult = LabEx.CalculateAngle(12, 30);
            // var tempResult = LabEx.CalculateAngle(11, 30);
            // var tempResult = LabEx.CalculateAngle(3, 30);
            // var tempResult = LabEx.CalculateAngle(4, 0);
            // var tempResult = LabEx.CalculateAngle(0, 66);
            #endregion

            #region
            //Circle circle = new Circle();
            // var tempCircle = circle.Calculate(r => 2 * Math.PI * r);
            //var tempCircle = circle.Calculate(r => r);
            #endregion

            #region

            List<Printer> printers = new List<Printer>();
            //for (int i = 0; i < 10; i++)
            //{
            //    //var tempValue = i;
            //    //printers.Add(delegate { Console.WriteLine(tempValue); });

            //    printers.Add(delegate { Console.WriteLine(i); });
            //}

            //foreach (var printer in printers)
            //{
            //    printer();
            //}
            #endregion

            #region boxing unboxing
            //object tempObj;
            //int tempInt = 1;
            //tempObj = (object)tempInt;
            //var tempVariable = (int)tempObj;
            #endregion

            #region Lab 412
            //FizzBuzz_412 fizzBuzz_412 = new FizzBuzz_412();
            //fizzBuzz_412.FizzBuzz(15);
            #endregion

            #region Lab 414
            //Third_Maximum_Number_414 lab414 = new Third_Maximum_Number_414();
            //int thirdMax = 0;
            //// lab414.ThirdMax(new int[] { 1, 2, 3, 4 });
            //thirdMax = lab414.ThirdMax(new int[] { 2, 2, 3, 1 });
            //// 2,2,3,1
            #endregion

            #region
            //long tempLong = -25;
            //string tempString3 = tempLong.ToString("N0");
            //string tempString4 = tempLong.ToString();
            #endregion


            #region Lab 11
            // Container_With_Most_Water_11 lab11 = new Container_With_Most_Water_11();
            // 
            // // int[] tempInt = new int[] { 1, 2 }; 
            // int[] tempInt = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            // 
            // // int tempArea =  lab11.MaxAreaNaive(tempInt);
            // int tempArea = lab11.MaxArea(tempInt);
            #endregion

            #region Lab 121

            // Best_Time_to_Buy_and_Sell_Stock_121 lab121 = new Best_Time_to_Buy_and_Sell_Stock_121();
            // 
            // // int[] tempInt = new int[] { 1, 2 };
            // // int[] tempInt = new int[] { 1, 2, 4 };
            // // int[] tempInt = new int[] { 8, 6, 2, 5, 4, 8, 3, 7 };
            // // int[] tempInt = new int[] { 7, 6, 4, 3, 1 };
            // // int[] tempInt = new int[] { 7, 1, 5, 3, 6, 4 };
            // int[] tempInt = new int[] { 5, 6, 7, 6, 7, 6, 4, 4, 4, 4, 4, 4 };
            // // 7,6,4,3,1
            // // 7,1,5,3,6,4
            // // 5,6,7,6,7,6,4,4,4,4,4,4
            // int tempResult = lab121.MaxProfit(tempInt);
            // // int tempResult = lab121.MaxProfitNaive(tempInt);

            #endregion
            #region GfG Greedy algorithm example
            // PrintEgyptianFraction.printEgyptian(18, 6);

            #endregion

            #region temp lerp
            #endregion
            #region lab 42
            //Trapping_Rain_Water_42 lab42 = new Trapping_Rain_Water_42();
            //// int[] height = new int[] { 4, 2, 0, 3, 2, 5, 3, 0, 0, 5 };
            //// int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            //// var result = lab42.Trap(height);

            //int[] buildings = new int[] { 18, 14, 13, 16, 12 };
            //var buildingStacks = lab42.FindBuildings(buildings);
            #endregion

            #region lab 739
            // 30,40,50,60
            // Daily_Temperatures_739 lab739 = new Daily_Temperatures_739();
            // // var temperatures = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            // // var temperatures = new int[] { 90,41,42,43,44 };
            // // var temperatures = new int[] { 90};
            // var temperatures = new int[] { 90, 90, 90, 90, 90 };
            // var lab_739_result = lab739.DailyTemperatures(temperatures);
            #endregion

            #region lab 2101
            //Detonate_the_Maximum_Bombs_2101 lab2101 = new Detonate_the_Maximum_Bombs_2101();
            //// Detonate_the_Maximum_Bombs_2101.float2 a = new Detonate_the_Maximum_Bombs_2101.float2(5f,1f);
            //// Detonate_the_Maximum_Bombs_2101.float2 b = new Detonate_the_Maximum_Bombs_2101.float2(1f,1f);
            //// var tempDist = lab2101.Distance(a,b);


            //// int[][] bombs = new int[][] { new int[]{ 2, 1, 3 }, new int[]{ 6, 1, 4 } };
            //int[][] bombs = new int[][] {
            //    new int[] { 1, 2, 3 },
            //    new int[] { 2, 3, 1 },
            //    new int[] { 3, 4, 2 },
            //    new int[] { 4, 5, 3 },
            //    new int[] { 5, 6, 4 }
            //};
            //// Input: bombs = [[1,2,3],[2,3,1],[3,4,2],[4,5,3],[5,6,4]]
            //// int[][] bombs = new int[3][];
            ////for (int i = 0; i < bombs.Length; i++)
            ////{
            ////    bombs[i] = 
            ////}

            //// lab2101.MaximumDetonation(bombs);

            #endregion

            #region lab36
            /*
             * 
             * [
             ['5','3','.','.','7','.','.','.','.']
            ,['6','.','.','1','9','5','.','.','.']
            ,['.','9','8','.','.','.','.','6','.']
            ,['8','.','.','.','6','.','.','.','3']
            ,['4','.','.','8','.','3','.','.','1']
            ,['7','.','.','.','2','.','.','.','6']
            ,['.','6','.','.','.','.','2','8','.']
            ,['.','.','.','4','1','9','.','.','5']
            ,['.','.','.','.','8','.','.','7','9']
            ]
             * 
             */
            //Valid_Sudoku_36 lab36 = new Valid_Sudoku_36();
            //var tempCharArray = new char[][]
            //    {
            //        //new char[]{ '5','3','.','.','7','.','.','.','.' },
            //        //new char[]{ '6','.','.','1','9','5','.','.','.' },
            //        //new char[]{ '.','9','8','.','.','.','.','6','.' },
            //        //new char[]{ '8','.','.','.','6','.','.','.','3' },
            //        //new char[]{ '4','.','.','8','.','3','.','.','1' },
            //        //new char[]{ '7','.','.','.','2','.','.','.','6' },
            //        //new char[]{ '.','6','.','.','.','.','2','8','.' },
            //        //new char[]{ '.','.','.','4','1','9','.','.','5' },
            //        //new char[]{ '.','.','.','.','8','.','.','7','9' },

            //        new char[]{ '5','3','.','.','7','.','.','.','.' },
            //        new char[]{ '6','.','.','1','9','5','.','.','.' },
            //        new char[]{ '.','9','8','.','.','.','.','6','.' },
            //        new char[]{ '8','.','.','.','6','.','.','.','3' },
            //        new char[]{ '4','.','.','8','.','3','.','.','1' },
            //        new char[]{ '7','.','.','.','2','.','.','.','6' },
            //        new char[]{ '.','6','.','.','.','.','.','8','.' },
            //        new char[]{ '.','.','.','4','1','9','.','.','5' },
            //        new char[]{ '.','.','.','.','8','.','.','7','9' },



            //    };
            //var lab36Result = lab36.IsValidSudoku(tempCharArray);
            ////var tempChar = tempCharArray[7][1];
            #endregion

            #region lab 12
            //Integer_to_Roman_12 lab12 = new Integer_to_Roman_12();
            //var inputInt = 3;
            //var result = lab12.IntToRoman(inputInt);
            //var result = lab12.IntToRoman(1234);
            #endregion

            #region ipa
            //string tempData = "abcdefgh";
            //string tempData2 = tempData.Substring(0, tempData.Length / 2);
            //string tempData3 = tempData.Substring(tempData.Length / 2, tempData.Length / 2);
            // "{Payload:{\\json\\:\\{\\\\orderId\\\\:\\\\GPA.3333-0344-2240-00548\\\\,";


            #endregion

            #region
            //var tempString123 = "hlmomlnlgioiblinclejodko.AO-J1Ox91napLWxxDREDjtrx_j0ChEBcWCjNHgLFENLpbqrPHxSBMwxbR3qbp9RFiZ9NvWX4IocTsLR-YWovKtUxHlGZjGYDdg&sid=21a216a3135f0ec6310544b13e0c52be98666620221122132457";
            //var temptempInt = tempString123.Length;
            #endregion

            #region lab 13
            //Roman_to_Integer_13 lab13 = new Roman_to_Integer_13();
            //var inputString = "MM";
            //var labResult = lab13.RomanToInt(inputString);
            #endregion

            #region GfG, show combination
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int r = 3;
            //int n = arr.Length;

            //int[] arr = { 13, 14, 23, 24 };
            //int r = 2;
            //int n = arr.Length;

            //for (int i = 0; i <= r; i++)
            //{
            //    CombinationUtil.ShowCombination(arr, n, i);
            //}

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int r = 4;
            //int n = arr.Length;

            //for (int i = 3; i <= r; i++)
            //{
            //    CombinationUtil.ShowCombination(arr, n, i);
            //}


            #endregion
            #region two dimension array
            //LabForPractice.Fiddling.TwoDimensionalArray tempClass = new LabForPractice.Fiddling.TwoDimensionalArray();
            //tempClass.TestDeclareTwoDimensionalArray();
            #endregion

            #region assmebly location and CSV file loading

            Console.WriteLine(" location of executed assembly is " + System.Reflection.Assembly.GetExecutingAssembly().Location);

            // LabForPractice.Fiddling.OthersWork.CSVReader csvReader = new LabForPractice.Fiddling.OthersWork.CSVReader();
            // KEY,Korean,English,Myanmar,Thailand,India
            //            T_LOGIN,로그인,Log in,အကောင့်၀င်ရန်,เข้าสู่ระบบ,
            //T_LOGOUT,로그아웃,Log out,လော့အောက်,,
            //string tempString = "KEY,Korean,English\r\n";
            //tempString += "T_LOGIN,로그인,Log in\r\n";
            //tempString += "T_LOGOUT,로그아웃,Log out\r\n";
            //// LabForPractice.Fiddling.OthersWork.CSVReader.TempTest("asdf,fdsa,fasdf");
            //// LabForPractice.Fiddling.OthersWork.CSVReader.TempTest(tempString);
            //// LabForPractice.Fiddling.OthersWork.CSVReader.GetStringFromFile();
            //var tempPath = "D:\\Lab\\Repo\\LabSamples\\LabForPractice_CSV_files\\TempTestCSV.csv";
            //var tempString2 = LabForPractice.Fiddling.OthersWork.CSVReader.GetStringFromFile(tempPath);
            //LabForPractice.Fiddling.OthersWork.CSVReader.TempTest(tempString2);


            // another setting up

            // var tempPath2 = "D:\\Lab\\Repo\\LabSamples\\LabForPractice_CSV_files\\Text_MercItemInfo.csv";
            // var tempString3 = LabForPractice.Fiddling.OthersWork.CSVReader.GetStringFromFile(tempPath2);
            // TestItemSetupForModding.StringSplitAndInsertToCollections(tempString3);


            #endregion
            #region random and excluding
            ////
            //List<int> excludeNum = new List<int>() { 57, 58 };
            //var excludedNumbers = TestItemSetupForModding.GetExcludeNum(56, 59);
            //// var excludedNumbers = TestItemSetupForModding.GetExcludeNum(58, 59);
            //for (int i = 0; i < 15; i++)
            //{
            //    // TestItemSetupForModding.RandomNumber(55, 61, excludeNum);
            //}
            #endregion

            #region reflection practice
            //ReflectionPracticeClass tempPracClass = new ReflectionPracticeClass(1, 2);

            //Type setType = typeof(ReflectionPracticeClass);
            //Type setBaseType = typeof(ReflectionPracticeClass).BaseType;
            //FieldInfo myField = setType.GetField("baseInt", BindingFlags.NonPublic | BindingFlags.Instance);
            //FieldInfo myBaseField = setBaseType.GetField("baseInt", BindingFlags.NonPublic | BindingFlags.Instance);
            //// var tempInt =  (int)myField.GetValue(tempPracClass);
            //var tempInt = (int)myBaseField.GetValue(tempPracClass);

            //Type tempCurrentType = typeof(List<int>);
            //FieldInfo tempCurrentField = setType.GetField(
            //    "tempReadOnlyList",
            //BindingFlags.NonPublic | BindingFlags.Instance
            //    );

            //// tempPracClass.tempReadOnlyList = new List<int>();
            //tempPracClass.tempReadOnlyList.Add(2);

            //var currentField = GetReflectField<List<int>, ReflectionPracticeClass>(tempPracClass, "tempReadOnlyList");

            //Console.WriteLine("");

            #endregion

            #region string format
            //string tempString = string.Empty;
            //int tempInt = 23;
            //int a = 1;
            //int b = 2;
            //Console.WriteLine($"string example1 : {a} + {b} = {a + b}");

            //string charType = "asdf";
            //string essenceType = "fdsa";
            //string essenceLevel = "qwer";
            //string currentCount = "asdf";
            //string maxCount = "zxcv";
            //var originCharText = 
            //    $" \" Required {@charType}: Essence condtion {@essenceType} {@essenceLevel}+, \"  {@currentCount} / {@maxCount}";
            //// var tempText = (originCharText, charType);
            //Console.WriteLine("ripped from mod "+ originCharText);
            //var originCharText_2 = "{0},{1}";

            //Console.WriteLine(string.Format(originCharText_2, 1, 2));

            //// C:\\gitrepo\\Labs\\LabSamples\\LabForPractice_CSV_files
            // var tempPath = "D:\\Lab\\Repo\\LabSamples\\LabForPractice_CSV_files\\TempTestCSV.csv";
            //// var tempPath = "C:\\gitrepo\\Labs\\LabSamples\\LabForPractice_CSV_files\\Text_UpgradeReqnfo.csv";
            //var tempString2 = LabForPractice.Fiddling.OthersWork.CSVReader.GetStringFromFile(tempPath);
            //var tempString3 = LabForPractice.Fiddling.OthersWork.CSVReader.SplitStringWithSeparator(tempString2, "\r\n");

            //var tempString4 = LabForPractice.Fiddling.OthersWork.CSVReader.SplitStringWithSeparator(tempString3[5], ",");

            ////var tempString5 = tempString4[1];
            ////var tempString6 = tempString5.Replace("\"", string.Empty);
            ////var tempString7 = LabForPractice.Fiddling.OthersWork.CSVReader.SplitStringWithSeparator(tempString6, "\n");

            #endregion
            #region struct dealloc show
            // TempMainStruct tempStr = GetStruct();
            // Dictionary<TempMainStruct, int> tempStructDic = new Dictionary<TempMainStruct, int>(4);
            // // ScopeTestingFunc(tempStr, ref tempStructDic);
            // ScopeTestingFunc(GetStruct(), ref tempStructDic);

            //////

            //Struct_A a = new Struct_A();
            //a.Foobar = "hi";
            //Class_B b = new Class_B();
            //b.Foobar = "hi";

            //List<Struct_A> tempList = new List<Struct_A>();

            //tempList.Add(a);

            //StructTest(a);
            //ClassTest(b);

            //StructTest(tempList[0]);

            #endregion

            #region xml loading and reading
            //XmlNamespaceManager nsMgr;
            //XmlDocument tempDocument = new XmlDocument();


            //XmlNode GettingNode;

            //var tempXmlPath= "D:\\Lab\\Repo\\LabSamples\\LabForPractice_XML_files\\AndroidManifest.xml";
            //tempDocument.Load(tempXmlPath);
            //XmlElement root = tempDocument.DocumentElement;
            ////using (var reader = new XmlTextReader(tempXmlPath))
            ////{
            ////    reader.Read();
            ////    tempDocument.Load(reader);
            ////}
            //nsMgr = new XmlNamespaceManager(tempDocument.NameTable);
            //string AndroidXmlNamespace = "https://schemas.android.com/apk/res/android";
            //nsMgr.AddNamespace("android", AndroidXmlNamespace);
            //// nsMgr.AddNamespace("android", AndroidXmlNamespace);
            //nsMgr.AddNamespace("bk", "urn:samples");
            //var tempNode = root.SelectSingleNode("descendant::action[@android:name='android.intent.action.MAIN']", nsMgr);
            //XmlNode book;
            //book = root.SelectSingleNode("descendant::book[@bk:ISBN='1-861001-57-6']", nsMgr);
            #endregion

            #region some math

            //Vector2 firstPoint = new Vector2(1, 5);
            //Vector2 secondPoint = new Vector2(3, 15);
            //GetPerpendicularLine(firstPoint, secondPoint);
            #endregion


            #region serialize class as file... and modify class later and load it..
            // saving
            //var tempPath = "D:\\Lab\\Repo\\LabSamples\\LabForPractice_BIN_files\\"; // directory
            //tempPath += "ClassSerializePractice";

            ////bool append = false;
            ////ClassSerializePractice objectToWrite = new ClassSerializePractice();
            ////objectToWrite.randomCount_1 = 24;
            ////using (Stream stream = File.Open(tempPath, append ? FileMode.Append : FileMode.Create))
            ////{
            ////    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            ////    binaryFormatter.Serialize(stream, objectToWrite);
            ////}

            ////loading
            //using (Stream stream = File.Open(tempPath, FileMode.Open))
            //{
            //    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            //    var currentValue = (ClassSerializePractice)binaryFormatter.Deserialize(stream);
            //}
            // no error when saved file has no variable which added newly
            #endregion

            #region regex for number only taking
            //bool bResult = false;
            //var regex = new Regex("^[0-9]+$");
            //// var input = "asdf";
            //var input = "4f32f1";
            //if (regex.IsMatch(input))
            //{
            //    bResult = true;
            //}
            #endregion

            #region multiple build config

            //#if Debug
            //Console.WriteLine("current config is Debug");
            //#elif Release
            //Console.WriteLine("current config is Release");
            //#endif
            #endregion

            #region GUID generate and save into file
            //Guid id = Guid.NewGuid();
            //var guidString = id.ToString();
            //var currentGuidText = string.Empty;
            //StringBuilder tempSB = new StringBuilder();
            //tempSB.Append(guidString);
            //tempSB.Append("\n");


            //id = Guid.NewGuid();
            //var guidString_2 = id.ToString();
            //tempSB.Append(guidString_2);
            //tempSB.Append("\n");

            //id = Guid.NewGuid();
            //var guidString_3 = id.ToString();
            //tempSB.Append(guidString_3);
            //tempSB.Append("\n");



            //var folderPath = Assembly.GetExecutingAssembly().Location;
            //// folderPath = folderPath.Remove(folderPath.Length - 4, 4);
            //var fileName = "TempTestText.txt";
            //string dir = Path.GetDirectoryName(folderPath);
            //// string root = Directory.GetCurrentDirectory();
            //folderPath = dir + "\\";
            //var fullFilePath = folderPath + fileName;

            //currentGuidText = tempSB.ToString();

            //File.WriteAllText(fullFilePath, currentGuidText);

            //// 		folderPath	"D:\\Lab\\Repo\\LabSamples\\LabForPractice\\bin\\Debug\\LabForPractice"	string

            //var tempReadText = File.ReadAllText(fullFilePath);
            //var splitTexts = CSVReader.SplitStringWithSeparator(tempReadText, "\n");

            //var splitTextList = splitTexts.ToList();

            //bool bCheckGUIDList = splitTextList.Contains(guidString);

            //bool bCheckGuid = false;
            //foreach (var item in splitTexts)
            //{
            //    if(guidString.Equals(item))
            //    {
            //        Console.WriteLine("same guid in file");
            //    }
            //}
            #endregion

            #region iterate with tables

            Dictionary<int, int> iteratorDic = new Dictionary<int, int>
            {
                { 1,500},
                { 15,1500},
                { 25,2500},
            };
            
            SortedList<int,int> iteratorSL = new SortedList<int, int>
            {
                { 1,500},
                { 15,1500},
                { 25,2500},
            };

            int standardIterateValue = 40000;

            var tempValue = Lerp(iteratorDic[1], iteratorDic[15], 0.5f);
            var tempValue_2 = Lerp(iteratorDic[1], iteratorDic[15], 0f);
            var tempValue_3 = Lerp(iteratorDic[1], iteratorDic[15], 1f);

            int exp = 0;
            int level = 1;

            int currentAssertion = 0;
            const int MAX_ASSERTION_COUNT = 150;

            while (standardIterateValue > 0)
            {
                var currentComparer = iteratorSL.SkipWhile(x => x.Key < level).FirstOrDefault();
                var currentValueComparers = GetKeyValueRange(level, iteratorSL,false);

                // var currentKeyComparers = GetKeyValueRange(level, iteratorSL, true);
                // var lerpedValue = currentComparers.Item1 / (float)currentComparers.Item2;
                var lerpedValue = level / (float)currentComparer.Key;
                if (currentValueComparers.Item2 == -1)
                {
                    Console.WriteLine("next item is NOT exist!");
                }

                var currentCompareValue = Lerp(currentValueComparers.Item1, currentValueComparers.Item2, lerpedValue);

                // if ((currentComparer.Value - standardIterateValue) <= 0)
                if ((currentCompareValue - standardIterateValue) <= 0)
                {
                    standardIterateValue -= currentCompareValue;
                    level++;

                }
                else
                {
                    exp = standardIterateValue;
                    standardIterateValue = 0;
                    break;
                }

                if (MAX_ASSERTION_COUNT <= currentAssertion)
                {
                    Console.WriteLine("break from assertion failed");
                    break;
                }
                currentAssertion++;
            }
            // 23, 1000
            // 
            var findKey = iteratorDic.SkipWhile(x => x.Key < level).FirstOrDefault();
            var findKey_2 = iteratorDic.SkipWhile(x => x.Key < 16).FirstOrDefault();
            var findKey_3 = iteratorDic.SkipWhile(x => x.Key < 14).FirstOrDefault();
            var findKey_4 = iteratorDic.SkipWhile(x => x.Key < 15).FirstOrDefault();

            var items = GetKeyValueRange(16, iteratorSL, false);
            // var currentComparer = iteratorSL.SkipWhile(x => x.Key < level);
            // var currentIndex = iteratorSL.IndexOfKey(currentComparer.Key);
            // var nextComparer = iteratorSL. [currentIndex + 1];
            

            //foreach (var item in findKey)
            //{
            //    var currentItemValue = item.Key;
            //}

            #endregion


        } // bracket of main

        private static (int,int) GetKeyValueRange(int paramLevel, SortedList<int, int> paramList, bool bReturnTypeKey = true)
        {
            (int, int) result = (-1, -1);
            int firstFind = -1;
            int firstFindKey = -1;
            foreach (var item in paramList)
            {
                if (item.Key >= paramLevel)
                {
                    
                    firstFind = bReturnTypeKey ? item.Key : item.Value;
                    firstFindKey = item.Key;
                    break;
                }
            }
            int secondFind = -1;
            foreach (var item in paramList)
            {
                if (item.Key >= (firstFindKey + 1))
                {
                    secondFind = bReturnTypeKey ? item.Key : item.Value;
                    break;
                }
            }
            result.Item1 = firstFind;
            result.Item2 = secondFind;
            return result;
        }

        private static float Lerp(float firstFloat, float secondFloat, float by)
        {
            return firstFloat * (1 - by) + secondFloat * by;
        }
        private static int Lerp(int firstInt, int secondInt, float by)
        {
            return (int)(firstInt * (1 - by) + secondInt * by);
        }

        public static void GetPerpendicularLine(Vector2 lineStartPoint, Vector2 lineEndPoint)
        {
            // line 1 = y = mx+n
            // line 2(this function's return value)

            // 1. get m(slope)
            var modValueY = lineEndPoint.y - lineStartPoint.y;
            var modValueX = lineEndPoint.x - lineStartPoint.x;
            var firstLineSlope = modValueY / modValueX;
            var secondLineSlope = -(1 / firstLineSlope);

            Vector2 secondLineFirstPoint = new Vector2(lineStartPoint.x, lineStartPoint.x * secondLineSlope);
            Vector2 secondLineSecondPoint = new Vector2(lineEndPoint.x, lineEndPoint.x * secondLineSlope);

        }

        public class Vector2
        {
            public float x = 0;
            public float y = 0;

            public Vector2(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }



#region
        public struct TempMainStruct
        {
            public int currentCount;
        }
        public static TempMainStruct GetStruct()
        {
            TempMainStruct result = default;// = new TempMainStruct();
            return result;
        }
        
        public static void ScopeTestingFunc(TempMainStruct paramStruct, ref Dictionary<TempMainStruct, int> paramDic)
        {
            paramStruct.currentCount++;
            if (paramDic.ContainsKey(paramStruct))
            {
                paramDic[paramStruct]++;
                
                //
            }
            else
            {
                paramDic.Add(paramStruct, 1);
            }
        }

        struct Struct_A
        {
            public string Foobar { get; set; }
        }

        class Class_B
        {
            public string Foobar { get; set; }
        }

        static void StructTest(Struct_A a)
        {
            a.Foobar = "hello";
        }
        static void AnotherStructTest(ref List<Struct_A> list)
        {
            //for (int i = 0; i < list.Count; i++)
            //{
            //    list[i].Foobar = "hello";
            //}

            foreach (var item in list)
            {
                // item.Foobar = "hello"; // CS1654  
            }
            //a.Foobar = "hello";
        }

        static void ClassTest(Class_B b)
        {
            b.Foobar = "hello";
        }

#endregion
        class DataflowProducerConsumer
        {
            static void Produce(ITargetBlock<byte[]> target)
            {
                var rand = new Random();

                for (int i = 0; i < 100; ++i)
                {
                    var buffer = new byte[1024];
                    rand.NextBytes(buffer);
                    target.Post(buffer);
                }

                target.Complete();
            }

            static async Task<int> ConsumeAsync(ISourceBlock<byte[]> source)
            {
                int bytesProcessed = 0;

                while (await source.OutputAvailableAsync())
                {
                    byte[] data = await source.ReceiveAsync();
                    bytesProcessed += data.Length;
                }

                return bytesProcessed;
            }

            //static async Task<int> ConsumeAsync(IReceivableSourceBlock<byte[]> source)
            //{
            //    int bytesProcessed = 0;
            //    while (await source.OutputAvailableAsync())
            //    {
            //        while (source.TryReceive(out byte[] data))
            //        {
            //            bytesProcessed += data.Length;
            //        }
            //    }
            //    return bytesProcessed;
            //}


            static async Task Main()
            {
                var buffer = new BufferBlock<byte[]>();
                var consumerTask = ConsumeAsync(buffer);
                Produce(buffer);

                var bytesProcessed = await consumerTask;

                Console.WriteLine($"Processed {bytesProcessed:#,#} bytes.");
            }
        }
        
        delegate void Printer();

        public sealed class Circle
        {
            private double radius = 2;

            public double Calculate(Func<double, double> op)
            {
                // var result = 2 * Math.PI * radius;
                return op(radius);
            }
            public double GetCircumference(double radius)
            {
                return 2 * Math.PI * radius;
            }
            public void Test(double radius)
            {
                Calculate(GetCircumference);
            }
        }

        public static void CalcLerpWithoutFloating(float t)
        {
            
        }

        public static void Distance(float[] a, float[] b)
        {
            int x = 0;
            int y = 1;
            // Math.Sqrt(  )
            var tempDistance = Math.Sqrt((a[x] - b[x]) * (a[x] - b[x]) + (a[y] - b[y]) * (a[y] - b[y]));
            // 0,0
            // 1,1
            // (0-1)^2 + (0-1)^2
            // 
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

#region reflect field related

        public static void SetReflectField<TsetValue, Tinstancetype>(Tinstancetype instance, string fieldName, TsetValue setValue)
        {

#region reflection variable
            Type setType = typeof(Tinstancetype);
            FieldInfo myField = setType.GetField(
                fieldName,
            BindingFlags.NonPublic | BindingFlags.Instance
                );
            // int assigningUnitID = (int)myField.GetValue(instance) + 1; // get playdata's unit id
            myField.SetValue(instance, setValue); // set playdata's unit id

#endregion
        }

        public static TgetValue GetReflectField<TgetValue, Tinstancetype>(Tinstancetype instance, string fieldName)
        {
            Type setType = typeof(Tinstancetype);
            FieldInfo myField = setType.GetField(
                fieldName,
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public
                );
            // int assigningUnitID = (int)myField.GetValue(instance) + 1; // get playdata's unit id
            // myField.SetValue(instance, setValue); // set playdata's unit id
            return (TgetValue)myField.GetValue(instance);
        }

#endregion

    }
}