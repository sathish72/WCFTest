using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public abstract class Employee
    {
        protected string name;

        public Employee(string name)  // constructor
        {
            this.name = name;
        }

        public abstract void Show();  // abstract show method

        public void ShowWithoutAbstract()
        {
            Console.WriteLine(name);
        }
    }

    public class Manager : Employee
    {
        public Manager(string name) : base(name) { }  // constructor 

        public override void Show()  //override the abstract show method
        {
            System.Console.WriteLine("Name : " + name);
        }
    }

    public class Drawing
    {
        public virtual void Draw()
        {
            Console.WriteLine("Base class draw");
        }
    }

    public class Line: Drawing 
    {
        public new void Draw()
        {
            Console.WriteLine("Sub class draw");
            //base.Draw();
        }
    }
        

    class Program
    {
        static void Main(string[] args)
        {

            Manager m1 = new Manager("H. Ackerman");
            m1.Show();
            m1.ShowWithoutAbstract();
            // Create an instance of Manager and assign it to an Employee reference:
            Employee ee1 = new Manager("M. Knott");
            ee1.Show();  //call the show method of the Manager class


            Drawing dra1 = new Line();
            dra1.Draw();
            Console.ReadKey();
        }
    }
}
