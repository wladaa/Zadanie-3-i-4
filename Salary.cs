using System;
abstract class Employee //Abstract class
{
    public string FullName;
    public int Age;
    public int Skill;
    public int Experience;

    public Employee(string name, int age, int skill, int experience)
    {
        this.FullName = name;
        this.Age = age;
        this.Skill = skill;
        this.Experience = experience;
    }

    public abstract double CalculateSalary();
}


class Driver : Employee //Driver class inheriting from Employee
{
    private const double BaseSalary = 6000;

    public Driver(string name, int age, int skill, int experience) : base(name, age, skill, experience) { }

    public override double CalculateSalary()
    {
        return BaseSalary * 1.1 * Age * Skill * Experience;
    }
}


class Mechanic : Employee //MEchanic class inheriting from Employee
{
    private const double BaseSalary = 5000;

    public Mechanic(string name, int age, int skill, int experience) : base(name, age, skill, experience) { }

    public override double CalculateSalary()
    {
        return BaseSalary * 1.1 * Age * Skill * Experience;
    }
}


class Service : Employee //Service class inheriting from Employee
{
    private const double BaseSalary = 4000;

    public Service(string name, int age, int skill, int experience) : base(name, age, skill, experience) { }

    public override double CalculateSalary()
    {
        return BaseSalary * 0.1 * Age * Skill * Experience;
    }
}




class Program
{
    static void Main(string[] args)  //Providing the required information about the employee
    {
        Console.WriteLine("Enter the employee's full name:");
        string name = Console.ReadLine();

        Console.WriteLine("Choose the job (1.Driver, 2.Mechanic, 3.Service):");
        int job = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee's age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee's skill  level from 1 to 5");
        int skill = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee's experience from 1 to 3 ");
        int experience = int.Parse(Console.ReadLine());


        Employee employee;


        switch (job)
        {
            case 1:
                employee = new Driver(name, age, skill, experience);
                break;
            case 2:
                employee = new Mechanic(name, age, skill, experience);
                break;
            case 3:
                employee = new Service(name, age, skill, experience);
                break;
            default:
                Console.WriteLine("Error.");
                return;
        }


        double salary = employee.CalculateSalary(); //CAlculating an employee's salary
        Console.WriteLine($"Employee: {employee.FullName}, earns: {salary} PLN.");
    }
}
