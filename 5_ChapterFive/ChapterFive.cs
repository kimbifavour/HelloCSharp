using System;

class Run{
    public static void Main(){
        // ChapterFive.One();
        // ChapterFive.Two();
        // ChapterFive.Three();
        // ChapterFive.Four();
        // ChapterFive.Five();
        // ChapterFive.Six();
        // ChapterFive.Eight();
        ChapterFive.Nine();

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

        if((num1 > 0 && num2<0 && num3<0) || (num1 > 0 && num2 > 0 && num3> 0)){
            Console.WriteLine("Sign of product: +");
        }

        if((num1 > 0 && num2<0 && num3>0) || (num1 > 0 && num2>0 && num3<0)){
            Console.WriteLine("Sign of product: -");
        }

        if((num2 > 0 && num1<0 && num3>0) || (num1<0 && num2<0 && num3<0)){
            Console.WriteLine("Sign of product: -");
        }
        if(num2> 0 && num1 < 0 && num3<0){
            Console.WriteLine("Sign of product: +");
        }

    }


    public static void Three(){
        
        Console.WriteLine("........................\nThree: Biggest of three integers");
        //Using nested if-statements
        Console.WriteLine("Enter three integers");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if( num1 > num2 && num1 > num3){
            Console.WriteLine(num1 + " is the biggest");
        }

        else {

            if(num2 > num1 && num2 > num3){
            Console.WriteLine(num2 + " is the biggest");
            }

            else{

                if (num3 > num1 && num3 > num2){
                    Console.WriteLine(num3 + " is the biggest");
                }

                else{

                    if((num1 > num2 && num1==num3) || (num3 > num2 && num3 == num1)){
                    Console.WriteLine(num1 + " is the biggest");

                    }

                    else {

                        if((num1 > num3 && num1 == num2) || (num2 > num3 && num2 == num1))
                            Console.WriteLine(num1 + " is the biggest");
                    }
                }

            }
        }
    }


    public static void Four(){
        
        Console.WriteLine("........................\nFour: Sorting three integers");
        //Using nested if statements 
        int a = 4;
        int b = 2;
        int c = 3;

        if(a<=b && b<=c){
            Console.WriteLine(c + ", " + b + ", " + a);
        }

        else{

            if(b<=a && a<=c){

                Console.WriteLine(c + ", " + a + ", " + b);
            }

            else{

                if(c<=a && a<=b){
 
                    Console.WriteLine(b + ", " + a + ", " + c); 
                
                }

                else{

                    if(c<=b && b<=a){
                        
                        Console.WriteLine(a + ", " + b + ", " + c); 

                    }

                    else{

                        if(b<=c && c<=a){
                        Console.WriteLine(a + ", " + c + ", " + b); 

                        }

                        else{

                            if(a<=c && c<=b){
                            Console.WriteLine(b + ", " + c + ", " + a); 

                            }
                        }
                    }
                }
            }
        }

    }


    public static void Five(){
        //Prints a digit in words using switch case

        Console.WriteLine("........................\nFive: Digits in words");
        Console.WriteLine("Enter a number from 0 to 9");
        int digit = int.Parse(Console.ReadLine());
        
            if(digit > 9 || digit <0){
                for(int i=3; i>0; i--){
                Console.WriteLine("Number out of range\nYou have {0} more tries", i);
                digit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number from 0 to 9");
            }
        }

        switch(digit){
            case 0:
                Console.WriteLine("Zero");
                break;

            case 1:
                Console.WriteLine("One");
                break;

            case 2: 
                Console.WriteLine("Two");
                break;
            
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
        }

    }


    public static void Six(){
        //Printing the roots of a quadratic equation

        Console.WriteLine("\n.........................\nSix: Quadratic Roots");
        Console.WriteLine("Enter the values of a, b and c: ");
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c: ");
        int c = int.Parse(Console.ReadLine());

        int det = ((b*b) - (4*a*c));
        int x1, x2;

        if(det > 0){
            Console.WriteLine("Real roots");
            x1 = ((-b + (det))/(2*a));
            x2 = ((-b - (det))/(2*a));
            Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2 );
        }

        else if(det < 0){
            Console.WriteLine("No real roots");

        }

        else if(det == 0){
            Console.WriteLine("Equal roots");
            x1 = x2 = -b/(2*a);
            Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2 );


        }
    }


    public static void Seven(){
        //greatest of five numbers

        Console.WriteLine("\n.........................\nSeven: The greatest of five numbers");
    }


    public static void Eight(){

        Console.WriteLine("\n.........................\nEight: User's Choice");
        Console.Write("Enter a choice: \n1 - Integer\n2- Double\n3- String\nChoice: ");
        int choice = int.Parse(Console.ReadLine());


        switch (choice){

            case 1:
                Console.Write("Enter Integer: ");
                int val = int.Parse(Console.ReadLine());
                Console.WriteLine("Value + 1 = " + (val + 1));
                break;

            case 2: 
                Console.Write("Enter Double: ");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("Value + 1 = " + (value + 1));
                break;

            case 3: 
                Console.Write("Enter String: ");
                string str = Console.ReadLine();
                Console.WriteLine("Value + * = " + str + "*");
                break;
                
        }
    }


    public static void Nine(){

        Console.WriteLine("\n.........................\nNine: Sum Equal to Zero");
        int a = 4;
        int b = 22;
        int c = 3;
        int d = -2;
        int e = -12;

    }
}