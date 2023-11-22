Console.WriteLine("Inserisci nome file");
string filePath = Console.ReadLine();

if(filePath.Length == 0){
    Console.WriteLine("Nome file non valido!");
    Environment.Exit(1);
}

string content = File.ReadAllText(filePath);
Console.WriteLine(content);
