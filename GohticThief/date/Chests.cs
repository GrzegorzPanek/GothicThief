using System;

namespace GohticThief
{
    internal class Chests
    {
        Random random = new Random();

        private int numberOfKeys;
        private int selected;
        private bool check;
        private int counter;

        private String[] easyChest = new string[5];
        private String[] middleChest = new string[7];
        private String[] hardChest = new string[9];
        private String cipher;

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

        public bool getCheck
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
            numberOfKeys = int.Parse(Console.ReadLine());
            Console.Clear();
            return numberOfKeys;
        }

        public String[] getEasyChest()
        {

            for (int i = 0; i < easyChest.Length; i++)
            {

                int randomNumber = random.Next(20) + 1;
                if (randomNumber >= 1 && randomNumber < 10)
                {
                    cipher = "LEWO";
                }
                else if (randomNumber > 10 && randomNumber <= 20)
                {
                    cipher = "PRAWO";
                }

                easyChest[i] = cipher;
            }

            return easyChest;
        }

        public String[] getMiddleChest()
        {

            for (int i = 0; i < middleChest.Length; i++)
            {
               
                int randomNumber = random.Next(20) + 1;
                if (randomNumber >= 1 && randomNumber < 10)
                {
                    cipher = "LEWO";
                }
                else if (randomNumber > 10 && randomNumber <= 20)
                {
                    cipher = "PRAWO";
                }

                middleChest[i] = cipher;
            }
       
            return middleChest;
        }

        public String[] getHardChest()
        {

            for (int i = 0; i < hardChest.Length; i++)
            {

                int randomNumber = random.Next(20) + 1;
                if (randomNumber >= 1 && randomNumber < 10)
                {
                    cipher = "LEWO";
                }
                else if (randomNumber > 10 && randomNumber <= 20)
                {
                    cipher = "PRAWO";
                }

                hardChest[i] = cipher;
            }

            return hardChest;
        }

        public void printChest(String [] chest)
        {
            Console.WriteLine("");
            for(int i = 0; i < chest.Length; i++)
            {
                Console.WriteLine(chest[i]);
            }
        }

        public int getAward()
        {
            return random.Next(200000);
        }
    }
}
