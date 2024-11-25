using PratikLinqGroupJoin;
using System;
using System.Collections.Generic;
using System.Linq;

List<Student> students = new List<Student>();
        
students.Add(new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 });
students.Add(new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 });
students.Add(new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 });
students.Add(new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 });
students.Add(new Student { StudentId = 5, StudentName = "Ahmet" , ClassId = 2 });
students.Add(new Student { StudentId = 6, StudentName = "İzzet", ClassId = 1 });
students.Add(new Student { StudentId = 7, StudentName = "Kemal", ClassId = 3 });
students.Add(new Student { StudentId = 8, StudentName = "Hamit", ClassId = 2 });
students.Add(new Student { StudentId = 9, StudentName = "Buket", ClassId = 2 });
students.Add(new Student { StudentId = 9, StudentName = "Nurten", ClassId = 3 });

List<Class> classes = new List<Class>();

classes.Add(new Class { ClassId = 1, ClassName = "Matematik" });
classes.Add(new Class { ClassId = 2, ClassName = "Türkçe" });
classes.Add(new Class { ClassId = 3, ClassName = "Kimya" });

var studentWithClass = classes.GroupJoin(
            students, // Eşleştirilecek ikinci liste
            className => className.ClassId, // classes için anahtar
            student => student.ClassId,  // students için anahtar
            (className, studentGroup) => new // Her eşleşmede oluşturulacak yapı
            {
                ClassName = className.ClassName,
                Students = studentGroup
            });
foreach (var group in studentWithClass)
{
    Console.WriteLine($"Sınıf: {group.ClassName}");
    foreach (var student in group.Students)
    {
        Console.WriteLine($"  - Öğrenci: {student.StudentName}");
    }
}











