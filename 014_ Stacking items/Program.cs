/*
Create an application that allows 3 options:

- Push
- Pop
- Peek

When the user selects 1, allow them to add a string to the stack. 
Option 2 should pop an item and print it to the console. 
Option 3 should print the result of the Peek() method.
*/

Stack<string> stringsStack = new Stack<string>();

stringsStack.Push("AAA");
stringsStack.Push("BBB");
stringsStack.Push("CCC");
stringsStack.Push("DDD");
stringsStack.Push("EEE");

Console.WriteLine("Write 1 if you want to add a string to the stack");
Console.WriteLine("Write 2 if you want to pop an item and print it to the console");
Console.WriteLine("Write 2 if you want to peek an item and print it to the console");

string actionChoice = Console.ReadLine();
if(actionChoice != "1" && actionChoice != "2" && actionChoice != "3"){
    Console.WriteLine("Invalid value!");
    Environment.Exit(1);
}

if(actionChoice == "1"){
    Console.WriteLine("Type the string");
    string str = Console.ReadLine();
    if(str.Length == 0){
        Console.WriteLine("Invalid string!");
        Environment.Exit(1);
    }
    stringsStack.Push(str);
}

if(actionChoice == "2"){
    Console.WriteLine(stringsStack.Pop());
}

if(actionChoice == "3"){
    Console.WriteLine(stringsStack.Peek());
}