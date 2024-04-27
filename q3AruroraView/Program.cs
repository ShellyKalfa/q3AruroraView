using System;
using System.Collections.Generic;

namespace q3AruroraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] brackets = { "}", "}", "{", "(","]", "[", "]", "[" };
            string[] brackets1 = { "{", "}", "{","(",")", "}", "(", ")", "[", "]"};
            string[] brackets2 = { "{", "[", "{","}", "]", "}","[", "]"};
            string[] bracketsAndOr = { "{", "[", "{","|","|", "}", "]", "}", "[", "]" };
            Console.WriteLine("first brackets {0} ", isItLogic(brackets).ToString());
            Console.WriteLine("secound brackets {0} ", isItLogic(brackets1).ToString());
            Console.WriteLine("Third brackets {0} ", isItLogic(brackets2).ToString());
            Console.WriteLine("bracketsAndOr brackets {0} ", isItLogic(bracketsAndOr).ToString());
        }
        static bool isItLogic(string[] bracketsTemp) 
        {
            Stack<string> openingBrackets = new Stack<string>();
            string tempBracket;
            bool flag=false ;
            for (int i=0;i<= bracketsTemp.Length-1;i++) 
            {
                if (bracketsTemp[i] == "{" || bracketsTemp[i] == "[" || bracketsTemp[i] == "(" ||(!flag && bracketsTemp[i] == "|"))
                {
                    openingBrackets.Push(bracketsTemp[i]);
                    if (bracketsTemp[i] == "|")
                        flag = true;
                }
                else
                {
                    if (openingBrackets.Count == 0)
                    {
                        return false;
                    }
                   
                    switch (bracketsTemp[i])
                        {
                            case "}":
                                tempBracket = openingBrackets.Pop();
                            if (tempBracket != "{")
                                    return false;
                                break;
                            case "]":
                                tempBracket = openingBrackets.Pop();
                            if (tempBracket != "[")
                                    return false;
                                break;
                            case ")":
                                tempBracket = openingBrackets.Pop();
                            if (tempBracket != "(")
                                    return false;
                                break;
                            case "|":
                                tempBracket = openingBrackets.Pop();
                            if (tempBracket != "|")
                                   return false;
                                break;
                        default:
                                return false;
                                break;
                        }
                }
            }

            return true;
        }
    }
   /* static bool isItLogicWithOutOr(string[] bracketsTemp)
    {
        Stack<string> openingBrackets = new Stack<string>();
        string tempBracket;
        for (int i = 0; i <= bracketsTemp.Length - 1; i++)
        {
            if (bracketsTemp[i] == "{" || bracketsTemp[i] == "[" || bracketsTemp[i] == "(")
            {
                openingBrackets.Push(bracketsTemp[i]);

            }
            else
            {
                if (openingBrackets.Count == 0)
                {
                    return false;
                }

                switch (bracketsTemp[i])
                {
                    case "}":
                        tempBracket = openingBrackets.Pop();
                        if (tempBracket != "{")
                            return false;
                        break;
                    case "]":
                        tempBracket = openingBrackets.Pop();
                        if (tempBracket != "[")
                            return false;
                        break;
                    case ")":
                        tempBracket = openingBrackets.Pop();
                        if (tempBracket != "(")
                            return false;
                        break;
                    default:
                        return false;
                        break;
                }
            }
        }

        return true;
    } */


}
