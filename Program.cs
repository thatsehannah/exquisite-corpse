using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            StarterMode();
        }

        static void StarterMode()
        {
            Console.WriteLine("Do you want to randomly create a creature or create one manually?");
            Console.Write("ENTER 1 for random or 2 manual: ");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                Console.WriteLine("You're about to building your creature...");
                ManuallyCreateACreature();
            }
            else
            {
                Console.WriteLine("Randomly creating your creature...");
                RandomMode();
            }
        }

        static void ManuallyCreateACreature()
        {
            Console.Write("What creature do you want for the head: ");
            string head = Console.ReadLine();
            Console.Write("What creature do you want for the body: ");
            string body = Console.ReadLine();
            Console.Write("What creature do you want for the feet: ");
            string feet = Console.ReadLine();

            BuildACreature(head, body, feet);
        }

        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);

            SwitchCase(headNum, bodyNum, feetNum);
        }

        static void RandomMode()
        {
            Random rando = new Random();
            int head = rando.Next(1, 4);
            int body = rando.Next(1, 4);
            int feet = rando.Next(1, 4);

            SwitchCase(head, body, feet);
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
                default:
                    break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
                default:
                    break;
            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
                default:
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            creature = creature.ToLower();
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
