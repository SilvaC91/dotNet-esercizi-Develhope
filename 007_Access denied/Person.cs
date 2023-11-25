namespace _007_Access_denied;

public abstract class Person{
    public string name;
    protected int age;
    internal float height;
    private string address;

    public Person(string name, int age, float height, string address){
        this.name = name;
        this.age = age;
        this.height = height;
        this.address = address;
        
    }

    public string GetAddress(){
        return address;
    }
    public void SetAddress(string address){
        this.address = address;
    }


}
