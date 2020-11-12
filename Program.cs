using System;
public class RandomSlot
{
    public static void Main()
    {
        //Setup
        // Opretter vaiabler til en player bank account samt hvad det koster at spille. Samt en loosingModifier som trækker et beløb fra bank account
        int Bet = 10;
        int Credits = 100;
        int losingModifier = -10;

        System.ConsoleKey userinput = Console.ReadKey().Key;
        // De 3 ruller i maskinen opstillet som arrays  
        string[] Rulle1 = { "K", "l", "A", "B", "J", "P" };

        string[] Rulle2 = { "K", "l", "A", "B", "J", "P" };

        string[] Rulle3 = { "K", "l", "A", "B", "J", "p" };

        // Vi laver randoms  
        Random rand1 = new Random();
        Random rand2 = new Random();
        Random rand3 = new Random();
        // Generate a random index less than the size of the array.  
        int gevinst1 = rand1.Next(Rulle1.Length);
        int gevinst2 = rand2.Next(Rulle2.Length);
        int gevinst3 = rand3.Next(Rulle3.Length);
        // Display the result.  
        // Console.WriteLine($"{Rulle1[gevinst1]}");
        //Console.WriteLine($"{Rulle2[gevinst2]}");
        //Console.WriteLine($"{Rulle3[gevinst3]}");

        //Hvis der er gevindst vil disse to variabler ændre værdi. Så kan du se hvor vidt du taber penge eller vinder penge.


     //Udskrift i console

        Console.WriteLine(@"              .-------.");
        Console.WriteLine(@"               |Jackpot|");
        Console.WriteLine(@"   ____________|_______|____________");
        Console.WriteLine(@"  |  __    __    ___  _____   __    |");
        Console.WriteLine(@"  | / _\  / /   /___\/__   \ / _\   |");
        Console.WriteLine(@"  | \ \  / /   //  //  / /\ \\ \  25|");
        Console.WriteLine(@"  | _\ \/ /___/ \_//  / /  \/_\ \ []| __");
        Console.WriteLine(@"  | \__/\____/\___/   \/     \__/ []|(__)");
        Console.WriteLine(@"  |===_______===_______===_______===| ||");
        Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
        Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
        Console.WriteLine($"  ||*|   {Rulle1[gevinst1]}   |*|   {Rulle2[gevinst2]}   |*|   {Rulle3[gevinst3]}   |*|| ||");
        Console.WriteLine(@"  ||*|       |*|       |*|       |*|| ||");
        Console.WriteLine(@"  ||*|_______|*|_______|*|_______|*||_//");
        Console.WriteLine(@"  |===___________________________===|_/");
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




        Console.ReadKey();
    }
}