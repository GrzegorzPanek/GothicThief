using System;

namespace GohticThief
{
    internal class User
    {
        private int numberOfKeys;
        private int selected;
        private bool check;
        private int counter;
        
        Chests chests = new Chests();
        Instruction instruction = new Instruction();

        public User()
        {
        }

        public int setCounter
        {
            set { counter = value; }
        }

        public int getCounter   
        { get { return counter; } }

        public bool setCheck
        {
            set { check = value; }
        }

        private bool getCheck
        {
            get { return check; }
        }

        public int setKeys
        {
            set { numberOfKeys = value; }
        }

        public int getKeys
        { get { return numberOfKeys; } }

        public int getSelected
        {
            get { return selected; }
        }

        public int setSelected
        {
            set { selected = value; }
        }



        public int keysNumber()
        {
            Console.WriteLine("\nUstaw liczbe wytrychów.\n");
            setKeys = int.Parse(Console.ReadLine());
            Console.Clear();
            return getKeys;
        }

        public void play(String[] chest, int keys)
        {
            setCounter = 0;
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
                        setCheck = true;
                        Console.WriteLine("OK.\n");
                        setCounter = getCounter + 1;
                    }
                    else
                    {
                        Console.WriteLine("Bład! Tracisz wytrych.\n ");
                        keys--;
                        Console.WriteLine("Liczba pozostałych wytrychów = " + keys + "\n");
                        setCheck = false;
                        setCounter = 0;
                        i = 0;
                    }
                    if(getCounter == chest.Length)
                    {
                        Console.WriteLine("Brawo! Udało Ci sie otworzyć skrzynię!\nZdobywasz " + chests.getAward() + " złota!\n");
                        Console.WriteLine("Zamknij grę lub rozpocznij nową.\n");
                        instruction.printMenu();
                    }

                } while (getCheck == false);
            }
            
        }
    }
}
