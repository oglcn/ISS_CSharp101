// See https://aka.ms/new-console-template for more information
using OOP_Introduction_2;

Console.WriteLine("Hello, World!");


// Player
// Enemy

// Zombies
// Creeper
// Skeleton

Player player = new Player();
player.Name = "Steve";

Zombie zombie1 = new Zombie();
zombie1.Name = "Zombie 1";

Creeper creeper1 = new Creeper();
creeper1.Name = "Creeper 1";

Skeleton skeleton1 = new Skeleton();
skeleton1.Name = "Skeleton 1";

//List<Enemy> enemies = new List<Enemy>();
//enemies.Add(zombie1);
//enemies.Add(skeleton1);

bool playerIsAlive = true;
while (playerIsAlive)
{
    Console.WriteLine("");
    Console.WriteLine(player.ToString());
    Console.WriteLine(zombie1.ToString());
    Console.WriteLine(creeper1.ToString());
    Console.WriteLine(skeleton1.ToString());

    Console.WriteLine("Which one do you want to attack?\n 1. Zombie\n 2. Creeper\n 3. Skeleton");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == 1)
    {
        // Attack Zombie
        int attackDamage = player.Attack();
        zombie1.TakeDamage(attackDamage, player.Name);

    }
    else if (answer == 2)
    {
        // Attack Creeper
        int attackDamage = player.Attack();
        creeper1.TakeDamage(attackDamage, player.Name);
    }
    else if (answer == 3) 
    {
        // Attack Skeleton
        int attackDamage = player.Attack();
        skeleton1.TakeDamage(attackDamage, player.Name);

    }

    // Mobs attack player
    playerIsAlive = player.TakeDamage(zombie1.Attack(), zombie1.Name);
    playerIsAlive = player.TakeDamage(creeper1.Attack(), creeper1.Name);
    playerIsAlive = player.TakeDamage(skeleton1.Attack(), skeleton1.Name);


}

//Console.WriteLine("Creeper: " + creeper1.ToString());

//Console.WriteLine("Zombie: " + zombie1.ToString());

//bool isAlive = true;
//while (isAlive)
//{
//    Console.WriteLine("");
//    isAlive = creeper1.TakeDamage(zombie1.Attack(), zombie1.Name);

//    Console.WriteLine("Creeper: " + creeper1.ToString());

//    Console.WriteLine("Zombie: " + zombie1.ToString());

    
//}
