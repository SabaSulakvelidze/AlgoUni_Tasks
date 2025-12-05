internal class Program
{
    private static void Main(string[] args)
    {
        Task_2();

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
    }
}