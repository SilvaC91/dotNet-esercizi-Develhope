/*
Create a list of 100 random numbers. For every number, create an instance of the new class NumberMetaData.
The class should contain the following properties: IsEven, NumberOfCharacters.
Try using Select() in LINQ to transform 100 numbers into 100 instances of NumberMetaData
*/


using _030_Projecting;

List<int> RandomNumbers(int number){
    Random random = new Random();
    return Enumerable.Range(0, number)
                     .Select(i => random.Next(0, 501)).ToList();
}                         

List<int> randomNumbers = RandomNumbers(100);

List<NumberMetaData> numbersMetaData = randomNumbers
                                       .Select(number => new NumberMetaData{
                                            Number = number,
                                            IsEven = number % 2 == 0,
                                            NumberOfCharacters = number.ToString().Length
                                        })
                                          .ToList();

 foreach(var numberMD in numbersMetaData){

    Console.WriteLine($"Number: {numberMD.Number}, IsEven: {numberMD.IsEven}, NumberOfCharacters: {numberMD.NumberOfCharacters}");
 }