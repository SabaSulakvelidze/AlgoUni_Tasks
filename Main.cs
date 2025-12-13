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
        pair.SecondValue= 23;
        Console.WriteLine($"{pair.FisrtValue} | {pair.SecondValue}");

        //5)დაწერე ჯენერიკული მეთოდი, რომელიც სიიდან ამოიღებს დუბლიკატებს. შეამოწმე მეთოდი სტრინგებისა და მთელი
        //რიცხვების სიაზე
        List<int> intArr = new List<int> { 1, 1, 2, 2, 3, 3, 4, 5, 6 };
        RemoveDuplicates<int>(intArr).ForEach(Console.WriteLine);
        List<string> strArr = new List<string> { "red", "blue", "red", "green", "green", "yellow" };
        RemoveDuplicates<string>(strArr).ForEach(Console.WriteLine);

        //შექმენით List<int>, რომელიც შეიცავს რიცხვებს 1 - დან 10 - მდე.დაამატეთ ამ სიაში რიცხვი 11 და გამოიტანეთ სიის
        //ყველა ელემენტი.

        //შექმენით List<string>, რომელიც შეიცავს ხუთ სახელისგან შემდგარ სიას. წაშალეთ სიის მეორე ელემენტი და გამოიტანეთ
        //დარჩენილი ელემენტები.

        //შექმენით List<double> და დაამატეთ მასში ხუთი შემთხვევითი მნიშვნელობა.იპოვეთ და გამოიტანეთ სიის მაქსიმალური მნიშვნელობა.

        //შექმენით List<int> და დაამატეთ მასში რიცხვები 1 - დან 5 - მდე.შემდეგ გადაახარისხეთ სია უკუ - მიმართულებით
        //და გამოიტანეთ შედეგი.

        //შექმენით List<string>, რომელიც შეიცავს ხუთი სხვადასხვა სახელს.შეამოწმეთ, შეიცავს თუ არა სია სახელ "Anna" - ს
        //და შედეგი დააბრუნეთ ეკრანზე.

        //შექმენით List<int>, დაამატეთ მასში შემთხვევითი რიცხვები და იპოვეთ სიის საშუალო მნიშვნელობა.

        //შექმენით List<string>, დაამატეთ მასში სიტყვები "apple", "banana", "cherry", "date", და "elderberry".იპოვეთ
        //სიის ყველაზე გრძელი სიტყვა.

        //შექმენით List<int> და დაამატეთ მასში რიცხვები 1 - დან 20 - მდე.წაშალეთ ყველა ლუწი რიცხვი და გამოიტანეთ შედეგი.

        //შექმენით List<string> და დაამატეთ მასში 5 ციფრი როგორც ტექსტური სტრინგები("1", "2", "3" და ა.შ.). გადაიყვანეთ
        //ეს სტრინგები რიცხვებად და იპოვეთ სიის ჯამი.

        //შექმენით List<int> და დაამატეთ მასში რიცხვები 10 - დან 20 - მდე.იპოვეთ და წაშალეთ სიის ყველა რიცხვი, რომელიც
        //მეტია 15 - ზე.

        //შექმენით Dictionary<int, string>, რომელიც შეიცავს 5 წყვილს, სადაც key არის რიცხვი და value არის რიცხვის
        //დასახელება(მაგ.: 1-> "One").დაამატეთ ახალი წყვილი და გამოიტანეთ ყველა წყვილი.

        //შექმენით Dictionary<string, int>, რომელიც შეიცავს 5 სტუდენტის სახელს და მათ შეფასებებს.იპოვეთ სტუდენტი,
        //რომლის შეფასება ყველაზე მაღალია.

        //შექმენით Dictionary<string, string>, დაამატეთ 3 ქვეყნის სახელი და მათი დედაქალაქები.შეცვალეთ ერთი ქვეყნის
        //დედაქალაქი და გამოიტანეთ განახლებული სია.

        //შექმენით Dictionary<int, string>, სადაც შეინახავთ მანქანის ნომრებს და მძღოლის სახელს.წაშალეთ ერთი ელემენტი
        //და გამოიტანეთ დარჩენილი მონაცემები.

        //შექმენით Dictionary<string, int>, რომელიც შეიცავს 5 სტუდენტის სახელს და მათი ასაკები.იპოვეთ სტუდენტი,
        //რომლის ასაკი არის 18 წელზე ნაკლები.

        //შექმენით Dictionary<int, string> და დაამატეთ 5 ქალაქის დასახელება მათი ID-ების მიხედვით.შეამოწმეთ, შეიცავს
        //თუ არა სია ქალაქის სახელ "Tbilisi" - ს და შედეგი გამოიტანეთ.

        //შექმენით Dictionary<string, string>, რომელიც შეიცავს 5 წიგნის ავტორს და მათ წიგნებს.დაამატეთ ახალი ავტორი
        //და წიგნი და გამოიტანეთ განახლებული სია.

        //შექმენით Dictionary<int, string> და შეინახეთ თვეების დასახელებები მათი რიგითი ნომრების მიხედვით(1->January,
        //2->February და ა.შ.).დაამატეთ ახალი თვე და გამოიტანეთ სია.

        //შექმენით Dictionary<int, string>, რომელიც შეიცავს 5 სხვადასხვა პროდუქტს მათი ID-ების მიხედვით.იპოვეთ პროდუქტი,
        //რომლის ID უდრის 3 - ს და გამოიტანეთ მისი სახელი.

        //შექმენით Dictionary<string, int> და დაამატეთ 5 სტუდენტის მონაცემები(სახელი -> შეფასება). შეცვალეთ ერთ-ერთი
        //სტუდენტის შეფასება და გამოიტანეთ განახლებული მონაცემები.


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