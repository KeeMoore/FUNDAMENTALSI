// WORKED IN A GROUP WITH LANASHA HALL IN LAB.//

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// loop that prints all values from 1-255
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

// loop that generates 5 random #'s between 10 and 20

Random rand = new Random();
int sum = 0;
for (int i = 0; i < 5; i++)
{
    var result = rand.Next(10, 21);
    sum += result;
    Console.WriteLine(result);
}

// Print the sum of the random values

Console.WriteLine("Sum: " + sum);


// loop that prints all values from 1 to 100 that are divisible by 3 or 5 but NOT BOTH

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

// Loop that prints "Fizz" for mult. of 3, "Buzz" for mult. of 5 and "fizzBuzz" for mult.of both

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

