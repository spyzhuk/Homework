Console.Write("Enter user name: ");
string? username = Console.ReadLine();

if (username.ToLower() == "Victoria")
{
    Console.WriteLine("Wow, it's you, Victoria!");
}
else 
{
    Console.Write($"Hello,{username}!");
}
