using System;

namespace GohticThief
{
    internal class Chests
    {
        Random random = new Random();

        private String[] easyChest = new string[5];
        private String[] middleChest = new string[7];
        private String[] hardChest = new string[9];

       
        

        public String[] getEasyChest()
        {
            String cipher = "";
            Random random = new Random();

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
            String cipher = "";
            Random random = new Random();

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
            String cipher = "";
            Random random = new Random();

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
