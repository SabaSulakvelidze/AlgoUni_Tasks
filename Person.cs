using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    //1) შექმენით Person კლასი, რომელსაც ექნება   სახელი,გვარი,ასაკი ,სასწავლებელი(სადაც ის სწავლობს) . შევქმნათ 2 კონსტრუქტორი.
    //1 რომელშიც იქნება 4ივე ინფორმაცია გადმოსაცემი და სრულად შეივსება ყველა ინფორმაცია.და მეორე კონსტრუქტორი, რომელშიც პირველი
    //3 ინფორმაცია იქნება შესაყვანი, სასწავლებელს კი Default ად AlgoUni მიენიჭება.   ამის მერე პროგრამ კლასში შექმენით Person კლასის
    //ინსტანსი, და დააკონსოლეთ ყველა ინფორმაცია
    internal class Person
    {
        public string name;
        public string lastName;
        public int age;
        public string univeristy;

        public Person(string name, string lastName, int age, string univeristy)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.univeristy = univeristy;
        }

        public Person(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.univeristy = "AlgoUni";
        }

        public string toString() 
        {
            return $"""
                name: {name}
                lastName: {lastName}
                age: {age}
                univeristy: {univeristy}
                """;
        }
    }
}
