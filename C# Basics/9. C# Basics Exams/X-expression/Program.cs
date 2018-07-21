using System;

namespace X_expression
{
    class Program
    {
        static void Main()
        {
            //string expression = Console.ReadLine();
            int symbol = Console.Read();
            decimal outerValue = 0; ;
            int outerSign = '+';
            while (symbol != '=')
            {
                if ('0' <= symbol && symbol <= '9')//Ако е число
                {
                    switch (outerSign)
                    {
                        case '+': outerValue += (symbol - '0'); break;
                        case '-': outerValue -= (symbol - '0'); break;
                        case '*': outerValue *= (symbol - '0'); break;
                        case '/': outerValue /= (symbol - '0'); break;
                    }
                }
                else if (symbol == '(')
                {
                    decimal innerValue = 0;
                    int innerSign = '+';
                    symbol = Console.Read();
                    while (symbol != ')')
                    {
                        if ('0' <= symbol && symbol <= '9')//Ако е число
                        {
                            switch (innerSign)
                            {
                                case '+': innerValue += (symbol - '0'); break;
                                case '-': innerValue -= (symbol - '0'); break;
                                case '*': innerValue *= (symbol - '0'); break;
                                case '/': innerValue /= (symbol - '0'); break;
                            }
                        }
                        else
                        {
                            innerSign = symbol;
                        }
                        symbol = Console.Read(); //Прочитаме следващия символ

                    }
                    switch (outerSign)
                    {
                        case '+': outerValue += innerValue; break;
                        case '-': outerValue -= innerValue; break;
                        case '*': outerValue *= innerValue; break;
                        case '/': outerValue /= innerValue; break;
                    }
                }
                else
                {
                    outerSign = symbol;
                }
                symbol = Console.Read();
            }
            Console.WriteLine("{0:F2}", outerValue);
        }
    }
}
