/*
Create an application that finds the Sum, Average and total number of items in a List of doubles.
*/


List<double> numbers = new List<double>(){45.5, 9.4, 2.14, 50.37, 32.89, 12.2, 10.6, 6.54};

var sum = numbers.Sum();
var average = numbers.Average();
var count = numbers.Count();                             

Console.WriteLine($"Sum = {sum}   Average = {average}   Count = {count}");
