using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<string> Contents { get; set; }
        public string DataType { get; set; }
        public string UserSelection;
        public int DiskSpeed = 0;
        public bool isSpinning = false;

        public BaseDisc(string name, int capacity, List<string> contents, string dataType)
        {
            Name = name;
            Capacity = capacity;
            Contents = contents;
            DataType = dataType;
        }

        public abstract void StoreData(List<string> baseData);

        public abstract void WriteData(List<string> newData);

        public abstract void ReadData();

        public abstract void ReportData();

        public abstract void SelectData();

        public abstract void Playback();

    }
}

