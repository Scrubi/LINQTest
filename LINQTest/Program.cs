using System;
using System.Collections.Generic;
using TestDataGeneratorLibrary;
using System.Linq;

namespace LINQTest
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<Person> people = GenerateListOfPeople();

            //var ages = people.Where(x => x.FirstName.StartsWith("S")&& x.Age.ToString().Contains(5.ToString())).ToList();
            var S = from person in people
                    where (Convert.ToString(person.FirstName[0]) == "S")
                    select person;
            //Console.WriteLine("Random Persons:\n");
            //PrintPerson();

            //Console.WriteLine("\nList of randomly generated people:\n");
            //PrintPeople();

            //Console.WriteLine("\nList of 200 People:\n");
            //GenerateListOfPeople();

            people.Add(TestDataGenerator.GenerateRandomPerson(Person.Gender.Female, "Sassy", null));
            foreach (var person in S) 
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age}, {person.gender}");
            }
            
            
            //{ FirstName = "Sasha", LastName = "Test", Age = 20, gender = Person.Gender.Female}
           
            Console.ReadKey();
        }

        public static void PrintPerson() 
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(TestDataGenerator.GenerateRandomPerson());
            }
        }

        public static void PrintPeople() 
        {
            List<Person> personList = new List<Person>();
           
            for (int i = 0; i < 25; i++)
            {
                
                Person persons = TestDataGenerator.GenerateRandomPerson();
                personList.Add(persons);
                Console.WriteLine(persons);
               
            }
            
            Console.WriteLine($"\nThis List had {personList.Count} people.");
        }
        
        
        public static List<Person> GenerateListOfPeople() 
        {
            int PeopleAmount = 200;
            List<Person> people = new List<Person>();

            for (int i = 0; i < PeopleAmount; i++)
            {
                Person peoples = TestDataGenerator.GenerateRandomPerson();
                people.Add(peoples);
                
            }
            return people;
        }
    }
}
