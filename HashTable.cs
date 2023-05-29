namespace HashTable
{

    using System;
    using System.Collections.Generic;

    class HashTable
    {
        private LinkedList<KeyValuePair<int, string>>[] table;
        private int size;

        public HashTable(int initialSize)
        {
            size = initialSize;
            table = new LinkedList<KeyValuePair<int, string>>[size];
        }

        private int GetHash(int key)
        {
            return key % size;
        }

        public void Insert(int key, string value)
        {
            int index = GetHash(key);

            if (table[index] == null)
            {
                table[index] = new LinkedList<KeyValuePair<int, string>>();
            }

            foreach (KeyValuePair<int, string> pair in table[index])
            {
                if (pair.Key == key)
                {
                    throw new ArgumentException("Key already exists in the hash table.");
                }
            }

            table[index].AddLast(new KeyValuePair<int, string>(key, value));
        }

        public bool Remove(int key)
        {
            int index = GetHash(key);

            if (table[index] != null)
            {
                LinkedListNode<KeyValuePair<int, string>> currentNode = table[index].First;

                while (currentNode != null)
                {
                    if (currentNode.Value.Key == key)
                    {
                        table[index].Remove(currentNode);
                        return true;
                    }

                    currentNode = currentNode.Next;
                }
            }

            return false;
        }

        public string GetValue(int key)
        {
            int index = GetHash(key);

            if (table[index] != null)
            {
                foreach (KeyValuePair<int, string> pair in table[index])
                {
                    if (pair.Key == key)
                    {
                        return pair.Value;
                    }
                }
            }

            return null;
        }
    }
}
