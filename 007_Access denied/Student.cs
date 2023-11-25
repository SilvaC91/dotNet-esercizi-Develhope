namespace _007_Access_denied;

public class Student : Person{

        private Student(string name, int age, float height, string address) : base(name, age, height, address){

        }
        static void Main(){
            Student student = new Student("Giovanni", 20, 1.87f, "Via Mazzini");

            Console.WriteLine(student.name);  //access to public field
            Console.WriteLine(student.age);   //access to protected field
            Console.WriteLine(student.height);  //access to internal field
            Console.WriteLine(student.GetAddress());  //access to private field
        }
}
