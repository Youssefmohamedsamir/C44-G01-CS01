using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Q1
            ////1.	Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter Your number :");
            //string num = Console.ReadLine();
            //Console.WriteLine("Your ID national is :" + num);

            //#endregion

            //#region Q2
            ////2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            ////#endregion

            ////string Name = "Youssef";

            ////int number = Convert.ToInt32(Name);

            ////Console.WriteLine("Converted number: " + number);

            ////System.FormatException: 'The input string 'Youssef' was not in a correct format.'
            //#endregion

            //#region Q3

            ////3.	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float num1 = 5.5f;
            //float num2 = 2.2f;
            //Double result = num1 * num2;
            //Console.WriteLine(result);

            //#endregion

            //#region Q4
            ////Write C# program that Extract a substring from a given string.

            //string Name = "Hello Youssef";

            //string cut = Name.Substring(3, 7);

            //Console.WriteLine(cut);

            //#endregion

            //#region Q5
            ////5.	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen



            ////    int X = 9;

            ////    int Y = X;

            ////    X = 2; 

            ////    Console.WriteLine("the Value x : "+ X);//2
            ////    Console.WriteLine("the Value Y : " + Y);//9
            //#endregion

            #region Q6
            // 6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


            int[] arr1 = { 1, 2, 3 };

            int[] arr2 = arr1; 

            arr2[2] = 99; 

            Console.WriteLine(" arr1 => " + arr1[2]); // 99
            Console.WriteLine("arr2 => " + arr2[2]); // 99 

            // beacause array is a referance type in C#

            #endregion

            #region Q7

            //7.	Write C# program that take two string variables and print them as one variable

            Console.WriteLine("Enter Two String To Print It :");

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            string str3 = str1 + " " + str2;

            Console.WriteLine(str3);

            #endregion

            #region Q8
            //8.	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //      Note: The formula for simple interest is Interest = (principal * rate * time) / 100.

            double principal = Convert.ToDouble(Console.ReadLine());

            double rate = Convert.ToDouble(Console.ReadLine());

            double time = Convert.ToDouble(Console.ReadLine());

            double Reasult = (principal * rate * time) / 100;

            Console.WriteLine("The reasault is " + Reasult);


            #endregion

            #region Q9
            //9.	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            //Note: The formula for BMI is BMI = (Weight) / (Height * Height)


            double Height = Convert.ToDouble(Console.ReadLine());

            double weight = Convert.ToDouble(Console.ReadLine());

            double Equation = (weight) / (Height * Height);

            Console.WriteLine("The Equation is " + Equation);


            #endregion

            #region Q10
            //        10.	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
            //        Note:
            //            a.that below 10 degrees is "Just Cold"
            //            b.above 30 degrees is "Just Hot"
            //            c.anything else is "Just Good"


            Console.WriteLine("Enter the temperature : ");
            int.TryParse(Console.ReadLine(), out int temp1);

            if (temp1 == 10)
            {
                Console.WriteLine("Just Gold ");
            }
            else if (temp1 == 30)
            {
                Console.WriteLine("Just Hot");
            }

            else
            {
                Console.WriteLine("Just Good");
            }




            #endregion

            #region Q11
            //            11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //            Ex:
            //            Today’s date : 20 , 11 , 2001
            //            Today's date : 20 / 11 / 2001
            //            Today's date : 20 – 11 – 2001

            Console.Write("Enter the Day: ");
            int.TryParse(Console.ReadLine(), out int day);

            Console.Write("Enter the month: ");
            int.TryParse(Console.ReadLine(), out int month);

            Console.Write("Enter the year: ");
            int.TryParse(Console.ReadLine(), out int year);

            Console.WriteLine($"Today's date : {day} , {month} , {year}");

            Console.WriteLine($"Today's date : {day} / {month} / {year}");

            Console.WriteLine($"Today's date : {day} – {month} – {year}");

            #endregion


            #region Q12

            //12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
               //  Example(1)
               // Input: 12
               // Output: Yes
               // Example(2)
               // Input: 9
               // Output: No




            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out int number);
            if (number % 3 == 0 || number % 4 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion

            #region Q13
              // 13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
             //Example(1)
             //Input: -5
             //Output: negative
             //Example(2)
             //Input: 10
             //Output: positive





            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out int number);

            if (number < 0)
                Console.WriteLine("Nagative");
            else
                Console.WriteLine("Positive");
            #endregion

            #region Q14
//    14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
//     Example(1)
//    Input: 7,8,5
//    Output:
//            max element = 8
//    min element = 5
//—--------------------------------
//    Example(2)
//    Input: 3 6 9
//    Outputs:
//            Max element = 9
//    Min element = 3




           

            int.TryParse(Console.ReadLine(), out int number1);

            

            int.TryParse(Console.ReadLine(), out int number2);

            
            int.TryParse(Console.ReadLine(), out int number3);

            int max = Math.Max(number1, Math.Max(number2, number3));
            int min = Math.Min(number1, Math.Min(number2, number3));

            Console.WriteLine("Max = " + max);
            Console.WriteLine("min = " + min);

            #endregion

            #region Q15

            //-Write a program that allows the user to insert an integer number then check If a number is even or odd.


            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out int number);
            if (number % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            #endregion

            #region Q16
    //        16 - Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
    //Example(1)
    //Input: O
    //Output: vowel
    //Example(2)
    //Input: b
    //Output: Consonant


            Console.WriteLine("Please Enter a Character");
            char Character = char.ToLower(Console.ReadLine()[0]);
            if ("aeiou".IndexOf(Character) > 0)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
            #endregion

            #region Q17
    //        17 - Write a program to input the month number and print the number of days in that month.
    //Example
    //Input: Month Number: 1
    //Output: Days in Month: 31


            Console.WriteLine("Please Enter The Month Number(1-12)");
            int month = int.Parse(Console.ReadLine());
            string reslut;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    reslut = "Days in Month: 31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                
                    reslut = "Days in Month: 30";
                    break;
                case 2:
                    reslut = "Days in Month: 28 ";
                    break;
                default:
                    reslut = "invalid month number";
                    break;
            }
            Console.WriteLine(reslut);
            #endregion




        }
    }
}
