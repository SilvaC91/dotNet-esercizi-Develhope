/*
Sorting numbers is easy, just go from low to high and you're done. But you can create your own way of sorting too.
Can you combine LINQ with a Custom Comparer to sort items based on how many characters they have? 

For instance:

5 = 1 character
52 = 2 characters
364 = 3 characters

Create a list of 1000 random numbers, and sort it by the amount of characters each number has, from low to high.
*/


Random random = new Random();
IEnumerable<int> range = Enumerable.Range(0, 1000)
                      .Select(i => random.Next(0, 501));

List<int> numbers = new List<int>(range);
List<string> stringNum = new List<string>();

foreach(int number in numbers){
    stringNum.Add(number.ToString());
}                            
  
IEnumerable<string> sortingByCharCount = from str in stringNum  
                                         orderby str.Length
                                         select str;                              

foreach(string str in sortingByCharCount){
    Console.WriteLine(str);
}

