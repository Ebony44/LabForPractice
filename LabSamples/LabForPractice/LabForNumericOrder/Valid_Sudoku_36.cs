using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{

    /*
     * 
     * 
     * Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

    Each row must contain the digits 1-9 without repetition.
    Each column must contain the digits 1-9 without repetition.
    Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

Note:

    A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    Only the filled cells need to be validated according to the mentioned rules.

     * 
     * Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true
     * 
     * 
     * 
     * 
     * 
     */


    class Valid_Sudoku_36
    {
        public bool IsValidSudoku(char[][] board)
        {
            bool result = false;


            var tempColumn2 = new List<HashSet<char>>(9);
            var tempRow2 = new List<HashSet<char>>(9);
            var tempThirdByThird = new List<HashSet<char>>(9);

            // var tempHashSet = new HashSet<char>();


            var tempColumn = new char[9][];
            var tempRow = new char[9][];
            for (int i = 0; i < 9; i++)
            {
                tempColumn2.Add(new HashSet<char>(9));
                tempRow2.Add(new HashSet<char>(9));
                tempThirdByThird.Add(new HashSet<char>(9));
            }
            for (int i = 0; i < 9; i++)
            {
                tempColumn[i] = new char[9];
                tempRow[i] = new char[9];
                
                for (int k = 0; k < 9; k++)
                {
                    // tempRow[i][k] = board[i][k];
                    // tempColumn[i][i] = board[i][i];
                    if(tempRow2[i].Contains(board[i][k])
                        && board[i][k] != '.')
                    {
                        Console.WriteLine("something dupe");
                        return false;
                    }
                    else
                    {
                        tempRow2[i].Add(board[i][k]);
                    }

                    if(tempColumn2[i].Contains(board[k][i]) 
                        && board[k][i] != '.')
                    {
                        Console.WriteLine("something dupe");
                        return false;
                    }
                    else
                    {
                        tempColumn2[i].Add(board[k][i]);
                    }

                    #region third by third adding
                    var tempAxis = CheckCurrentBlock(i, k);
                    if (tempThirdByThird[tempAxis].Contains(board[i][k])
                        && board[i][k] != '.')
                    {
                        Console.WriteLine("something dupe");
                        return false;
                    }
                    else
                    {
                        tempThirdByThird[tempAxis].Add(board[i][k]);
                    }
                    #endregion

                }
            }


            return true;
        }

        public int CheckCurrentBlock(int x, int y)
        {
            //012 345 678
            // x 3, y 3
            // if()
            // 
            var modifier = 3;
            var tempRow = -1;
            var tempColumn = -1;
            tempColumn = x / modifier;
            tempRow = y / modifier;

            var result = tempColumn + (tempRow * 3);
            return result;
            
            // int[] tempAxis = new int[] { tempColumn, tempRow };

            // return tempAxis;


        }
        public float Distance(int[] a, int[] b)
        {
            int x = 0;
            int y = 1;
            float result = ((a[x] - b[x]) * (a[x] - b[x])) + ((a[y] - b[y]) * (a[y] - b[y]));
            return (float)Math.Sqrt(result);
        }
        public float DistanceFromZero(int[] a, int[] b)
        {
            int x = 0;
            int y = 1;
            float result = ((a[x] - b[x]) * (a[x] - b[x])) + ((a[y] - b[y]) * (a[y] - b[y]));
            return (float)Math.Sqrt(result);
        }

    }
}
