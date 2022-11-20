class Run{
    public static void Main(){
        // ChapterThree.One();
        // ChapterThree.Two();
        // ChapterThree.Three();
        //ChapterThree.Four(); //not done
        // ChapterThree.Five();
        // ChapterThree.Six();
        // ChapterThree.Seven();
        // ChapterThree.Eight();
        // ChapterThree.Nine(); //Not done
        // ChapterThree.Ten();
        //ChapterThree.Eleven();
        //ChapterThree.Twelve();
        //ChapterThree.Thirteen(); // Redo with reduced complexity
        //ChapterThree.Fourteen();
        //ChapterThree.Fifteen(); // I don't get it
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
        int number = 25753;
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

    public static void Four(){

    }

    public static void Five(){
        Console.WriteLine("\nFive: Area of a trapezoid \n....................");
        int a = 5;
        int b = 2;
        int c = 6;
        float area = ((a+b)/2)*c;
        Console.WriteLine ("The area of a trapezoid with bases {0} and {1}, and height {2} is = {3}", a, b, c, area);
    }

    public static void Six(){
        Console.WriteLine("\nSix: Perimeter and Area of a Rectangle \n....................");
        Console.Write("Width(cm): ");
        int w = Convert.ToInt32(Console.ReadLine());
        Console.Write("Length(cm): ");
        int l = Convert.ToInt32(Console.ReadLine());
        int area = l*w;
        Console.WriteLine("Area = {0}x{1} = {2}cm", l, w, area);

    }

    public static void Seven(){
        Console.WriteLine("\nSeven: Gravitational Fields \n....................");
        float mass = 12f;
        double gEarth = mass*9.81;
        double gMoon = gEarth*0.17;
        Console.Write("The gavitational field of a {0}kg mass on earth is: {1}\nThe gravitational pull on the moon is 17% that of the earth: {2} ", mass,  gEarth, gMoon);
    }

    public static void Eight(){
        Console.WriteLine("\nEight: Point in a circle \n....................");
        float radius = 5;
        float x = 4f;
        float y = 3f;
        double length = Math.Sqrt((x*x) + (y*y));
        Console.WriteLine(length <= radius ? "The point ({0},{1}) is found in the circle" : "The point ({0},{1}) is not found in the circle", x, y);
    }

    public static void Ten(){
        Console.WriteLine("\nTen:Four digit OPerations \n....................");
        Console.Write("Enter a four digit number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int i;
        String reverse = "";
        String newNum = num.ToString();
        int length = newNum.Length;

        String firstDigit = (num/1000).ToString();
        String lastDigit = (num%10).ToString();
        int LastNewDigit = num/10;
        LastNewDigit = LastNewDigit%100;
        int second = LastNewDigit/10;
        int third = LastNewDigit%10;

        if(length == 4){
            for(i=0; i<4; i++){
                sum = sum + (num%10);
                reverse = reverse + num%10;
                num = num/10;
            }
            
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("reverse order: " + reverse);
            Console.WriteLine("Last digit in the first position: " + lastDigit + LastNewDigit + firstDigit);
            Console.WriteLine("Second and Third digits exchanged: " + firstDigit + third + second + lastDigit);
        }
        else
            Console.WriteLine("You did not enter a four digit number");
    }

    public static void Eleven(){
        int n = 36;
        int p = 5;
        int i = 1;
        int mask = i << p;
        Console.WriteLine((n&mask) != 0? 1: 0);
    }
    public static void Twelve(){
        Console.WriteLine("\nEleven:Bit on Position P \n...................."); 
        int n = 36;
        int p = 6;
        int i = 1;
        bool ans = true;
        int mask = i << p;
        Console.WriteLine((n&mask) != 0? ans : ans == false);
    }

    public static void Thirteen (){
        int n = 35;
        int p = 6;
        int v = 1;
        int mask = 1 << p;
            if ((n&mask) != v){
                int i = 0;
                int stop = 1;
                for(i = 0; i<stop; i++){
                n = n << 1;
                stop++;
                i++;
                }
                Console.WriteLine("The new value of n is: {0}", n);
            }
            else
            Console.WriteLine("value of n stays the same: " + n);
        }

        public static void Fourteen(){
            Console.WriteLine("\nFourteen :Is a Prime Number? \n...................."); 
            Console.Write("Enter an integer between 1 and 100 inclusive: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>0 && n<101){
                if (n==1 || n==2 || n==3)
                    Console.WriteLine("{0} is a prime number", n);
                else if(n%3 != 0)
                    Console.WriteLine("{0} is a prime number", n);
                else
                    Console.WriteLine("{0} is not a prime number", n);
            }
            else
                Console.WriteLine("{0} is not between 1 and 100 inclusive", n);
        }

        public static void Fifteen(){
            int num = 28;
            Console.WriteLine(num);
            int bit3 = (num >> 3) & 1;
            int bit24 = (num >> 24) & 1;
            num = num & (~(1 << 24)) | (bit3 << 24);
            num = num & (~(1 << 3)) | (bit24 << 3);
            Console.WriteLine(bit3);
            Console.WriteLine(bit24);
            Console.WriteLine(num);
        }

        public static void Sixteen(){
            Console.WriteLine("Not done ");
        }

}

