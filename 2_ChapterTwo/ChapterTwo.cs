// See https://aka.ms/new-console-template for more information
class Run{
    public static void Main(){
        Exercises.One();
        Exercises.Two();
        Exercises.Three();
        Exercises.Four();
        Exercises.Five();
        Exercises.Six();
        Exercises.Seven();
        Exercises.Eight();
        Exercises.Nine();
        Exercises.Ten();
        Exercises.Eleven();
        Exercises.Twelve();
        Exercises.Thirteen();
        

    }
}

public class Exercises{
    public static void One(){
        sbyte num1 = 52;
        byte num2 = 130;
        sbyte num3 = -115;
        int num4 = 4825932;
        sbyte num5 = 97;
        short num6 = -10000;
        long num7 = -123456789123456789;
        Console.WriteLine("One\n....................");
        Console.WriteLine("sbyte: {0}, {1}, {2}\nbyte: {3}\nint: {4}\nshort: {5}\nlong: {6}\n", num1, num3, num5, num2, num4, num6, num7);
    }

    public static void Two(){
        decimal num1 = 0.9m;
        double num2 = -5.1d;
        float num3 = 0023.7592F; //also written 2.37592e+1f
        double num4 = 12.345d;
        double num5 = 8923.1234857d;
        Console.WriteLine("Two\n....................");
        Console.WriteLine("Decimal: {0}\nFloat: {1}\nDouble: {2}, {3}, {4}\n", num1, num3, num2, num4, num5);
    }

    public static void Three(){
        Console.WriteLine("Three: Precision\n....................");
        float a = 12;
        double b = 12.01;
        double precision = 0.000001;
        bool equal = Math.Abs(a-b) < precision;
        Console.WriteLine("{0}\n", equal);
    }

    public static void Four(){
        Console.WriteLine("Four: Hexadecimals\n....................");
        int hex_num = 0X100;
        Console.WriteLine("The hexadecimal number 0x100 is " + hex_num + "\n");
    }

    public static void Five(){
        Console.WriteLine("Five: Char\n....................");
        char unicode = '\u0048';
        Console.WriteLine("The character with unicode 72 is {0}", unicode);

    }

    public static void Six(){
        Console.WriteLine("Six: Boolean\n....................");
        string gender = "female";
        bool isMale = gender.ToLower() == "male";
        Console.WriteLine("You must be male: {0} \n", isMale);
    }

    public static void Seven(){
        Console.WriteLine("Seven: Concatenation\n....................");
        string first = "Hello";
        string second = "World";
        //object is the parent of all other types in .NET. It takes values from any other type
        object concatenation = first + " " + second; 
        Console.WriteLine(concatenation + "\n");
    }

    public static void Eight(){
        Console.WriteLine("Eight: Type Conversion\n....................");
        string first = "Hello";
        string second = "World";
        object concatenation = first + " " + second;
        string newString = (String)concatenation; //type conversion from object to string
        Console.WriteLine(newString + "\n");
    }

    public static void Nine(){
        Console.WriteLine("Nine: Quotations\n....................");
        string withQuotes = "The \"use\" of quotations causes difficulties";
        string withoutQuotes = "The use of quotations causes difficulties";
        Console.WriteLine("With Quotes: {0}\nWithout Quotes: {1} \n", withQuotes, withoutQuotes);
    }

    public static void Ten(){
        Console.WriteLine("Ten: Heart\n....................");
        Console.WriteLine("");
        Console.WriteLine("   o     o");
        Console.WriteLine(" o    o    o");
        Console.WriteLine("  o       o");
        Console.WriteLine("   o    o");
        Console.WriteLine("      o\n");
    }

    public static void Eleven(){
        Console.WriteLine("Eleven: Isoceles Triangle\n....................");
        Console.WriteLine("  ©");
        Console.WriteLine(" ©©©");
        Console.WriteLine("©©©©©\n");
    }

    public static void Twelve(){
        Console.WriteLine("Twelve: Employee Information\n....................");
        string firstName = "Seige";
        string lastName = "Way";
        char gender = 'f';
        int employeeNum = 27569991;
        Console.WriteLine("First name: {0}\nLast Name: {1}\nGender: {2}\nEmployee Number: {3}\n", firstName, lastName, gender, employeeNum); 

    }

    public static void Thirteen(){
        Console.WriteLine("Thirteen: Number Swap\n....................");
        int value1 = 5;
        int value2 = 10;
        int temp;
        Console.WriteLine("Before swap\nValue 1: " + value1 +"\nValue 2 " + value2);
        temp = value1;
        value1 = value2;
        value2 = temp;
        Console.WriteLine("Value 1: " + value1 +"\nValue 2 " + value2);
    }
}

