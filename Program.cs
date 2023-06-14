namespace cspractice
{
    internal class Program
    {
        static void Main(string[] args) {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement opertor
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;
            // condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            // condition1 OR condition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);
            Console.ReadKey();
        }
        
            //Console.WriteLine("Please enter a number");
            //string userInput = Console.ReadLine();

            //try
            //{
            //    int userInputASInt = int.Parse(userInput);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format exception, please enter the correct type.");
            //}
            //catch(OverflowException)
            //{
            //    Console.WriteLine("Overflow exception. Number was too long for an int32.");
            //}
            //finally
            //{
            //    Console.WriteLine("You're done pal");
            //}
        //public static void AddTwoNums()
        //{

        //    Console.Write("Enter first input: ");
        //    string input1 = Console.ReadLine();

        //    Console.Write("Enter second input: ");
        //    string input2 = Console.ReadLine();

        //    int sum = int.Parse(input1) + int.Parse(input2); 
        //    Console.WriteLine($"{input1} + {input2} = {sum}" );
        //}

        //constants as fields

        //const double PI = 3.14159265359;
        //const int weeks = 52, months = 12;
        //const string birthday = "02.11.1994", birthday2 = "11.02.1994";
        //Console.WriteLine(birthday);

        //vars
        //var takes type of value 

        //var num = 2;
        //var name = "string";

        //Console.Write("Enter the string here: ");
        //string input = Console.ReadLine();

        //Console.Write("Enter a character to search: ");
        //char searchInput = Console.ReadLine()[0];

        //int searchIndex = input.IndexOf(searchInput);

        //Console.WriteLine(searchIndex);


        //string name;

        //Console.WriteLine("Please enter your name and press enter");
        //name = Console.ReadLine();

        //Console.WriteLine(name.ToUpper());
        //Console.WriteLine(name.ToLower());
        //Console.WriteLine(name.Trim());

        //int age = 31;
        //string name = "Alfonso";

        ////Takes spaces and ignores escape characters
        //Console.WriteLine("Verbatim Strings");
        //Console.WriteLine(@"Lorem

        //as /ndf");


        //Console.WriteLine("String Interlopation");
        //Console.WriteLine($"HelloHello my name is {name}, I am {age} years old ");

        //Console.WriteLine("String Concatenation");
        //Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

        //Console.WriteLine("String Formating");
        //Console.WriteLine("Hello my name is {0}, I am {1} years old", name, age);


        //string stringForFloat = "0.85"; // datatype should be float
        //string stringForInt = "12345"; // datatype should be int

        //float newFloat = float.Parse(stringForFloat);
        //int newInt = Int32.Parse(stringForInt);

        //Console.WriteLine(newFloat);



        //string myString = "15";
        //string myOtherString = "13";
        //int num1 = Int32.Parse(myString);
        //int num2 = Int32.Parse(myOtherString);
        //int resultInt = num1 + num2;

        //string result = myString + myOtherString;
        //Console.WriteLine(resultInt);


        //// implicit conversion
        //int num = 123423;
        //long bigNum = num;

        //float myFloat = 12.234f;
        //double myNewDouble = myFloat;

        //// explicit conversion
        //double myDouble = 12.23;
        //int myInt;

        //// cast double to int
        //myInt = (int)myDouble;

        ////type conversion 
        //string myString = myDouble.ToString();

        //Console.WriteLine(myInt);


        // String methods
        //string myname = "Jeff";

        //string message = "My name is " + myname;

        //string lowerMessage = message.ToLower();

        //Console.WriteLine(lowerMessage);
        //Console.WriteLine(message);
        //Console.ReadLine();


        //int asciiValue = Console.Read();
        //Console.WriteLine("ASCII value is {0}", asciiValue);
        //Console.Read();


        // Primitive Data Types

        // // Integral
        // Choose the smallest type your value fits into

        //sbyte z = 127;
        // sbyte: range from -128 - 127

        //short y = 32767;
        // range from -32,768 - 32,767

        //int x = 2147483647;
        // range from -2,147,483,648 - 2,147,483,647

        //long w = 9223372036854775807;
        // range from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

        // // Floating point
        // Use float for 3D graphics, double for everything (except money calculations) and decimal for financial applications.

        //float v = 0.5f;
        // range from 1.5 × 10^−45 - 3.4 × 10^38, 7-digit precision

        //double u = 0.5;
        // range from 5.0 × 10^−324 - 1.7 × 10^308, 15-digit precision

        //decimal t = 0.5m;
        // range from –7.9 × 10^−28 - 7.9 × 10^28, 28-digit precision
    }
}