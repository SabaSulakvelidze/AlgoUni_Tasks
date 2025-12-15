using AlgoUni_Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        //1)შექმენი ჯენერიკული კლასი სახელად Box, რომელიც ინახავს ერთ ფროფერთის. დაწერე მეთოდები ამ ფროფერთის
        //მნიშვნელობის დასაყენებლად და დასაბრუნებლად. შექმენი Box<string> და Box<int> ობიექტები და ტესტი ჩაატარე.
        Box<int> intBox = new();
        intBox.Value = 22;
        Console.WriteLine(intBox.Value);

        Box<string> stringBox = new();
        stringBox.Value = "Hello";
        Console.WriteLine(stringBox.Value);

        //2)დაწერე ჯენერიკული მეთოდი, რომელიც მიიღებს მასივს და ინდექსს და დააბრუნებს ახალ მასივს, სადაც მოცემული
        //ინდექსის ელემენტს ამოიღებს,შეამოწმე მეთოდი სტრინგებისა და მთელი რიცხვების მასივზე.
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] newArr = RemoveElement<int>(arr, 3);
        Array.ForEach(newArr, Console.WriteLine);

        string[] stArr = { "blue", "red", "green", "yellow" };
        string[] newStArr = RemoveElement<string>(stArr, 1);
        Array.ForEach(newStArr, Console.WriteLine);

        //3)შექმენი ჯენერიკული ინტერფეისი სახელად IDisplay, რომელსაც ექნება ერთი მეთოდი Display, რომელიც ეკრანზე
        //გამოიტანს ობიექტის მნიშვნელობას.შექმენი კლასი, რომელიც ახორციელებს ამ ინტერფეისს და გამოიტანს სტრინგებსა და რიცხვებს.
        //შექმენი ორი კლასი, ერთი სტრინგებისთვის, მეორე კი რიცხვებისთვის და შეამოწმე.
        IntDisplayer intDisplayer = new();
        intDisplayer.Display(15);
        StringDisplayer stringDisplayer = new();
        stringDisplayer.Display("Hi");

        //4)შექმენი ჯენერიკული კლასი Pair, რომელიც ორი ტიპის ფროფერთის შეიცავს.შექმენი Pair<string, int> ობიექტი და
        //ტესტი ჩაატარე
        Pair<string, int> pair = new();
        pair.FisrtValue = "Age";
        pair.SecondValue = 23;
        Console.WriteLine($"{pair.FisrtValue} | {pair.SecondValue}");

        //5)დაწერე ჯენერიკული მეთოდი, რომელიც სიიდან ამოიღებს დუბლიკატებს. შეამოწმე მეთოდი სტრინგებისა და მთელი
        //რიცხვების სიაზე
        List<int> intArr = new List<int> { 1, 1, 2, 2, 3, 3, 4, 5, 6 };
        RemoveDuplicates<int>(intArr).ForEach(Console.WriteLine);
        List<string> strArr = new List<string> { "red", "blue", "red", "green", "green", "yellow" };
        RemoveDuplicates<string>(strArr).ForEach(Console.WriteLine);

        //შექმენით List<int>, რომელიც შეიცავს რიცხვებს 1 - დან 10 - მდე.დაამატეთ ამ სიაში რიცხვი 11 და გამოიტანეთ სიის
        //ყველა ელემენტი.
        List<int> list = Enumerable.Range(1, 10).ToList();
        list.Add(11);
        list.ForEach(e => Console.WriteLine(e));

        //შექმენით List<string>, რომელიც შეიცავს ხუთ სახელისგან შემდგარ სიას. წაშალეთ სიის მეორე ელემენტი და გამოიტანეთ
        //დარჩენილი ელემენტები.
        List<string> nameList = new() { "Jon", "Mary", "George", "Saba", "Anna" };
        nameList.RemoveAt(1);
        nameList.ForEach(e => Console.WriteLine(e));

        //შექმენით List<double> და დაამატეთ მასში ხუთი შემთხვევითი მნიშვნელობა.იპოვეთ და გამოიტანეთ სიის მაქსიმალური მნიშვნელობა.
        Random rand = new Random();
        List<double> dbList = Enumerable.Range(1, 5).Select(e => rand.NextDouble() * 10).ToList();
        Console.WriteLine(dbList.Max());

        //შექმენით List<int> და დაამატეთ მასში რიცხვები 1 - დან 5 - მდე.შემდეგ გადაახარისხეთ სია უკუ - მიმართულებით
        //და გამოიტანეთ შედეგი.
        List<int> list1 = Enumerable.Range(1, 5).ToList();
        list1.Reverse();
        list1.ForEach(e => Console.WriteLine(e));

        //შექმენით List<string>, რომელიც შეიცავს ხუთი სხვადასხვა სახელს.შეამოწმეთ, შეიცავს თუ არა სია სახელ "Anna" - ს
        //და შედეგი დააბრუნეთ ეკრანზე.
        string name = "Anna";
        Console.WriteLine(nameList.Contains(name) ? $"List Contains name {name}" : $"List does not Contain name {name}");

        //შექმენით List<int>, დაამატეთ მასში შემთხვევითი რიცხვები და იპოვეთ სიის საშუალო მნიშვნელობა.
        List<int> intList = Enumerable.Range(1, 10).Select(e => rand.Next(1, 100)).ToList();
        Console.WriteLine(intList.Average());

        //შექმენით List<string>, დაამატეთ მასში სიტყვები "apple", "banana", "cherry", "date", და "elderberry".იპოვეთ
        //სიის ყველაზე გრძელი სიტყვა.
        List<string> fruitList = new() { "apple", "banana", "cherry", "date", "elderberry" };
        Console.WriteLine(fruitList.OrderBy(f => f.Length).Last());

        //შექმენით List<int> და დაამატეთ მასში რიცხვები 1 - დან 20 - მდე.წაშალეთ ყველა ლუწი რიცხვი და გამოიტანეთ შედეგი.
        List<int> intList1 = Enumerable.Range(1, 10).ToList();
        intList1.RemoveAll(n => n % 2 == 0);
        intList1.ForEach(e => Console.WriteLine(e));

        //შექმენით List<string> და დაამატეთ მასში 5 ციფრი როგორც ტექსტური სტრინგები("1", "2", "3" და ა.შ.). გადაიყვანეთ
        //ეს სტრინგები რიცხვებად და იპოვეთ სიის ჯამი.
        List<string> list2 = new() { "1", "2", "3", "4", "5" };
        Console.WriteLine(list2.Select(int.Parse).Sum());

        //შექმენით List<int> და დაამატეთ მასში რიცხვები 10 - დან 20 - მდე.იპოვეთ და წაშალეთ სიის ყველა რიცხვი, რომელიც
        //მეტია 15 - ზე.
        List<int> list3 = Enumerable.Range(10, 20).ToList();
        list3.RemoveAll(n => n > 15);
        list3.ForEach(Console.WriteLine);

        //შექმენით Dictionary<int, string>, რომელიც შეიცავს 5 წყვილს, სადაც key არის რიცხვი და value არის რიცხვის
        //დასახელება(მაგ.: 1-> "One").დაამატეთ ახალი წყვილი და გამოიტანეთ ყველა წყვილი.
        Dictionary<int, string> dictionary = new() {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" }
        };
        dictionary.Add(7,"seven");
        foreach (var item in dictionary)
            Console.WriteLine($"key: {item.Key} | value: {item.Value}");

        //შექმენით Dictionary<string, int>, რომელიც შეიცავს 5 სტუდენტის სახელს და მათ შეფასებებს.იპოვეთ სტუდენტი,
        //რომლის შეფასება ყველაზე მაღალია.
        Dictionary<string, int> grades = new() {
            {"john",33 },
            {"mary",67 },
            {"george",97 },
            {"luke",57 },
            {"anna",85 }
        };
        int maxGrade = grades.Select(i => i.Value).ToList().Max();
        Console.WriteLine(grades.Where(i=>i.Value==maxGrade).First().Key);

        //შექმენით Dictionary<string, string>, დაამატეთ 3 ქვეყნის სახელი და მათი დედაქალაქები.შეცვალეთ ერთი ქვეყნის
        //დედაქალაქი და გამოიტანეთ განახლებული სია.
        Dictionary<string, string> countries = new() {
            { "Georgia", "Kutaisi" },
            { "France", "Paris" },
            { "India", "New Dehli" },
        };
        countries["Georgia"] = "Tbilisi";
        foreach (var item in countries)
            Console.WriteLine($"{item.Key} : {item.Value}");

        //შექმენით Dictionary<int, string>, სადაც შეინახავთ მანქანის ნომრებს და მძღოლის სახელს.წაშალეთ ერთი ელემენტი
        //და გამოიტანეთ დარჩენილი მონაცემები.
        Dictionary<int, string> drivers = new()
        {
            { 471, "Giorgi" },
            { 123, "Tamar" },
            { 555, "Lasha" },
            { 117, "Mariami" }
        };
        drivers.Remove(555);
        foreach (var item in drivers)
            Console.WriteLine($"{item.Key} : {item.Value}");

        //შექმენით Dictionary<string, int>, რომელიც შეიცავს 5 სტუდენტის სახელს და მათი ასაკები.იპოვეთ სტუდენტი,
        //რომლის ასაკი არის 18 წელზე ნაკლები.
        Dictionary<string, int> students = new()
        {
            { "Luka", 21 },
            { "Ana", 17 },
            { "Davit", 22 },
            { "Eka", 20 },
            { "Sandro", 15 }
        };

        Dictionary<string, int> ofAgeStudents = students.Where(s => s.Value < 18).ToDictionary<string, int>();
        foreach (var item in ofAgeStudents)
            Console.WriteLine($"{item.Key} : {item.Value}");

        //შექმენით Dictionary<int, string> და დაამატეთ 5 ქალაქის დასახელება მათი ID-ების მიხედვით.შეამოწმეთ, შეიცავს
        //თუ არა სია ქალაქის სახელ "Tbilisi" - ს და შედეგი გამოიტანეთ.
        Dictionary<int, string> cities = new()
        {
            { 1, "Tbilisi" },
            { 2, "Kutaisi" },
            { 3, "Batumi" },
            { 4, "Rustavi" },
            { 5, "Gori" }
        };
        Console.WriteLine(cities.ContainsValue("Tbilisi"));

        //შექმენით Dictionary<string, string>, რომელიც შეიცავს 5 წიგნის ავტორს და მათ წიგნებს.დაამატეთ ახალი ავტორი
        //და წიგნი და გამოიტანეთ განახლებული სია.
        Dictionary<string, string> books = new()
        {
            { "Jane Austen", "Pride and Prejudice" },
            { "George Orwell", "1984" },
            { "F. Scott Fitzgerald", "The Great Gatsby" },
            { "Virginia Woolf", "Mrs. Dalloway" },
            { "J.R.R. Tolkien", "The Hobbit" }
        };
        books.Add("Ernest Hemingway", "The Old Man and the Sea");
        foreach (var item in books)
            Console.WriteLine($"{item.Key} : {item.Value}");

        //შექმენით Dictionary<int, string> და შეინახეთ თვეების დასახელებები მათი რიგითი ნომრების მიხედვით(1->January,
        //2->February და ა.შ.).დაამატეთ ახალი თვე და გამოიტანეთ სია.
        Dictionary<int, string> months = new()
        {
            { 1, "January" },
            { 2, "February" },
            { 3, "March" },
            { 4, "April" },
            { 5, "May" },
            { 6, "June" },
            { 7, "July" },
            { 8, "August" },
            { 9, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" }
        };
        months.Add(13, "Mecamete");
        foreach (var item in months)
            Console.WriteLine($"{item.Key} : {item.Value}");

        //შექმენით Dictionary<int, string>, რომელიც შეიცავს 5 სხვადასხვა პროდუქტს მათი ID-ების მიხედვით.იპოვეთ პროდუქტი,
        //რომლის ID უდრის 3 - ს და გამოიტანეთ მისი სახელი.
        Dictionary<int, string> products = new()
        {
            { 1, "Laptop" },
            { 2, "Mouse" },
            { 3, "Keyboard" },
            { 4, "Monitor" },
            { 5, "Webcam" }
        };
        Console.WriteLine(products[3]);

        //შექმენით Dictionary<string, int> და დაამატეთ 5 სტუდენტის მონაცემები(სახელი -> შეფასება). შეცვალეთ ერთ-ერთი
        //სტუდენტის შეფასება და გამოიტანეთ განახლებული მონაცემები.
        Dictionary<string, int> stidentsGrades = new() {
            {"john",33 },
            {"mary",67 },
            {"george",97 },
            {"luka",57 },
            {"anna",85 }
        };
        stidentsGrades["luka"] = 89;
        foreach (var item in stidentsGrades)
            Console.WriteLine($"{item.Key} : {item.Value}");
    }

    public static T[] RemoveElement<T>(T[] arr, int index)
    {
        if (index >= arr.Length)
        {
            Console.WriteLine("Index is out of bound!");
            return null;
        }
        T[] result = new T[arr.Length - 1];
        for (int i = 0; i < index; i++)
            result[i] = arr[i];
        for (int i = index+1; i < arr.Length; i++)
            result[i-1] = arr[i];
        return result;
    }

    public static List<T> RemoveDuplicates<T>(List<T> list)
    {
       return list.Distinct().ToList(); 
    }
}