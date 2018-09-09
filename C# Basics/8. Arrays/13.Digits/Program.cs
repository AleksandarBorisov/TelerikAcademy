using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Digits
{
    class Program
    {
        private static byte[,] digits;

        static void Main(string[] args)
        {
            //            //Моето решение, което удря лиммит от памет
            //            //string[] test = File.ReadAllLines("test.txt");
            //            //int n = int.Parse(test[0]);
            //            int n = int.Parse(Console.ReadLine());
            //            string[] predefinedDigits = new string[]
            //            {
            //                @"000
            //0 0
            //0 0
            //0 0
            //000",
            //                @"  1
            // 11
            //1 1
            //  1
            //  1",
            //                @" 2 
            //2 2
            //  2
            // 2 
            //222",
            //                @"333
            //  3
            // 33
            //  3
            //333",
            //                @"4 4
            //4 4
            //444
            //  4
            //  4",
            //                @"555
            //5  
            //555
            //  5
            //555",
            //                @"666
            //6  
            //666
            //6 6
            //666",
            //                @"777
            //  7
            // 7 
            // 7 
            // 7 ",
            //                @"888
            //8 8
            // 8 
            //8 8
            //888",
            //                @"999
            //9 9
            // 99
            //  9
            //999"
            //            };

            //            digits = new byte[n, n];
            //            for (int row = 0; row < n; row++)
            //            {
            //                //string[] input = test[row + 1].Split();
            //                string input = Console.ReadLine().Replace(" ", "");
            //                for (int col = 0; col < input.Length; col++)
            //                {
            //                    digits[row, col] = (byte)(input[col] - '0');
            //                }
            //            }
            //            int sum = 0;
            //            for (int row = 0; row < n - 4; row++)
            //            {
            //                for (int col = 0; col < n - 2; col++)
            //                {
            //                    if (digits[row + 2, col] == 1)
            //                    {
            //                        if (CheckPattern(predefinedDigits[1].Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries), row, col))
            //                        {
            //                            sum += 1;
            //                            continue;
            //                        }
            //                    }
            //                    if (digits[row, col + 1] == 2)
            //                    {
            //                        if (CheckPattern(predefinedDigits[2].Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries), row, col))
            //                        {
            //                            sum += 2;
            //                            continue;
            //                        }
            //                    }
            //                    if (digits[row, col] != 1 && digits[row, col] != 2)
            //                    {
            //                        if (CheckPattern(predefinedDigits[digits[row, col]].Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries), row, col))
            //                        {
            //                            sum += digits[row, col];
            //                        }
            //                    }
            //                }
            //            }
            //            Console.WriteLine(sum);
            //        }

            //        static bool CheckPattern(string[] pattern, int row, int col)
            //        {
            //            for (int i = 0; i < pattern.Length; i++)
            //            {
            //                for (int j = 0; j < pattern[i].Length; j++)
            //                {
            //                    char currentSign = pattern[i][j];
            //                    if (currentSign != ' ')
            //                    {
            //                        if (pattern[i][j] - '0' != digits[row + i, col + j])
            //                        {
            //                            return false;
            //                        }
            //                    }
            //                }
            //            }
            //            return true;

            int n = int.Parse(Console.ReadLine());
            digits = new byte[n, n];
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine().Replace(" ", "");
                for (int col = 0; col < input.Length; col++)
                {
                    digits[row, col] = (byte)(input[col] - '0');
                }
            }
            int sum = 0;
            for (int row = 0; row < n - 4; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    switch (digits[row, col])
                    {
                        case 1: sum += CheckforOne(row, col); break;
                        case 2: sum += CheckforTwo(row, col); break;
                        case 3: sum += CheckforThree(row, col); break;
                        case 4: sum += CheckforFour(row, col); break;
                        case 5: sum += CheckforFive(row, col); break;
                        case 6: sum += CheckforSix(row, col); break;
                        case 7: sum += CheckforSeven(row, col); break;
                        case 8: sum += CheckforEight(row, col); break;
                        case 9: sum += CheckforNine(row, col); break;

                    }
                }
            }
            Console.WriteLine(sum);
        }

        private static int CheckforOne(int row, int col)
        {
            bool result = col >= 2 &&
                digits[row + 1, col - 1] == 1 &&
                digits[row + 1, col] == 1 &&
                digits[row + 2, col - 2] == 1 &&
                digits[row + 2, col] == 1 &&
                digits[row + 3, col] == 1 &&
                digits[row + 4, col] == 1;

            return !result ? 0 : 1;
        }

        private static int CheckforTwo(int row, int col)
        {
            bool result = col >= 1 &&
                col < digits.GetLength(1) - 1 &&
                digits[row + 1, col - 1] == 2 &&
                digits[row + 1, col + 1] == 2 &&
                digits[row + 2, col + 1] == 2 &&
                digits[row + 3, col] == 2 &&
                digits[row + 4, col] == 2 &&
                digits[row + 4, col - 1] == 2 &&
                digits[row + 4, col + 1] == 2;

            return !result ? 0 : 2;
        }

        private static int CheckforThree(int row, int col)
        {
            bool result = col >= 2 &&
                digits[row, col - 1] == 3 &&
                digits[row, col - 2] == 3 &&
                digits[row + 1, col] == 3 &&
                digits[row + 2, col] == 3 &&
                digits[row + 2, col - 1] == 3 &&
                digits[row + 3, col] == 3 &&
                digits[row + 4, col] == 3 &&
                digits[row + 4, col - 1] == 3 &&
                digits[row + 4, col - 2] == 3;

            return !result ? 0 : 3;
        }

        private static int CheckforFour(int row, int col)
        {
            bool result = col >= 2 &&
                digits[row, col - 2] == 4 &&
                digits[row + 1, col - 2] == 4 &&
                digits[row + 1, col] == 4 &&
                digits[row + 2, col - 2] == 4 &&
                digits[row + 2, col - 1] == 4 &&
                digits[row + 2, col] == 4 &&
                digits[row + 3, col] == 4 &&
                digits[row + 4, col] == 4;

            return !result ? 0 : 4;
        }

        private static int CheckforFive(int row, int col)
        {
            bool result = col >= 2 &&
                digits[row, col - 1] == 5 &&
                digits[row, col - 2] == 5 &&
                digits[row + 1, col - 2] == 5 &&
                digits[row + 2, col - 2] == 5 &&
                digits[row + 2, col - 1] == 5 &&
                digits[row + 2, col] == 5 &&
                digits[row + 3, col] == 5 &&
                digits[row + 4, col] == 5 &&
                digits[row + 4, col - 1] == 5 &&
                digits[row + 4, col - 2] == 5;

            return !result ? 0 : 5;
        }

        private static int CheckforSix(int row, int col)
        {
            bool result = col >= 2 &&
                digits[row, col - 1] == 6 &&
                digits[row, col - 2] == 6 &&
                digits[row + 1, col - 2] == 6 &&
                digits[row + 2, col - 2] == 6 &&
                digits[row + 2, col - 1] == 6 &&
                digits[row + 2, col] == 6 &&
                digits[row + 3, col - 2] == 6 &&
                digits[row + 3, col] == 6 &&
                digits[row + 4, col - 2] == 6 &&
                digits[row + 4, col - 1] == 6 &&
                digits[row + 4, col] == 6;

            return !result ? 0 : 6;
        }

        private static int CheckforSeven(int row, int col)
        {
            bool result = col >= 2 &&
                digits[row, col - 2] == 7 &&
                digits[row, col - 1] == 7 &&
                digits[row + 1, col] == 7 &&
                digits[row + 2, col - 1] == 7 &&
                digits[row + 3, col - 1] == 7 &&
                digits[row + 4, col - 1] == 7;

            return !result ? 0 : 7;
        }

        private static int CheckforEight(int row, int col)
        {
            bool result = col >= 2 &&
                digits[row, col - 2] == 8 &&
                digits[row, col - 1] == 8 &&
                digits[row + 1, col - 2] == 8 &&
                digits[row + 1, col] == 8 &&
                digits[row + 2, col - 1] == 8 &&
                digits[row + 3, col - 2] == 8 &&
                digits[row + 3, col] == 8 &&
                digits[row + 4, col - 2] == 8 &&
                digits[row + 4, col] == 8 &&
                digits[row + 4, col - 1] == 8;

            return !result ? 0 : 8;
        }

        private static int CheckforNine(int row, int col)
        {
            bool result = col >= 2 &&
                digits[row, col - 2] == 9 &&
                digits[row, col - 1] == 9 &
                digits[row + 1, col] == 9 &&
                digits[row + 1, col - 2] == 9 &&
                digits[row + 2, col] == 9 &&
                digits[row + 2, col - 1] == 9 &&
                digits[row + 3, col] == 9 &&
                digits[row + 4, col] == 9 &&
                digits[row + 4, col - 1] == 9 &&
                digits[row + 4, col - 2] == 9;

            return !result ? 0 : 9;
        }
    }
}
