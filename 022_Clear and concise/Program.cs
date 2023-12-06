/*
Change the previous application to use LINQ's method syntax instead.
*/

Random random = new Random();
IEnumerable<int> range = Enumerable.Range(0, 1000)
                      .Select(i => random.Next(0, 501));

List<int> numbers = new List<int>(range);

foreach(int number in numbers.Where(i => i%2 != 0)){
    Console.WriteLine(number);
}