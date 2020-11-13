using System;

namespace DelegateApp
{
    public delegate string AddDel(string str);
    public delegate string RemoveDel(string str);
    class Program
    {

        static void Main(string[] args)
        {
            var delTest = new TestDelegate();
            AddDel addDel = delTest.Space;
            RemoveDel delRemove = delTest.Reverse;

            Console.WriteLine(addDel("Congratulations"));
            Console.WriteLine(delRemove("Congratulations"));


        }
    }
}
