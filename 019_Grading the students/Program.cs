/*
Create a data collection that holds 10 students. The Student class should contain a Name and Grade. 
Write a program that calculates the average grade, as well as print out the student with the highest grade.
*/

using _019_Grading_the_students;

List<Student> students = new List<Student>(){new Student("Marcello", 68.72),
                                             new Student("Claudio", 89.55),
                                             new Student("Simona", 60.6),
                                             new Student("Giorgia", 77.32),
                                             new Student("Francesco", 98.9),
                                             new Student("Sara", 90.5),
                                             new Student("Bruna", 81.22),
                                             new Student("Lucia", 84.99),
                                             new Student("Pietro", 72.45),
                                             new Student("Alessandro", 65.19)
                                            };


double gradeAverage = 0;
for(int i=0; i<students.Count; i++){
    gradeAverage += students[i].Grade;
}
gradeAverage /= students.Count;
Console.WriteLine($"Grade average = {gradeAverage}");

double gradeMax = 0;
int indexBestStudent = 0;
for(int i=0; i<students.Count; i++){
    if(students[i].Grade > gradeMax){
         indexBestStudent = i;
        }
    gradeMax = Math.Max(students[i].Grade, gradeMax);
    
}

Console.WriteLine($"Student with the highest grade\nName: {students[indexBestStudent].Name}, Grade: {gradeMax}");