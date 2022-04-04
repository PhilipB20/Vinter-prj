using System;

namespace TamamGucchi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro Code
            Console.WriteLine("TamamGucci pet");
            Console.WriteLine("Write a name for your pet");
            string Name = Console.ReadLine();
            Console.Clear();

            Tamagotchi tamamgucci = new Tamagotchi();
            Enemy enemy = new Enemy();
            Random generator = new Random();

            while (tamamgucci.Health > 0)
            {
                //Hud Code
                Console.WriteLine("TamamGucci pet");
                Console.WriteLine("Pet Name: " + Name);
                Console.WriteLine("Health: " + tamamgucci.Health);
                Console.WriteLine("Hunger: " + tamamgucci.Hunger);
                Console.WriteLine("Money: " + tamamgucci.Money);
                Console.ReadLine();

                //Daily Code
                tamamgucci.Boredom = generator.Next(1, 10);
                tamamgucci.Health = tamamgucci.Health - tamamgucci.Boredom;

                Console.WriteLine(Name + " Took daily damage " + tamamgucci.Boredom);

                tamamgucci.HungerTake = generator.Next(1, 5);
                tamamgucci.Hunger = tamamgucci.Hunger - tamamgucci.HungerTake;

                Console.WriteLine(Name + " Lost " + tamamgucci.HungerTake + " in hunger");


                Console.ReadLine();
                tamamgucci.Money = generator.Next(5, 10);
                Console.WriteLine(Name + " got " + tamamgucci.Money + " Money");

                Console.ReadLine();
                Console.Clear();

                //Shop Code
                Console.WriteLine("TamamGucci pet");
                Console.WriteLine("Pet Name: " + Name);
                Console.WriteLine("Health: " + tamamgucci.Health);
                Console.WriteLine("Money: " + tamamgucci.Money);

                Console.WriteLine("Welcome to Tamam Shop");
                Console.WriteLine("Type the thing you want");
                Console.WriteLine("Food: 10 Money");
                Console.WriteLine("Health Boost: 10 Money");
                tamamgucci.Shop = Console.ReadLine();


                if (tamamgucci.Shop == "Food")
                {
                    tamamgucci.Hunger = tamamgucci.Hunger + 2;
                    tamamgucci.Money = tamamgucci.Money - 10;
                }

                else if (tamamgucci.Shop == "Health Boost")
                {
                    tamamgucci.Health = tamamgucci.Health + 10;
                    tamamgucci.Money = tamamgucci.Money - 10;
                }
                else
                {
                    Console.WriteLine("Skipped shopping round");
                }

                //Fight Code
                enemy.EnemyHappen = generator.Next(1, 4);
                Console.ReadLine();
                if (enemy.EnemyHappen == 4)
                {
                    Console.WriteLine("Oh No!, a bandit has appeared!");
                    Console.ReadLine();
                    Console.Clear();

                    while (tamamgucci.Health > 0 && enemy.EnemyHealth > 0)
                    {
                        enemy.EnemyDamage = generator.Next(1, 15);
                        tamamgucci.Health = tamamgucci.Health - enemy.EnemyDamage;
                        Console.WriteLine("The bandit dealt " + enemy.EnemyDamage + " damage to " + tamamgucci.name);

                        Console.WriteLine("Click any button to continue fight");
                        Console.ReadLine();
                        Console.Clear();

                        tamamgucci.Damage = generator.Next(10, 20);
                        enemy.EnemyHealth = enemy.EnemyHealth - tamamgucci.Damage;
                        Console.WriteLine(tamamgucci.name + " dealt " + tamamgucci.Damage + " damage to the bandit");

                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Coast seems clear today :)");
                }

                Console.ReadLine();
                Console.Clear();
            }


        }
    }
}
