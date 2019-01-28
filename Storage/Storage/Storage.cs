using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public abstract class Storage
    {
        public string NameDrive { get; set; }
        public string Model { get; set; }
        public double Memory { get; set; }

        public abstract double CopyForDrive();
        public abstract bool MemoryIsFree();
        public abstract double HowMuchMemoryFree();
        public abstract string Info();

        public Storage(string nameDrive, string model, double memory)
        {
            NameDrive = nameDrive;
            Model = model;
            Memory = memory;
        }
    }
}
