using System;
using System.Collections.Generic;

namespace Algorithms.Test
{
    public class AritmaticMachine
    {
        public int solution(string S)
        {

            Stack<int> machine = new Stack<int>();

            string currentValue = "";

            foreach (char i in S)
            {
               
                if (Char.IsNumber(i)) {

                    machine.Push((int)Char.GetNumericValue(i));
                    continue;

                };
                

                if (i.Equals('+') || i.Equals('-') || i.Equals('*') || i.Equals('/'))
                {
                    if (machine.Count <= 1 )
                    {
                        return -1;
                    }

                    var value1 = machine.Pop();
                    var value2 = machine.Pop();

                    machine.Push((int)Calculate(value1, value2, i));
                }
                
            }

            return (int) machine.Pop();

        }

        private double Calculate(int num1, int num2, char op)
        {

            if (op == '+')    {
                return num1 + num2;
            } 
            else if (op == '-')
            {
                return num1 - num2;
            }
            else if (op == '*')
            {
                return num1 * num2;
            }
            else if (op == '/')
            {
                return Convert.ToDouble(num1) / Convert.ToDouble(num1);
            }

            return 0;
        }

    }
}
