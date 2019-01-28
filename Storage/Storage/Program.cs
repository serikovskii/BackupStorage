using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage dvd = new Dvd("DVD-диск", "DVD-RW", 4700);
            Storage flash = new Flash("USB 3.0", "Genius", 2048);
            Storage hdd = new Hdd("HDD-800gb", "Transcend", 819200);
            File file = new File();

            Console.WriteLine(file);
            Console.WriteLine();
            // dvd
            Console.WriteLine((dvd as Dvd).Info());
            Console.WriteLine();
            Console.WriteLine(file.NameFile + " скачается на " + (dvd as Dvd).NameDrive + " за " + Math.Round((dvd as Dvd).CopyForDrive(), 0) + " секунд");
            Console.WriteLine("Свободная память: " + (dvd as Dvd).GetDvdMemory() + "mb из " + (dvd as Dvd).Memory + "mb");
            // flash
            Console.WriteLine();
            Console.WriteLine((flash as Flash).Info());
            Console.WriteLine();
            Console.WriteLine(file.NameFile + " скачается на " + (flash as Flash).NameDrive + " за " + Math.Round((flash as Flash).CopyForDrive(), 0) + " секунд");
            Console.WriteLine("Свободная память: " + (flash as Flash).GetFlashMemory() + "mb из " + (flash as Flash).Memory + "mb");
            // hdd
            Console.WriteLine();
            Console.WriteLine((hdd as Hdd).Info());
            Console.WriteLine();
            Console.WriteLine(file.NameFile + " скачается на " + (hdd as Hdd).NameDrive + " за " + Math.Round((hdd as Hdd).CopyForDrive(), 0) + " секунд");
            Console.WriteLine("Свободная память: " + (hdd as Hdd).GetHddMemory() + "mb из " + (hdd as Hdd).Memory + "mb");
            Console.ReadLine();
        }
    }
}
