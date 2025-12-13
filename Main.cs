using AlgoUni_Tasks;

internal class Program
{
    

        

    private static void Main(string[] args)
    {
        //1) IVehicle ინტერფეისის შექმნა
        //შექმენი ინტერფეისი IVehicle, რომელიც შეიცავს შემდეგ მეთოდებს:

        //Start()
        //Stop()
        //შექმენი ორი კლასი Car და Bicycle, რომლებიც ამ ინტერფეისს იმპლემენტირებენ.

        //გამოიყენე ორივე კლასი პროგრამაში და ჩატარე თითოეული კლასის ობიექტზე Start() და Stop() მეთოდები.
        Car car = new Car();
        car.Start();
        car.Stop();

        Bicycle bicycle = new Bicycle();
        bicycle.Start();
        bicycle.Stop();

        //2) IShape ინტერფეისის შექმნა.
        //შექმენი ინტერფეისი IShape, რომელიც შეიცავს ორ მეთოდს:

        //double CalculateArea()
        //double CalculatePerimeter()
        //შექმენი ორი კლასი Rectangle და Circle, რომლებიც ამ ინტერფეისს იმპლემენტირებენ.

        //გამოითვალე თითოეული კლასის ფართობი და პერიმეტრი და დაბეჭდე კონსოლში
        IShape circle = new Circle(10);
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());

        IShape rectangle = new Rectangle(2, 5);
        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());

        //3)IDrive ინტერფეისის მემკვიდრეობა

        //შექმენი ინტერფეისი IDrive, რომელიც მოიცავს Drive() მეთოდს.
        //შექმენი ინტერფეისი IFly, რომელიც მოიცავს Fly() მეთოდს.
        //შექმენი კლასი FlyingCar, რომელიც იმპლემენტირებს ორივე ინტერფეისს.
        //გამოიყენე ინტერფეისების მეთოდები კლასის ობიექტზე.

        FlyingCar c = new FlyingCar();
        c.Drive();
        c.Fly();


        //4) IWorker ინტერფეისის გამოყენება

        //შექმენი ინტერფეისი IWorker, რომელიც შეიცავს შემდეგ მეთოდებს:

        //Work()
        //GetSalary()
        //შექმენი კლასები Developer და Manager, რომლებიც იმპლემენტირებენ ამ ინტერფეისს.GetSalary() მეთოდი თითოეული კლასისთვის განსხვავებულ ანაზღაურებას აბრუნებს.

        IWorker developer = new Developer();
        developer.Work();
        Console.WriteLine(developer.GetSalary());

        IWorker manager = new Manager();
        manager.Work();
        Console.WriteLine(manager.GetSalary());


        //5) IAnimal ინტერფეისის შექმნა
        //დავალება:

        //შექმენი ინტერფეისი IAnimal, რომელიც მოიცავს:

        //Speak()
        //Eat()
        //შექმენი ორი კლასი Dog და Cat, რომლებიც იმპლემენტირებენ ამ ინტერფეისს.
        Cat cat = new Cat();
        cat.Eat();
        cat.Speak();

        Dog dog = new Dog();
        dog.Eat();
        dog.Speak();

    }
}