using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyExercise1
{
    class Program
    {   
        static void Main(string[] args)
        {
            string condition;
            do
            {
                Console.WriteLine("Give me 2 numbers"); //ask the user to give two numbers
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Give me a boolean value. Press 1 for true, anything else for false"); //ask the user to give the boolean values
                int flag = Convert.ToInt16(Console.ReadLine());
                bool bln1;
                if (flag != 1)
                {
                    bln1 = false;
                }
                else
                {
                    bln1 = true;
                }
                Console.WriteLine("Give me another boolean value. Press 1 for true, anything else for false");
                flag = Convert.ToInt16(Console.ReadLine());
                bool bln2;
                if (flag != 1)
                {
                    bln2 = false;
                }
                else
                {
                    bln2 = true;
                }

                if (bln1 == false && bln2 == false) //question1
                {
                    int sum = num1 + num2;
                    Console.WriteLine($"The result of addition is {sum}");
                }
                else if (bln1 && bln2) //suestion2
                {
                    Console.WriteLine("Just a message");
                }

                if (bln1 || bln2)//question3
                {
                    int sub = num1 - num2;
                    Console.WriteLine($"The result of substraction is {sub}");
                }

                if (bln1 == false && num1 > 20) //question4
                {
                    int multi = num1 * num2;
                    Console.WriteLine($"The result of multiplication is {multi}");
                }
                else
                {
                    double div = num2 / num1;
                    Console.WriteLine($"The result of division is {div}");
                }
                
                if (bln2 && (num1 + num2) > 44 && (num1 % num2 == 0))//question5
                {
                    Console.WriteLine("Yeah, this just happened!");
                }
                Console.WriteLine("Do you want to continue? Y/N ");
                condition = Convert.ToString(Console.ReadKey());

            } while (condition != "N");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
