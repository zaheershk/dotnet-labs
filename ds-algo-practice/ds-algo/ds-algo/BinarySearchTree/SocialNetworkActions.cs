using System;
using System.Collections.Generic;
using System.Text;

namespace ds_algo.BinarySearchTree
{
    public static class SocialNetworkActions
    {
        public static Person Initialize()
        {
            Person Eva = new Person("Eva");
            Person Sophia = new Person("Sophia");
            Person Brian = new Person("Brian");
            Eva.IsConnectionOf(Sophia);
            Eva.IsConnectionOf(Brian);

            Person Lisa = new Person("Lisa");
            Person Tina = new Person("Tina");
            Person John = new Person("John");
            Person Mike = new Person("Mike");
            Sophia.IsConnectionOf(Lisa);
            Sophia.IsConnectionOf(John);
            Brian.IsConnectionOf(Tina);
            Brian.IsConnectionOf(Mike);

            return Eva;
        }

        public static void BreadthFirstTraversal(this Person node)
        {
            Queue<Person> traverseQ = new Queue<Person>();

            Queue<Person> connectionQ = new Queue<Person>();
            connectionQ.Enqueue(node);

            HashSet<Person> verifiedConnections = new HashSet<Person>();
            verifiedConnections.Add(node);

            while (connectionQ.Count > 0)
            {
                Person p = connectionQ.Dequeue();
                traverseQ.Enqueue(p);

                foreach (var c in p.Connections)
                {
                    if (!verifiedConnections.Contains(c))
                    {
                        connectionQ.Enqueue(c);
                        verifiedConnections.Add(c);
                    }
                }
            }

            while (traverseQ.Count > 0)
            {
                var person = traverseQ.Dequeue();
                Console.WriteLine(person.Name);
            }
        }

        public static void BreadthFirstSearch(this Person node, string nameToSearch)
        {
            Queue<Person> connectionQ = new Queue<Person>();
            connectionQ.Enqueue(node);

            HashSet<Person> verifiedConnections = new HashSet<Person>();
            verifiedConnections.Add(node);

            while (connectionQ.Count > 0)
            {
                Person p = connectionQ.Dequeue();
                if (p.Name == nameToSearch)
                {
                    Console.WriteLine(p.Name);
                }

                foreach (var c in p.Connections)
                {
                    if (!verifiedConnections.Contains(c))
                    {
                        connectionQ.Enqueue(c);
                        verifiedConnections.Add(c);
                    }
                }
            }
        }

        public static void DepthFirstTraversal(this Person node)
        {
            Console.WriteLine(node.Name);

            foreach (var c in node.Connections)
            {
                DepthFirstTraversal(c);
            }
        }

        public static void DepthFirstSearch(this Person node, string nameToSearch)
        {
            if (node.Name == nameToSearch)
            {
                Console.WriteLine(node.Name);
            }

            foreach (var c in node.Connections)
            {
                DepthFirstSearch(c, nameToSearch);
            }
        }
    }
}
