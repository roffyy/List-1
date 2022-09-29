using System;

namespace List1
{
    class List1
    {
        static void Main(string[] args)
        {
            void question1()
            {
                float F, C;

                Console.Write("Put the temperature valor in Fahrenheit: ");
                F = (float)Convert.ToDouble(Console.ReadLine());

                C = (F - 32) / 1.8f;

                Console.WriteLine("\n\nThe temperature valor in Celsius is: " + C);
            }

            void question2()
            {
                int n, a1, q, aN;

                Console.Write("Put the N valor: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nPut the first term: ");
                a1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nPut the ratio valor: ");
                q = Convert.ToInt32(Console.ReadLine());

                aN = a1 * (q ^ (n - 1));

                Console.WriteLine("The last term is: " + aN);
            }

            void question3()
            {
                int min, km, intmin;
                float diff, seconds;

                Console.Write("Put the spent time (in min): ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the travelled distance (in km): ");
                km = Convert.ToInt32(Console.ReadLine());

                diff = (float)min / (float)km;
                intmin = Convert.ToInt32(diff);
                seconds = (diff - intmin) * 60;
                Console.WriteLine("Average pace of the runner: {0}:{1} min/km", intmin, seconds);
            }

            void question4()
            {
                int a = 2;
                int b = 4;
                int c = 6;

                Console.WriteLine(a == 4 || b > 2);
                Console.WriteLine(6 <= c && a > 3);
                Console.WriteLine(1 != b && c != 3);
                Console.WriteLine(a >= -1 || a <= b);
                Console.WriteLine(!(a > 2));
            }

            void question5()
            {
                int num1, num2, num3, num4, evenCount, evenSum, oddCount = 0, oddSum = 0, evenAvg, oddAvg;

                Console.Write("Put the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the third number: ");
                num3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the fourth number: ");
                num4 = Convert.ToInt32(Console.ReadLine());

                oddCount += num1%2;
                oddCount += num2%2;
                oddCount += num3%2;
                oddCount += num4%2;

                evenCount = 4 - oddCount;

                oddSum += num1 * (num1 % 2);
                oddSum += num2 * (num2 % 2);
                oddSum += num3 * (num3 % 2);
                oddSum += num4 * (num4 % 2);

                evenSum = num1 + num2 + num3 + num4 - oddSum;

                evenAvg = evenSum / evenCount;
                oddAvg = oddSum / oddCount;

                Console.WriteLine("\n\nThe even sum is: {0} \nThe even average is: {1}", evenSum, evenAvg);
                Console.WriteLine("\nThe odd sum is: {0} \nThe odd average is: {1}", oddSum, oddAvg);
            }

            void question6()
            {
                int num, d1, d2, d3, d4;

                Console.Write("Put a number of 4 digits: ");
                num = Convert.ToInt32(Console.ReadLine());

                d1 = num / 1000;
                d2 = (num / 100) - (d1 * 10);
                d3 = (num / 10) - (d1 * 100) - (d2 * 10);
                d4 = num - (d1 * 1000) - (d2 * 100) - (d3 * 10);

                if (d1 == d4 && d2 == d3)
                {
                    Console.WriteLine("\nThe number {0} is a palindrome!", num);
                }
                else
                {
                    Console.WriteLine("\nThe number {0} isnt a palindrome!", num);
                }
            }

            void question7()
            {
                int num, d1, d2, d3;

                Console.Write("Put a number of 3 digits here: ");
                num = Convert.ToInt32(Console.ReadLine());

                d1 = num / 100;
                d2 = num / 10 - d1 * 10;
                d3 = num - d1 * 100 - d2 * 10;

                if (d1 < d2 && d2 < d3)
                {
                    Console.WriteLine("\n\nThe number {0} is ascending", num);
                }
                else
                {
                    Console.WriteLine("\n\nThe number {0} isnt ascending", num);
                }
            }

            void question8()
            {
                float avg;

                Console.Write("Put the average valor: ");
                avg = (float)Convert.ToDouble(Console.ReadLine());

                if (avg >= 9.0)
                {
                    Console.WriteLine("print('A')");
                }
                else
                {
                    if (avg >= 8.0)
                    {
                        Console.WriteLine("print('B')");
                    }
                    else
                    {
                        if (avg >= 7.0)
                        {
                            Console.WriteLine("print('C')");
                        }
                        else
                        {
                            if (avg >= 6.0)
                            {
                                Console.WriteLine("print('D')");
                            }
                            else
                            {
                                Console.WriteLine("print('R')");
                            }
                        }
                    }
                }
            }

            void question9()
            {
                float avg;

                Console.Write("Put the average valor: ");
                avg = (float)Convert.ToDouble(Console.ReadLine());

                if (avg >= 9.0)
                {
                    Console.WriteLine("print('A')");
                }
                else if (avg >= 8.0)
                {
                    Console.WriteLine("print('B')");
                }
                else if (avg >= 7.0)
                {
                    Console.WriteLine("print('C')");
                }
                else if (avg >= 6.0)
                {
                    Console.WriteLine("print('D')");
                }
                else
                {
                    Console.WriteLine("print('R')");
                }
            }

            void question10()
            {
                float test1, test2, test3, avg, finaltest, finalAvg;

                Console.Write("Put the score of the first test: ");
                test1 = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Put the score of the second test: ");
                test2 = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Put the score of the third test: ");
                test3 = (float)Convert.ToDouble(Console.ReadLine());

                avg = (test1 + test2 + test3) / 3;

                if (avg >= 7)
                {
                    Console.WriteLine("\nThe student is approved!");
                }
                else
                {
                    Console.WriteLine("\nThe student isnt approved!");
                    Console.Write("\nType the final test score here: ");
                    finaltest = (float)Convert.ToDouble(Console.ReadLine());

                    finalAvg = (avg + finaltest) / 2;

                    if (finalAvg >= 5)
                    {
                        Console.WriteLine("\nThe student is approved!");
                    }
                    else
                    {
                        Console.WriteLine("\nThe student isnt approved!");
                    }
                }
            }

            void question11()
            {
                float x;

                Console.Write("Put the X valor here: ");
                x = (float)Convert.ToDouble(Console.ReadLine());

                if (x <= 1)
                {
                    Console.Write("\nThe Y valor is: " + Math.Log(x));
                }
                else if (1 < x  && x <= 2)
                {
                    Console.Write("\nThe Y valor is: " + Math.Log10(x) * Math.Sqrt(x));
                }
                else if (2 < x && x <= 5)
                {
                    Console.Write("\nThe Y valor is: " + (x * x + Math.Exp(x)));
                }
                else
                {
                    Console.Write("\nThe Y valor is: " + (Math.Pow(x, x / 2) + Math.Log2(x)));
                }
            }

            void question12()
            {
                int n;
                float side;

                Console.Write("Put the number of sides the polygon has: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the side valor: ");
                side = (float)Convert.ToDouble(Console.ReadLine());

                if (n == 3)
                {
                    Console.WriteLine("\nThe polygon is a triangle! \nThe perimeter valor is: " + side * 3);
                }
                else if (n == 4)
                {
                    Console.WriteLine("\nThe polygon is a square! \nThe are is: " + Math.Pow(side, 2));
                }
                else if (n == 5)
                {
                    Console.WriteLine("\nThe polygon is a pentagon!");
                }
                else
                {
                    Console.WriteLine("\nThe polygon isnt identified!");
                }
            }

            void question13()
            {
                float a, b, c;
                bool flag;

                Console.Write("Put the first side valor: ");
                a = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Put the second side valor: ");
                b = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Put the third side valor: ");
                c = (float)Convert.ToDouble(Console.ReadLine());

                if (Math.Abs(b - c) < a && a < b + c) flag = true;

                else if (Math.Abs(a - c) < b && b < a + c) flag = true;

                else if (Math.Abs(a - b) < c && c < a + b) flag = true;

                else flag = false;

                if (flag == true)
                {
                    Console.WriteLine("\nIts possible to form a triangle!");

                    if (a == b && b == c)
                    {
                        Console.WriteLine("The triangle is equilateral!");
                    }
                    else if (a != b && b != c)
                    {
                        Console.WriteLine("The triangle is scalene!");
                    }
                    else
                    {
                        Console.WriteLine("The triangle is isosceles!");
                    }
                }
                else
                {
                    Console.WriteLine("\nIts not possible to form a triangle!");
                }
            }

            void question14()
            {
                int run1Hours, run1Minutes, run1Seconds, run2Hours, run2Minutes, run2Seconds, totalAmount1, totalAmount2, diff, diffHours, diffMinutes, diffSeconds;

                Console.WriteLine("Runner 1: ");
                Console.Write("Hours: ");
                run1Hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Minutes: ");
                run1Minutes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Seconds: ");
                run1Seconds = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nRunner 2: ");
                Console.Write("Hours: ");
                run2Hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Minutes: ");
                run2Minutes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Seconds: ");
                run2Seconds = Convert.ToInt32(Console.ReadLine());

                totalAmount1 = (run1Hours * 3600) + (run1Minutes * 60) + run1Seconds;
                totalAmount2 = (run2Hours * 3600) + (run2Minutes * 60) + run2Seconds;

                if (totalAmount1 < totalAmount2)
                {
                    diff = totalAmount2 - totalAmount1;
                    diffHours = (diff) / (60 * 60);
                    diffMinutes = (diff / 60) - (diffHours * 60);
                    diffSeconds = (diff) - (diffHours * 60 * 60) - (diffMinutes * 60);
                    Console.WriteLine("\nThe Runner 1 is the winner!");
                    Console.WriteLine("\nTime difference: {0} Hours {1} Minutes and {2} Seconds", diffHours, diffMinutes, diffSeconds);
                }
                else if (totalAmount2 < totalAmount1)
                {
                    diff = totalAmount1 - totalAmount2;
                    diffHours = (diff) / (60 * 60);
                    diffMinutes = (diff / 60) - (diffHours * 60);
                    diffSeconds = (diff) - (diffHours * 60 * 60) - (diffMinutes * 60);
                    Console.WriteLine("\nThe Runner 2 is the winner!");
                    Console.WriteLine("\nTime difference: {0} Hours {1} Minutes and {2} Seconds", diffHours, diffMinutes, diffSeconds);
                }
                else
                {
                    Console.WriteLine("Both runners arrived at the same time!");
                }
            }

            void question15()
            {
                int birthDay, birthMon, birthYear, day, mon, year, age;
                
                Console.Write("Put the day of your birth: ");
                birthDay = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the month of your birth: ");
                birthMon = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the year of your birth: ");
                birthYear = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nPut the current day: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the current month: ");
                mon = Convert.ToInt32(Console.ReadLine());
                Console.Write("Put the current year: ");
                year = Convert.ToInt32(Console.ReadLine());

                if (year > birthYear)
                {
                    if (mon > birthMon)
                    {
                        age = year - birthYear;
                        Console.WriteLine("\nAge: {0} years old\n", age);
                    }
                    else if (mon == birthMon)
                    {
                        if (day >= birthDay)
                        {
                            age = year - birthYear;
                            Console.WriteLine("\nAge: {0} years old\n", age);
                        }
                        else
                        {
                            age = year - birthYear - 1;
                            Console.WriteLine("\nAge: {0} years old\n", age);
                        }
                    }
                    else
                    {
                        age = year - birthYear - 1;
                        Console.WriteLine("\nAge: {0} years old\n", age);
                    }
                }
                else if (year == birthYear)
                {
                    if (mon > birthMon)
                    {
                        age = year - birthYear;
                        Console.WriteLine("\nAge: {0} years old\n", age);
                    }
                    else if (mon == birthMon)
                    {
                        if (day >= birthDay)
                        {
                            age = year - birthYear;
                            Console.WriteLine("\nAge: {0} years old\n", age);
                        }
                        else
                        {
                            Console.WriteLine("\nThe date isnt valid!\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThe date isnt valid!\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nThe year isnt valid!\n");
                }
            }

            void question16()
            {
                int year, a, b, c, d, e, X, Y, P = 0, P1 = 0, P2 = 0;

                Console.Write("Put a year: ");
                year = Convert.ToInt32(Console.ReadLine());

                a = year % 19;
                b = year % 4;
                c = year % 7;

                if (year >= 1582 && year <= 1699)
                {
                    X = 22;
                    Y = 2;
                    d = (19 * a + X) % 30;
                    e = (2 * b + 4 * c + 6 * d + Y) % 7;
                    P = 22 + d + e;
                    P1 = d + e - 9;
                    P2 = P1 - 7;
                }
                else if (year >= 1700 && year <= 1799)
                {
                    X = 23;
                    Y = 3;
                    d = (19 * a + X) % 30;
                    e = (2 * b + 4 * c + 6 * d + Y) % 7;
                    P = 22 + d + e;
                    P1 = d + e - 9;
                    P2 = P1 - 7;
                }
                else if (year >= 1800 && year <= 1899)
                {
                    X = 23;
                    Y = 4;
                    d = (19 * a + X) % 30;
                    e = (2 * b + 4 * c + 6 * d + Y) % 7;
                    P = 22 + d + e;
                    P1 = d + e - 9;
                    P2 = P1 - 7;
                }
                else if (year >= 1900 && year <= 2099)
                {
                    X = 24;
                    Y = 5;
                    d = (19 * a + X) % 30;
                    e = (2 * b + 4 * c + 6 * d + Y) % 7;
                    P = 22 + d + e;
                    P1 = d + e - 9;
                    P2 = P1 - 7;
                }
                else if (year >= 2100 && year <= 2199)
                {
                    X = 24;
                    Y = 6;
                    d = (19 * a + X) % 30;
                    e = (2 * b + 4 * c + 6 * d + Y) % 7;
                    P = 22 + d + e;
                    P1 = d + e - 9;
                    P2 = P1 - 7;
                }
                else if (year >= 2200 && year <= 2299)
                {
                    X = 25;
                    Y = 0;
                    d = (19 * a + X) % 30;
                    e = (2 * b + 4 * c + 6 * d + Y) % 7;
                    P = 22 + d + e;
                    P1 = d + e - 9;
                    P2 = P1 - 7;
                }
                else if (year >= 2300 && year <= 2399)
                {
                    X = 26;
                    Y = 1;
                    d = (19 * a + X) % 30;
                    e = (2 * b + 4 * c + 6 * d + Y) % 7;
                    P = 22 + d + e;
                    P1 = d + e - 9;
                    P2 = P1 - 7;
                }
                else if (year >= 2400 && year <= 2499)
                {
                    X = 25;
                    Y = 1;
                    d = (19 * a + X) % 30;
                    e = (2 * b + 4 * c + 6 * d + Y) % 7;
                    P = 22 + d + e;
                    P1 = d + e - 9;
                    P2 = P1 - 7;
                }
                else
                {
                    Console.WriteLine("\nIts not a valid year!");
                }

                if (P <= 31)
                {
                    Console.WriteLine("\nIn the year {0} the easter will be in the {1} day of march", year, P);
                }
                else if (P1 <= 25)
                {
                    Console.WriteLine("\nIn the year {0} the easter will be in the {1} day of April", year, P1);
                }
                else
                {
                    Console.WriteLine("\nIn the year {0} the easter will be in the {1} day of April", year, P2);
                }

            }

            int OP;

            Console.Write("Choose an operator between 1 and 16: ");

            OP = Convert.ToInt32(Console.ReadLine());

            if (OP >= 1 && OP <= 16)
            {
                if (OP == 1) question1();

                if (OP == 2) question2();

                if (OP == 3) question3();

                if (OP == 4) question4();

                if (OP == 5) question5();

                if (OP == 6) question6();

                if (OP == 7) question7();

                if (OP == 8) question8();

                if (OP == 9) question9();

                if (OP == 10) question10();

                if (OP == 11) question11();

                if (OP == 12) question12();

                if (OP == 13) question13();

                if (OP == 14) question14();

                if (OP == 15) question15();

                if (OP == 16) question16();
            }
            else
            {
                Console.WriteLine("That number isnt a valid operator!");
            }
        }
    }
}