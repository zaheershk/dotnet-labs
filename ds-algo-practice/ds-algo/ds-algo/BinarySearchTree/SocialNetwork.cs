using System;
using System.Collections.Generic;
using System.Text;

namespace ds_algo.BinarySearchTree
{
    public class Person
    {
        private List<Person> _connectionList = new List<Person>();

        public string Name { get; set; }

        public List<Person> Connections
        {
            get
            {
                return _connectionList;
            }
        }

        public Person(string name)
        {
            Name = name;
        }

        public void IsConnectionOf(Person p)
        {
            _connectionList.Add(p);
        }
    }
}
