using System;
using System.Collections.Generic;

namespace multibracketvalidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// MultiBracketValidation
        /// </summary>
        /// <param name="input">String to test</param>
        /// <returns>Is ok or not</returns>
        public static bool Validate(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char charactor in input)
            {
                if (charactor == '(' || charactor == '[' || charactor == '{')
                {
                    stack.Push(charactor);
                }
                else if (charactor == ')' || charactor == ']' || charactor == '}')
                {
                    if (stack.Count != 0)
                    {
                        if (charactor == ')')
                        {
                            if (stack.Peek() == '(')
                            {
                                stack.Pop();
                            }
                        }
                        else if (charactor == ']')
                        {
                            if (stack.Peek() == '[')
                            {
                                stack.Pop();
                            }
                        }
                        else if (charactor == '}')
                        {
                            if (stack.Peek() == '{')
                            {
                                stack.Pop();
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
