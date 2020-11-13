using System;
namespace DesmondLimited
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public string Occupation { get; set; }
        public decimal principal;
        public double rate;
        public int time;

        public Customer(string first, string last, string accountNumber, string occupation, decimal principal, double rate, int time)
        {
            FirstName = first;
            LastName = last;
            AccountNumber = accountNumber;
            Occupation = occupation;
            Principal = principal;
            Rate = rate;
            Time = time;
        }

        public decimal Principal
        {
            get { return principal; }

            set
            {
                if (value > 0)
                {
                    principal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Principal", value, "Must be greater than zeros");
                }
            }
        }
        public double Rate
        {
            get { return rate; }

            set
            {
                if (value > 0 && value < 1)
                {
                    rate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Rate", value, "Must be greater than zeros");
                }
            }
        }

        public int Time
        {
            get { return time; }

            set
            {
                if (value > 0)
                {
                    time = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Time", value, "Must be greater than zeros");
                }
            }
        }

        public override string ToString()
        {
            return $"Customer Name: {FirstName} {LastName}\nAccount Number: {AccountNumber}\nOccupation: {Occupation}";
        }
    }
}