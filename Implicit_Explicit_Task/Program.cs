using System;
using System.Collections;

namespace Implicit_Explicit_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Person obj1 = new Person("Gunel", "Yusubova", 25);
            Person obj2 = new Person("Elchin", "Xelilov", 23);
            Person obj3 = new Person("Sabina", "Quliyeva", 26);
            Person obj4 = new Person("Dilber", "Yusubova", 45);
            Person obj5 = new Person("Turan", "Abdullayev", 12);

            Person[] people = { obj1, obj2, obj3,obj4,obj5 };

            foreach (var item in people)
            {
                for (int i = 0; i < people.Length-1; i++)
                {
                    if (people[i] > people[i+1])
                    {
                        var a = people[i];
                        people[i] = people[i + 1];
                        people[i + 1] = a;
                    }
                }
            }

            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }

            //ArrayList AgeList = new ArrayList() { obj1.Age, obj2.Age, obj3.Age,obj4.Age,obj5.Age };
            //AgeList.Sort();
            //foreach (var item in AgeList)
            //{
            //    Console.WriteLine(item);
            //}
           


            
            //Kelvin K = new Kelvin(50);
            //Celsius C = K;
            //Console.WriteLine(C.Degree);

        }
    }
     class Person
     {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public static bool operator >(Person a, Person b)
        {
      
            return a.Age > b.Age;
        }

        public static bool operator <(Person a, Person b)
        {
            return a.Age < b.Age;
        }

     }

    //class Kelvin
    //{
    //    public double Degree { get; set; }
    //    public Kelvin(double K)
    //    {
    //        Degree = K;
    //    }
    //}

    class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double C)
        {
            Degree = C;
        }
        //public static implicit operator Celsius(Kelvin kelvin)
        //{
        //    return new Celsius(kelvin.Degree - 273.15);
        //}

    }  

}

