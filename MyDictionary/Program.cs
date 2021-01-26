using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Mehmet", 1);
            myDictionary.Add("Ayşe", 2);
            myDictionary.Add("Ali", 3);
            myDictionary.List();
        }
    }
}
