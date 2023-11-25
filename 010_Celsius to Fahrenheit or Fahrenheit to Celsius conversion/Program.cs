Console.WriteLine("Write 1 if you want to convert from Celsius to Fahrenheit \nWrite 2 if you want to convert from Fahrenheit to Celsius");
string conversionChoice = Console.ReadLine();
if(conversionChoice != "1" && conversionChoice != "2"){
    Console.WriteLine("Invalid value!");
    Environment.Exit(1);
}

if(conversionChoice == "1"){
Console.WriteLine("Write your temperature in Celsius");
}
if(conversionChoice == "2"){
Console.WriteLine("Write your temperature in Fahrenheit");
}
string inputValue = Console.ReadLine();

if(inputValue.Length == 0){
    Console.WriteLine("Invalid value!");
    Environment.Exit(1);
}

if(conversionChoice == "1"){
    double temperatureCelsius = double.Parse(inputValue);
    double temperatureFahrenheit = (temperatureCelsius * 1.8) + 32;
    Console.WriteLine($"{temperatureCelsius} Celsius are {temperatureFahrenheit} Fahrenheit");
}

if(conversionChoice == "2"){
    double temperatureFahrenheit = double.Parse(inputValue);
    double temperatureCelsius = (temperatureFahrenheit - 32) * 0.5556;
    Console.WriteLine($"{temperatureFahrenheit} Fahrenheit are {temperatureCelsius} Celsius");
}