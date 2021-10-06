using System;

// for (int i = 1; i <= 255; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 1; i < 100; i++)
// {
//     if (i%5 == 0 && i%3 == 0)
//     {
//         Console.WriteLine("nope");
//     }
//     else if(i%5==0)
//     {
//         Console.WriteLine(i);
//     }
//     else if(i%3==0)
//     {
//         Console.WriteLine(i);
//     }
// }

for (int i = 1; i < 100; i++)
{
    if (i%5 == 0 && i%3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(i%5==0)
    {
        Console.WriteLine("Buzz");
    }
    else if(i%3==0)
    {
        Console.WriteLine("Fizz");
    }
}

//turning the previous for loop into a while loop
int num = 1;
while(num<=100)
{
    num=num+1;
    if (num%5 == 0 && num%3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(num%5==0)
    {
        Console.WriteLine("Buzz");
    }
    else if(num%3==0)
    {
        Console.WriteLine("Fizz");
    }
}