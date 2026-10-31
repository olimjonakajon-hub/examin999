// public class StudentService : IStudentService
// {
//     private List<Student> students = new List<Student>();

//     public void AddStudent(Student student)
//     {
//         if (students.Any(s => s.Id == student.Id))
//         {
//             throw new InvalidOperationException($"Донишҷӯ  Id ({student.Id})");
//         }
//         students.Add(student);
//     }

//     public void DisplayStudents()
//     {
//         if (students.Count == 0)
//         {
//             Console.WriteLine("Рӯйхат");
//             return;
//         }

//         Console.WriteLine("пролд");
//         foreach (var s in students)
//         {
//             Console.WriteLine($"ID: {s.Id} | Ном: {s.FullName} | Синну сол: {s.Age} | Гурӯҳ: {s.Group}");
//         }
//     }

//     public void UpdateStudent(int id, string fullName, int age, string group)
//     {
//         var student = students.FirstOrDefault(s => s.Id == id);
//         if (student == null)
//         {
//             throw new KeyNotFoundException($"Дониш  Id {id} ");
//         }

//         student.FullName = fullName;
//         student.Age = age;
//         student.Group = group;
//     }

//     public void DeleteStudent(int id)
//     {
//         var student = students.FirstOrDefault(s => s.Id == id);
//         if (student == null)
//         {
//             throw new KeyNotFoundException($"Дони Id {id} ");
//         }

//         students.Remove(student);
//     }

//     public Student SearchByName(string fullName)
//     {
//         return students.FirstOrDefault(s => s.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));
//     }

//     public List<Student> SearchByGroup(string group)
//     {
//         return students.Where(s => s.Group.Equals(group, StringComparison.OrdinalIgnoreCase)).ToList();
//     }
// }