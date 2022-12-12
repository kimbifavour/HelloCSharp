using System;

class Run{
    public static void Main(){

        ChapterSix.One();
    }

}

class ChapterSix{

    public static void One(){
        //Prints numbers from one to N
        Console.WriteLine(".........................\nOne: Print numbers one to N");
        Console.Write("Enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        int i = 1;

        while(i<=n){
            Console.Write(i);
            Console.Write(", ");
            i++;
        }
    }
}