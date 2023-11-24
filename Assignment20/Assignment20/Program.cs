using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        public static int CalculateFactorial(int n)
        {
            if (n == 0 ||n == 1) 
                 return 1;
            else
                return n*CalculateFactorial(n-1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Hello World\n2.User Input\n3.Basic Arithmatics\n4.Control Statements\n5.Loops\n6.Arrays\n7.Methods\n8.Exception Handeling");
            Console.WriteLine("enter your choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine("Hello,World!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your name");
                        string name= Console.ReadLine();
                        Console.WriteLine("Hello,"+name+"!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter first number");
                        int n1=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.Modulus");
                        Console.WriteLine("Enter your choice");
                        int choice=int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            int res = n1 + n2;
                            Console.WriteLine("Addition result:"+res);
                        }
                        else if (choice == 2)
                        {
                            int res = n1 - n2;
                            Console.WriteLine("Substraction result:" + res);
                        }
                        else if(choice == 3)
                        {
                            int res = n1 * n2;
                            Console.WriteLine("Multiplication result:" + res);
                        } 
                        else if (choice == 4)
                        {
                           
                           
                            if (n2 == 0)
                            {
                                Console.WriteLine("Division by 0 error!!");
                            }
                            else
                            {
                                int res = n1 / n2;
                                Console.WriteLine("Division result:" + res);
                            }
                           
                        }
                        else if (choice == 5)
                        {
                            int res = n1 % n2;
                            Console.WriteLine("Modulus result:" + res);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter a number");
                        int num = int.Parse(Console.ReadLine());
                        if(num%2 == 0)
                        {
                            Console.WriteLine(num+":is a even number");
                        }
                        else
                        {
                            Console.WriteLine(num+":is a odd number");
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(" for Loop");
                        for(int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    }
                case 6:
                    {
                        int[] arr = new int[5]{ 1, 2, 3, 4, 5 };
                        int sum = 0;
                      

                        for(int i = 0; i < arr.Length; i++)
                        {
                            sum += arr[i];
                        }
                        Console.WriteLine("sum:"+sum);
                        Console.WriteLine("Average:"+(sum/arr.Length));
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Enter number to find its factorial");
                        int num=int.Parse(Console.ReadLine());
                        Console.WriteLine("Factorial of "+num+":"+ CalculateFactorial(num));
                        
                        break;
                    }
                case 8:
                    {
                        try
                        {
                            int age;

                            while (true)
                            {
                                Console.Write("Enter your age: ");
                                string input = Console.ReadLine();

                                if (int.TryParse(input, out age))
                                {
                                    // Valid integer input
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                                }
                            }

                            if (age < 18)
                            {
                                Console.WriteLine("You are a minor.");
                            }
                            else if (age >= 18 && age <= 65)
                            {
                                Console.WriteLine("You are an adult.");
                            }
                            else
                            {
                                Console.WriteLine("You are a senior.");
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Error!!"+ex);
                        }
                        break;
                    }
            }
        }
    }
}
