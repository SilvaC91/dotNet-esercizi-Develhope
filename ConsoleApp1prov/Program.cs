Console.WriteLine("Inserisci il tuo nome");
string nome = Console.ReadLine();

if(nome.Length == 0){
    Console.WriteLine("Nome non valido!");
    Environment.Exit(1);
}
Console.WriteLine($"Hello, {nome}");