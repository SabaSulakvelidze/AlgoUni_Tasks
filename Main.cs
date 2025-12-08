using AlgoUni_Tasks;
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Xml.Linq;
using System.Xml.Serialization;
using Rectangle = AlgoUni_Tasks.Rectangle;

internal class Program
{
    

    private static void Main(string[] args)
    {
        // დავალებები ველების და ფროფერთების გამოყენებით:
        //1. შექმენით კლასი `Book`, რომელშიც იქნება ველი `title` და ფროფერთი `Title`, რომელიც შეამოწმებს რომ სათაური ცარიელი არ არის.
        Book book = new Book();
        book.Title = "Game of Thrones";
        Console.WriteLine(book.Title);
        book.Title = "";
        Console.WriteLine(book.Title);

        //2. დაწერეთ კლასი `Person`, რომელსაც ექნება ველი `age` და ფროფერთი `Age`, რომელიც შეამოწმებს, რომ ასაკი დადებითია.
        Person person = new Person();
        person.Age = 25;
        Console.WriteLine(person.Age);
        person.Age = -1;
        Console.WriteLine(person.Age);

        //3. შექმენით კლასი `Rectangle`, რომელსაც ექნება ველი `width` და `height` და ფროფერთი, რომელიც დაითვლის მართკუთხედის ფართობს.
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 2;
        rectangle.Height = 4;
        Console.WriteLine(rectangle.Area);

        //4. შექმენით კლასი `Student`, რომელშიც იქნება ველი `name` და ფროფერთი `Name`, რომელიც გამოიყენებს მხოლოდ წაკითხვის რეჟიმს (read-only property).
        Student student = new Student("Saba");
        Console.WriteLine(student.Name);
        //5. დაწერეთ კლასი `Car`, რომელშიც იქნება ველი `speed` და ფროფერთი `Speed`, რომელიც შეამოწმებს, რომ სიჩქარე დადებითია.
        Car car = new Car();
        car.Speed = 0;
        Console.WriteLine(car.Speed);
        car.Speed = 120;
        Console.WriteLine(car.Speed);
        car.Speed = -30;
        Console.WriteLine(car.Speed);

        // დავალებები კონსტრუქტორების გამოყენებით:
        //6. დაწერეთ კლასი `Laptop`, რომლის კონსტრუქტორს გადაეცემა ლეპტოპის მოდელი და ოპერატიული მეხსიერების ზომა.
        //7. შექმენით კლასი `Phone`, რომელიც მიიღებს ტელეფონის მოდელს და ფერს კონსტრუქტორის მეშვეობით და გამოიყენებს ფროფერთებს მოდელის და ფერისთვის.
        //8. შექმენით კლასი `Movie`, რომლის კონსტრუქტორი მიიღებს სათაურს და გამოშვების წელს.
        //9. დაწერეთ კლასი `Employee`, რომლის კონსტრუქტორი მიიღებს თანამშრომლის სახელს და სამუშაო პოზიციას.
        //10. შექმენით კლასი `Order`, რომლის კონსტრუქტორს ექნება პარამეტრი პროდუქტის სახელის და რაოდენობის მითითებით.

        // დავალებები მემკვიდრეობაზე:
        //11. შექმენით კლასები `Animal` და `Dog`. `Dog` მიიღებს მემკვიდრეობით `Animal` კლასის ველებს და დაამატებს თავის თვისებას `Breed`.
        //12. დაწერეთ კლასები `Shape` და `Circle`. `Circle` მიიღებს მემკვიდრეობით `Shape`-ის ველს `Color` და დაამატებს `Radius` ფროფერთს.
        //13. დაწერეთ კლასები `Vehicle` და `Bike`, სადაც `Bike` მიიღებს მემკვიდრეობით `Vehicle`-ის ველებს და დაამატებს თავის ველს `Type`.
        //14. დაწერეთ კლასები `Person` და `Student`. `Student` მიიღებს მემკვიდრეობით `Person`-ის თვისებებს და დაამატებს `Grade` ფროფერთს.
        //15. შექმენით კლასები `Employee` და `Manager`, სადაც `Manager` მიიღებს მემკვიდრეობით `Employee`-ის თვისებებს და დაამატებს `TeamSize` ფროფერთს.

        // დავალებები სტატიკური კლასებისა და მეთოდების გამოყენებით:
        //16. შექმენით სტატიკური კლასი `MathHelper`, რომელიც გამოიყენებს სტატიკურ მეთოდს ორი რიცხვის ჯამის დასათვლად.
        //17. დაწერეთ სტატიკური კლასი `StringHelper`, რომელიც შეიცავს სტატიკურ მეთოდს, რომელიც ამოწმებს არის თუ არა სტრიქონი ცარიელი.
        //18. შექმენით სტატიკური კლასი `ConversionHelper`, რომელიც შეიცავს სტატიკურ მეთოდს, რომელიც გადაიყვანს კილომეტრებს მილებში.
        //19. დაწერეთ სტატიკური კლასი `TemperatureConverter`, რომელიც შეიცავს სტატიკურ მეთოდს, რომელიც ცელსიუსებს ფარენჰეიტში გადაიყვანს.
        //20. შექმენით სტატიკური კლასი `Calculator`, რომელიც შეიცავს სტატიკურ მეთოდს, რომელიც აბრუნებს ორნიშნა რიცხვის მაქსიმალურ მნიშვნელობას.

    }
}