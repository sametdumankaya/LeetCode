using System;
using System.Collections.Generic;

namespace LeetCodeSolutions.Solutions
{
    class Problem20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            try
            {
                foreach (char ch in s)
                {
                    if (ch.Equals('{') || ch.Equals('(') || ch.Equals('['))
                    {
                        stack.Push(ch);
                    }
                    else
                    {
                        if (ch.Equals('}') && stack.Peek().Equals('{'))
                        {
                            if (stack.Peek().Equals('{'))
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return false;
                            }

                        }

                        else if (ch.Equals(')'))
                        {
                            if (stack.Peek().Equals('('))
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return false;
                            }

                        }

                        else if (ch.Equals(']'))
                        {
                            if (stack.Peek().Equals('['))
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return stack.Count == 0;
        }
    }
}
