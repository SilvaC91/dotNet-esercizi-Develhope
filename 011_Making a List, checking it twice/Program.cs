/*
Create a console application. The console application should ask the user 10 times for input. 
This input is added to a list. After the 10th time, the console program will print out the list twice. 
Once from start to finish, the other time in reverse.
*/

Console.WriteLine("Insert 10 numbers");

List<int> numbers = new List<int>();

for(int i=0; i<10; i++){
    numbers.Add(int.Parse(Console.ReadLine()));
}

List<int> reverseNumbers = new List<int>(numbers);
reverseNumbers.Reverse();

Console.WriteLine("List:");
foreach(int number in numbers){
    Console.WriteLine(number);
}

Console.WriteLine("\nReversed list:");
foreach(int number in reverseNumbers){
    Console.WriteLine(number);
}



