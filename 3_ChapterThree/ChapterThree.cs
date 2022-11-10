class Run{
    public static void Main(){
        ChapterThree.One();
        ChapterThree.Two();
        ChapterThree.Three();
    }
}

public class ChapterThree{
     public static void One(){
        Console.WriteLine("One: Even or Odd\n....................");
        //Even numbers are divisible by 2 while odd numbers leave a remaineder when divided by two
        int a = 13;
        Console.WriteLine(a%2 == 0 ? "{0} is even" : "{0} is odd", a);
    }

    public static void Two(){
        Console.WriteLine("\nTwo: Divisible by 5 and 7? \n....................");
        int a = 35;
        Console.WriteLine(a%5 == 0 && a%7 == 0 ? "{0} is divisible by both 5 and 7" : "{0} is not divisible by both 5 and 7", a);
    }

    public static void Three(){
        Console.WriteLine("\nThree: Is it's third digit 7? \n....................");
        int number = 25;
        if(number/100 == 0){
            Console.WriteLine("Number has to be three digits or more");
        }
        else{
             int newnum = number/100;
            if(newnum%10 == 7)
                Console.WriteLine("The third digit from the right of {0} is 7", number);
            else
                Console.WriteLine("The third digit from the right of {0} is not 7", number);
        }
    }
}
