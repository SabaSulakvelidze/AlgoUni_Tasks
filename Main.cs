using AlgoUni_Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //1.Where მეთოდის დავალება:**
        //გქონდეს რიცხვების სია(1 - 100) და გამოიყენე `Where` მეთოდი, რომ მოძებნო ყველა ისეთი რიცხვი, რომელიც 5 - ზე იყოფა.
        List<int> intList = Enumerable.Range(1, 100).ToList();
        foreach (var item in intList.Where(i => i % 5 == 0))
            Console.WriteLine(item);

        // 2.Select მეთოდის დავალება:**
        //შექმენი სტუდენტების სია, სადაც თითოეულ სტუდენტს აქვს `Id`, `Name`, და `Age`. გამოიყენე `Select` მეთოდი,
        //რათა აიღო სტუდენტების მხოლოდ სახელები და მათი ასაკები.
        List<Student> students = new() {
            {new Student(1,"Giorgi",19) },
            {new Student(2,"Ana",23) },
            {new Student(3,"Mari",21) },
            {new Student(4,"Giorgi",20) },
            {new Student(5,"Ana",18) },
            {new Student(6,"Luka",25) },
            {new Student(7,"Nino",19) }
        };

        List<Student> newStudents = students.Select(s => new Student(s.Name, s.Age)).ToList();
        newStudents.ForEach(s => Console.WriteLine($"{s.Name} - {s.Age}"));

        // 3.OrderBy მეთოდის დავალება:**
        //შექმენი პროდუქტების სია, სადაც თითოეულ პროდუქტს აქვს `Name` და `Price`. გამოიყენე `OrderBy`, რომ დაალაგო
        //პროდუქტები ფასის მიხედვით ზრდადობით.
        List<Product> products = new List<Product> {
            new("Laptop", 2500.00),
            new("Mouse", 35.50),
            new("Monitor 27''", 549.99),
            new("Keyboard", 75.00),
            new("Headphones", 120.99)
        };
        List<Product> orderedAsc = products.OrderBy(p => p.Price).ToList();
        orderedAsc.ForEach(Console.WriteLine);

        // 4.OrderByDescending მეთოდის დავალება:**
        //გამოიყენე იგივე პროდუქტების სია და `OrderByDescending`, რომ დაალაგო პროდუქტები ფასის მიხედვით კლებადობით.
        List<Product> orderedDesc = products.OrderByDescending(p => p.Price).ToList();
        orderedDesc.ForEach(Console.WriteLine);

        // 5.GroupBy მეთოდის დავალება:**
        //შექმენი თანამშრომლების სია, სადაც თითოეულ მათგანს აქვს `Department` და `Salary`. გამოიყენე `GroupBy`,
        //რომ დაჯგუფო თანამშრომლები დეპარტამენტის მიხედვით.
        List<Employee> employees = new List<Employee>{
            new("Giorgi", "IT", 65000.00),
            new("Anna", "HR", 48000.50),
            new("Luka", "Sales", 55000.75),
            new("Mari", "IT", 72000.00),
            new("Beka", "Marketing", 51500.25)
        };
        var gropuped = employees.GroupBy(e => e.Department).ToList();
        gropuped.ForEach(g =>
        {
            Console.WriteLine(g.Key);
            foreach (var item in g)
                Console.WriteLine(item);
        });

        // 6.Join მეთოდის დავალება:**
        //გქონდეს ორი სია: სტუდენტები და კურსები, სადაც თითოეულ სტუდენტს აქვს `Id`, ხოლო თითოეულ კურსს აქვს `StudentId`
        //და `CourseName`. გამოიყენე `Join`, რომ შეაერთო სტუდენტების სახელები და კურსები.
        List<Student> students6 = new List<Student>
        {
            new (1, "Giorgi"),
            new (2, "Ana"),
            new (3, "Mari"),
            new (4, "Giorgi"),
            new (5, "Beka"),
            new (6, "Luka"),
            new (7, "Nino")
        };
        List<Course> courses6 = new List<Course>
        {
            new(1, "Algorithms"),
            new(1, "Database Systems"),
            new(2, "Web Development"),
            new(2, "UX Design"),
            new(2, "Data Structures"),
            new(3, "Cloud Computing")
        };
        var joinedWithQuery = from stud in students6
                         join course in courses6 on stud.Id equals course.StudentId
                         select new
                         {
                             stud.Id,
                             stud.Name,
                             course.CourseName
                         };
        foreach (var i in joinedWithQuery)
            Console.WriteLine($"{i.Id}, {i.Name}, {i.CourseName}");

        var joinedWithMethod = students6.Join(courses6,
            s => s.Id,
            c => c.StudentId,
            (s, c) => new
            {
                s.Id,
                s.Name,
                c.CourseName
            });
        Console.WriteLine("==================");
        foreach (var i in joinedWithMethod)
            Console.WriteLine($"{i.Id}, {i.Name}, {i.CourseName}");

        // 7.Count მეთოდის დავალება:**
        //გქონდეს სახელების სია, და გამოიყენე `Count` მეთოდი, რომ დათვალო რამდენი სახელი შეიცავს ასო "a" - ს.
        var namesList = students6.Select(s => s.Name).ToList();
        Console.WriteLine(namesList.Count(n => n.Contains('a')));

        // 8.Sum მეთოდის დავალება:**
        //გქონდეს რიცხვების სია და გამოიყენე `Sum`, რომ გამოიანგარიშო ყველა რიცხვის ჯამი.
        Console.WriteLine(intList.Sum());

        // 9.Average მეთოდის დავალება:**
        //გქონდეს თანამშრომლების სია, სადაც თითოეულ თანამშრომელს აქვს `Salary`. გამოიყენე `Average`, რომ გამოიანგარიშო
        //თანამშრომლების საშუალო ხელფასი.
        Console.WriteLine($"average salary: {employees.Average(e=>e.Salary)}");

        // 10.Max მეთოდის დავალება:**
        //გქონდეს პროდუქტების სია, სადაც თითოეულ პროდუქტს აქვს `Price`. გამოიყენე `Max`, რომ იპოვო ყველაზე მაღალი ფასი.
        Console.WriteLine($"max price: {products.Max(p => p.Price)}");

        // 11.Min მეთოდის დავალება:**
        //გამოიყენე იგივე პროდუქტების სია და `Min`, რომ იპოვო ყველაზე დაბალი ფასი.
        Console.WriteLine($"max price: {products.Min(p => p.Price)}");

        // 12.First მეთოდის დავალება:**
        //გქონდეს რიცხვების სია და გამოიყენე `First`, რომ იპოვო პირველი რიცხვი, რომელიც მეტია 10 - ზე.
        Console.WriteLine(intList.First(i => i > 10));

        // 13.FirstOrDefault მეთოდის დავალება:**
        //გამოიყენე იგივე რიცხვების სია და `FirstOrDefault`, რომ იპოვო პირველი რიცხვი, რომელიც მეტია 100 - ზე.
        //თუ ასეთი არ არსებობს, დაბრუნდეს ნულოვანი მნიშვნელობა.
        Console.WriteLine(intList.FirstOrDefault(i => i > 100, 0));

        // 14.Distinct მეთოდის დავალება:**
        //გქონდეს სტუდენტების სახელების სია, სადაც ზოგიერთ სახელზე განმეორება ხდება.გამოიყენე `Distinct`,
        //რომ მიიღო მხოლოდ უნიკალური სახელები.
        var distinctNames = students.Select(s => s.Name).Distinct();
        foreach (var item in distinctNames)
            Console.WriteLine(item);

        var distinctByNames = students.DistinctBy(s => s.Name).ToList();
        foreach (var item in distinctByNames)
            Console.WriteLine(item);
        // 15.Any მეთოდის დავალება:**
        //გქონდეს რიცხვების სია და გამოიყენე `Any`, რომ შეამოწმო, არსებობს თუ არა სია, რომელშიც რიცხვი 50 - ზე მეტია.
        Console.WriteLine(intList.Any(i => i > 50));
        Console.WriteLine(intList.Any(i => i > 150));

    }

    
}