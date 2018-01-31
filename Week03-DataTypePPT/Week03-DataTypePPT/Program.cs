using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_DataTypePPT
{
    class Program
    {
        /// <summary>
        /// Week03 - Data Type Practice
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("[Week03 - Data Type Practice]");
            
            // 1. int converts to others
            Console.WriteLine("\n1. int converts to others");

            int inputInt = 923;
            Console.WriteLine(" 1.1. Original int Number = " + inputInt);

            double intToDoubleA = Convert.ToDouble(inputInt);
            Console.WriteLine(" 1.2. Convert.ToDouble() Format = " + intToDoubleA);

            double intToDoubleB = (double)inputInt;
            Console.WriteLine(" 1.3. (double) format = " + intToDoubleB);

            char intToCharA = Convert.ToChar(inputInt);
            Console.WriteLine(" 1.4. Convert.ToChar() Format = " + intToCharA + " (The result conver to related char)");

            char intToCharB = (char)inputInt;
            Console.WriteLine(" 1.5. (char) format = " + intToCharB + " (The result conver to related char)");

            string intToStringA = Convert.ToString(inputInt);
            Console.WriteLine(" 1.6. Convert.ToString() format = " + intToStringA);

            //string intToStringB = (string)inputInt;
            Console.WriteLine(" 1.7. (string) format = Error! (Convert.ToString() != (string)inputInt) **");

            Console.WriteLine("\n [Result of int convert]");
            Console.WriteLine(" => int accepts 'double', 'char', 'string'(Convert.ToString() format only)");
            Console.WriteLine(" => int cannot accept 'string' ((string) format)");

            // 2. double converts to others
            Console.WriteLine("\n\n2. double converts to others");

            double inputDouble = 83;
            Console.WriteLine(" 2.1. Original double Number = " + inputDouble);

            int doubleToIntA = Convert.ToInt32(inputDouble);
            Console.WriteLine(" 2.2. Convert.ToInt32() Format = " + doubleToIntA);

            int doubleToIntB = (int)inputDouble;
            Console.WriteLine(" 2.3. (int) Format = " + doubleToIntB);

            // char doubleToCharA = Convert.ToChar(inputDouble);
            Console.WriteLine(" 2.4. Convert.ToChar() Format = Error! (Convert.ToChar() != (char)inputInt) **");

            char doubleToCharB = (char)inputDouble;
            Console.WriteLine(" 2.5. (char) Format = " + doubleToCharB + " (The result conver to related char)");

            string doubleToStringA = Convert.ToString(inputDouble);
            Console.WriteLine(" 2.6. Convert.ToString() Format = " + doubleToStringA);

            //string doubleToStringB = (string)inputDouble;
            Console.WriteLine(" 2.7. (string) format = Error! (Convert.ToString() != (string)inputInt) **");

            Console.WriteLine("\n [Result of double convert]");
            Console.WriteLine(" => double accepts 'int', 'char' ((char) format only), 'string'(Convert.ToString() format only)");
            Console.WriteLine(" => double cannot accept 'string' ((string) format),'char' (Convert.ToChar() format)");


            // 3. char converts to others
            Console.WriteLine("\n\n3. char converts to others");

            char inputChar = 'R';
            Console.WriteLine(" 3.1. Original char Character = " + inputChar + " (Use ' ') ");

            int charToIntA = Convert.ToInt32(inputChar);
            Console.WriteLine(" 3.2. Convert.ToInt32() Format = " + charToIntA + " (The result conver to related int number)");

            int charToIntB = (int)inputChar;
            Console.WriteLine(" 3.3. (int) Format = " + charToIntB + " (The result conver to related int number)");

            //double charToDoubleA = Convert.ToDouble(inputChar);
            Console.WriteLine(" 3.4. Convert.ToDouble() Format = Error! (Convert.ToDouble() != (double)inputInt) **");

            double charToDoubleB = (double)inputChar;
            Console.WriteLine(" 3.5. (double) Format = " + charToDoubleB + " (The result conver to related int number)");

            string charToStringA = Convert.ToString(inputChar);
            Console.WriteLine(" 3.6. Convert.ToString() format = " + charToStringA);

            //string charToStringB = (string)inputChar;
            Console.WriteLine(" 3.7. (string) format = Error! (Convert.ToString() != (string)inputInt)");

            Console.WriteLine("\n [Result of char convert]");
            Console.WriteLine(" => char accepts 'int', 'double' ((double) format only), 'string'(Convert.ToString() format only)");
            Console.WriteLine(" => char cannot accept 'string' ((string) format),'double' (Convert.ToDouble() format)");


            // 4. string converts to others
            Console.WriteLine("\n\n4. string converts to others");

            string inputString = "R";
            Console.WriteLine(" 4.1. Original string Letter = " + inputString);

            //int stringToIntA = Convert.ToInt32(inputString);
            Console.WriteLine(" 4.2. Convert.ToInt32() format = Error! (string cannot convert to int)");

            //int stringToIntB = (int)inputString;
            Console.WriteLine(" 4.3. (int) format = Error! (string cannot convert to int)");

            //double stringToDoubleA = Convert.ToDouble(inputString);
            Console.WriteLine(" 4.4. Convert.ToDouble() format = Error! (string cannot convert to double)");

            //double stringToDoubleB = (double)inputString;
            Console.WriteLine(" 4.5. (double) format = Error! (string cannot convert to double)");

            char stringToCharA = Convert.ToChar(inputString);
            Console.WriteLine(" 4.6. Convert.ToChar() format = " + stringToCharA + " (The result only valid in one character from input. More than one character is not accepted)");

            //char stringToCharB = (char)inputString;
            Console.WriteLine(" 4.7. (char) format = Error! (Convert.ToChar() != (char)inputInt)");

            Console.WriteLine("\n [Result of string convert]");
            Console.WriteLine(" => char accepts 'char' (Convert.ToChar() format only)");
            Console.WriteLine(" => char cannot accept 'char' ((char) format),'int', 'double'");


            Console.WriteLine("\n\n[Data Type Convert]");
            Console.WriteLine(" => int (Valid Convertion): 'double', 'char', 'string'(Convert.ToString() format only)");
            Console.WriteLine(" => int (InValid Convertion): 'string' ((string) format)");

            Console.WriteLine("\n => double (Valid Convertion): 'int', 'char' ((char) format only), 'string'(Convert.ToString() format only)");
            Console.WriteLine(" => double (InValid Convertion): 'string' ((string) format),'char' (Convert.ToChar() format)");

            Console.WriteLine("\n => char (Valid Convertion): 'int', 'double' ((double) format only), 'string'(Convert.ToString() format only)");
            Console.WriteLine(" => char (InValid Convertion): 'string' ((string) format),'double' (Convert.ToDouble() format)");

            Console.WriteLine("\n => string (Valid Convertion): 'char' (Convert.ToChar() format only)");
            Console.WriteLine(" => string (InValid Convertion): 'char' ((char) format),'int', 'double'");

        }
    }
}
