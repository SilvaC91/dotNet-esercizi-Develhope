/*
Create an application that allows a user to give a path to a .txt file. 
That file should contain a lot of words, with some duplicates. 
The application should create a Dictionary<string, int> to store every unique word, and how often they appear in the file. 
For this purpose, words are not case-sensitive.
*/

Console.WriteLine("Type the file path");
string filePath = Console.ReadLine();

if(filePath.Length == 0){
    Console.WriteLine("Invalid path!");
    Environment.Exit(1);
}

Dictionary<string, int> uniqueWordsCount = new Dictionary<string, int>();

string stringFromFile = File.ReadAllText(filePath).Trim();

List<string> words = new List<string>(stringFromFile.Split(' ', ','));

foreach(string word in words){
    if(uniqueWordsCount.ContainsKey(word.ToLower())){
        uniqueWordsCount[word.ToLower()]++; 

    } else {
        uniqueWordsCount.Add(word.ToLower(), 1);
    }

foreach (var kvp in uniqueWordsCount) {
            Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
        }
}
// 3 dog    2 cat     3 horse     2 pig      1 monkey    2 cocodrile

//non stampa le chiavi con il valore massimo raggiunto, ma stampa le chiavi ad ogni aumento del valore
