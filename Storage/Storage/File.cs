using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class File
    {
        public double SizeFile { get; set; }
        public string NameFile { get; set; }
        public File()
        {
            SizeFile = 750;
            NameFile = "Фильм - Темный рыцарь (2018)";
        }
        public override string ToString()
        {
            return $"{NameFile}, {SizeFile}mb";
        }
    }
}
