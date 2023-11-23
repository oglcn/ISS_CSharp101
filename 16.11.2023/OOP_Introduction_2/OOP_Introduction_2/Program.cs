// See https://aka.ms/new-console-template for more information
using OOP_Introduction_2;

Console.WriteLine("Hello, World!");


// Player
// Enemy

// Zombies
// Creeper
// Skeleton

Zombie zombie1 = new Zombie();
zombie1.Name = "Köylü zombi";

Creeper creeper1 = new Creeper();

Console.WriteLine("Creeper: " + creeper1.ToString());

Console.WriteLine("Zombie: " + zombie1.ToString());

bool isAlive = true;
while (isAlive)
{
    Console.WriteLine("");
    isAlive = creeper1.TakeDamage(zombie1.Attack(), zombie1.Name);

    Console.WriteLine("Creeper: " + creeper1.ToString());

    Console.WriteLine("Zombie: " + zombie1.ToString());

    
}
