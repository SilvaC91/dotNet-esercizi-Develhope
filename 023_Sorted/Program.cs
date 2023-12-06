/*
Create another list of 1000 random integers. Can you sort them from low to high? Print out the result.
Bonus points if you can do it in reverse too.
*/

Random random = new Random();
IEnumerable<int> range = Enumerable.Range(0, 10)
                      .Select(i => random.Next(0, 501));

List<int> numbers = new List<int>(range);

var ascendingSortedNumbers = from number in numbers
                             orderby number
                             select number;

var descendingSortedNumbers = from number in numbers
                              orderby number descending
                              select number;

Console.WriteLine("Ascending sorted numbers");
foreach(int number in ascendingSortedNumbers){
    Console.WriteLine(number);
}
Console.WriteLine("\nDescending sorted numbers");
foreach(int number in descendingSortedNumbers){
    Console.WriteLine(number);
}
