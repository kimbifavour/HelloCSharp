class Run{
    public static void Main(){
        ChapterThree.One();
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

    }
}
