using System.Runtime.CompilerServices;
using System.Transactions;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Write a program that allows the user to enter a number then print it.

            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(x);

            #endregion

            #region 2. Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(x);

            //We get unhandled exception System.FormatException

            #endregion

            #region 3. Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float x = 0.1f;

            //float y = 0.2f;

            //float sum = x + y;

            //Console.WriteLine(sum);

            //if the number is within the float limit (7 or 8 digits), it will get the exact sum
            //if the number is more than the limit, it will approximate the sum to the limit

            #endregion

            #region 4. Write C# program that Extract a substring from a given string.

            //string fullText = "Hello, World";

            //string subText = fullText.Substring(7);

            //Console.WriteLine(subText);

            #endregion

            #region 5. Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int x = 5;

            //int y = 10;

            //y = x;

            //x++;

            //Console.WriteLine($"X = {x}, Y = {y}");

            //changing the original variable in a value type variable does not affect the other variable

            #endregion

            #region 6. Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Person p1 = new Person();

            //Person p2 = new Person();

            //p1.x = 5;
            //p1.y = 6;

            //p2.x = 7;
            //p2.y = 8;

            //p2 = p1;

            //p1.x++;
            //p1.y++;

            //Console.WriteLine($"Object 1 : x = {p1.x}, y = {p1.y}");
            //Console.WriteLine($"Object 2 : x = {p2.x}, y = {p2.y}");

            //changing the original variable in a reference type variable changes the other variable

            #endregion

            #region 7. Write C# program that take two string variables and print them as one variable

            //string text1 = Console.ReadLine();
            //string text2 = Console.ReadLine();

            //string fullText = string.Concat(text1, " ", text2);

            //Console.WriteLine(fullText);

            #endregion

            #region 8. Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 

            //Console.Write("Enter the Principal amount : ");
            //double principal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the Rate amount : ");
            //double rate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the Time amount : ");
            //double time = Convert.ToDouble(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine($"Interest = {interest}");

            #endregion

            #region 9. Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 

            //Console.Write("Enter the Weight in kg : ");
            //double weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the Height in meters : ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double BMI = weight / (height * height);

            //Console.WriteLine($"BMI = {BMI}");

            #endregion

            #region 10. Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 

            //Console.Write("Enter the temperature : ");
            //int temp = Convert.ToInt32(Console.ReadLine());

            //string tempState = temp < 10 ? "Too Cold" : temp > 30 ? "Too Hot" : "Just Good";

            //Console.WriteLine(tempState);

            #endregion

            #region 11. Write a program that takes the date from the user and displays it in various formats using string interpolation.

            //Console.Write("Enter day: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter month: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter separator: ");
            //char separator = Convert.ToChar(Console.ReadLine());

            //string date = $"{day}{separator}{month}{separator}{year}";

            //Console.WriteLine($"Today's date is {date}");

            #endregion

            #region 12. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region 13. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}

            #endregion

            #region 14. Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.Write("Enter the first number : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the third number : ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max, min;

            //if (num1 > num2)
            //{
            //    max = num1;
            //    min = num2;
            //}
            //else
            //{
            //    max = num2;
            //    min = num1;
            //}

            //if (num3 > max) 
            //{
            //    max = num3;
            //}
            //if(num3 < min)
            //{
            //    min = num3;
            //}

            //Console.WriteLine($"Maximum = {max}, Minimum = {min}");

            #endregion

            #region 15. Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //string msg;

            //if (num % 2 == 0)
            //{
            //    msg = "The number is Even";
            //}
            //else
            //{
            //    msg = "The number is Odd";
            //}

            //Console.WriteLine(msg);

            #endregion

            #region 16. Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.Write("Enter a letter : ");
            //char letter = Convert.ToChar(Console.ReadLine());

            //if (letter == 'a' || letter == 'b' || letter == 'c' || letter == 'd' || letter == 'e'
            //    || letter == 'A' || letter == 'B' || letter == 'C' || letter == 'D' || letter == 'E')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}

            #endregion

            #region 17. Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter the month number : ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("This month is 31 days");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("This month is 30 days");
            //        break;
            //    case 2:
            //        Console.WriteLine("This month is 28 days");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}

            #endregion
        }
    }
}
