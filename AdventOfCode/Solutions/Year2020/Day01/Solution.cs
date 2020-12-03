using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Solutions.Year2020
{

    class Day01 : ASolution
    {

        IEnumerable<int> Report;
        public Day01() : base(01, 2020, "Report Repair")
        {
           Report= Input.ToIntArray("\n").ToHashSet().Where(e=>e<2020);
        }

        protected override string SolvePartOne()
        {
            var expenses = new Queue<int>(Report);
            while(true){
                var el=expenses.Dequeue();
                foreach (var el2 in expenses)
                {
                    if(el+el2==2020)return (el*el2).ToString();
                }
            }
        }

        protected override string SolvePartTwo()
        {
         var expenses = new Queue<int>(Report);
            while(true){
                var el = expenses.Dequeue();
                foreach (var el2 in expenses)
                {foreach (var el3 in expenses)
                {
                    if(el+el2+el3==2020)return(el*el2*el3).ToString();
                    
                }
                    
                }
            }
        }
    }
}
