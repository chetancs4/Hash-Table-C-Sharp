namespace HashTable
{

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(10);

            // Inserting key-value pairs
            hashTable.Insert(5, "Value 1");
            hashTable.Insert(15, "Value 2");
            hashTable.Insert(25, "Value 3");

            // Retrieving values
            Console.WriteLine("Value for key 5: " + hashTable.GetValue(5));
            Console.WriteLine("Value for key 15: " + hashTable.GetValue(15));
            Console.WriteLine("Value for key 25: " + hashTable.GetValue(25));

            // Removing a key-value pair
            hashTable.Remove(15);

            // Retrieving values after removal
            Console.WriteLine("Value for key 15 after removal: " + hashTable.GetValue(15));
        }
    }
}
