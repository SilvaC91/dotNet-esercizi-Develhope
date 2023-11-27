/*
Create a List<int>. The list should have 1000 random numbers. 
Write a program that finds the minimum and maximum numbers in that list.
*/

List<int> numbers = new List<int>();
Random random = new Random();
int numbersCount = 1000;
int numbersMax = int.MinValue;
int numbersMin = int.MaxValue;

for(int i=0; i<numbersCount; i++){
    numbers.Add(random.Next());
}
for(int i=0; i<numbersCount; i++){
    numbersMax = Math.Max(numbers[i], numbersMax);
    numbersMin = Math.Min(numbers[i], numbersMin);
}
Console.WriteLine($"Min number = {numbersMin}\nMax number = ");



