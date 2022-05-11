using System;

namespace GohticThief
{
    internal class User
    {
        Chests chests = new Chests();
        Instruction instruction = new Instruction();

        public User()
        {
        }

       

        public void play(String[] chest, int keys)
        {
            chests.setCounter = 0;
            Console.WriteLine("\n Wpisz LEWO lub PRAWO aby otworzyć skrzynie i odebrać nagrodę.\n");
            for (int i = 0; i < chest.Length; i++)
            {

                do
                {
                    if (keys == 0)
                    {
                        Console.WriteLine("\nZłamałeś wszystkie wytrychy. Gra Skończona! \n");
                        Environment.Exit(0);
                    }
                    String input = Console.ReadLine();
                    Console.Clear();
                    if (String.Equals(input.ToUpper(), chest[i]))
                    {
                        chests.setCheck = true;
                        Console.WriteLine("OK.\n");
                        chests.setCounter = chests.getCounter + 1;
                    }
                    else
                    {
                        Console.WriteLine("Bład! Tracisz wytrych.\n ");
                        keys--;
                        Console.WriteLine("Liczba pozostałych wytrychów = " + keys + "\n");
                        chests.setCheck = false;
                        chests.setCounter = 0;
                        i = 0;
                    }
                    if(chests.getCounter == chest.Length)
                    {
                        Console.WriteLine("Brawo! Udało Ci sie otworzyć skrzynię!\nZdobywasz " + chests.getAward() + " złota!\n");
                        Console.WriteLine("Zamknij grę lub rozpocznij nową.\n");
                        instruction.printMenu();
                    }

                } while (chests.getCheck == false);
            }
            
        }
    }
}
