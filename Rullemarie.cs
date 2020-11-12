using System;
using System.Threading.Tasks;

namespace Slot2
{
    class Rullemarie
    {
        static void Main(string[] args)
        {

            string[] Rulle1 = { "K", "l", "A", "B", "J", "P" };

            string[] Rulle2 = { "K", "l", "A", "B", "J", "P" };

            string[] Rulle3 = { "K", "l", "A", "B", "J", "p" };

            Random rand1 = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            
            int gevinst1 = rand1.Next(Rulle1.Length);
            int gevinst2 = rand2.Next(Rulle2.Length);
            int gevinst3 = rand3.Next(Rulle3.Length);

            int gevinst4 = rand1.Next(Rulle1.Length);
            int gevinst5 = rand2.Next(Rulle2.Length);
            int gevinst6 = rand3.Next(Rulle3.Length);

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            //Console.WriteLine(@"  |  __    __         _____   __    |");
            //Console.WriteLine(@"  | / _\  / /   //  //__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []| __");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|(__)");
            Console.WriteLine(@"  |===_______===_______===_______===| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            Console.ReadKey();
            System.Threading.Thread.Sleep(25);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []| __");
            Console.WriteLine(@"  |===_______===_______===_______===|(__)");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst1]}   |*|   {Rulle2[gevinst2]}   |*|   {Rulle3[gevinst3]}   |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===| __");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||(__)");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst2]}   |*|   {Rulle2[gevinst1]}   |*|   {Rulle3[gevinst1]}   |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| __");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||(__)");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst1]}   |*|   {Rulle2[gevinst3]}   |*|   {Rulle3[gevinst2]}   |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| __");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst5]}   |*|   {Rulle2[gevinst2]}   |*|   {Rulle3[gevinst6]}   |*||(__)");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst3]}   |*|   {Rulle2[gevinst4]}   |*|   {Rulle3[gevinst5]}   |*|| __");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||(__)");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_||");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst4]}   |*|   {Rulle2[gevinst1]}   |*|   {Rulle3[gevinst4]}   |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*|| __");
            Console.WriteLine(@"  |lc=___________________________===|(__)");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst6]}   |*|   {Rulle2[gevinst2]}   |*|   {Rulle3[gevinst3]}   |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_");
            Console.WriteLine(@"  |lc=___________________________===|_\");
            Console.WriteLine(@"  |  /___________________________\  | ||");
            Console.WriteLine(@"  |   |                         |   |(__)");
            Console.WriteLine(@" _|    \_______________________/    |");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst5]}   |*|   {Rulle2[gevinst4]}   |*|   {Rulle3[gevinst1]}   |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_");
            Console.WriteLine(@"  |lc=___________________________===|_\");
            Console.WriteLine(@"  |  /___________________________\  | \\");
            Console.WriteLine(@"  |   |                         |   | ||");
            Console.WriteLine(@" _|    \_______________________/    |(__)");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst6]}   |*|   {Rulle2[gevinst2]}   |*|   {Rulle3[gevinst3]}   |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_");
            Console.WriteLine(@"  |lc=___________________________===|_\");
            Console.WriteLine(@"  |  /___________________________\  | ||");
            Console.WriteLine(@"  |   |                         |   |(__)");
            Console.WriteLine(@" _|    \_______________________/    |");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst4]}   |*|   {Rulle2[gevinst1]}   |*|   {Rulle3[gevinst4]}   |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*|| __");
            Console.WriteLine(@"  |lc=___________________________===|(__)");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst3]}   |*|   {Rulle2[gevinst4]}   |*|   {Rulle3[gevinst5]}   |*|| __");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||(__)");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_||");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| __");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst5]}   |*|   {Rulle2[gevinst2]}   |*|   {Rulle3[gevinst6]}   |*||(__)");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===|");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| __");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||(__)");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst1]}   |*|   {Rulle2[gevinst3]}   |*|   {Rulle3[gevinst2]}   |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|");
            Console.WriteLine(@"  |===_______===_______===_______===| __");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*||(__)");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst2]}   |*|   {Rulle2[gevinst1]}   |*|   {Rulle3[gevinst1]}   |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(75);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []|");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []| __");
            Console.WriteLine(@"  |===_______===_______===_______===|(__)");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst1]}   |*|   {Rulle2[gevinst2]}   |*|   {Rulle3[gevinst3]}   |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

            System.Threading.Thread.Sleep(75);
            Console.Clear();

            Console.WriteLine(@"               .-------.");
            Console.WriteLine(@"               |Jackpot|");
            Console.WriteLine(@"   ____________|_______|____________");
            Console.WriteLine(@"  |  __    __    ___  _____   __    |");
            Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
            //Console.WriteLine(@"  |  __    __         _____   __    |");
            //Console.WriteLine(@"  | / _\  / /   //  //__   \ / _\   |");
            Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
            Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []| __");
            Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|(__)");
            Console.WriteLine(@"  |===_______===_______===_______===| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine($"  ||*|   {Rulle1[gevinst1]}   |*|   {Rulle2[gevinst2]}   |*|   {Rulle3[gevinst3]}   |*|| ||");
            Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
            Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
            Console.WriteLine(@"  |lc=___________________________===|_/");
            Console.WriteLine(@"  |  /___________________________\  |");
            Console.WriteLine(@"  |   |                         |   |");
            Console.WriteLine(@" _|    \_______________________/    |_");
            Console.WriteLine(@"(_____________________________________)");

        }
    }
}
