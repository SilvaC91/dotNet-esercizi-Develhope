Console.WriteLine("Inserisci il testo");
string str = Console.ReadLine();

if(str.Length == 0){
    Console.WriteLine("Nessun testo inserito!");
    Environment.Exit(1);
}

Console.WriteLine(string.Concat(Enumerable.Reverse(str)));
