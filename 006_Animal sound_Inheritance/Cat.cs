namespace _006_Animal_sound_Inheritance;

public class Cat : Animal{

    public Cat(string name, int age) : base(name, age){
        
    }

    public override void Speak(){
        Console.WriteLine($"{name} says meow!");
    }

}
