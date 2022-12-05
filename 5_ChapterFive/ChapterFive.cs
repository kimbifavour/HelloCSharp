using System;

class Run{
    public static void Main(){
        // ChapterFive.One();
        ChapterFive.Two();

    }
}

class ChapterFive{

    public static void One(){
        //an if-statement that swaps the values of two variables if the first is greater than the second
        Console.WriteLine(".........................\nOne: Exchange numbers? ");
        Console.Write("Enter the first number: ");
        int greater = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int lesser = int.Parse(Console.ReadLine());

        if(lesser > greater){
            int temp = greater;
            greater = lesser;
            lesser = temp;
        }
            Console.WriteLine("Greater: {0}\nLesser: {1}", greater, lesser);

    }

    
    public static void Two(){
        Console.WriteLine("........................\nTwo: Sign of the product");
        Console.WriteLine("Enter three integers");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if(num1 > 0 &&(num2<0 || num3<0)){
            Console.WriteLine("Sign of product: -");
        }

        else if ((num1 < 0 && num2<0 && num3<0) || (num1>0 && num2>0 && num3>0)){
            Console.WriteLine("Sign of product: +");
        }
    }


    public static void Three(){
        
        Console.WriteLine("........................\nTwo: Sign of the product");
    }
}