// CLASSES AND ARRAYS

// using system;

// namespace MyVehicle{

//     public class Vehicle(){
//         // Creation of vehicle class

//         string modelName;
//         string modelType;
//         int nDoors;
//         int nWheels;

//     }

//     public class program(){
//         //creating instances of the class and modifying its values
//         static void Main(args[], str){

//         Vehicle myCar = new Vehicle;
//         myCar.modelName = "Honda";
//         Console.WriteLine(myCar.modelName);
//         Vehicle spousalCar = myCar;
//         spousalCar.modelName = "BMW";
//         mycar = void;
//         Console.WriteLine(spousalCar.modelName);
//         }
        
//     }
// }

// Array Declaration creates a reference variable 
// (variable which points to a space in the dynamic memory) that has no value
// int[] myArray;


// // Array Creation. 
// int[] myArray = new int[5];

// // Array Initialization 
// int[] myArray = {1, 2, 3, 4, 5, 6};

// //Reversing an Array
// int[] array = {1, 2, 3, 4, 5, 6};
// int[] revArray = new int[6];
// int i;
// int length = 5;

// for(i=0; i<6; i++){
//     revArray[i] = array[(length-i)];
// }
// Console.WriteLine("Original Array: \n");
// for(i=0; i<6; i++){
//     Console.WriteLine(array[i] );
// }

// Console.WriteLine("Reversed Array");
// for(i = 0; i<6; i++){
//     Console.WriteLine(revArray[i]);
// }


class Symmetry {
    public static void SymmetricArrays(){

    // Is the array symmetric?

    // Get values of the array
    Console.Write("Length of array: ");
    int arrayLength = int.Parse(Console.ReadLine());
    int[] checkArray = new int[arrayLength];

    for (int i=0; i<arrayLength; i++){
        Console.Write("Value #" + (i+1) + ": ");
        checkArray[i] = int.Parse(Console.ReadLine());
    }

    // Check for symmetry
    bool isSymmetric = true;
    int newLength = arrayLength/2;
    for (int i = 0; i<newLength; i++){
        if(checkArray[i] == checkArray[(arrayLength-1)-i]){
            isSymmetric = true;
        }
        else
            isSymmetric = false;
    }

    Console.WriteLine(checkArray);  //Prints the data type of the array
    Console.WriteLine("Array is symmetric? : " + isSymmetric);
    }
}


class MultidimensionalArrays{

    public static void Multidimentionals(){

    // Multi-Dimensional Matrices

    // Declare and initialize a 2x4 matrix (array)
    int[ , ] matrix = {
        {1, 2, 3, 4}, // row 0 values
        {5, 6, 7, 8}, // row 1 values
    };

    //print the matrix to the console
    for(int row = 0; row < matrix.GetLength(0); row ++){
        for(int col = 0; col < matrix.GetLength(1); col++){
            Console.Write(" " + matrix[row, col] );
        }
        
        Console.WriteLine();
    }

    }
}

// Maximal Platform in a Matrix

class MaxPlatform2x2 {
    public static void MaxMatrix(){
        // Declaration and initialization of a 4x6 matrix

        int[ , ] matrix = {
            {0, 2, 4, 0, 5, 9},
            {7, 1, 3, 3, 2, 1},
            {1, 3, 9, 8, 5, 6},
            {4, 6, 7, 9, 1, 0}
        };

        // Find the maximal sum platform of size 2x2

        long maxSum = long.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for(int row = 0; row < matrix.GetLength(0) - 1; row ++){
            for(int col = 0; col < matrix.GetLength(1) - 1; col ++){
                long sum = matrix[row,col] + matrix[row, col+1] + matrix[row+1, col] + matrix[row+1, col+1];

            if(sum > maxSum){
                maxSum = sum;
                maxRow = row;
                maxCol = col;
            }
            }
        }

        // Print the result
        Console.WriteLine("The best Platform is: ");
        Console.WriteLine(" {0} {1} ", matrix[maxRow, maxCol], matrix[maxRow, maxCol+1]);
        Console.WriteLine(" {0} {1} ", matrix[maxRow+1, maxCol], matrix[maxRow+1, maxCol+1]);
        Console.WriteLine("The maximum sum is: {0}", maxSum);

    }
}

Console.WriteLine("Reversed Array");
for(i = 0; i<6; i++){
    Console.WriteLine(revArray[i]);
}




class Symmetry {
    public static void SymmetricArrays(){

    // Is the array symmetric?

    // Get values of the array
    Console.Write("Length of array: ");
    int arrayLength = int.Parse(Console.ReadLine());
    int[] checkArray = new int[arrayLength];

    for (int i=0; i<arrayLength; i++){
        Console.Write("Value #" + (i+1) + ": ");
        checkArray[i] = int.Parse(Console.ReadLine());
    }

    // Check for symmetry
    bool isSymmetric = true;
    int newLength = arrayLength/2;
    for (int i = 0; i<newLength; i++){
        if(checkArray[i] == checkArray[(arrayLength-1)-i]){
            isSymmetric = true;
        }
        else
            isSymmetric = false;
    }

    Console.WriteLine(checkArray);  //Prints the data type of the array
    Console.WriteLine("Array is symmetric? : " + isSymmetric);
    }
}


class MultidimensionalArrays{

    public static void Multidimentionals(){

    // Multi-Dimensional Matrices

    // Declare and initialize a 2x4 matrix (array)
    int[ , ] matrix = {
        {1, 2, 3, 4}, // row 0 values
        {5, 6, 7, 8}, // row 1 values
    };

    //print the matrix to the console
    for(int row = 0; row < matrix.GetLength(0); row ++){
        for(int col = 0; col < matrix.GetLength(1); col++){
            Console.Write(" " + matrix[row, col] );
        }
        
        Console.WriteLine();
    }

    }
}

// Maximal Platform in a Matrix

class MaxPlatform2x2 {
    public static void MaxMatrix(){
        // Declaration and initialization of a 4x6 matrix

        int[ , ] matrix = {
            {0, 2, 4, 0, 5, 9},
            {7, 1, 3, 3, 2, 1},
            {1, 3, 9, 8, 5, 6},
            {4, 6, 7, 9, 1, 0}
        };

        // Find the maximal sum platform of size 2x2

        long maxSum = long.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for(int row = 0; row < matrix.GetLength(0) - 1; row ++){
            for(int col = 0; col < matrix.GetLength(1) - 1; col ++){
                long sum = matrix[row,col] + matrix[row, col+1] + matrix[row+1, col] + matrix[row+1, col+1];

            if(sum > maxSum){
                maxSum = sum;
                maxRow = row;
                maxCol = col;
            }
            }
        }

        // Print the result
        Console.WriteLine("The best Platform is: ");
        Console.WriteLine(" {0} {1} ", matrix[maxRow, maxCol], matrix[maxRow, maxCol+1]);
        Console.WriteLine(" {0} {1} ", matrix[maxRow+1, maxCol], matrix[maxRow+1, maxCol+1]);
        Console.WriteLine("The maximum sum is: {0}", maxSum);

    }
}


//Array of Arrays (Jagged Arrays)


// Chapter 7 Exercises

class Exercises{
    // Printing elements of an array

    public static void One(){
        int[] arrayOfElements = new int[20];

        Console.Write("[");
        for(int i=0; i<20; i++){
            arrayOfElements[i] = i*5;
            Console.Write(" " + arrayOfElements[i]);
        }
        Console.Write(" ]");
    }


    public static void Two(){
        // Equality of two arrays

        Console.Write("Number of elements in Array 1: ");
        int arrayOneLength = int.Parse(Console.ReadLine());

        Console.Write("Number of elements in Array 2: ");
        int arrayTwoLength = int.Parse(Console.ReadLine());

        int[] arrayOne = new int[arrayOneLength];
        int[] arrayTwo = new int[arrayTwoLength];

        if(arrayOneLength != arrayTwoLength){
            Console.WriteLine("The lengths of the array have to be thesame for them to be equal");
        }

        else{ 

            Console.WriteLine("Elements of Array 1");
            for(int i = 0; i<arrayOneLength; i++){
            Console.Write("Array[" + i + "]: ");
            arrayOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elements of Array 2");
            for(int i = 0; i<arrayTwoLength; i++){
            Console.Write("Array[" + i + "]: ");
            arrayTwo[i] = int.Parse(Console.ReadLine());
            } 

            for(int i = 0; i<arrayOneLength; i++){
                if(arrayOne[i] != arrayTwo[i]){
                    Console.WriteLine("Arrays are not equal");
                }

                else{
                    Console.WriteLine("Arrays are equal");
                }
            } 

        }
    }