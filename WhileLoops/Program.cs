Random rnd = new Random();
int cpuRandom;

bool loopAvtice = true;

while (loopAvtice)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"Cpu had generated {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won");
        //loopAvtice = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops.Try again");
    }
}
Console.WriteLine("Have a nice day");