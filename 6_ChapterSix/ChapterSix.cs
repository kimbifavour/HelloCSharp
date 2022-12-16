using System;

class Run{
    public static void Main(){

        // ChapterSix.One();
        Learn.DoWhileFactorial();
    }

}

class Learn{

    public static void DoWhileFactorial(){

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        decimal factorial = 1;

        do{
            factorial *= n;
            n--;

        } while (n>0);
        Console.WriteLine("n! = " + factorial);
    }


    public static void WhileFactorial(){
        n = int.Parse(Console.ReadLine());
        decimal factorial = 1;

        while (true){

            if(n<=1){
                break;
            }
            factorial *= n;
            n--;

        }

        Console.WriteLine("n! = " + factorial);
    }


    public static void ProductInRange(){
         
    }
}

class ChapterSix{

    public static void One(){
        //Prints numbers from one to N
        Console.WriteLine(".........................\nOne: Print numbers one to N");
        Console.Write("Enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        Console.Write(i);
        i = 2;

        while(i<=n){
            Console.Write(", " + i);
            i++;
        }
    }
}