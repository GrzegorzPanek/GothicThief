using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GohticThief
{
    internal class Instruction
    {
        
        public void printInstruction()
        {
            krecha();
            StringBuilder myStringBuilder = new StringBuilder("                                            INSTRUKCJA GRY\n\n");
            myStringBuilder.Append("Musisz otworzyć skrzynki za pomocą wytrychów.");
            myStringBuilder.Append("Kążda skrzyna ma swój unikalny kod złożony ze slów LEWO PRAWO.\n");
            myStringBuilder.Append("Aby otworzyć skrzynie musisz porpawnie podać wszystkie elementy kodu.\nGdy się pomylisz wytrych się łamie trzeba zacząć od poczatku.\n");
            myStringBuilder.Append("Są 3 poziomy trudności skrzyń. Ilość wytrychów należy ustawić na poczatku gry.\nNależy wybrać która skrzynie chcemy otworzyć.\n");
            myStringBuilder.Append("Nagrodą za otwarcie jest złoto w ilosći zależnej od trudności otwieranej skrzyni.\n");
            Console.WriteLine(myStringBuilder);
            krecha();
        }
       
        public void krecha()
        {
            Console.WriteLine("=================");
        }

        public void printMenu()
        {
            Console.WriteLine("\n[1] Wyświetl instrukcję.");
            Console.WriteLine("[2] Rozpocznij grę.");
            Console.WriteLine("[3] Zamknij grę.");
            Console.WriteLine("[4] Wyświetl menu gry.\n");

        }

        public void chooseChest()
        {
            Console.WriteLine("\nWybierz poziom trudności.\n1 = Łatwy\n2 = Średni\n3 = Trudny\n");
        }
        
    }
}
