int firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    distance = 10000,
    dogSpeed = 5,
    dogDirection = 2,
    time = 0,
    count = 0;


while (distance > 5)
{
    if (dogDirection == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        dogDirection = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        dogDirection = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)* time;
    count+=1;
}
Console.Write($"Dog will make {count} runs!");
