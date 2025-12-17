using AlgoUni_Tasks;
using System.ComponentModel;
using System.Linq.Expressions;

internal class Program
{
    delegate void MathOperation(int a,int b);
    delegate int OtherMathOperation(int a,int b);
    delegate void Printer();
    delegate void OtherPrinter(string s);
    delegate bool IsEqual(int a, int b);
    delegate string RemoveLast(string s);
    static void Add(int a, int b)
    {
        Console.WriteLine(a+b);
    }
    static void Subtract(int a, int b)

    {
        Console.WriteLine(a-b);
    }
    
    static void DoSomething(MathOperation m,int a,int b) 
    {
        m(a, b);
    }
    private static void Main(string[] args)
    {
        //1)შექმენი დელეგატი, რომელიც მიუთითებს ორ მეთოდზე: ერთს, რომელიც დაბეჭდავს ორ რიცხვის ჯამს, და მეორეს,
        //რომელიც დაბეჭდავს მათ სხვაობას.
        MathOperation mathOperation = Add;
        mathOperation += Subtract;

        mathOperation(4, 2);

        //2)დაწერე დელეგატი, რომელიც მიიღებს ორ რიცხვს და დააბრუნებს მათ ნამრავლს ლამბდა გამოთქმის(Expression) გამოყენებით.
        OtherMathOperation multiply = (a, b) => a * b;
        Console.WriteLine(multiply(2,5));

        //3)შექმენი დელეგატი, რომელიც მიუთითებს ანონიმურ მეთოდზე, რომელიც დაბეჭდავს "Hello, World!" - ს.
        Printer print = delegate ()
        {
            Console.WriteLine("Hello, World!");
        };

        print();

        //4)შექმენი მეთოდი, რომელიც დელეგატს მიიღებს პარამეტრად და დელეგატის მეშვეობით გამოიძახებს შესაბამის ფუნქციას.გამოიყენე
        //ლამბდა ან ანონიმური მეთოდი.
        DoSomething(Add, 4, 60);

        //5)დაწერე დელეგატი, რომელიც მიიღებს ორ რიცხვს და შეადარებს მათ ლამბდა გამოთქმის(Expression) გამოყენებით.
        IsEqual isEqual = (a, b) => a == b;
        Console.WriteLine(isEqual(1,2));
        Console.WriteLine(isEqual(2,2));

        //6)შექმენი კლასი ორი სტატიკური მეთოდით(დამატება და გამოკლება).შემდეგ შექმენი დელეგატი და მიუთითე ამ მეთოდებზე,
        //რომ ორივე მეთოდი გამოიძახოს.
        MathOperation mathOperation1 = MathClass.Add;
        mathOperation1 += MathClass.Subrtact;

        mathOperation1(5, 3);

        //7)შექმენი დელეგატი, რომელიც ერთდროულად მიუთითებს ორ მეთოდზე(დამატება და გამოკლება). შემდეგ, ამოიღე დამატების
        //მეთოდი და დააკვირდი შედეგს.
        Console.WriteLine("After removal");
        mathOperation1 -= MathClass.Add;
        mathOperation1(2, 3);

        //8)დაწერე დელეგატი, რომელიც მიიღებს სტრიქონს და ანონიმური მეთოდის მეშვეობით მოაჭრის მას ბოლო სიმბოლოს.
        RemoveLast removeLast = (string s) => s.Substring(0, s.Length - 1);
        Console.WriteLine(removeLast("abcdefg"));

        //9)შექმენი დელეგატი, რომელიც მიუთითებს როგორც სტატიკურ, ასევე არასტატიკურ მეთოდებზე და ორივე მეთოდს გამოიძახებს.
        MathOperation mathOperation2 = Add;
        mathOperation2 += MathClass.Add;
        mathOperation2(10, 10);

        //10)დაწერე დელეგატი, რომელიც მიიღებს სტრიქონს და დაბეჭდავს მას ლამბდა გამოთქმის(Expression) გამოყენებით.
        OtherPrinter p = (string s) => Console.WriteLine(s);
        p("qwerty");
    }

    
}