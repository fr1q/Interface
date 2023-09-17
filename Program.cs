using System.Security.Cryptography.X509Certificates;

namespace Интерфейс
{
     public class Human
        {
            public string? Name { get; set; }   
            public int Age { get; set; }
            public Human(string? name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
            public override string ToString()
            {
                return $"{Name}";
            }
        }
        public interface Iworker
        {
            string? job();
            void work();

        }
        public interface ISalary
        {
            int Salary { get; }
            string getSalaryInfo();
            void setSalary(int salsry);
        }
        public class Worker : Human
        {
        protected string? _job;
        protected int _salary;

            public string? Job { set
                {
                    if ((value ?? "").Contains(' '))
                    _job = "работаю";
                    else _job = value;
                } }
            public int Salary { set
                {
                    if (value < 0)
                    _salary = 0;
                    else _salary = value;
                } }
            public Worker(string? name, int age, string? job)
            : base(name, age)
        { Job= job; }
            
        public void Work()
        {
            Salary = _salary;
            Console.WriteLine($"{this} : {_job}");
        }
        public string getSalaryInfo()
        {
            return $"{this} : {_salary} денег";
        }
            
        }
    internal class Program
    {

        static void Main(string[] args)
        {
            Worker sasha = new("Саша", 30, "кручу");
            Worker anton = new("Антон", 25, "стучу");
            Worker[] workers = { anton, sasha };
            anton.Salary = 200;
            sasha.Salary = 350;
            foreach (Worker worker in workers)
                worker.Work();
            Console.WriteLine("\n\n");
            foreach (Worker worker in workers)
                Console.WriteLine(
                    worker.getSalaryInfo()
                    );

        }
    }
}