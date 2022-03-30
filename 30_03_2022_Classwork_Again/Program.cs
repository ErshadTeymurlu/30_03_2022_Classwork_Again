using _30_03_2022_Classwork_Again.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_03_2022_Classwork_Again
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Ershad","Teymurlu",20,2,40); 
            emp1.GetInfo();                             
            
            Console.WriteLine("\n-----------------------------------");

            Student std1 = new Student("Huseyin", "Mirzezade", 19, 90, 50);
            std1.GetInfo();
            Console.ReadLine();
        }
    }
}
