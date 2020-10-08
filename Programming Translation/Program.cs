using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Translation {
    class Program {
        static void Main(string[] args) {

//            W1Q1();       // Paint Q 
            W1Q2();
        }


        static void W1Q1() {
            /*
             #W1 Q1 Paint litres needed
            import pdb
            height = float(input("Enter height of room in metres: ")) 
            length = float(input("Enter length of room in metres: ")) 
            width = float(input("Enter width of room in metres: ")) 
            totalArea = height * (length + width) * 2
            unpaintedSpaceArea = float(input("Enter area of unpainted space: "))
            paintableArea = totalArea - unpaintedSpaceArea     
            numCoats = int(input("Enter number of coats of paint required: "))

            # pdb.set_trace()

            totalPaintArea = paintableArea * numCoats
            print ("Total paint area",totalPaintArea)
            litresNeeded = totalPaintArea/11
            litresNeededRounded = round(totalPaintArea/11,2)              # assume 1 litre covers 11 sq m
            print("You will need ",litresNeededRounded," litres")

            input("\nPress Enter to exit program ")
             */

            // Ask for height of room
            Console.Write("Enter the height of the room in meters: ");
            float height = float.Parse(Console.ReadLine());

            // Ask for length of room
            Console.Write("Enter the length of the room in meters: ");
            float length = float.Parse(Console.ReadLine());

            // Ask for width of room
            Console.Write("Enter the width of the room in meters: ");
            float width = float.Parse(Console.ReadLine());

            // Area
            float totalArea = height * (length + width) * 2;

            // Ask for unpainted space of room
            Console.Write("Enter area of unpainted space: ");
            float unpaintedSpaceArea = float.Parse(Console.ReadLine());

            // Find paintable area
            float paintableArea = totalArea - unpaintedSpaceArea;

            // Ask for unpainted space of room
            Console.Write("Enter number of coats of paint required: ");
            int numCoats = int.Parse(Console.ReadLine());

            // Find total paint area
            float totalPaintArea = paintableArea * numCoats;
            Console.WriteLine("Total paint area: " + totalPaintArea);

            // Find and round litres needed
            float litresNeeded = totalPaintArea / 11;
            float litresNeededRounded = (float)Math.Round(litresNeeded, 2);

            // Output how many litres are needed to 2 decimal places
            Console.WriteLine("You will need " + litresNeededRounded + " litres");

        }

        static void W1Q2() {
            /*
             #OCR W1 Q2 Car mileage per gallon

            litresPerGallon = 4.546
            previousCarMileage = float(input("Enter previous mileometer reading: "))
            currentCarMileage = float(input("Enter current mileometer reading: "))
            litresToFillTank = float(input("Enter litres needed to fill tank: "))
            totalMiles = currentCarMileage - previousCarMileage
            gallonsToFillTank = litresToFillTank / litresPerGallon
            mileage = totalMiles /gallonsToFillTank
            mileage = int(mileage)
            print("Miles per gallon :", mileage)

            input("\nPress Enter to exit program ")
             */

            // Vars
            double litresPerGallon = 4.546;

            // Ask and retrieve previous mileometer reading from user
            Console.Write("Enter previous mileometer reading: ");
            double previousCarMileage = double.Parse(Console.ReadLine());


            // Ask and retrieve current mileometer reading from user
            Console.Write("Enter current mileometer reading: ");
            double currentCarMileage = double.Parse(Console.ReadLine());

            // How much litres are needed to fill tank
            Console.Write("Enter litres needed to fill tank: ");
            double litresToFillTank = double.Parse(Console.ReadLine());

            // Work out totals
            double totalMiles = currentCarMileage - previousCarMileage;
            double gallonsToFillTank = litresToFillTank / litresPerGallon;
            double mileage = totalMiles / gallonsToFillTank;
            
            // Round result
            double mileageRounded = Math.Round(mileage, 0);
            
            // Output
            Console.WriteLine("Miles per gallon: " + mileageRounded);
            

        }
    }

    
}
