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

//Reversing an Array
int[] array = {1, 2, 3, 4, 5, 6};
int[] revArray = new int[6];
int i;
int length = 5;

for(i=0; i<6; i++){
    revArray[i] = array[(length-i)];
}
Console.WriteLine("Original Array: \n");
for(i=0; i<6; i++){
    Console.WriteLine(array[i] );
}

Console.WriteLine("Reversed Array");
for(i = 0; i<6; i++){
    Console.WriteLine(revArray[i]);
}