/*
Edit the collection of students from previous exercise, Grading the students. 
Create two students with the same grade, that grade should be the highest. How does your application deal with that?
If needed, change the application to allow multiple students to have the highest grade.
Extra points if you can print out their names in alphabetical order.
*/

using System.Collections;
using _020_Sharing_victory;

List<Student> students = new List<Student>(){new Student("Marcello", 68.72),
                                             new Student("Claudio", 98.9),
                                             new Student("Simona", 60.6),
                                             new Student("Giorgia", 77.32),
                                             new Student("Francesco", 98.9),
                                             new Student("Sara", 90.5),
                                             new Student("Bruna", 81.22),
                                             new Student("Lucia", 98.9),
                                             new Student("Pietro", 72.45),
                                             new Student("Alessandro", 98.9)
                                            };


double gradeAverage = 0;
for(int i=0; i<students.Count; i++){
    gradeAverage += students[i].Grade;
}
gradeAverage /= students.Count;
Console.WriteLine($"Grade average = {gradeAverage}");

double gradeMax = -1;
int indexBestStudent = 0;
List<Student> bestStudents = new List<Student>();
for(int i=0; i<students.Count; i++){
    if(students[i].Grade > gradeMax){
        indexBestStudent = i;
        }
    gradeMax = Math.Max(students[i].Grade, gradeMax);
}
for(int i=0; i<students.Count; i++){
    if(students[i].Grade == gradeMax){
        bestStudents.Add(students[i]);
    }
}
bestStudents.Sort((x, y) => x.Name.CompareTo(y.Name));
Console.Write($"Student with the highest grade\nName: ");
foreach(Student student in bestStudents){
    Console.Write($"{student.Name}, ");
}
Console.WriteLine($"Grade: {gradeMax}");    
