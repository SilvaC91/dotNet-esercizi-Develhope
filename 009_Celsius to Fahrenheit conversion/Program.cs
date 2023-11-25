Console.WriteLine("Write your temperature in Celsius");
string inputValue = Console.ReadLine();

if(inputValue.Length == 0){
    Console.WriteLine("Invalid value!");
    Environment.Exit(1);
}

double temperatureCelsius = double.Parse(inputValue);
double temperatureFahrenheit = (temperatureCelsius * 1.8) + 32;
Console.WriteLine($"{temperatureCelsius} Celsius are {temperatureFahrenheit} Fahrenheit");







