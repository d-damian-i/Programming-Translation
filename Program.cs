using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Programming_Translation {
    class Program {
        static void Main(string[] args) {

            // Basics
            // W1Q1();
            // W1Q2();
            // W1Q4();

            // Selection
            // W2Q3();
            // W2Q4();
            // W2Q5();

            // Iteration
            // H3Q2P();
            // H3Q2F();
            // H3Q3();

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

        static void W1Q4() {

            /*
            #OCR W1 Q4 Number of Books
            numberOfStudents = int(input("Enter number of students: "))
            numberOfBooks = int(input("Enter number of books: "))
            booksPerStudent = numberOfBooks // numberOfStudents
            leftOver = numberOfBooks % numberOfStudents
            print("Books per student: ",booksPerStudent)
            print("Books left over: ", leftOver)

            input("\nPress Enter to exit program ")
             */

            // Asks how many students there are
            Console.Write("Enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            // Asks how many books there are
            Console.Write("Enter number of books: ");
            int numberOfBooks = int.Parse(Console.ReadLine());

            // Finds how many books per student there are and how many are left over
            int booksPerStudent = numberOfBooks / numberOfStudents;
            int leftOver = numberOfBooks % numberOfStudents;

            // Prints results
            Console.WriteLine("Books per student: " + booksPerStudent);
            Console.WriteLine("Books left over: " + leftOver);
        }

        static void W2Q3() {
            /*
             #OCR unit 11 W2 Q3 Online bookstore
            import math
            orderVal = float(input("Enter order value: "))
            postageCharge = 5.0
            print("Do you want to pay £5.00 for next day delivery? ")
            postageCode = input("Enter 1 for next day delivery, 2 for 2nd class post: ")
            if orderVal >=15.0 and postageCode == "2":
                postageCharge = 0
            elif orderVal < 15.0 and postageCode == "2":
                postageCharge = 3.50

            totalCharge = orderVal + postageCharge
            #You can round to 2 decimal places but this will print 25.40 as 25.4
            #totalCharge = round(totalCharge,2)

            #To print currency amounts to two decimal places, you can put "markers" %0.2f
            # into the string to mark the positions where 2 float values are to be inserted
            #Follow the string with % (postageCharge,totalCharge) to show
            #where the two float values are to be inserted
            #see http://learning.londonmet.ac.uk/computing/cc0002n/webpages/chpt3_3.htm
            print ("Postage charge: £%0.2f      Total charge  £%0.2f" % (postageCharge,totalCharge))

            input("\nPress Enter to exit program ")
             */

            // Asks for order amount
            Console.Write("Enter order value: ");
            double orderVal = double.Parse(Console.ReadLine());

            // Postage charge
            double postageCharge = 5.0;

            // Asks which delivery user wants
            Console.WriteLine("Do you want to pay £5.00 for next day delivery?");
            Console.Write("Enter 1 for next day delivery, 2 for 2nd class post: ");
            string postageCode = Console.ReadLine();

            // Checks if user needs to be charge for postage option
            if (orderVal >= 15.0 & postageCode == "2") {
                postageCharge = 0;
            } else if (orderVal < 15.0 & postageCode == "2") {
                postageCharge = 3.50;
            }

            // Find totals and displays them
            double totalCharge = orderVal + postageCharge;
            double totalChargeRounded = (float)Math.Round(totalCharge, 2);

            Console.WriteLine("Postage charge: " + postageCharge);
            Console.WriteLine("Total charge: " + totalChargeRounded);
        }

        static void W2Q4() {

            /*
             #OCR unit 11 W2 Q4 Decision table
            mark = int(input("Enter exam mark %: "))
            attendance = int(input ("Enter attendance %: " ))
            if attendance > 90:
                if mark > 90:    
                    print ("Grade A")
                elif mark >80:    
                    print ("Grade B")
                elif mark >70:   
                    print ("Grade C")
                else:
                    print("fail")
            else:
                print("fail")
    
            input("\nPress Enter to exit program ")
            */

            // Asks for users mark
            Console.Write("Enter exam mark %: ");
            int mark = int.Parse(Console.ReadLine());

            // Asks for users attendance
            Console.Write("Enter attendance %: ");
            int attendance = int.Parse(Console.ReadLine());

            // Checks if user meets criteria for grades
            if (attendance > 90) {
                if (mark > 90) {
                    Console.WriteLine("Grade A");
                } else if (mark > 80) {
                    Console.WriteLine("Grade B");
                } else if (mark > 70) {
                    Console.WriteLine("Grade C");
                } else {
                    Console.WriteLine("Fail");
                }
            } else {
                Console.WriteLine("Fail");
            }
        }

        static void W2Q5() {
            /*
             #OCR unit 11 W2 Q5(a) Home security system

            alarm = "Off"   #initialise alarm
            #To test the program, the user must enter information

            print("Is the alarm triggered? (Y or N): ", end ="")
            trigger = input()
            #allow uppcase or lowercase response
            trigger = trigger.upper()
            if trigger == "Y":
                print("Has movement been detected on ground floor? (Y or N): ",end ="")
                moveGround = input()
                moveGround = moveGround.upper()
                if moveGround == "Y":
                    alarm = "On"
                    print("Alarm = ",alarm, " Intruder alert ground floor!")
        
                print("Has movement been detected on first floor? (Y or N): ",end ="")
                moveFirst = input()
                moveFirst = moveFirst.upper()

                if moveFirst == "Y":
                    alarm = "On"
                    print("Alarm = ",alarm, " Intruder alert first floor!")

            input("\nPress Enter to exit program ")
             */

            // Initialise alarm
            Console.Write("Is the alarm triggered? (Y or N): ");
            string trigger = Console.ReadLine();

            // Makes input uppercase
            trigger = trigger.ToUpper();

            // Checks if movement has been detected on the ground floor
            if (trigger == "Y") {
                Console.Write("Has movement been detected on ground floor ? (Y or N): ");
                string moveGround = Console.ReadLine();
                // Makes input uppercase
                moveGround = moveGround.ToUpper();

                // If movement is detected, the alarm sounds
                if (moveGround == "Y") {
                    string alarm = "On";
                    Console.WriteLine("Alarm = " + alarm + ". Intruder alert ground floor!");

                }

                // Checks if movement has been detected on the first floor
                Console.Write("Has movement been detected on the first floor? (Y or N): ");
                string moveFirst = Console.ReadLine();
                // Makes input uppercase
                moveFirst = moveFirst.ToUpper();

                // If movement is detected, the alarm sounds
                if (moveFirst == "Y") {
                    string alarm = "On";
                    Console.WriteLine("Alarm = " + alarm + "Intruder alert first floor!");
                }
            }
        }

        static void H3Q2P() {
            /*
             #OCR unit 11 H3 Q2 Password
            password = input("Please enter password: ")
            attempts = 1
            while password != "Tues1212" and attempts < 3:
                password = input("Password incorrect - please re-enter: ")
                attempts += 1
            if password == "Tues1212":
                print("password accepted")
            else:
                print("password rejected")
            carryOn = input("Press Enter to continue")
             */

            // Asks for password
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();

            // Sets attempts to 1
            int attempts = 1;

            // Checks if password is correct
            while (password != "Tues1212" && attempts < 3) {
                if (password == "Tues1212") {
                    Console.WriteLine("password accepted");
                } else {
                    Console.WriteLine("password refejcted, " + (3 - attempts) + " attempts remaining");
                    Console.Write("Password incorrect - please re-enter: ");
                    password = Console.ReadLine();
                    attempts++;

                }
            }
        }

        static void H3Q2F() {

            /*
            #OCR unit 11 W3 Q2 fever
            temp = 0
            hour = 0
            total = 0
            fever = 0
            while hour < 7:
            #while hour < 6:
                temp = float(input("Enter temperature: "))
                if temp > 37:
                    fever += 1
                total = total + temp
                hour += 1
                print("Hour", hour,"Total of temperature readings", total," fever: ",fever)
            #endwhile
            average = round(total/hour,1)
            print ("Average temperature:",average)
            print("Incidents of fever:", fever)

            input("\nPress Enter to exit program ")
            */

            // Define variables
            double temp = 0;
            int hour = 0;
            double total = 0;
            int fever = 0;

            // Keep asking for temperature until 7th hour
            while (hour < 7) {
                Console.Write("Enter temperature: ");
                temp = double.Parse(Console.ReadLine());

                // If temp reading is above 37, fever counter increments
                if (temp > 37) {
                    fever += 1;
                }

                total += temp;
                hour += 1;
                Console.WriteLine("Hour " + hour + ", Total temperature of readings: " + total + ", fever: " + fever); 
            }
            double average = Math.Round((total / hour), 1);

            // Results
            Console.WriteLine("Average temperature: " + average);
            Console.WriteLine("Incidents of fever: " + fever);


        }

        static void H3Q3() {
            /*
             #OCR unit 11 W3 Q3 part numbers

            oldModel = 0
            total = 0
            partnum = input("Enter part number: ")
            while partnum != "9999":
                while len(partnum) !=4:
                    partnum = input("Error: enter 4-digit number: ")
                if partnum[3] >= "6" and partnum[3]<="8":
                    oldModel += 1
                total += 1
                partnum = input("Enter part number: ")
            #endwhile
            print("Number of old models:", oldModel)
            print("Total number of parts:", total)

            input("\nPress Enter to exit program ")
             */

            int oldModel = 0;
            int total = 0;

            Console.Write("Enter part number: ");
            string partNum = Console.ReadLine();

            while (partNum != "9999") {

                while (partNum.Length != 4) {
                    Console.Write("Error: enter 4-digit number: ");
                    partNum = Console.ReadLine();
                }
                if (partNum[3] >= 6 && partNum[3] <= 8) {
                    oldModel += 1;
                }
                total += 1;
                Console.Write("Enter a part number: ");
                partNum = Console.ReadLine();
            }
            Console.WriteLine("Number of old models: " + oldModel);
            Console.WriteLine("Total number of parts: " + total);
        }
    }

}
