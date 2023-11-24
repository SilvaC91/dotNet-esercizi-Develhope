namespace _006_Animal_sound_Inheritance;

public class Dog : Animal{

    public Dog(string name, int age) : base(name, age){
        
    }

    public override void Speak(){
        Console.WriteLine($"{name} says woof!");
    }

}
