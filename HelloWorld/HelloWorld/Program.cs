using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter the time you have arrived [8 (8:00)]");
        int hour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please enter the minute");
        int minute = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You entered " + hour + ":" + minute);
        Console.WriteLine("Enter the time you have departed [5 (5:00)]");
        int hour2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please enter the minute");
        int minute2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You entered " + hour2 + ":" + minute2);
        int sum = hour + minute;
        int sum2 = hour2 + minute2;
        int work = hour - hour2;
        int time = 12 - work;
        if (sum > 38)
        {
            Console.WriteLine("You are late by ");
            if (sum2 <= 34)
            {
                Console.WriteLine("isn't a bit early to leave dont ya think?");
                Console.WriteLine("The time you worked for is :");
                Console.WriteLine(time - 1);
            }
            else if (sum2 >= 36)
            {
                Console.WriteLine("would you look at that, overtime thank you for your work ");
                Console.WriteLine("The time you worked for is :");
                Console.WriteLine(time - 1);
            }
            else
            {
                Console.WriteLine("would you look at that, leaving on time, thank you for your work ");
                Console.WriteLine("The time you worked for is :");
                Console.WriteLine(time - 1);
            }
        }
        else if (sum <= 38)
        {
            Console.WriteLine("You are not late ");
            if (sum2 <= 34)
            {
                Console.WriteLine("isn't a bit early to leave dont ya think?");
                Console.WriteLine("The time you worked for is :");
                Console.WriteLine(time - 1);
            }
            else if (sum2 >= 36)
            {
                Console.WriteLine("would you look at that, overtime thank you for your work ");
                Console.WriteLine("The time you worked for is :");
                Console.WriteLine(time - 1);
            }
            else
            {
                Console.WriteLine("would you look at that, leaving on time, thank you for your work ");
                Console.WriteLine("The time you worked for is :");
                Console.WriteLine(time - 1);
            }
        }
    }
}