using System;

namespace GenericStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            Console.WriteLine(myList.Length);
            myList.Add(54);
            myList.Add(45);
            Console.WriteLine(myList.Length);
            foreach (int item in myList.Items)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
