using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace AdventOfCode.Solutions.Year2020
{

    public class PasswordPolicy
    {
        public int minCount;
        public int maxCount;
        public string c;

        public String ExamplePassword;
        //1-3 a: abcde

        public PasswordPolicy(string InputText)
        {
            var parts = InputText.Split(" ");
            this.minCount = Convert.ToInt32(parts[0].Split("-")[0]);
            this.maxCount = Convert.ToInt32(parts[0].Split("-")[1]);
            this.c = parts[1].Substring(0, 1);
            this.ExamplePassword = parts[2];

        }

    }
    class Day02 : ASolution
    {
        public int CountOccurence(string text, string pattern)
        {
            int c = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                c++;
            }
            return c;
        }
        string[] PasswordList;
        public Day02() : base(02, 2020, "Password Philosophy")
        {
            PasswordList = Input.SplitByNewline().ToArray();
        }

        protected override string SolvePartOne()
        {
            int counter = 0;
            for (var i = 0; i < PasswordList.Length; i++)
            {
                var cPassword = new PasswordPolicy(PasswordList[i]);
                var occurence = CountOccurence(cPassword.ExamplePassword, cPassword.c);
                if (cPassword.minCount <= occurence && cPassword.maxCount >= occurence)
                {
                    counter++;
                }
            }
            //var policy = new PasswordPolicy(InputList.FirstOrDefault());
            return counter.ToString();
        }

        protected override string SolvePartTwo()
        {
            int counter = 0;
            for (var i = 0; i < PasswordList.Length; i++)
            {
                var cp = new PasswordPolicy(PasswordList[i]);
                char character = cp.c[0];
                char loChar=cp.ExamplePassword[cp.minCount-1];
                char hiChar=cp.ExamplePassword[cp.maxCount-1];
                if((loChar==character)!=(hiChar==character)){
                    counter++;
                }
            }
            return counter.ToString();

        }
    }
}
