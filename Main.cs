using AlgoUni_Tasks;
using System;
using System.Diagnostics.Metrics;
using System.Xml.Serialization;

internal class Program
{
   
        private static void Main(string[] args)
    {
        //1) შექმენით Person კლასი, რომელსაც ექნება   სახელი,გვარი,ასაკი ,სასწავლებელი(სადაც ის სწავლობს) . შევქმნათ 2 კონსტრუქტორი.
        //1 რომელშიც იქნება 4ივე ინფორმაცია გადმოსაცემი და სრულად შეივსება ყველა ინფორმაცია.და მეორე კონსტრუქტორი, რომელშიც პირველი
        //3 ინფორმაცია იქნება შესაყვანი, სასწავლებელს კი Default ად AlgoUni მიენიჭება.   ამის მერე პროგრამ კლასში შექმენით Person კლასის
        //ინსტანსი, და დააკონსოლეთ ყველა ინფორმაცია

        Person p = new Person("Saba", "Sulakvelidze", 31, "Not AlgoUni");

        Console.WriteLine(p.toString());

        Console.WriteLine("===========");

        Person p1 = new Person("Saba", "Sulakvelidze", 31);

        Console.WriteLine(p1.toString());

        //2) შექმენით Cat კლასი,რომელსაც ექნება სახელი,ასაკი და მეთოდი სახელად Speak რომელიც დაპრინტავს " meow" ,გამოიყენეთ კონსტრუქტორი.
        //შექმენით პროგრამ კლასში რამდენიმე Cat კლასის ინსტანსი, და გამოიძახეთ მეთოდი Speak.
        Console.WriteLine("===========");
        Cat c = new Cat();

        c.speak();

        //3) შექმენით BankInfo კლასი, რომელშიც იქნება ბალანსი,(პრივატული ცვლადი) , და 2 მეთოდი , თანხის შემოტანის მეთოდი,
        //და თანხის გატანის.პირველი მეთოდი ბალანსს უნდა ამატებდეს მაგ თანხას, ხოლო გატანის შემთხვევაში პირიქით, აკლდებოდეს .
        //შექმენით პროგრამ კლასში შესაბამისი კლასის ინსტანსი, და გამოიძახეთ ორივე მეთოდი

        Console.WriteLine("===========");
        BankInfo b = new BankInfo();

        b.addBalance(1000);

        b.subtractBalance(600);

        b.checkBalance();

        Console.WriteLine("===========");
    }
}