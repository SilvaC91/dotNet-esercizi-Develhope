Console.WriteLine("Write a word or a sentence");
string str = Console.ReadLine();

if(str.Length == 0){
    Console.WriteLine("Invalid sentence!");
    Environment.Exit(1);
}

string reversedString = null;

for(int i=str.Length-1; i>=0; i--){
    reversedString += str.Substring(i, 1);
}


if(str.Replace(" ","") == reversedString.Replace(" ","")){
    Console.WriteLine("Your sentence is a palindrome!");
} else {
    Console.WriteLine("Your sentence is not a palindrome :(");
}