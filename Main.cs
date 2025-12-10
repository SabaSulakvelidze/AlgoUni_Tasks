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
        Laptop laptop = new Laptop("HP Spectre x360", 16);

        //7. შექმენით კლასი `Phone`, რომელიც მიიღებს ტელეფონის მოდელს და ფერს კონსტრუქტორის მეშვეობით და გამოიყენებს ფროფერთებს მოდელის და ფერისთვის.
        Phone phone = new Phone("IPhone 11","Red");

        //8. შექმენით კლასი `Movie`, რომლის კონსტრუქტორი მიიღებს სათაურს და გამოშვების წელს.
        Movie movie = new Movie("The Martian", 2015);

        //9. დაწერეთ კლასი `Employee`, რომლის კონსტრუქტორი მიიღებს თანამშრომლის სახელს და სამუშაო პოზიციას.
        Employee employee = new Employee("ანა მაჩაიძე", "პროგრამისტი");

        //10. შექმენით კლასი `Order`, რომლის კონსტრუქტორს ექნება პარამეტრი პროდუქტის სახელის და რაოდენობის მითითებით.
        Order order1 = new Order("KeyBoard", 2);



        // დავალებები მემკვიდრეობაზე:
        //11. შექმენით კლასები `Animal` და `Dog`. `Dog` მიიღებს მემკვიდრეობით `Animal` კლასის ველებს და დაამატებს თავის თვისებას `Breed`.
        Animal animal = new Animal();
        animal.MakeNoise();

        Dog dog = new Dog();
        dog.MakeNoise();
        dog.Breed();

        //12. დაწერეთ კლასები `Shape` და `Circle`. `Circle` მიიღებს მემკვიდრეობით `Shape`-ის ველს `Color` და დაამატებს `Radius` ფროფერთს.
        Circle circle = new Circle();
        circle.Colour = "Blue";
        circle.Radius = 2;

        //13. დაწერეთ კლასები `Vehicle` და `Bike`, სადაც `Bike` მიიღებს მემკვიდრეობით `Vehicle`-ის ველებს და დაამატებს თავის ველს `Type`.
        Bike bike = new Bike("Harley Devidson","Chopper");
        Console.WriteLine(bike.Manufacturer);
        Console.WriteLine(bike.Type);

        //14. დაწერეთ კლასები `Person` და `Student`. `Student` მიიღებს მემკვიდრეობით `Person`-ის თვისებებს და დაამატებს `Grade` ფროფერთს.
        Student student1 = new Student(31,"Saba","A");
        Console.WriteLine(student1.Name);
        Console.WriteLine(student1.Grade);

        //15. შექმენით კლასები `Employee` და `Manager`, სადაც `Manager` მიიღებს მემკვიდრეობით `Employee`-ის თვისებებს და დაამატებს `TeamSize` ფროფერთს.
        Manager manager = new Manager("John","Sales",5);
        Console.WriteLine(manager.Name);
        Console.WriteLine(manager.Position);
        Console.WriteLine(manager.TeamSize);

        // დავალებები სტატიკური კლასებისა და მეთოდების გამოყენებით:
        //16. შექმენით სტატიკური კლასი `MathHelper`, რომელიც გამოიყენებს სტატიკურ მეთოდს ორი რიცხვის ჯამის დასათვლად.
        //17. დაწერეთ სტატიკური კლასი `StringHelper`, რომელიც შეიცავს სტატიკურ მეთოდს, რომელიც ამოწმებს არის თუ არა სტრიქონი ცარიელი.
        //18. შექმენით სტატიკური კლასი `ConversionHelper`, რომელიც შეიცავს სტატიკურ მეთოდს, რომელიც გადაიყვანს კილომეტრებს მილებში.
        //19. დაწერეთ სტატიკური კლასი `TemperatureConverter`, რომელიც შეიცავს სტატიკურ მეთოდს, რომელიც ცელსიუსებს ფარენჰეიტში გადაიყვანს.
        //20. შექმენით სტატიკური კლასი `Calculator`, რომელიც შეიცავს სტატიკურ მეთოდს, რომელიც აბრუნებს ორნიშნა რიცხვის მაქსიმალურ მნიშვნელობას.

    }
}