using System.Collections.Generic;
using System.Linq;

namespace SumOfGCPandLCM
{
    public class GCDandLCMCalculator
    {
        public GCDandLCMCalculator(int firstNum, int secondNum)
        {
            NumberOne = firstNum;
            NumberTwo = secondNum;
        }
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public int GetGCD(int num, int numb)
        {           
            Stack<int> nums = new Stack<int>();
            nums.Push(num);
            nums.Push(numb);
            int bigger = nums.Max();
            int smaller = nums.Min();
            int reminder = -1;
            while (reminder != 0)
            {
                reminder = bigger % smaller;
                bigger = smaller;
                if (reminder != 0)
                    smaller = reminder;
            }
            return smaller;
        }
        public int GetLCM(int num, int numb)
        {
            return num * numb / GetGCD(num, numb);
        }
        public int GetSumOfGCDAndLCM(int num, int numb)
        {
            return GetGCD(num, numb) + GetLCM(num, numb);
        }
    }
}

