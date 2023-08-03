namespace LinqLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region No. 1
            //List<int> nums = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            //// Query 1 :-
            //var distNums = nums.Distinct().OrderBy(x => x);
            //foreach (int num in distNums)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("==========");

            //// Query 2:-
            //var multipNums = distNums.Select(x => new { Number = x, Multiply = x * x });
            //foreach (var num in multipNums)
            //{
            //    Console.WriteLine($"{{ Number = {num.Number}, Multiply = {num.Multiply} }}");
            //}
            #endregion

            #region No. 2
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            #region Query1
            //// Query 1 - Query Expression
            //var q1 = from name in names
            //         where name.Length == 3
            //         select name;
            //foreach (var name in q1)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("==========");

            //// Query 1 - Method Expression
            //var q1M = names.Where(name => name.Length == 3);
            //foreach (var name in q1M)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("==========");
            #endregion

            #region Query2
            // Query 2 - Query Expression
            //var q2 = from name in names
            //         where name.ToLower().Contains("a")
            //         orderby name.Length
            //         select name;
            //foreach (var name in q2)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("==========");

            //// Query 2 - Method Expression
            //var q2M = names.Where(name => name.ToLower().Contains("a")).OrderBy(name => name.Length);
            //foreach (var name in q2M)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("==========");
            #endregion

            #region Query3
            //// Query 3 - Query Expression
            //var q3 = (from name in names
            //          select name).Take(2);
            //foreach (var name in q3)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("==========");

            //// Query 3 - Method Expression
            //var q3M = names.Take(2);
            //foreach (var name in q3M)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #endregion

            #region No. 3
            //List<Student> students = new List<Student>()
            //{
            //    new Student()
            //    {
            //        ID = 1,
            //        FirstName = "Ali",
            //        LastName = "Mohammed",
            //        subjects = new Subject[]
            //        {
            //            new Subject() { Code = 22, Name = "EF" },
            //            new Subject() { Code = 33, Name = "UML" }
            //        }
            //    },
            //    new Student()
            //    {
            //        ID = 2,
            //        FirstName = "Mona",
            //        LastName = "Gala",
            //        subjects = new Subject[]
            //        {
            //            new Subject() { Code = 22, Name = "EF" },
            //            new Subject() { Code = 34, Name = "XML" },
            //            new Subject() { Code = 25, Name = "JS" }
            //        }
            //    },
            //    new Student()
            //    {
            //        ID = 3,
            //        FirstName = "Yara",
            //        LastName = "Yousf",
            //        subjects = new Subject[]
            //        {
            //            new Subject() { Code = 22, Name = "EF" },
            //            new Subject() { Code = 25, Name = "JS" }
            //        }
            //    },
            //    new Student()
            //    {
            //        ID = 4,
            //        FirstName = "Ali",
            //        LastName = "Ali",
            //        subjects = new Subject[]
            //        {
            //            new Subject() { Code = 33, Name = "UML" }
            //        }
            //    }
            //};

            //// Query 1
            //var q1 = students.Select(s => new { FullName = s.FirstName + " " + s.LastName, NoOfSubjects = s.subjects.Length });
            //foreach (var student in q1)
            //{
            //    Console.WriteLine($"{{ FullName = {student.FullName}, NoOfSubjects = {student.NoOfSubjects} }}");
            //}
            //Console.WriteLine("==========");

            //// Query 2
            //var q2 = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName).Select(s => s.FirstName + " " + s.LastName);
            //foreach (var fullName in q2)
            //{
            //    Console.WriteLine(fullName);
            //}
            //Console.WriteLine("==========");

            //// Query 3
            //var q3 = students.SelectMany(s => s.subjects, (s, sub) => new { StudentName = s.FirstName + " " + s.LastName, SubjectName = sub.Name });
            //foreach (var item in q3)
            //{
            //    Console.WriteLine($"{{ StudentName = {item.StudentName}, SubjectName = {item.SubjectName} }}");
            //}
            //Console.WriteLine("==========");

            //// Query 3- Bonus
            //var q3B = q3.GroupBy(s => s.StudentName);
            //foreach (var group in q3B)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"\t{item.SubjectName}");
            //    }
            //}
            #endregion
        }
    }

    class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] subjects { get; set; }
    }
}