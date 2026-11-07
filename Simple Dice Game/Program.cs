int randomPlayerNumber;
int randomCompueterNumber;

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("press any key to roll a dice");

    Console.ReadKey();
    randomPlayerNumber = random.Next(1, 7);
    Console.WriteLine("You rolled a " + randomPlayerNumber);
}

    Console.ReadKey();