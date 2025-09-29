int prohp = 100;
int anthp = 100;
int NO = 1;
string proname;
string antname;

Console.WriteLine("Välkommen till det första slagsmålsspelet!");
Console.ReadLine();
Console.WriteLine("Vad ska din protagonist heta?");
proname = Console.ReadLine();

Console.WriteLine("Vad ska din antagonist heta?");
antname = Console.ReadLine();

Console.WriteLine($"{proname} & {antname} ska slåss");
while (prohp > 0 && anthp > 0)

{
    Console.WriteLine($"Runda {NO}");
    NO ++;
    Console.WriteLine($"\x1b[32m{proname}: {prohp}HP \x1b[31m{antname}: {anthp}HP");
    int prodmg = Random.Shared.Next(5, 21);
    prohp -= prodmg;
    int antdmg = Random.Shared.Next(5, 21);
    anthp -= antdmg;
    
    Console.WriteLine($"\x1b[32m{proname} slår {antname} och gör {antdmg} skada!");
    Console.WriteLine($"\x1b[31m{antname} slår {proname} och gör {prodmg} skada!");
    
    Console.ReadLine();
}
if (prohp < 0 && anthp < 0)
{
    Console.WriteLine("\x1b[39mDet blev oavgjort, ingen vann!.");
}
else if (prohp < 0)
{
    Console.WriteLine($"\x1b[32m{proname} vann!");
}

else if (anthp < 0)
{
    Console.WriteLine($"\x1b[31m{antname} vann!");
}

Console.ReadLine();
