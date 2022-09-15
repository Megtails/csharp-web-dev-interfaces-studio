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

        public void StoreData(string baseData)
        {
            if(isSpinning)
            {
                Contents.Add(baseData);
                Capacity--;
            }
        }

        public void ReadData()
        {
            if (isSpinning)
            {
                Console.WriteLine("Content Extracted");
            }
        }

        public void ReportData()
        {
            if (isSpinning)
            {
                foreach (string j in Contents)
                {
                    Console.WriteLine($"{j}");
                }
            }
        }

        public void SelectData()
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

        public void Playback()
        {
            Console.WriteLine($"{UserSelection}");
        }


    }
}
