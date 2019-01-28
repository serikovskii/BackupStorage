using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Flash : Storage
    {
        public double FlashSpeed { get; set; }
        public double FlashSpeedForCopy { get; set; }
        File file = new File();
        public double flashMemory;
        public double GetFlashMemory()
        {
            return flashMemory;
        }
        public void SetFlashMemory(double memory)
        {
            flashMemory = memory;
        }

        public override double CopyForDrive()
        {
            if (MemoryIsFree())
            {
                FlashSpeedForCopy = file.SizeFile / FlashSpeed;
                SetFlashMemory(GetFlashMemory() - file.SizeFile);
                return FlashSpeedForCopy;
            }
            return GetFlashMemory();
        }

        public override bool MemoryIsFree()
        {
            if (GetFlashMemory() > file.SizeFile)
            {
                return true;
            }
            else
                return false;
        }
        public override double HowMuchMemoryFree()
        {
            return GetFlashMemory();
        }
        public override string Info()
        {
            return $"Название носителя: {NameDrive}, тип: {Model}, \nПамять: {Memory} mb, скорость скачивания: {FlashSpeed}mb/s";
        }

        public Flash(string nameDrive, string model, double memory) : base(nameDrive, model, memory)
        {
            FlashSpeed = 500;
            SetFlashMemory(memory);
        }

    }
}
