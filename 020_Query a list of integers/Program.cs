/*
Create a console application that filters a list of integers.
It should only select uneven numbers from a list of 1000 random integers. Use LINQ's query syntax to solve this exercise.
*/

Random random = new Random();
IEnumerable<int> range = Enumerable.Range(0, 1000)
                      .Select(i => random.Next(0, 501));

List<int> numbers = new List<int>(range);

foreach(int number in numbers.Where(i => i%2 != 0)){
    Console.WriteLine(number);
}