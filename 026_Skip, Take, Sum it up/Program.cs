/*
Change the previous application. Allow the user to input 2 numbers. Use the first number to Skip and the second number to Take.
Now do the Sum, Average and total number of items calculations on that subset of items.
*/

Console.WriteLine("Insert first number");
var num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insert second number");
var num2 = int.Parse(Console.ReadLine());

List<double> numbers = new List<double>(){45.5, 9.4, 2.14, 50.37, 32.89, 12.2, 10.6, 6.54};

var skipTakeNumbers = numbers.Skip(num1).Take(num2);

var sum = skipTakeNumbers.Sum();
var average = skipTakeNumbers.Average();
var count = skipTakeNumbers.Count();                             

Console.WriteLine($"Sum = {sum}   Average = {average}   Count = {count}");

