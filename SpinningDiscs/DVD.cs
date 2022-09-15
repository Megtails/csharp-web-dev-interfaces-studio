using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, ISpin
    {
        // TODO: Implement your custom interface.
        public void Spin()
        {
            isSpinning = true;
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name, int capacity, List<string> contents, string dataType) : base(name, capacity, contents, dataType)
        {
        }

        public void StoreData(string baseData)
        {
            Contents.Add(baseData);
            Capacity--;
        }

        public void ReadData()
        {
            Console.WriteLine("Content Extracted");
        }

        public void ReportData()
        {
            foreach (string j in Contents)
            {
                Console.WriteLine($"{j}");
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
