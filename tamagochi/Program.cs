using tamagochi;
try
{
    var panda = new Panda();
    var who = panda.Whoami();
    Console.WriteLine(who);
    while (true)
    {
        var tosss = panda.Do();
        Thread.Sleep(500);
        Console.WriteLine($"toss was {tosss}");
        if (tosss > 8)
        {
            Console.WriteLine("F = Nakrmit");
            Console.WriteLine("P = Hrát si");
            var action = Console.ReadLine();

            while (action != "exit")
            {
                if (action == "F")
                {
                    panda.Feed();
                    break;
                }
                if (action == "P")
                {
                    panda.Play();
                    break;
                }
            }
        }
        Console.Write("Hlad: ");
        Console.WriteLine(panda.Hunger);
        Console.Write("Znuděnost: ");
        Console.WriteLine(panda.Boredom);
        Console.WriteLine(panda.IsAlive() ? "žije" : "nežije");
        Console.WriteLine("\n");
    }
}
catch (DeadPetEcxeption)
{
    Console.WriteLine("smůla Panda je mrtvá");
}

