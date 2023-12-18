/*
There is a crucial difference between FirstOrDefault and SingleOrDefault.
If I only want 1 item, and want to make sure that is the only item with that value, which do I use?
Play around with both methods to see the differences. Which one should you use, and why?
*/


List<int> numbers = new List<int>(){3};

var result = numbers.SingleOrDefault(); //Returns the only item of a sequence, or a default value if there are no items in the sequence. Throws exception if the sequence has more than 1 item
var result2 = numbers.FirstOrDefault(); //Returns the first item of a sequence, or a default value if there are no items in the sequence

System.Console.WriteLine(result);
System.Console.WriteLine(result2);