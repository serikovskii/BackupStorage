using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Hdd : Storage
    {
        public double HddSpeed { get; set; }
        public double HddSpeedForCopy { get; set; }
        public int DiskPartitions { get; set; }
        public double[] SizeDiskPartitions { get; set; }
        File file = new File();
        public double hddMemory;
        public double GetHddMemory()
        {
            return hddMemory;
        }
        public void SetHddMemory(double memory)
        {
            hddMemory = memory;
        }

        public override double CopyForDrive()
        {
            if (MemoryIsFree())
            {
                HddSpeedForCopy = file.SizeFile / HddSpeed;
                SetHddMemory(GetHddMemory() - file.SizeFile);
                return HddSpeedForCopy;
            }
            return GetHddMemory();
        }

        public override bool MemoryIsFree()
        {
            if (GetHddMemory() > file.SizeFile)
            {
                return true;
            }
            else
                return false;
        }
        public override double HowMuchMemoryFree()
        {
            return GetHddMemory();
        }
        public override string Info()
        {
            return $"Название носителя: {NameDrive}, тип: {Model}, \nПамять: {Memory} mb, скорость скачивания: {HddSpeed}mb/s";
        }
        public Hdd(string nameDrive, string model, double memory) : base(nameDrive, model, memory)
        {
            HddSpeed = 60;
            DiskPartitions = 2;
            SetHddMemory(memory);
            //SizeDiskPartitions[1] = memory / DiskPartitions;
            //SizeDiskPartitions[2] = memory / DiskPartitions;
        }
    }
}
