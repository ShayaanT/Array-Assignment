using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                double[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] array = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
                char[] arrray = new char[10];
                char[] arrray1 = new char[10];

                Console.WriteLine();
                Console.WriteLine("                                       Please select the section you would like to visit by typing in the number next to your desired selection");
                Console.WriteLine();
                Console.WriteLine("                                          ____________________________________________________________________________________________");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |           Please enter the number indicating which category you want to order from.        |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  1 -       Array                                           |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  2 -  Sum of an array                                      |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  3 - Array multiplied by 10                                |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  4 -   Make an array                                       |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  5 - Put signs in your array                               |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  6 -        Exit                                           |");
                Console.WriteLine("                                         |____________________________________________________________________________________________|");
                int Selection1 = Convert.ToInt32(Console.ReadLine());


                if (Selection1 == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                                                     This is an array ");
                    Console.WriteLine();
                    for (int i = 0; i <= 9; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    Console.ReadLine();
                }

                if (Selection1 == 2)
                {

                    Console.WriteLine();
                    Console.WriteLine("                                                                                This is the sum of the array");
                    Console.WriteLine();
                    double sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum = sum + array[i];
                        Console.WriteLine(sum);
                    }
                    Console.ReadLine();
                }

                if (Selection1 == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                                      This is each element of the array, multiplied by 10");
                    Console.WriteLine();
                    for (int i = 0; i <= 9; i++)
                    {
                        Console.WriteLine(array[i] * 10);
                    }

                    Console.ReadLine();
                }


                if (Selection1 == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                                            Now it's your turn to make an array!");
                    Console.WriteLine();
                    for (int i = 0; i <= 9; i++)
                    {
                        Console.WriteLine("                                                                               Add a number to your array");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                        if (numbers[i] == 7)
                        {
                            break;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("                                                                            Please change the numbers " + numbers[8] + " and " + numbers[9]);
                    numbers[8] = Convert.ToDouble(Console.ReadLine());
                    numbers[9] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(numbers[0] + ", " + numbers[1] + ", " + numbers[2] + ", " + numbers[3] + ", " + numbers[4] + " ," + numbers[5] + " ," + numbers[6] + " ," + numbers[7] + " ," + numbers[8] + " ," + numbers[9]);
                    Console.ReadLine();

                    if (numbers[0] > numbers[1] & numbers[0] > numbers[2] & numbers[0] > numbers[3] & numbers[0] > numbers[4] & numbers[0] > numbers[5] & numbers[0] > numbers[6] & numbers[0] > numbers[7] & numbers[0] > numbers[8] & numbers[0] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[0]);
                    }

                    if (numbers[1] > numbers[0] & numbers[1] > numbers[2] & numbers[1] > numbers[3] & numbers[1] > numbers[4] & numbers[1] > numbers[5] & numbers[1] > numbers[6] & numbers[1] > numbers[7] & numbers[1] > numbers[8] & numbers[1] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[1]);
                    }

                    if (numbers[2] > numbers[0] & numbers[2] > numbers[1] & numbers[2] > numbers[3] & numbers[2] > numbers[4] & numbers[2] > numbers[5] & numbers[2] > numbers[6] & numbers[2] > numbers[7] & numbers[2] > numbers[8] & numbers[2] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[2]);
                    }

                    if (numbers[3] > numbers[0] & numbers[3] > numbers[1] & numbers[3] > numbers[2] & numbers[3] > numbers[4] & numbers[3] > numbers[5] & numbers[3] > numbers[6] & numbers[3] > numbers[7] & numbers[3] > numbers[8] & numbers[3] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[3]);
                    }

                    if (numbers[4] > numbers[0] & numbers[4] > numbers[1] & numbers[4] > numbers[2] & numbers[4] > numbers[3] & numbers[4] > numbers[5] & numbers[4] > numbers[6] & numbers[4] > numbers[7] & numbers[4] > numbers[8] & numbers[4] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[4]);
                    }

                    if (numbers[5] > numbers[0] & numbers[5] > numbers[1] & numbers[5] > numbers[2] & numbers[5] > numbers[3] & numbers[5] > numbers[4] & numbers[5] > numbers[6] & numbers[5] > numbers[7] & numbers[5] > numbers[8] & numbers[5] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[5]);
                    }

                    if (numbers[6] > numbers[0] & numbers[6] > numbers[1] & numbers[6] > numbers[2] & numbers[6] > numbers[3] & numbers[6] > numbers[4] & numbers[6] > numbers[5] & numbers[6] > numbers[7] & numbers[6] > numbers[8] & numbers[6] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[6]);
                    }

                    if (numbers[7] > numbers[0] & numbers[7] > numbers[1] & numbers[7] > numbers[2] & numbers[7] > numbers[3] & numbers[7] > numbers[4] & numbers[7] > numbers[5] & numbers[7] > numbers[6] & numbers[7] > numbers[8] & numbers[7] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[7]);
                    }

                    if (numbers[8] > numbers[0] & numbers[8] > numbers[1] & numbers[8] > numbers[2] & numbers[8] > numbers[3] & numbers[8] > numbers[4] & numbers[8] > numbers[5] & numbers[8] > numbers[6] & numbers[8] > numbers[7] & numbers[8] > numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[8]);
                    }

                    if (numbers[9] > numbers[0] & numbers[9] > numbers[1] & numbers[9] > numbers[2] & numbers[9] > numbers[3] & numbers[9] > numbers[4] & numbers[9] > numbers[5] & numbers[9] > numbers[6] & numbers[9] > numbers[7] & numbers[9] > numbers[8])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The greatest value inputed was " + numbers[9]);
                    }



                    if (numbers[0] < numbers[1] & numbers[0] < numbers[2] & numbers[0] < numbers[3] & numbers[0] < numbers[4] & numbers[0] < numbers[5] & numbers[0] < numbers[6] & numbers[0] < numbers[7] & numbers[0] < numbers[8] & numbers[0] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The least value inputed was " + numbers[0]);
                    }

                    if (numbers[1] < numbers[0] & numbers[1] < numbers[2] & numbers[1] < numbers[3] & numbers[1] < numbers[4] & numbers[1] < numbers[5] & numbers[1] < numbers[6] & numbers[1] < numbers[7] & numbers[1] < numbers[8] & numbers[1] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The least value inputed was " + numbers[1]);
                    }

                    if (numbers[2] < numbers[0] & numbers[2] < numbers[1] & numbers[2] < numbers[3] & numbers[2] < numbers[4] & numbers[2] < numbers[5] & numbers[2] < numbers[6] & numbers[2] < numbers[7] & numbers[2] < numbers[8] & numbers[2] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The least value inputed was " + numbers[2]);
                    }

                    if (numbers[3] < numbers[0] & numbers[3] < numbers[1] & numbers[3] < numbers[2] & numbers[3] < numbers[4] & numbers[3] < numbers[5] & numbers[3] < numbers[6] & numbers[3] < numbers[7] & numbers[3] < numbers[8] & numbers[3] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The least value inputed was " + numbers[3]);
                    }

                    if (numbers[4] < numbers[0] & numbers[4] < numbers[1] & numbers[4] < numbers[2] & numbers[4] < numbers[3] & numbers[4] < numbers[5] & numbers[4] < numbers[6] & numbers[4] < numbers[7] & numbers[4] < numbers[8] & numbers[4] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The least value inputed was " + numbers[4]);
                    }

                    if (numbers[5] < numbers[0] & numbers[5] < numbers[1] & numbers[5] < numbers[2] & numbers[5] < numbers[3] & numbers[5] < numbers[4] & numbers[5] < numbers[6] & numbers[5] < numbers[7] & numbers[5] < numbers[8] & numbers[5] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The least value inputed was " + numbers[5]);
                    }

                    if (numbers[6] < numbers[0] & numbers[6] < numbers[1] & numbers[6] < numbers[2] & numbers[6] < numbers[3] & numbers[6] < numbers[4] & numbers[6] < numbers[5] & numbers[6] < numbers[7] & numbers[6] < numbers[8] & numbers[6] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                             The least value inputed was " + numbers[6]);
                    }

                    if (numbers[7] < numbers[0] & numbers[7] < numbers[1] & numbers[7] < numbers[2] & numbers[7] < numbers[3] & numbers[7] < numbers[4] & numbers[7] < numbers[5] & numbers[7] < numbers[6] & numbers[7] < numbers[8] & numbers[7] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                              The least value inputed was " + numbers[7]);
                    }

                    if (numbers[8] < numbers[0] & numbers[8] < numbers[1] & numbers[8] < numbers[2] & numbers[8] < numbers[3] & numbers[8] < numbers[4] & numbers[8] < numbers[5] & numbers[8] < numbers[6] & numbers[8] < numbers[7] & numbers[8] < numbers[9])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                              The least value inputed was " + numbers[8]);
                    }

                    if (numbers[9] < numbers[0] & numbers[9] < numbers[1] & numbers[9] < numbers[2] & numbers[9] < numbers[3] & numbers[9] < numbers[4] & numbers[9] < numbers[5] & numbers[9] < numbers[6] & numbers[9] < numbers[7] & numbers[9] < numbers[8])
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                                                              The least value inputed was " + numbers[9]);
                    }

                }


                if (Selection1 == 5)
                {
                    Console.ReadLine();

                    Console.WriteLine("                                                                       Do you want to change the array with '*' or '&'?");
                    string selection = Convert.ToString(Console.ReadLine());

                    if (selection == "*")
                    {

                        for (int i = 0; i <= 9; i++)
                        {
                            numbers[i] = Convert.ToChar(arrray[i]);
                        }
                        for (int i = 0; i <= 9; i++)
                        {
                            arrray[i] = '*';
                            Console.WriteLine(arrray[i]);
                        }
                    }

                    if (selection == "&")
                    {

                        for (int i = 0; i <= 9; i++)
                        {
                            numbers[i] = Convert.ToChar(arrray1[i]);
                        }
                        for (int i = 0; i <= 9; i++)
                        {
                            arrray1[i] = '&';
                            Console.WriteLine(arrray1[i]);
                        }
                    }

                    Console.ReadLine();
                }

                if (Selection1 == 6)
                {
                    Console.WriteLine("                                                                                 Have a great day!");
                    Console.ReadLine();
                    break;
                }
            }
        }
       
    }
    
}
