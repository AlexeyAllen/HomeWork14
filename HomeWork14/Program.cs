using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Разработать абстрактный класс Animal, производные классы Cat и Dog.
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.AnimalName = "Барсик";
            cat.ShowInfo();

            Dog dog = new Dog();
            dog.AnimalName = "Дружок";
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        string name;
        public Animal()
        {
            name = "";
        }
        public abstract string AnimalName { get; set; }
        public abstract void Say();
        public virtual void ShowInfo()
        {
            Console.WriteLine(AnimalName);
            Say();
        }
    }
    public class Cat : Animal
    {
        string name;
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        public override string AnimalName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    public class Dog : Animal
    {
        string name;
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        public override string AnimalName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }

}
