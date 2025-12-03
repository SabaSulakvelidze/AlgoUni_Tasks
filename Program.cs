Tasks();

static void Tasks()
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
