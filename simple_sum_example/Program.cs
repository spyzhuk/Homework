int numberA = new Random().Next(1,10); // 1 2 3 4 ... 9
Console.WriteLine($"First number:{numberA}");

int numberB = new Random().Next(1,10);
Console.WriteLine($"Second number:{numberB}");

int result = numberA + numberB;
Console.WriteLine($"Sum:{result}");