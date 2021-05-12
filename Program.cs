using System;
using System.Collections.Generic;

namespace EnumeratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string data = Console.ReadLine();

            while (data != "END")
            {
                string[] personData = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personData[0];
                int age = int.Parse(personData[1]);
                string town = personData[2];

                Person person = new Person(name, age, town);
                people.Add(person);
                data = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());  //n is  currIdx from the collection->pointing to currPerson

            Person personCurrentInstance = people[n - 1];// this person is given from imput as instance to compare with other

            int numNotEqaulPeople = 0;
            int countMatches = 0;

            foreach (var person in people)
            {
                if (personCurrentInstance.CompareTo(person) == 0)
                {
                    countMatches++;
                }
                else //!= 0
                {
                    numNotEqaulPeople++;
                }
            }

            if (countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else //matches > 1
            {                
               Console.WriteLine($"{countMatches} {numNotEqaulPeople} {people.Count}");
            }           
        }
    }
}
