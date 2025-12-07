using System.Diagnostics.Metrics;
using System.Xml.Serialization;

internal class Program
{
    static void Task_1()
    {
        //დაწერეთ პროგრამა რომელიც კონსოლში გამოიტანს "Hello World" -ს.
        Console.WriteLine("Hello World");
        //დაბეჭდეთ რიცხვი.
        Console.WriteLine(32);
        //დაწერეთ პროგრამა ორი რიცხვის შესაკრებად და შედეგის გამოსატანად.
        Console.WriteLine(1 + 2);
        //დაწერეთ პროგრამა რომელიც გამოაკლებს ორ რიცხვს ერთმანეთს და აჩვენებს შედეგს.
        Console.WriteLine(2 - 1);
        //დაწერეთ პროგრამა ორი რიცხვის გასამრავლებლად და შედეგის გამოსატანად.
        Console.WriteLine(2 * 2);
        //დაწერეთ ფუნქცია , რომელიც შეეკითხება უზერს სახელს და დაპრინტავს "Hello, (სახელი)!".
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
        //.ამობეჭდეთ ტექსტის სიგრძე.
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Text length: " + text.Length);
        //დაწერეთ პროგრამა ორი სტრიქონის შესაერთებლად და შედეგის ჩვენების მიზნით.
        Console.Write("Enter first text: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second text: ");
        string str2 = Console.ReadLine();
        Console.WriteLine("Joined text: " + str1 + str2);
        //დაწერეთ პროგრამა სტრიქონის დიდ ასოებზე გადასაყვანად.
        Console.Write("Enter a text: ");
        string input = Console.ReadLine();
        Console.WriteLine("Uppercase: " + input.ToUpper());
        //დაწერეთ პროგრამა სტრიქონის მცირე ასოზე გადასაყვანად.
        Console.Write("Enter a text: ");
        string inputLower = Console.ReadLine();
        Console.WriteLine("Lowercase: " + inputLower.ToLower());

    }

    static void Task_2()
    {
        //1) სთხოვეთ მომხმარებელს შეიყვანოს თავისი სახელი და აჩვენოს იგი დიდი და პატარა ასოებით.
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Uppercase: " + name.ToUpper());
        Console.WriteLine("Uppercase: " + name.ToLower());
        //2) სთხოვეთ მომხმარებელს შეიყვანოს სიტყვა და აჩვენოს სიტყვის სიგრძე.
        Console.Write("Enter text: ");
        var text = Console.ReadLine();
        Console.WriteLine("length of a text is: " + text.Length);
        //3) სთხოვეთ მომხმარებელს შეიყვანოს წინადადება და ამოიღოს პირველი 5 სიმბოლო.
        Console.Write("Enter a sentence: ");
        var sentence = Console.ReadLine();
        Console.WriteLine("First 5 characters: " + sentence.Substring(0, 5));
        //4)შექმენით ორი ინტ ტიპის  ცვლადი , დაამატეთ ისინი და აჩვენეთ შედეგი.
        int a = 5;
        int b = 10;
        Console.WriteLine("Sum: " + (a + b));
        //5) შექმენით ორი  double რიცხვი, გაამრავლეთ ისინი და აჩვენეს შედეგი.
        double x = 5.5;
        double y = 2.2;
        Console.WriteLine("Product of " + x.ToString() + "*" + y.ToString() + " is: " + (x * y));
        //6) შექმენით სიმბოლო და გაარკვიეთ, ინფორმაცია  არის ციფრი თუ ასო.
        char ch = 'A';
        if (char.IsDigit(ch))
        {
            Console.WriteLine(ch + " is a digit.");
        }
        else if (char.IsLetter(ch))
        {
            Console.WriteLine(ch + " is a letter.");
        }
        else
        {
            Console.WriteLine(ch + " is neither a digit nor a letter.");
        }
        //7) შექმენით ცვლადი -ლოგიკური მნიშვნელობა(true / false) და აჩვენოს ამ მნიშვნელობის შებრუნებული მნიშვნელობა.
        bool bln = false;
        Console.Write(!bln);
        //8) სთხოვეთ მომხმარებელს შეიყვანოს წინადადება და სიტყვა. შეამოწმეთ, შეიცავს თუ არა წინადადება სიტყვას და აჩვენეთ შედეგი.
        Console.Write("Enter a sentence: ");
        var sent = Console.ReadLine();
        Console.Write("Enter a word to search: ");
        var word = Console.ReadLine();
        if (sent.Contains(word)) Console.WriteLine("Sentence contains word: " + word);
        else Console.WriteLine("Sentence does not contain word: " + word);
        //9) სთხოვეთ მომხმარებელს შეიყვანოს წინადადება და შეცვალოს ყველა სფეისი  დეფისით.
        Console.Write("Enter a sentence: ");
        var phrase = Console.ReadLine();
        var modifiedPhrase = phrase.Replace(" ", "-");
        Console.WriteLine("Modified sentence: " + modifiedPhrase);
        //10) შექმენით ინტ ტიპის ცვლადი  და აჩვენეთ  მისი კვადრატული ფესვი და  გაორმაგებული მნიშვნელობა
        int i = 49;
        Console.WriteLine("Squeare root of " + i.ToString() + " is: " + Math.Sqrt(i));
        Console.WriteLine("Doubled value of " + i.ToString() + " is: " + i * 2);

    }

    static void Task_3()
    {
        //დაწერეთ პროგრამა, რათა შეამოწმოთ რიცხვი ლუწია თუ კენტი.
        Console.Write("Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());
        if (num1 % 2 == 0) Console.WriteLine("number is even");
        else Console.WriteLine("number is odd");
        //დაწერეთ პროგრამა, რათა შეამოწმოთ რიცხვი დადებითია, უარყოფითი თუ ნული.
        Console.Write("Enter a number: ");
        int num2 = int.Parse(Console.ReadLine());
        if (num2 > 0) Console.WriteLine("its positive number");
        else if (num2 < 0) Console.WriteLine("its negative number");
        else if (num2 == 0) Console.WriteLine("its zero");
        //დაწერეთ პროგრამა, რათა შეამოწმოთ იყოფა თუ არა რიცხვი სხვა რიცხვზე.
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a % b == 0 ? "its devisible" : "its not devisible");
        //დაწერეთ პროგრამა, რათა შეამოწმოთ სტრიქონი ცარიელია თუ არა.
        Console.Write("Enter text: ");
        String text = Console.ReadLine();
        if (text.Length == 0 || text == null) Console.WriteLine("text is empty");
        else Console.WriteLine("text is not empty");
        //დაწერეთ პროგრამა, რათა შეამოწმოთ, შეიცავს თუ არა სტრიქონი კონკრეტულ სიტყვას.
        Console.Write("Enter a sentence: ");
        var sent = Console.ReadLine();
        Console.Write("Enter a word to search: ");
        var word = Console.ReadLine();
        Console.WriteLine(sent.Contains(word) ? "Sentence contains word: " + word :
            "Sentence does not contain word: " + word);
        //დაწერეთ პროგრამა, რომ იპოვოთ მინიმალური ორი რიცხვიდან if elsebit.
        Console.Write("Enter first number: ");
        var a1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        var a2 = int.Parse(Console.ReadLine());
        if (a1 < a2) Console.WriteLine(a1 + " is min");
        else if (a1 > a2) Console.WriteLine(a2 + " is min");
        else Console.WriteLine("they are equal");
        //დაწერეთ პროგრამა, რომ იპოვოთ მაქსიმალური ორი რიცხვიდან if elsebit.
        Console.Write("Enter first number: ");
        var b1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        var b2 = int.Parse(Console.ReadLine());
        if (b1 < b2) Console.WriteLine(b2 + " is max");
        else if (b1 > b2) Console.WriteLine(b1 + " is max");
        else Console.WriteLine("they are equal");

        //დაწერეთ პროგრამა, რომელიც მომხმარებელს შეეკითხება თავის ასაკს და დაადგენს 
        //    არის თუ არა 18 წლის ან უფრო მეტის. თუ არის, გამოპრინტეთ "Adult", 
        //    თუარადა - "Minor".
        Console.Write("Enter your age: ");
        var age = int.Parse(Console.ReadLine());
        Console.WriteLine(age >= 18 ? "Adult" : "Minor");

        //დაწერეთ პროგრამა, რომელიც შეეკითხება მომხმარებელს ქულას და გამოიტანს შესაბამის
        //    შეფასებას. 91 - 100->A; 81 - 90->B, 71-> 80: C, 61 - 70->D, 51 - 60->E, 
        //    0 - 50->ჩაიჭრა.გამოიყენეთ ორივე - if/else if/else .
        Console.Write("Enter your points: ");
        var p = int.Parse(Console.ReadLine());
        String result = "";
        if (p <= 50) result = "F";
        else if (60 >= p && p >= 51) result = "E";
        else if (70 >= p && p >= 61) result = "D";
        else if (80 >= p && p >= 71) result = "C";
        else if (90 >= p && p >= 81) result = "B";
        else if (100 >= p && p >= 91) result = "A";
        Console.WriteLine("Your letter grade is: " + result);

        //დაწერეთ პროგრამა, რომელიც მიიღებს შეფასებას(A, B, C, D ან F) ინფუთის სახით და
        //      დაბეჭდავს შესაბამის შეტყობინებას. მაგალითად, თუ ინფუთი არის "A", უნდა 
        //      დაბეჭდოს "შესანიშნავი!"
        Console.Write("Enter your leter grade: ");
        String g = Console.ReadLine();
        String result1 = "";
        switch (g)
        {
            case "A":
                result1 = "Excelent";
                break;
            case "B":
                result1 = "Good";
                break;
            case "C":
                result1 = "Average";
                break;
            case "D":
                result1 = "Weak";
                break;
            case "E":
                result1 = "Poor";
                break;
            case "F":
                result1 = "Failing";
                break;
        }
        Console.WriteLine(result1);
        //დაწერეთ პროგრამა, რომელიც ინფუთის სახით მიიღებს თვის რიცხვს(1 იანვრისთვის, 
        //    2 თებერვლისთვის და ა.შ.) და ამობეჭდავს დღეების რაოდენობას ამ თვეში.
        Console.Write("Enter index of a month: ");
        var d = int.Parse(Console.ReadLine());
        int[] arr30 = { 4, 6, 9, 11 };
        int[] arr31 = { 1, 3, 5, 7, 8, 10, 12 };
        int res = 0;
        if (d == 2) res = 28;
        else if (arr30.Contains(d)) res = 30;
        else if (arr31.Contains(d)) res = 31;
        Console.WriteLine(res);
    }

    static void Task_4()
    {
        //1.დაწერეთ პროგრამა რომელიც კონსოლში გამოპრინტავს რიცხვებს 0 დან 10 - ის ჩათვლით.გამოიყენეთ while და for ციკლები.
        int j = 0;
        while (j <= 10)
        {
            Console.WriteLine(j);
            j++;
        }

        for (int i = 0; i <= 10; i++) Console.WriteLine(i);

        //2.დაწერეთ პროგრამა, რომელიც ბეჭდავს ლუწ რიცხვებს 1 - დან 20 - მდე for loop - ის გამოყენებით.
        for (int i = 0; i < 20; i++) if (i % 2 == 0) Console.WriteLine(i);

        //3.დაწერეთ პროგრამა, რომელიც სთხოვს მომხმარებელს შეიყვანოს რიცხვი და დაბეჭდოს "Hello!" იმდენჯერ რამდენსაც უდრის
        //ეს შეყვანილი რიცხვი.
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        int num;
        if (int.TryParse(input, out num))
            for (int i = 0; i < num; i++) Console.WriteLine("Hello!");
        else Console.WriteLine("Invalid input.");

        //4.დაწერეთ პროგრამა, რომელიც გამოთვლის რიცხვების ჯამს 1 - დან 100 - მდე for loop - ის გამოყენებით და დაბეჭდავს
        //შედეგს.
        int result = 0;
        for (int i = 0; i < 100; i++) result += i;
        Console.WriteLine($"Sum: {result}");

        //5.დაწერეთ პროგრამა, რომელიც გამოთვლის კენტი რიცხვების ჯამს 1 - დან 100 - მდე და დაბეჭდავს შედეგს.
        int resultOdd = 0;
        for (int i = 0; i < 100; i++) if (i % 2 != 0) resultOdd += i;
        Console.WriteLine($"Sum: {resultOdd}");

        //6.დაწერეთ პროგრამა, რომელიც სთხოვს მომხმარებელს გამოიცნოს საიდუმლო რიცხვი 1 - დან 10 - მდე.განაგრძეთ
        //გამოცნობის მოთხოვნა, სანამ ისინი სწორად გამოიცნობენ, while loop - ის გამოყენებით.
        bool b = true;
        int secretNum = new Random().Next(1, 10);

        while (b)
        {
            Console.Write("Guess the number between 1 and 9: ");
            string input6 = Console.ReadLine();
            int output6;
            if (int.TryParse(input6, out output6))
            {
                if (output6 == secretNum)
                {
                    Console.WriteLine("Congrats! you guessed it!");
                    b = false;
                }
                else
                {
                    Console.WriteLine("No! try again!");
                }

            }
        }

        //7)დაწერეთ პროგრამა, რომელიც შეეკითხება მომხმარებელს ქულას და გამოიტანს შესაბამის შეფასებას. 91 - 100->A;
        //81 - 90->B, 71-> 80: C, 61 - 70->D, 51 - 60->E, 0 - 50->ჩაიჭრა.გამოიყენეთ ორივე - if/else if/else ,switch-case
        Console.Write("Enter your points: ");
        String input7 = Console.ReadLine();
        int p;
        String result7 = "";
        if (int.TryParse(input7, out p))
        {
            switch (p)
            {
                case <= 50:
                    result7 = "F";
                    break;
                case >= 51 and <= 60:
                    result7 = "E";
                    break;
                case >= 61 and <= 70:
                    result7 = "D";
                    break;
                case >= 71 and <= 80:
                    result7 = "C";
                    break;
                case >= 81 and <= 90:
                    result7 = "B";
                    break;
                case >= 91 and <= 100:
                    result7 = "A";
                    break;
            }

            Console.WriteLine($"Your letter grade is: {result7}");
        }

        //8)დაწერეთ პროგრამა, რომელიც მიიღებს შეფასებას(A, B, C, D ან F) ინფუთის სახით და დაბეჭდავს შესაბამის შეტყობინებას.
        //მაგალითად, თუ ინფუთი არის "A", უნდა დაბეჭდოს "შესანიშნავი!" გამოიყენეთ switch-case
        Console.Write("Enter your leter grade: ");
        String g = Console.ReadLine();
        String result8 = "";
        switch (g)
        {
            case "A":
                result8 = "Excelent";
                break;
            case "B":
                result8 = "Good";
                break;
            case "C":
                result8 = "Average";
                break;
            case "D":
                result8 = "Weak";
                break;
            case "E":
                result8 = "Poor";
                break;
            case "F":
                result8 = "Failing";
                break;
        }
        Console.WriteLine(result8);

        //9)დაწერეთ პროგრამა, რომელიც ინფუთის სახით მიიღებს თვის რიცხვს(1 იანვრისთვის, 2 თებერვლისთვის და ა.შ.)
        //და ამობეჭდავს დღეების რაოდენობას ამ თვეში. გამოიყენეთ  switch-case
        Console.Write("Enter index of a month: ");
        String input9 = Console.ReadLine();
        int d;
        int res = 0;
        if (int.TryParse(input9, out d))
        {
            switch (d)
            {
                case 2:
                    res = 28;
                    break;
                case 4 or 6 or 9 or 11:
                    res = 30;
                    break;
                case 1 or 3 or 5 or 7 or 8 or 10 or 12:
                    res = 31;
                    break;
            }
            Console.WriteLine(res);
        }
    }

    static void Task_5()
    {
        int a = 10;
        double b = a;
        long c = a;
        float d = c;

        double x = 1.23;
        int y = (int)x;
        float f = 123.456f;
        short s = (short)f;
        long big = 99999999;
        int small = (int)big;

        int n1 = Convert.ToInt32("123");
        double n2 = Convert.ToDouble(12.3);
        bool flag = Convert.ToBoolean("true");

        string input = "42";
        int value;
        int.TryParse(input, out value);

        bool ok = true;
        string bs = ok.ToString();
        int boolToInt = Convert.ToInt32(ok);
        Console.WriteLine(boolToInt);

        int ii = 10;
        double dd = ii;
        float ff = (float)dd;
        long ll = Convert.ToInt64(ff);
        string ss = ll.ToString();
        bool bb = Convert.ToBoolean(0);
    }

    //==============Task_6 methods==============
    //1.დაწერეთ ფუქნცია, სახელად sayHello, რომელიც დაპრინტავს - "Hello, World".
    static void sayHello()
    {
        Console.WriteLine("Hello, World");
    }
    //2.დაწერეთ ფუნქცია, სახელად greet, რომელიც პარამეტრა მიიღებს სახელს და დაპრინტავს - "გამარჯობა, [სახელი]"
    static void greet(String name)
    {
        Console.WriteLine($"Hello, {name}");
    }
    //3.დაწერეთ ფუნქცია, სახელად sum, რომელიც არგუმენტებად მიიღებს ორ რიცხვს და დააბრუნებს მათ ჯამს. შედეგი გამოიტანეთ
    //ტერმინალში.
    static int sum(int a,int b)
    {
        return a + b;
    }
    //4.დაწერეთ ფუნქცია, სახელად calculateArea, რომელიც არგუმენტად მიიღებს ოთხკუთხედის სიგრესა და სიგანეს და დააბრუნებს
    //მის ფართობს. შედეგი გამოიტანეთ ტერმინალში.
    static int calculateArea(int a,int b)
    {
        return a * b;
    }
    //5.დაწერეთ ფუნქცია, რომელიც მიიღებს ორ არგუმენტს და დააბრუნებს მათ შორის უდიდესს.
    static int maxNumber(int a, int b)
    {
        return Math.Max(a,b);
    }
    //6.დაწერეთ ფუქნცია, რომელიც პარამეტრად მიიღებს იმ რაოდენობას, რამდენჯერად უნდა გამოკონსოლდეს "Hello, World".
    static void repeatHelloWordl(int a)
    {
        for (int i = 0; i < a; i++) Console.WriteLine("Hello, World");
    }
    //7.დაწერეთ ფუქნცია, სახელად celsiusToFahrenheit, რომელიც პარამეტრად მიიღებს ცელსიუსს და გადაიყვანს ფარენჰეიტში.
    //ფორმულა - (Celsius * 9 / 5) + 32
    static double celsiusToFahrenheit(double celsius) 
    {
        return (celsius * 9 / 5) + 32;
    }
    //8.დაწერეთ ფუნქცია სახელად sumDigits, რომელიც არგუმენტად იღებს რიცხვს და აბრუნებს მისი ციფრების ჯამს.
    static int sumDigits(int num) 
    {
        int result = 0;
        String stNum = num.ToString();
        for (int i = 0; i < stNum.Length; i++) 
        {
            result +=Convert.ToInt32(stNum[i].ToString());
        }
        return result;
    }
    //9.დაწერეთ ფუნქცია სახელად countBs, რომელიც იღებს სტრიქონს თავის ერთადერთ არგუმენტად და აბრუნებს სტრიქონში დიდი
    //"B" სიმბოლოების რაოდენობას.
    static int countBs(String text)
    {
        int result = 0;
        foreach (char c in text.ToCharArray())
            if (c.ToString().Equals("B"))
                result++;
        return result;
    }
    //10.დაწერეთ ფუნქცია, რომელიც მიიღებს ორ პარამეტრს და დააჯამებს ყველა რიცხვს გარკვეულ შუალედში. მაგალითად შეკრიბავს
    //რიცხვებს 5 - დან 100 - მდე.
    static int sumInRange(int a,int b)
    {
        int result = 0;
        for (int i = Math.Min(a, b); i < Math.Max(a, b); i++)
            result += i;
        return result;
    }
    //11.დაწერეთ ფუნქცია, რომელიც პარამეტრად მიიღებს სტრინგს და დააბრუნებს true - ს თუ სტრინგი არის პალინდრომი(თავიდან
    //და ბოლოდან იგივენარიად იწერება) და false - ს თუ არაა პალინდრომი.
    static bool isPalendrome(String word)
    {
        if (word == null)
            return false;
        return new string(word.Reverse().ToArray()).Equals(word);
    }

    static void Task_6() 
    {
        sayHello();

        greet("Saba");

        Console.WriteLine(sum(2, 5));

        Console.WriteLine(calculateArea(4, 5));

        Console.WriteLine(maxNumber(25, 32));

        repeatHelloWordl(4);

        Console.WriteLine(celsiusToFahrenheit(25.2));

        Console.WriteLine(sumDigits(1121));

        Console.WriteLine(countBs("abbBBB123"));

        Console.WriteLine(sumInRange(5, 100));

        Console.WriteLine(isPalendrome("abba"));
    }

    static bool isArraySorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1]) return false;
        }
        return true;
    }

    static int[] removeElement(int[] array,int intToRemove)
    {
        int[] newArray = new int[array.Length - 1];
        int indexToRemove = -1;

        for (int i = 0; i < array.Length; i++)
            if (array[i] == intToRemove)
                indexToRemove = i;

        for (int i = 0; i < indexToRemove; i++)
            newArray[i] = array[i];

        for (int i = indexToRemove + 1; i < array.Length; i++)
            newArray[i - 1] = array[i];

        return newArray;
    }

    static bool areArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++)
            if (arr1[i] != arr2[i])
                return false;
        return true;
    }

    static void sortArray(int[] arr)
    {
        while (!isArraySorted(arr))
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
        }
    }

    static int[] mergeAndSortArrays(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
            result[i] = arr1[i];
        for (int i = 0; i < arr2.Length; i++)
            result[i+arr1.Length] = arr2[i];
        sortArray(result);
        return result;
    }

    static int findCommonElement(int[][] arr)
    {
        int common = 0;
        int count;
        for (int i = 0; i < arr[0].Length; i++)
        {    
            common = arr[0][i];
            count = 0;
            for (int j = 1; j < arr.Length; j++)
            {
                if (arrayContainsInt(common, arr[j])) count++;
                else break;
            }
            if (count==arr.Length-1) break;
        }
        return common;
    }

    static bool arrayContainsInt(int a, int[] arr)
    {
        foreach (int i in arr)
            if (a == i)
                return true;
        return false;
    }

    static void Task_7()
    {
        int[] array = { 4, 1, 7, 9, 2, 6, 8, 3, 5 };
        //1.დაწერეთ პროგრამა, რომ იპოვოთ მასივის ყველა რიცხვის ჯამი.
        int sum1 = 0;
        foreach (int i in array) sum1 += i;
        Console.WriteLine($"#1: {sum1}");

        //2.დაწერეთ პროგრამა მასივში რიცხვების საშუალოს საპოვნელად.
        int sum2 = 0;
        foreach (int i in array) sum2 += i;
        Console.WriteLine($"#2: {sum2 / array.Length}");

        //3.დაწერეთ პროგრამა რიცხვების მასივის ზრდის მიხედვით დასალაგებლად.
        //Array.Sort(array);
        sortArray(array);
        Console.WriteLine($"#3: {isArraySorted(array)}");
        Array.ForEach(array, Console.Write);
        Console.WriteLine();
        
        //4.დაწერეთ პროგრამა მასივში ყველაზე დიდი ელემენტის მოსაძებნად.
        int max = array[0];
        foreach (int i in array) if (max < i) max = i;
        Console.WriteLine($"#4: {max}");
        
        //5.დაწერეთ პროგრამა მასივის ყველაზე პატარა ელემენტის მოსაძებნად.
        int min = array[0];
        foreach (int i in array) if (min > i) min = i;
        Console.WriteLine($"#5: {min}");

        //6.დაწერეთ პროგრამა, რათა შეამოწმოთ, შეიცავს თუ არა მასივი კონკრეტულ ელემენტს.
        Console.WriteLine("#6: ");
        int num5 = 5;
        bool result5 = false;
        foreach (int i in array) 
            if (num5 == i) result5 = true;
        Console.WriteLine(result5 ? $"array contains number {num5}" : $"array does not contain number {num5}");

        //7.დაწერეთ პროგრამა მასივიდან ელემენტის ამოსაღებად.
        int[] result7 = removeElement(array, 4);
        Console.WriteLine("#7: ");
        Array.ForEach(result7, Console.Write);
        Console.WriteLine();
        
        //8.დაწერეთ პროგრამა მასივში კონკრეტული ელემენტის გავრცელების რაოდენობის დასათვლელად.
        int[] array8 = { 1, 1, 1, 6, 2, 3, 4, 5, 6, 2, 3 };
        int count = 0;
        int num8 = 1;
        foreach (int i in array8) if (i == num8) count++;
        Console.WriteLine($"#8: number {num8} appears {count} times");

        //9.დაწერეთ პროგრამა, რომ იპოვოთ მასივის ყველა ლუწი რიცხვის ჯამი.
        int result9 = 0;
        foreach (int i in array)
            if (i % 2 == 0) result9 += i;
        Console.WriteLine($"#9: {result9}");
        
        //10.დაწერეთ პროგრამა მასივში სიდიდით მეორე რიცხვის მოსაძებნად.
        removeElement(array, max);
        int newMax = array[0];
        foreach (int i in array) if (newMax < i) newMax = i;
        Console.WriteLine($"#10: {newMax}");
        
        //11.დაწერეთ პროგრამა, რათა შეამოწმოთ არის თუ არა ორი მასივი ტოლი.
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 1, 2, 4 };
        
        Console.WriteLine($"#11: {areArraysEqual(arr1, arr2)}");

        //12.დაწერეთ პროგრამა რომ ორი სორტირებული მასივის შერთდეს და გახდეს ერთი მასივი რომელიც ასევე სორტირებული იქნება.

        int[] mergSortedArr = mergeAndSortArrays(arr1, arr2);

        Console.WriteLine("#12: ");
        Array.ForEach(mergSortedArr, Console.Write);
        Console.WriteLine();

        //13.დაწერეთ პროგრამა სტრიქონების მასივის ანბანის მიხედვით დასალაგებლად.
        string[] words = { "apple", "house", "train", "river", "light" };
        Array.Sort(words);

        Console.WriteLine("#13: ");
        Array.ForEach(words, Console.Write);
        Console.WriteLine();

        //14.დაწერეთ პროგრამა მრავალ მასივებს შორის საერთო ელემენტების მოსაძებნად.
        int[][] arrays = {
            new int[] { 7, 12, 18, 26 },
            new int[] { 3, 7, 19, 41 },
            new int[] { 5, 22, 7, 33 },
            new int[] { 7, 14, 29, 55 }
        };
        Console.WriteLine($"#13: {findCommonElement(arrays)}");
    }

    private static void Main(string[] args)
    {

        Task_7();

    }
}