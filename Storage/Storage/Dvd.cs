using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Dvd : Storage
    {
        public double DvdSpeed { get; set; }
        public string TypeDvdMemory { get; set; } // false - 4,7gb, true - 9gb
        public double DvdSpeedForCopy { get; set; }
        File file = new File();
        public double dvdMemory;
        public double GetDvdMemory()
        {
            return dvdMemory;
        }
        public void SetDvdMemory(double memory)
        {
            dvdMemory = memory;
        }
        public override double CopyForDrive()
        {
            if (MemoryIsFree())
            {
                DvdSpeedForCopy = file.SizeFile / DvdSpeed;
                SetDvdMemory(GetDvdMemory() - file.SizeFile);
                return DvdSpeedForCopy;
            }
            return GetDvdMemory();
        }

        public override bool MemoryIsFree()
        {
            if (GetDvdMemory() > file.SizeFile)
            {
                return true;
            }
            else
                return false;
        }
        public override double HowMuchMemoryFree()
        {
            return GetDvdMemory();
        }
        public override string Info()
        {
            return $"Название носителя: {NameDrive}, тип: {Model}, \nПамять: {Memory} mb, скорость скачивания {DvdSpeed}mb/s";
        }
        public Dvd(string nameDrive, string model, double memory) : base(nameDrive, model, memory)
        {
            DvdSpeed = 42.26;
            SetDvdMemory(memory);
            if (memory > 4700)
            {
                TypeDvdMemory = "Двухсторонний";
            }
            else
                TypeDvdMemory = "Односторонний";
        }
    }
}
