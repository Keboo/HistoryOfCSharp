using System.Collections.Generic;
using System.Linq;
using System;

namespace CSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhoneBox> phoneBoxes = new List<PhoneBox>
            {
                new PhoneBox { Number = "123-456-7890" },
                new PhoneBox { Number = "509-123-4567" },
                new PhoneBox { Number = "987-654-3210" },
                new PhoneBox { Number = "509-987-6543" },
                new PhoneBox { Number = "555-555-5555" }
            };

            var filteredNumbers = phoneBoxes
                .Where(pb => pb.GetAreaCode() == "509")
                .Select(pb => pb.Number);

            filteredNumbers
                = from pb in phoneBoxes
                  where pb.GetAreaCode() == "509"
                  select pb.Number;
   
            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }

    class PhoneBox
    {
        public string Number { get; set; }
    }

    static class PhoneBoxExtensions
    {
        public static string GetAreaCode(this PhoneBox phoneBox)
        {
            return phoneBox.Number.Substring(0, 3);
        }
    }
}
