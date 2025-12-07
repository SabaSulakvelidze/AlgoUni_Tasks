using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    //3) შექმენით BankInfo კლასი, რომელშიც იქნება ბალანსი,(პრივატული ცვლადი) , და 2 მეთოდი , თანხის შემოტანის მეთოდი,
    //და თანხის გატანის.პირველი მეთოდი ბალანსს უნდა ამატებდეს მაგ თანხას, ხოლო გატანის შემთხვევაში პირიქით, აკლდებოდეს .
    //შექმენით პროგრამ კლასში შესაბამისი კლასის ინსტანსი, და გამოიძახეთ ორივე მეთოდი
    internal class BankInfo
    {
        private double balance;

        public void checkBalance() 
        {
            Console.WriteLine($"Yopur balance is: {balance}");
        }

        public void addBalance(double amount)
        {
            this.balance += amount;
        }

        public void subtractBalance(double amount)
        {
            this.balance -= amount;
        }


    }
}
