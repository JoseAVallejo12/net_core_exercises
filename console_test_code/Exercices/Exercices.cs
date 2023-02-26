using System;
using console_test_code.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace console_test_code.Exercices
{
    public class FlowControl
    {

        /// <summary>
        /// Write a program and ask the user to enter a number.
        /// The number should be between 1 to 10. If the user enters a valid number,
        /// display "Valid" on the console. Otherwise, display "Invalid".
        /// </summary>
        public static void ExampleOne()
        {
            string message = "Type number in range 1 - 10";
            try
            {
                if (IsValidNumber(Utility.GetUserInput(message)))
                {
                    PrintMessage("Valid");
                }
                else
                {
                    PrintMessage("Invalid");
                }
            }
            catch (FormatException e)
            {
                PrintMessage(e.Message);
            }

        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public static void ExampleTwo()
        {
            try
            {
                int valueOne = Utility.GetUserInput("Type first number: ");
                int valuetwo = Utility.GetUserInput("Type second number: ");

                PrintMessage($"Higther value tiping is: {GetHigtherValue(valueOne, valuetwo)}");
            }
            catch (FormatException e)
            {
                PrintMessage(e.Message);

            }
        }

        /// <summary>
        ///  Write a program and ask the user to enter the width and height of an image.
        ///  Then tell if the image is landscape or portrait.
        /// </summary>
        public static void ExampleThreeth()
        {
            try
            {
                int hight = Utility.GetUserInput("type image hight: ");
                int width = Utility.GetUserInput("Type image width: ");
                if (IsImagePortrait(width, hight))
                {
                    PrintMessage("The image is portrait");
                }
                else
                {
                    PrintMessage("The image is landscape.");

                }

            }
            catch (FormatException e)
            {
                PrintMessage(e.Message);
            }
        }

        /// <summary>
        /// Your job is to write a program for a speed camera.
        /// For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        /// Write a program that asks the user to enter the speed limit. Once set,
        /// the program asks for the speed of a car.
        /// If the user enters a value less than the speed limit, program should display Ok on the console.
        /// If the value is above the speed limit, the program should calculate the number of demerit points.
        /// For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        /// If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        public static void ExampleFourth()
        {
            int maxSpeedAllowed = 30;
            int maxDemeritPoints = 12;
            double demeritPointByOverSpeed = 5.0;
            string message = "Ok";
            try
            {
                int speed = Utility.GetUserInput("Typing car speed: ");
                if (IsNotValidSpeed(maxSpeedAllowed, speed))
                {
                    var overSpeed = (double)speed - maxSpeedAllowed;
                    int demeritPoints = (int)Math.Floor(overSpeed / demeritPointByOverSpeed);
                    message = demeritPoints < maxDemeritPoints ? $"{demeritPoints} demerit points" : "License Suspended.";
                }
                PrintMessage(message);

            }
            catch (FormatException e)
            {
                PrintMessage(e.Message);
            }
        }

        private static bool IsNotValidSpeed(int baseSpeed, int speed)
        {
            return baseSpeed < speed;
        }

        private static bool IsValidNumber(int value)
        {
            int minRange = 1;
            int maxRange = 10;

            return value >= minRange && value <= maxRange;
        }

        private static bool IsImagePortrait(int width, int hight)
        {
            return hight > width;
        }

        private static int GetHigtherValue(int valueOne, int valueTwo)
        {
            return valueOne > valueTwo ? valueOne : valueTwo;
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

