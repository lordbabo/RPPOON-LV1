using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note1;
            note1 = new Note();
            Console.WriteLine(note1.author);
            Console.WriteLine(note1.text);

            Note note2;
            note2 = new Note("Antigona", 1);
            Console.WriteLine(note2.author);
            Console.WriteLine(note2.text);

            TimeNote timenote = new TimeNote();
            Console.WriteLine(timenote.ToString());
            Console.ReadLine();




        }
    }
}
