using System;

namespace GohticThief
{
    public class Program
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
                    chest.setSelected = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (chest.getSelected > 0 && chest.getSelected < 5)
                    {
                        switch (chest.getSelected)
                        {
                            case 1:
                                Console.Clear();
                                instruction.printInstruction();
                                break;

                            case 2:
                                chest.keysNumber();
                                instruction.chooseChest();
                                int selected2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (selected2 == 1)
                                {
                                    chest.getEasyChest();
                                    Console.WriteLine("");
                                    user.play(chest.getEasyChest(), chest.getKeys);


                                }
                                else if (selected2 == 2)
                                {
                                    chest.getMiddleChest();
                                    Console.WriteLine("");
                                    user.play(chest.getMiddleChest(), chest.getKeys);

                                }
                                else if (selected2 == 3)
                                {
                                    chest.getHardChest();
                                    Console.WriteLine("");
                                    user.play(chest.getHardChest(), chest.getKeys);
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
                    Console.Clear();
                    Console.WriteLine("Wprowadzono niepoprawne dane. Wybierz ponownie. ");
                }

            } while (chest.getSelected !=0);

        }
    }
}
