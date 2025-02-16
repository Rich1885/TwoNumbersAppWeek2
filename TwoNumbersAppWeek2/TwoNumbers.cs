using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersAppWeek2
{
    internal class TwoNumbers
    {
        private int FirstNum;
        private int SecondNum;

        public TwoNumbers(int firstNum, int secondNum) {

            FirstNum = firstNum;
            SecondNum = secondNum;

        }

        public int ReturnNum1()
        {
            return FirstNum;
        }

        public int ReturnNum2()
        {
            return SecondNum;
        }

        public int ReturnLargeNum()
        {
            return Math.Max(FirstNum, SecondNum);   
        }

        public bool ReturnEqualNum() 
        {
            return FirstNum == SecondNum;
            
        }

        public int GCD()
        {
            int a = FirstNum;
            int b = SecondNum;

            while(a != b)
            {
                if(a > b)
                {
                    a = a - b;
                } else
                {
                    b = b - a;
                }
            }
            return a;
        }

        public void AddNumbers(int firstNum, int secondNum)
        {
            FirstNum += firstNum;
            SecondNum += secondNum;
        }

        public override string ToString()
        {
            return $"First Number: {FirstNum}\n" +
                   $"Second Number: {SecondNum}\n" +
                   $"Max: {ReturnLargeNum()}\n" +
                   $"Equal: {ReturnEqualNum()}\n" +
                   $"GCD: {GCD()}";
        }


    }
}
