// See https://aka.ms/new-console-template for more information
class Run{
    static void Main(string[] args){
        ExerciseOne.One();
        ExerciseTwo.Two();
        ExerciseThree.Three();
        ExerciseFour.Four();
        ExerciseFive.Five();
        ExerciseNine.Nine();
        ExerciseTen.Ten();
        ExerciseEleven.Eleven();
    }
}

public class ExerciseOne{
    public static void One(){
            Console.WriteLine("Exercise 4");
            Console.WriteLine("------------------");
            Console.WriteLine("Hello C#\n");
    }
}
    
class ExerciseTwo{
    public static void Two(){

            Console.WriteLine("Exercise 5");
            Console.WriteLine("------------------");
            Console.WriteLine("Good Day!\n");
    }
}
class ExerciseThree{
    public static void Three(){

            Console.WriteLine("Exercise 6");
            Console.WriteLine("------------------");
            string firstname = "Kimbi";
            string lastname = "Favour";
            Console.WriteLine(firstname + " " + lastname + "\n");
    }
}
class ExerciseFour{
    public static void Four(){
            Console.WriteLine("Exercise 7");
            Console.WriteLine("------------------");
            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");
    }
}
            //DateTime dt = new DateTime(2022, 10, 30, 17, 27, 12);
            //Console.WriteLine(dt);
            //creating an obect of the DateTime structure and sets the values of the
            //year, month, day, hour, minute and second in that order
            
class ExerciseFive{
    public static void Five(){
            Console.WriteLine("\nExercise 8");
            Console.WriteLine("------------------");
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date and time is " + currentDateTime);
    }
}

class ExerciseNine{
    public static void Nine(){
            Console.WriteLine("\nExercise 9");
            Console.WriteLine("------------------");
            Console.Write("Enter a number to find its square root: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square root of " + value + " = " + Math.Sqrt(value));
    }
}
class ExerciseTen{
    public static void Ten(){
            Console.WriteLine("\nExercise 10");
            Console.WriteLine("------------------");
            for(int i = 2; i<100; i++){
                if(i%2 == 0){
                    Console.WriteLine(i);
                }
                else
                    Console.WriteLine(i*-1);
            }
    }
}
class ExerciseEleven{
    public static void Eleven(){
            Console.WriteLine("\nExercise 11");
            Console.WriteLine("------------------");
            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            age = age+10;
            Console.WriteLine("You will be " + age + "in 10 years.");
    }
}