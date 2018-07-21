﻿using System;

namespace X_Expression
{
    class Program
    {
        static void Main()
        {
            int symbol = Console.Read();
            decimal result = 0;
            int expressionOperator = '+';
            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    decimal innerResult = 0;
                    int innerOperator = '+';
                    symbol = Console.Read();
                    while (symbol != ')')
                    {
                        if (0 <= symbol - '0' && symbol - '0' <= 9)
                        {
                            switch (innerOperator)
                            {
                                case '+':
                                    innerResult += symbol - '0';
                                    break;
                                case '-':
                                    innerResult -= symbol - '0';
                                    break;
                                case '/':
                                    innerResult /= symbol - '0';
                                    break;
                                case '*':
                                    innerResult *= symbol - '0';
                                    break;
                            }
                        }
                        if (symbol == '+' ||
                            symbol == '-' ||
                            symbol == '/' ||
                            symbol == '*')
                        {
                            innerOperator = symbol;
                        }
                        symbol = Console.Read();
                    }
                    switch (expressionOperator)
                    {
                        case '+':
                            result += innerResult;
                            break;
                        case '-':
                            result -= innerResult;
                            break;
                        case '/':
                            result /= innerResult;
                            break;
                        case '*':
                            result *= innerResult;
                            break;
                    }
                }
                else if (0 <= symbol - '0' && symbol - '0' <= 9)
                {
                    switch (expressionOperator)
                    {
                        case '+':
                            result += symbol - '0';
                            break;
                        case '-':
                            result -= symbol - '0';
                            break;
                        case '/':
                            result /= symbol - '0';
                            break;
                        case '*':
                            result *= symbol - '0';
                            break;
                    }
                }
                else if (symbol == '+' ||
                         symbol == '-' ||
                         symbol == '/' ||
                         symbol == '*')
                {
                    expressionOperator = symbol;
                }
                symbol = Console.Read();
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
