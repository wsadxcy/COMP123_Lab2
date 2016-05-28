using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /**
     * This class is the driver class for the program
     * 
     * @class program
     */
    public class Program
    {
        /**
         * the main method for my driver class
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class
            Person Nick = new Person();
            // set a value in the Name property for the Person class
            Nick.Name = "Nick";
            Nick.Age = 27;
            // get the Name value and print to console
            //Console.WriteLine(Nick.Name);
            Nick.SaysHello();
            Nick.ShowAge();

            Person John = new Person("John", 50);
            John.SaysHello();
            John.ShowAge();

        }
    }
}
