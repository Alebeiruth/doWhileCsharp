
Random random = new Random();

int lifeHero = 10;
int lifeMonster = 10;

do
{
    int roll = random.Next(1, 11);
    lifeMonster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {lifeMonster} health.");

    if (lifeMonster <= 0)
    {
        Console.WriteLine("Hero Wins!");
        break;
    }

    roll = random.Next(1, 11);
    lifeHero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {lifeHero} health.");

    if (lifeMonster <= 0)
    {
        Console.WriteLine("Monster Wins!");
        break;
    }

} while(lifeHero > 0 && lifeMonster > 0);
Console.WriteLine(lifeHero > lifeMonster ? "Hero wins!" : "Monster wins!");


