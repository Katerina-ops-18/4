using System;
using System.Diagnostics;

namespace Lab4_3
{
    class Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual void getInfo()
        {
            // Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}\n");
            Debug.WriteLine($"Name: {this.Name}\nAge: {this.Age}\n");
        }
    }

    class Employee : Person
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Employee() : base()
        {

        }
        public Employee(string name, int age, double salary) : base(name, age)
        {
            this.Salary = salary;
        }
        public override void getInfo()
        {
            // Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}");
            Debug.WriteLine($"Name: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Evgen Petrovych", 54);
            person.getInfo();

            Employee employee = new Employee("Another one", 15, 300.533);
            employee.getInfo();

            Person person1 = (Person)person;
            person1.getInfo();

            Employee employee1 = (Employee)employee;
            employee1.getInfo();
        }
    }
}
