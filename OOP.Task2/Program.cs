using OOP.Task2;

Student student = new Student();

student.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


foreach (var item in student.Grades)
{
    Console.WriteLine(item);
}


int[] a = new int[0];

ArrayExtension.Add(ref a, 1);