using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Task_3();

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
            Console.WriteLine("length of a text is: "+ text.Length);
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
            Console.WriteLine("Product of "+ x.ToString()+"*"+y.ToString()+" is: "+ (x * y));
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
            else{
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
            Console.WriteLine("Doubled value of " + i.ToString() + " is: " + i*2);

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
            else if(100 >= p && p >= 91) result = "A";
            Console.WriteLine("Your letter grade is: "+result);

            //დაწერეთ პროგრამა, რომელიც მიიღებს შეფასებას(A, B, C, D ან F) ინფუთის სახით და
            //      დაბეჭდავს შესაბამის შეტყობინებას. მაგალითად, თუ ინფუთი არის "A", უნდა 
            //      დაბეჭდოს "შესანიშნავი!"
            Console.Write("Enter your leter grade: ");
            String g = Console.ReadLine();
            String result1 = "";
            switch (g) 
            {
                case "A": result1 = "Excelent";
                    break;
                case "B": result1 = "Good";
                    break;
                case "C": result1 = "Average";
                    break;
                case "D": result1 = "Weak";
                    break;
                case "E": result1 = "Poor";
                    break;
                case "F": result1 = "Failing";
                    break;
            }
            Console.WriteLine(result1);
            //დაწერეთ პროგრამა, რომელიც ინფუთის სახით მიიღებს თვის რიცხვს(1 იანვრისთვის, 
            //    2 თებერვლისთვის და ა.შ.) და ამობეჭდავს დღეების რაოდენობას ამ თვეში.
            Console.Write("Enter index of a month: ");
            var d = int.Parse(Console.ReadLine());
            int[] arr30 = { 4, 6, 9, 11 };
            int[] arr31 = { 1, 3, 5, 7, 8,10,12 };
            int res = 0;
            if (d == 2) res = 28;
            else if (arr30.Contains(d)) res = 30;
            else if (arr31.Contains(d)) res = 31;
            Console.WriteLine(res);
        }
    }
}