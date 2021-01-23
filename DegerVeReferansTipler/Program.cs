using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 nedir? 30
            //int decimal float double bool değertip
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 15, 25, 35 };
            sayilar1 = sayilar2;
            sayilar1[0] = 99;
            //sayilar1[0] elemanı nedir? 99 referans olduğundan
            //array,class, interface ler referans tiplerdir.
            Console.WriteLine(sayilar1[0]);

            Console.WriteLine("------------------");

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Helen";
            person2 = person1;
            person1.FirstName = "Ayten";
            Console.WriteLine(person2.FirstName);
            person2.FirstName = "Derin";
            Console.WriteLine(person1.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Arzu";
            customer.CreditCardNumber = "12345";

            Employee employee = new Employee();
            employee.FirstName = "Eda";

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


         }
    }

    //Base class: Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
