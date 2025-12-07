using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    //2) შექმენით Cat კლასი,რომელსაც ექნება სახელი,ასაკი და მეთოდი სახელად Speak რომელიც დაპრინტავს " meow" ,გამოიყენეთ კონსტრუქტორი.
    //შექმენით პროგრამ კლასში რამდენიმე Cat კლასის ინსტანსი, და გამოიძახეთ მეთოდი Speak.
    internal class Cat
    {
        public string name;
        public int age;

        public void speak()
        {
            Console.WriteLine("meow");
        }
    }
}
