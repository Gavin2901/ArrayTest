

using Microsoft.VisualBasic;
using System;


int[] newArray = { 10, 20, 30, 40, 50 }; //first we create an array by declaring the data type and then the array name followed by the data inside


for (int i = 0; i < newArray.Length; i++)
   // The loop initializes a counter variable i to 0, and then checks if i is less than the length of the array (newArray.Length).
   // If the condition is true, the loop executes the code inside the curly braces.

{
    Console.WriteLine(newArray[i]);
}
//we then use a for loop to iterate through each element 
//the loop prints each element to the console using consolewriteline
//Length is a property used to determine the number of elements in the array
//the loop runs from '0' to 'Length-1' which allows it to access each element of the array

Console.WriteLine();


//you can also use foreach to iterate through the elements of the array

foreach (int value in newArray)
{
    Console.WriteLine(value);
}
//this does the same as the previous example but used foreach instead to iterate through the elements
//foreach automatically iterates through each element and assigns its values to the value variable 


Console.WriteLine();

//we will now show how to input data into an array via the console
//we use the Console.ReadLine() method to read user input from the console

int[] myArray = new int[5];  //create a new array that can hold 5 ints

for (int i = 0; i < myArray.Length; i++)   //use a for loop using length to iterate each element
{
    Console.Write("Enter a number: "); //prompt
    string input = Console.ReadLine(); //reads your input and returns it as a string which is stored in the "input" value
    int value = int.Parse(input);  //then the input is converted to an int by calling int.Parse(input) and stores the result in 'value'
    myArray[i] = value; //then the value of 'value' is assigned to the current element of the array (the i-th element of the array)
}

Console.WriteLine("The array contains the following values:");
foreach (int value in myArray) //we use a foreach loop to iterate the elements of the array
{
    Console.WriteLine(value);
}