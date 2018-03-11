using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrance_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void ASwordOnTheConsole()
        {
            double n = double.Parse(Console.ReadLine());

            int myNumber = (int)Math.Ceiling((n / 2 - 1));
            int myNumber2 = (int)Math.Ceiling(n / 2);
            int myNumber3 = (int)Math.Floor(n / 2);

            string HashTags = new string('#', myNumber);
            string Spaces = new string(' ', myNumber2);
            string Spaces2 = new string(' ', myNumber);
            string HashTags2 = new string('#', (int)n - 1);
            string HashTags3 = new string('#', (int)n - myNumber + 1);

            Console.WriteLine($"{new string('#', (int)n - 1)}/^\\{new string('#', (int)n - 1)}");

            int difference = (int)n - 1 - myNumber;

            for (int i = 0; i < difference; i++)
            {
                Console.WriteLine($"{new string('#', (int)n - 2 - i)}.{new string(' ', 3 + 2 * i)}.{new string('#', (int)n - 2 - i)}");
            }
            if (n % 2 == 0)
            {
                Console.WriteLine($"{HashTags}|{Spaces}S{Spaces}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces}O{Spaces}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces}F{Spaces}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces}T{Spaces}|{HashTags}");
            }
            else
            {
                Console.WriteLine($"{HashTags}|{Spaces2}S{Spaces2}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces2}O{Spaces2}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces2}F{Spaces2}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces2}T{Spaces2}|{HashTags}");
            }

            if (n == 4)
            {
                Console.WriteLine($"{HashTags}|{Spaces} {Spaces}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces}U{Spaces}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces}N{Spaces}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces}I{Spaces}|{HashTags}");
            }
            else if (n == 5)
            {
                Console.WriteLine($"{HashTags}|{Spaces2} {Spaces2}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces2}U{Spaces2}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces2}N{Spaces2}|{HashTags}");
                Console.WriteLine($"{HashTags}|{Spaces2}I{Spaces2}|{HashTags}");
            }
            else
            {
                for (int i = 0; i < n - 4; i++)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"{new string('#', myNumber)}|{new string(' ', myNumber2)} {new string(' ', myNumber2)}|{new string('#', myNumber)}");
                    }
                    else
                    {
                        Console.WriteLine($"{new string('#', myNumber)}|{new string(' ', myNumber)} {new string(' ', myNumber)}|{new string('#', myNumber)}");
                    }
                }
                if (n % 2 == 0)
                {
                    Console.WriteLine($"{HashTags}|{Spaces}U{Spaces}|{HashTags}");
                    Console.WriteLine($"{HashTags}|{Spaces}N{Spaces}|{HashTags}");
                    Console.WriteLine($"{HashTags}|{Spaces}I{Spaces}|{HashTags}");
                }
                else
                {
                    Console.WriteLine($"{HashTags}|{Spaces2}U{Spaces2}|{HashTags}");
                    Console.WriteLine($"{HashTags}|{Spaces2}N{Spaces2}|{HashTags}");
                    Console.WriteLine($"{HashTags}|{Spaces2}I{Spaces2}|{HashTags}");
                }
            }

            Console.WriteLine($"@{new string('=', (int)n * 2 - 1)}@");

            if (n <= 5)
            {
                Console.WriteLine($"{HashTags2}| |{HashTags2}");
                Console.WriteLine($"{HashTags2}| |{HashTags2}");
                Console.WriteLine($"{HashTags2}\\./{HashTags2}");

            }
            else
            {
                if (n % 2 == 0)
                {
                    int myNumber4 = (int)n - 3;
                    for (int i = 0; i < myNumber3; i++)
                    {
                        Console.WriteLine($"{new string('#', (int)n - myNumber)}|{new string(' ', myNumber4)}|{new string('#', (int)n - myNumber)}");
                    }
                    Console.WriteLine($"{new string('#', (int)n - myNumber)}\\{new string('.', myNumber4)}/{new string('#', (int)n - myNumber)}");

                }
                else
                {
                    int myNumber4 = (int)n - 4;
                    for (int i = 0; i < myNumber3; i++)
                    {
                        Console.WriteLine($"{HashTags3}|{new string(' ', myNumber4)}|{HashTags3}");
                    }
                    Console.WriteLine($"{HashTags3}\\{new string('.', myNumber4)}/{HashTags3}");
                }
            }
        }

        private static void PrimePairs()
        {
            int firstCouple = int.Parse(Console.ReadLine());
            int secondCouple = int.Parse(Console.ReadLine());
            int incrementFirstCouple = int.Parse(Console.ReadLine());
            int incrementSecondCouple = int.Parse(Console.ReadLine());
            int firstCoupleMax = firstCouple + incrementFirstCouple;
            int secondCOupleMax = secondCouple + incrementSecondCouple;

            var listFirstCouple = new List<int>();
            var listSecondCouple = new List<int>();


            for (int i = firstCouple; i <= firstCoupleMax; i++)
            {
                if (IsPrime(i))
                {
                    listFirstCouple.Add(i);
                }
            }

            for (int i = secondCouple; i <= secondCOupleMax; i++)
            {
                if (IsPrime(i))
                {
                    listSecondCouple.Add(i);
                }
            }

            foreach (var item in listFirstCouple)
            {
                foreach (var item2 in listSecondCouple)
                {
                    Console.WriteLine($"{item}{item2}");
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static void CSGO()
        {
            const int ak47 = 2700;
            const int awp = 4750;
            const int sg553 = 3500;
            const int grenade = 300;
            const int flash = 250;
            const int glock = 500;
            const int bazooka = 5600;


            int itemsCount = int.Parse(Console.ReadLine());
            int moneyAvailable = int.Parse(Console.ReadLine());
            int cost = 0;
            int difference = 0;

            if (itemsCount >= 8)
            {
                Console.WriteLine("Sorry, you can't carry so many things!");
                return;
            }

            for (int i = 0; i < itemsCount; i++)
            {
                var weaponBuy = Console.ReadLine();
                switch (weaponBuy)
                {
                    case "ak47":
                        {
                            cost += ak47;
                            break;
                        }
                    case "awp":
                        {
                            cost += awp;
                            break;
                        }
                    case "sg553":
                        {
                            cost += sg553;
                            break;
                        }
                    case "grenade":
                        {
                            cost += grenade;
                            break;
                        }
                    case "flash":
                        {
                            cost += flash;
                            break;
                        }
                    case "glock":
                        {
                            cost += glock;
                            break;
                        }
                    case "bazooka":
                        {
                            cost += bazooka;
                            break;
                        }
                    default:
                        break;
                }

            }

            difference = moneyAvailable - cost;

            if (difference >= 0)
            {
                Console.WriteLine($"You bought all {itemsCount} items! Get to work and defeat the bomb!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference)} more money.");
            }
        }

        private static void ArenaTournament()
        {
            int points = int.Parse(Console.ReadLine());
            string arenaName = Console.ReadLine();
            string day = Console.ReadLine();
            string itemType = Console.ReadLine();

            int discount = 0;

            int actualItemsCost = 0;

            int difference;


            // Wednesday/Monday/Nagrand - 5%
            // Tuesday/Thursday/Gurubashi - 10%
            // Friday/Saturday/Dire Maul - 7%

            //Poor - 7000
            //Normal - 14000
            //Legendary - 21000

            switch (arenaName)
            {
                case "Nagrand":
                    {
                        switch (day)
                        {
                            case "Wednesday":
                                {
                                    discount = 5;
                                    break;
                                }
                            case "Monday":
                                {
                                    discount = 5;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case "Gurubashi":
                    {
                        switch (day)
                        {
                            case "Tuesday":
                                {
                                    discount = 10;
                                    break;
                                }
                            case "Thursday":
                                {
                                    discount = 10;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case "Dire Maul":
                    {
                        switch (day)
                        {
                            case "Friday":
                                {
                                    discount = 7;
                                    break;
                                }
                            case "Saturday":
                                {
                                    discount = 7;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                default:
                    break;
            }

            switch (itemType)
            {
                case "Poor":
                    {
                        actualItemsCost = 7000 - ((discount * 7000) / 100);
                        break;
                    }
                case "Normal":
                    {
                        actualItemsCost = 14000 - ((discount * 14000) / 100);
                        break;
                    }
                case "Legendary":
                    {
                        actualItemsCost = 21000 - ((discount * 21000) / 100);
                        break;
                    }
                default:
                    break;
            }

            difference = points - actualItemsCost;

            if (difference >= 0)
            {
                Console.WriteLine($"Items bought: {5}");
                Console.WriteLine($"Arena points left: {difference}");
                Console.WriteLine($"Success!");
            }
            else
            {
                int pricePerItem = actualItemsCost / 5;
                int itemsBought = points / pricePerItem;

                Console.WriteLine($"Items bought: {itemsBought}");
                Console.WriteLine($"Arena points left: {points - (pricePerItem * itemsBought)}");
                Console.WriteLine($"Failure!");
            }
        }

        private static void Sandbox()
        {
            int widthHole = int.Parse(Console.ReadLine());
            int lenghtHole = int.Parse(Console.ReadLine());
            int pictureSize = int.Parse(Console.ReadLine());
            int pictureCount = int.Parse(Console.ReadLine());

            int holeArea = widthHole * lenghtHole;

            int picturesArea = pictureSize * pictureSize * pictureCount;

            int difference = holeArea - picturesArea;

            if (difference >= 0)
            {
                Console.WriteLine($@"The pictures fit in the hole. Hole area is {difference} bigger than pictures area.");
            }
            else
            {
                Console.WriteLine($@"The pictures don't fit in the hole. Picture area is {Math.Abs(difference)} bigger than hole area.");
            }
        }

        private static void Heathstone()
        {
            int relaxTime = int.Parse(Console.ReadLine());
            double pricePerCarts = double.Parse(Console.ReadLine());
            double pricePerAdventure = double.Parse(Console.ReadLine());
            double pricePerCOffee = double.Parse(Console.ReadLine());


            Console.WriteLine($"{3 * pricePerCarts + 2 * pricePerAdventure + pricePerCOffee:f2}");


            Console.WriteLine(relaxTime - 15);
        }
    }
}
