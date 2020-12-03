using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Solutions.Year2020
{

    class Day03 : ASolution
    {


       bool [][] map;
        public Day03() : base(03, 2020, "Toboggan Trajectory")
        {
         map = Input.SplitByNewline().Select(line => line.Select(c => c == '#').ToArray()).ToArray();
        }
        long TreeCheck(int column,int row){
           
           long count =0;
             for (int x = 0, y = 0; y < map.Length; y +=row , x += column)
            {
                x %= map[y].Length;
                if (map[y][x]) count++;
            }
           return count;
        }
        protected override string SolvePartOne()
        {
            int moveColumn=3;
            int moveRow=1;
            return TreeCheck(moveColumn,moveRow).ToString();
        }

        protected override string SolvePartTwo()
        {
                    return (TreeCheck(1,1)*TreeCheck(3,1)*TreeCheck(5,1)*TreeCheck(7,1)*TreeCheck(1,2)).ToString();
        }
    }
}
