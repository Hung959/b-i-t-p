using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public
     int Age
        { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "An", Age = 16 },
            new Student { Id = 2, Name = "Binh", Age = 18 },
            new Student { Id = 3,  Name ="Cuong", Age = 15 },
            new Student { Id = 4,  Name ="Duy", Age = 17 },
            new Student { Id = 5, Name = "Hoa", Age = 16 },
        };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sach toan bo học sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 đen 18:");
            var studentsAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in studentsAge15To18)
            {
                Console.WriteLine($"ID: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\nHoc sinh co ten bat đau bang chu \"A\":");
            var studentStartWithA = students.FirstOrDefault(s => s.Name.StartsWith("A"));
            if (studentStartWithA != null)
            {
                Console.WriteLine($"ID: {studentStartWithA.Id}, Ten: {studentStartWithA.Name}, Tuoi: {studentStartWithA.Age}");
            }
            else
            {
                Console.WriteLine("Khong tim thay hoc sinh nao co ten bat đau bang chu \"A\".");
            }

            // d. Tính tổng tuổi của tất cả học sinh
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine($"\nHoc sinh co tuoi lon nhat:");
            Console.WriteLine($"ID: {oldestStudent.Id}, Ten: {oldestStudent.Name}, Tuoi: {oldestStudent.Age}");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }
        }
    }
}
