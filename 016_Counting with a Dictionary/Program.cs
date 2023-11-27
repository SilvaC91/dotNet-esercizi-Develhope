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
    string wordToLower = word.ToLower();
    if(uniqueWordsCount.ContainsKey(wordToLower)){
        uniqueWordsCount[wordToLower]++; 
    }else{
        uniqueWordsCount.Add(wordToLower, 1);
    }
}
foreach(var kvp in uniqueWordsCount){
    Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
}