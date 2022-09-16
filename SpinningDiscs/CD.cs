using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, ISpin
    {
        // TODO: Implement your custom interface.
        public void Spin()
        {
                isSpinning = true;
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public CD(string name, int capacity, List<string> contents, string dataType) : base(name, capacity, contents, dataType)
        {
        }

        public override void StoreData(List<string> baseData)
        {
            if (isSpinning)
            {
                foreach (string i in baseData)
                {
                    Contents.Add(i);
                    Capacity--;
                }
            }
        }

        public override void WriteData(List<string> newData)
        {
            if (isSpinning)
            {
                foreach (string j in newData)
                {
                    Contents.Add(j);
                    Capacity--;
                }
            }

        }

        public override void ReadData()
        {
            if (isSpinning)
            {
                Console.WriteLine("Content Extracted");
            }
        }

        public override void ReportData()
        {
            if (isSpinning)
            {
                foreach (string j in Contents)
                {
                    Console.WriteLine($"{j}");
                }
            }
        }

        public override void SelectData()
        {
            string userSelection;
            Console.WriteLine("Make a selection.");
            userSelection = Console.ReadLine();

            if (isSpinning)
            {
                if (Contents.Contains(userSelection))
                {
                    UserSelection = userSelection;
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }
        }

        public override void Playback()
        {
            Console.WriteLine($"{UserSelection}");
        }


    }
}
