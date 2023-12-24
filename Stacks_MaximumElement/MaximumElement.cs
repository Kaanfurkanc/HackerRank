using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stacks_MaximumElement
{
    public class Result
    {
        public static List<int> getMax(List<string> operations)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();
            List<int> result = new List<int>();
            int length = operations.Count;
            int maxValue = 0;
            
            maxStack.Push(maxValue);
            for (int i = 0; i < length; i++)
            {
                var query = operations[i].Split();
                if (query[0] == "1")
                {
                    int value = int.Parse(query[1]);
                    if (maxValue < value)
                    {
                        maxValue = value;
                        maxStack.Push(maxValue);
                    }
                    stack.Push(value);
                }
                else if (query[0] == "2")
                {
                    if (maxStack.Peek() == stack.Peek())
                    {
                        maxStack.Pop();
                        maxValue = maxStack.Peek();
                    }
                    stack.Pop();     
                }
                else if (query[0] == "3") 
                    result.Add(maxStack.Peek());   
            }
            return result;
        }
    }
}