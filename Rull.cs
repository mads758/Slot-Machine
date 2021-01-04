
            using System;
            using System.Threading.Tasks;

namespace Slot2
    {
        class Rull
        {
            static void Main(string[] args)
            {
            //Setup
            // Opretter vaiabler til en player bank account samt hvad det koster at spille. Samt en loosingModifier som trækker et beløb fra bank account
               int Bet = 10;
               int Credits = 100;
               int losingModifier = -10;
                        
            //Vi opretter Vores Ruller Som Strings
                string[] Rulle1 = { "K", "l", "A", "B", "J", "P" };

                string[] Rulle2 = { "K", "l", "A", "B", "J", "P" };

                string[] Rulle3 = { "K", "l", "A", "B", "J", "p" };

            //Her opretter vi Random Funktion

                Random rand1 = new Random();
                Random rand2 = new Random();
                Random rand3 = new Random();

            //Her får vi random funktionen til at vælge en værdi fra rullerne/Strings
                int gevinst1 = rand1.Next(Rulle1.Length);
                int gevinst2 = rand2.Next(Rulle2.Length);
                int gevinst3 = rand3.Next(Rulle3.Length);

                int gevinst4 = rand1.Next(Rulle1.Length);
                int gevinst5 = rand2.Next(Rulle2.Length);
                int gevinst6 = rand3.Next(Rulle3.Length);
                
            //Her Venter vi på input fra brugeren og spillet går i gang hvis der trykkes en knap.
                Console.ReadKey();
                System.Threading.Thread.Sleep(250);
                Console.Clear();
               
            //Slot maskinen med mulighed for udskift af variabel

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
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     ____________     ____________");
                Console.WriteLine("    |   Price    |   |  Account   |");
                Console.WriteLine($"    |     {Bet}     |   |    {Credits}     |");
                Console.WriteLine("    |____________|   |____________|");
                System.Threading.Thread.Sleep(500);

            //Her sætter vi cursor op til gevinst linjen
                Console.SetCursorPosition(0, Console.CursorTop - 7);
                System.Threading.Thread.Sleep(50);

            //Her laver vi et Do while(true) loop og det den gør er at udskifte variablerne i rullerne ved først at lave nye randoms
            //Og derefter skifte dem ud ved hjælp af SetCursorPosition
            do
            {

                Random rand4 = new Random();
                Random rand5 = new Random();
                Random rand6 = new Random();

                int gevinst10 = rand4.Next(Rulle1.Length);
                int gevinst11 = rand5.Next(Rulle2.Length);
                int gevinst12 = rand6.Next(Rulle3.Length);

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine($"  ||*|   {Rulle1[gevinst10]}   |*|   {Rulle2[gevinst11]}   |*|   {Rulle3[gevinst12]}   |*|| ||");
                System.Threading.Thread.Sleep(125);
            }

            //Vi kan i fremtiden ændre betingelsen for dette loop eks at den skal køre i x antal sekunder
            //eller indtil at brugeren hiver i håndtaget
            while (true);

            //Hele dette dokument skal være en class kaldet "Rull" som vi kan indlæse i vores program fil
            }

            }
        }
