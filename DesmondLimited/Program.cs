using System;
using System.Collections.Generic;
namespace DesmondLimited
{

    public delegate IList<decimal> InterestDel();
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer("Odonkoro", "Danladi", "0045504239", "Wine-Tapper", 6000M, 0.9, 6);
            Customer cust2 = new Customer("Otugbo", "kodo", "4356937898", "wood-splitter", 6000M, 0.5, 2);
            Customer cust3 = new Customer("Samuel", "miele-meile", "7755479799", "Engeneer", 7000M, 0.4, 4);
            Customer cust4 = new Customer("Dogo", "Osemegbe", "0069404239", "Programmer", 1000M, 0.9, 6);
            IList<Customer> customers = new List<Customer>() { cust1, cust2, cust3, cust4 };
            Interest interest = new Interest(customers);

            InterestDel simpleinterestDel = interest.SimpleInterest;

            InterestDel compdInterestDl = interest.CompdInterest;

            IList<decimal> simpInt = simpleinterestDel();
            IList<decimal> compdInterests = compdInterestDl();


            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{customers[i]}\nSimple Interest: {simpInt[i]:C}\nCompound Interest: {compdInterests[i]:C}\n");
            }
        }
    }
}
