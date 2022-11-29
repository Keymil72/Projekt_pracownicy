using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Message
    {
        public void Display(List<Worker> workers)
        {
            WorkerDetails details = new WorkerDetails();
            String s = " | ";
            Console.WriteLine("Lp.      Imię       |      Nazwisko       |          Wiek            |       Rodzaj pracy     | zł/h    |  zł/mies.");
            foreach (Worker w in workers)
            {
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.Write(w.Id + ". ");
                Console.Write(Text(w.FirstName, 17) + " ");
                Console.Write(Text(w.LastName, 20) + s);
                Console.Write(Text(w.Birthday + "(" + details.getHowOld(details.getWorker(workers, w.Id)) + " lat)", 24) + s);
                Console.Write(Text(w.WorkType, 22) + s);
                Console.Write(Text(w.PerHour + "", 7) + s);
                Console.WriteLine(Text(w.Salary + "", 7));

            }
        }

        public String Text(String text, int lenght)
        {
            int howLong =  text.Length;
            int howManySpaces = lenght-howLong-2;
            String spaces = "";
            for (int i = 0; i < howManySpaces; i++)
            {
                spaces += " ";
            }
            if (howLong < lenght-2)
                return "  " + text + spaces;
            return text;
        }
    }
}
