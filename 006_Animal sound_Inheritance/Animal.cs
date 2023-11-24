using System.Security.Cryptography;

namespace _006_Animal_sound_Inheritance;

public abstract class Animal{
    public string name{get; set;}
    public int age{get; set;}

    public Animal(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public virtual void Speak(){
    }


}
