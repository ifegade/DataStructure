using System;
using System.Collections.Generic;

namespace soti
{
    public class PrefixAndInfix
    {
        // string input1 = "8+(7-9)*2";
        static bool isCharAnOperator(char theChar)
        {
            return (!(theChar >= 'a' && theChar <= 'z') &&
                    !(theChar >= '0' && theChar <= '9') &&
                    !(theChar >= 'A' && theChar <= 'Z'));
        }
        static int isCharPriority(char theChar)
        {
            if (theChar == '-' || theChar == '+')
                return 1;
            else if (theChar == '*' || theChar == '/')
                return 2;
            else if (theChar == '^')
                return 3;
            return 0;
        }
        static string firstOperand;
        static string secondOperand;
        static char op;
        static string temp;
        static string infixToPrefixConverter(string infix)
        {
            Stack<char> operators = new Stack<char>();

            Stack<string> operands = new Stack<string>();

            for (int i = 0; i < infix.Length; i++)
            {
                if (infix[i] == '(')
                {
                    operators.Push(infix[i]);
                }
                else if (infix[i] == ')')
                {
                    while (operators.Count != 0 && operators.Peek() != '(')
                    {

                        firstOperand = operands.Peek();
                        operands.Pop();

                        secondOperand = operands.Peek();
                        operands.Pop();

                        op = operators.Peek();
                        operators.Pop();

                        temp = op + secondOperand + firstOperand;
                        operands.Push(temp);
                    }

                    operators.Pop();
                }
                else if (!isCharAnOperator(infix[i]))
                {
                    operands.Push(infix[i] + "");
                }
                else
                {
                    while (operators.Count != 0 && isCharPriority(infix[i]) <= isCharPriority(operators.Peek()))
                    {

                        firstOperand = operands.Peek();
                        operands.Pop();

                        secondOperand = operands.Peek();
                        operands.Pop();

                        op = operators.Peek();
                        operators.Pop();

                        temp = op + secondOperand + firstOperand;
                        operands.Push(temp);
                    }

                    operators.Push(infix[i]);
                }
            }

            while (operators.Count != 0)
            {
                firstOperand = operands.Peek();
                operands.Pop();

                secondOperand = operands.Peek();
                operands.Pop();

                op = operators.Peek();
                operators.Pop();

                temp = op + secondOperand + firstOperand;
                operands.Push(temp);
            }

            return operands.Peek();
        }
    }
}
