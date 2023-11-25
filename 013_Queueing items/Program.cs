/*
Create an application that allows 3 options:

- Queue
- Dequeue
- Peek

When the user selects 1, allow them to add a string to the queue. 
Option 2 should dequeue an item and print it to the console. 
Option 3 should print the result of the Peek() method.
*/

Queue<string> stringsQueue = new Queue<string>();

stringsQueue.Enqueue("AAA");
stringsQueue.Enqueue("BBB");
stringsQueue.Enqueue("CCC");
stringsQueue.Enqueue("DDD");
stringsQueue.Enqueue("EEE");

Console.WriteLine("Write 1 if you want to add a string to the queue");
Console.WriteLine("Write 2 if you want to dequeue an item and print it to the console");
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
    stringsQueue.Enqueue(str);
}

if(actionChoice == "2"){
    Console.WriteLine(stringsQueue.Dequeue());
}

if(actionChoice == "3"){
    Console.WriteLine(stringsQueue.Peek());
}