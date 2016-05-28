using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /**
     * This class define a Person
     * 
     * @class Person
     * @field {string} _name 
     */

    public class Person
    {
        // PRIVATE INSTANCE VARIABLES
        private string _name;
        private int _age;
        // PUBLIC PROPERTIES
        /**
         * This is a public property for private _name field
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /**
         * <summary>
         * This is a public property for our private _age field
         * </summary>
         * 
         * @property {int} Age
         */
        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }

        // CONSTRUCTORS
        /**
         * <summary>
         * This is the default empty constructor for the Person class
         * </summary>
         * 
         * @Constructor Person
         */
        public Person()
        {
            this.Name = "unknown name";
            this.Age = 0;
        }

        /**
         *<summary>
         * This is a constructor that takes name as a param and passes it to the _name Instance Variable 
         *</summary>
         * 
         * @Constructor Person
         * @param {String}name
         */
        public Person(string name)
        {
            this.Name = name;

            this.SaysHello();
        }

        /** <summary>
         * This is a constructor that takes both name and age as parameters.
         * It assigns the local name value to the Name property.
         * It assigns the local age value to the age property.
         * </summary>
         * 
         * @constructor Person
         * @param {string} name
         * @param {int} age
         */
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        /**
         * <summary>
         * This is a constructor that takes age as a parameter and passes
         * it to the _age private isntance variable
         * </summary>
         * 
         * @constructor Person
         * @param {int} age
         */
        public Person(int age)
        {
            this.Name = "unknown name!";
            this.Age = age;
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method outputs the _name value + " says hello!" to the console.
         * </summary>
         * 
         * @method SaysHello
         * @returns {void}
         */
        public void SaysHello()
        {
            Console.WriteLine(this.Name + " says hello!");
        }

        /**
         * <summary>
         * This method outputs _name + " is " + _age + " years old".
         * </summary>
         * 
         * @method ShowAge
         * @returns {void}
         */
        public void ShowAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " years old.");
        }
    }
}
