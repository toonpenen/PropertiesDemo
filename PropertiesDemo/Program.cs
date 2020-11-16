using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class Student
    {
        private string _name;

        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                this._name = name;
            }
        }
        public string GetName()
        {
            return _name;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student._name = " ";

            Console.WriteLine(student.name);
        }
    }
}
