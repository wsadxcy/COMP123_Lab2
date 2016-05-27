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
            Person Nick = new Person("Nick");
            // set a value in the Name property for the Person class
            Nick.Name = "Nick";
            // get the Name value and print to console
            Console.WriteLine(Nick.Name);

        }
    }
}
