using System;

namespace AssassinsLoopGenerator
{
    class main
    {

        private static string[] players = new string[]{"Wolfram",
                                    "Maui",
                                    "Hei Hei",
                                    "Bird",
                                    "Plumeria",
                                    "Kazoo",
                                    "Atom",
                                    "Danny",
                                    "Wakanda",
                                    "SRK",
                                    "Squid",
                                    "Lobster" };
        private static Random rand = new Random();
        private static bool complete = false;

        static void Main(string[] args)
        {
            string playerlist = "";

            Shuffle(players);
            for (int x = 0; x < players.Length; x++)
            {
                if(x == (players.Length - 1))
                {
                    playerlist += players[x] + ".";
                }
                else
                {
                    playerlist += players[x] + ", ";
                }
            }
            while(!complete)
            {
                Console.Clear();
                string title = @"                                                                                                                                                                                               
                                                                                                                                                                                               
               AAA                 SSSSSSSSSSSSSSS    SSSSSSSSSSSSSSS              AAA                 SSSSSSSSSSSSSSS    SSSSSSSSSSSSSSS IIIIIIIIIINNNNNNNN        NNNNNNNN   SSSSSSSSSSSSSSS 
              A:::A              SS:::::::::::::::S SS:::::::::::::::S            A:::A              SS:::::::::::::::S SS:::::::::::::::SI::::::::IN:::::::N       N::::::N SS:::::::::::::::S
             A:::::A            S:::::SSSSSS::::::SS:::::SSSSSS::::::S           A:::::A            S:::::SSSSSS::::::SS:::::SSSSSS::::::SI::::::::IN::::::::N      N::::::NS:::::SSSSSS::::::S
            A:::::::A           S:::::S     SSSSSSSS:::::S     SSSSSSS          A:::::::A           S:::::S     SSSSSSSS:::::S     SSSSSSSII::::::IIN:::::::::N     N::::::NS:::::S     SSSSSSS
           A:::::::::A          S:::::S            S:::::S                     A:::::::::A          S:::::S            S:::::S              I::::I  N::::::::::N    N::::::NS:::::S            
          A:::::A:::::A         S:::::S            S:::::S                    A:::::A:::::A         S:::::S            S:::::S              I::::I  N:::::::::::N   N::::::NS:::::S            
         A:::::A A:::::A         S::::SSSS          S::::SSSS                A:::::A A:::::A         S::::SSSS          S::::SSSS           I::::I  N:::::::N::::N  N::::::N S::::SSSS         
        A:::::A   A:::::A         SS::::::SSSSS      SS::::::SSSSS          A:::::A   A:::::A         SS::::::SSSSS      SS::::::SSSSS      I::::I  N::::::N N::::N N::::::N  SS::::::SSSSS    
       A:::::A     A:::::A          SSS::::::::SS      SSS::::::::SS       A:::::A     A:::::A          SSS::::::::SS      SSS::::::::SS    I::::I  N::::::N  N::::N:::::::N    SSS::::::::SS  
      A:::::AAAAAAAAA:::::A            SSSSSS::::S        SSSSSS::::S     A:::::AAAAAAAAA:::::A            SSSSSS::::S        SSSSSS::::S   I::::I  N::::::N   N:::::::::::N       SSSSSS::::S 
     A:::::::::::::::::::::A                S:::::S            S:::::S   A:::::::::::::::::::::A                S:::::S            S:::::S  I::::I  N::::::N    N::::::::::N            S:::::S
    A:::::AAAAAAAAAAAAA:::::A               S:::::S            S:::::S  A:::::AAAAAAAAAAAAA:::::A               S:::::S            S:::::S  I::::I  N::::::N     N:::::::::N            S:::::S
   A:::::A             A:::::A  SSSSSSS     S:::::SSSSSSSS     S:::::S A:::::A             A:::::A  SSSSSSS     S:::::SSSSSSSS     S:::::SII::::::IIN::::::N      N::::::::NSSSSSSS     S:::::S
  A:::::A               A:::::A S::::::SSSSSS:::::SS::::::SSSSSS:::::SA:::::A               A:::::A S::::::SSSSSS:::::SS::::::SSSSSS:::::SI::::::::IN::::::N       N:::::::NS::::::SSSSSS:::::S
 A:::::A                 A:::::AS:::::::::::::::SS S:::::::::::::::SSA:::::A                 A:::::AS:::::::::::::::SS S:::::::::::::::SS I::::::::IN::::::N        N::::::NS:::::::::::::::SS 
AAAAAAA                   AAAAAAASSSSSSSSSSSSSSS    SSSSSSSSSSSSSSS AAAAAAA                   AAAAAAASSSSSSSSSSSSSSS    SSSSSSSSSSSSSSS   IIIIIIIIIINNNNNNNN         NNNNNNN SSSSSSSSSSSSSSS   ";
                Console.WriteLine(title);
                Console.WriteLine("\nPlease enter your name to recieve your target. \nValid names: " + playerlist);
                string name = Console.ReadLine();
                FindVictim(players, name);
            }
        }

        static void FindVictim(string[] array, string target)
        {
            if (target == "quit")
            {
                complete = true;
                return;
            }
            else
            {
                for(int x = 0; x < array.Length; x++)
                {
                    if(target == array[x])
                    {
                        string victim;
                        if(x == array.Length - 1)
                        {
                            Console.WriteLine("Looping back.");
                            victim = array[0];
                        }
                        else
                        {
                            victim = array[x+1];
                        }
                        Console.WriteLine("Your target is: " + victim);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        return;
                    }
                }

                Console.WriteLine("Invalid name.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }

        static void Shuffle(string[] sarray)
        {
            int n = sarray.Length;
            while(n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string value = sarray[k];
                sarray[k] = sarray[n];
                sarray[n] = value;
            }
        }
    }
}
