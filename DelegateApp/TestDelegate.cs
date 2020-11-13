using System.Collections.Generic;
namespace DelegateApp
{
    public class TestDelegate
    {
        public string Space(string str)
        {
            string addSpace = "";
            foreach (var item in str)
            {
                addSpace += item + " ";
            }
            return addSpace;
        }

        public string Reverse(string str)
        {
            string output = "";
            Stack<char> reverseSpace = new Stack <char>();
            foreach(var item in str)
            {
                reverseSpace.Push(item);
            }
            foreach (var item in reverseSpace)
            {
                output += item;
            }
            return output;
        }
    }
}