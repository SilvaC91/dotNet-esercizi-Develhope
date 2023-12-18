/*
Create a console application that checks whether all elements in a list of integers meet a specific condition (e.g., are even) and whether any elements meet another condition (e.g., are odd) using LINQ.
*/


using System.Globalization;

List<int> numbers = new List<int>(){452, 92, 22, 512, 312, 112, 112, 612};

var allNumbersEven = numbers.All(number => number % 2 == 0);
var anyNumbersOdd = numbers.Any(number => number % 2 != 0);

if(allNumbersEven){
    Console.WriteLine("All elements in the list are even");
}else{
    Console.WriteLine("Not all elements in the list are even");
 }

if(anyNumbersOdd){
    Console.WriteLine("At least one element in the list is odd");
}else{
    Console.WriteLine("No element in the list is odd");

 }




