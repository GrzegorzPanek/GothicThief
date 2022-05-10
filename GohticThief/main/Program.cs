using System;

namespace GohticThief
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nWitamy w grze GothicThief!\n");
            Chests chest = new Chests();
            User user = new User();
            Instruction instruction = new Instruction();

            instruction.printMenu();

            do
            {
                try
                {
                    user.setSelected = int.Parse(Console.ReadLine());

                    if (user.getSelected > 0 && user.getSelected < 5)
                    {
                        switch (user.getSelected)
                        {
                            case 1:
                                instruction.printInstruction();
                                break;

                            case 2:
                                user.keysNumber();
                                instruction.chooseChest();
                                int selected2 = int.Parse(Console.ReadLine());
                                if (selected2 == 1)
                                {
                                    chest.getEasyChest();
                                    chest.printChest(chest.getEasyChest());
                                    Console.WriteLine("");
                                    user.play(chest.getEasyChest(), user.getKeys);


                                }
                                else if (selected2 == 2)
                                {
                                    chest.getMiddleChest();
                                    chest.printChest(chest.getMiddleChest());
                                    Console.WriteLine("");
                                    user.play(chest.getMiddleChest(), user.getKeys);

                                }
                                else if (selected2 == 3)
                                {
                                    chest.getHardChest();
                                    chest.printChest(chest.getHardChest());
                                    Console.WriteLine("");
                                    user.play(chest.getHardChest(), user.getKeys);
                                }

                                break;

                            case 3:
                                Console.WriteLine("Do zobaczenia!");
                                Environment.Exit(0);
                                break;

                            case 4:
                                instruction.printMenu();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Musisz wybrać liczbę od 1 do 4 \n");
                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadzono niepoprawne dane. Wybierz ponownie. ");
                }

            } while (user.getSelected !=0);

        }
    }
}
