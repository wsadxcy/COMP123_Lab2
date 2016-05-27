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
     * @field {int} _age 
     */

    public class Person
    {
        // PRIVATE INSTANCE VARIABLES
        private string _name;

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
         * This is the default empty constructor for the Person class
         * 
         * 
         * @Constructor Person
         */
        public Person()
        {
            this._name = "unknown name";
        }

        /**
         * This is a constructor that takes name as a param and passes it to the _name Instance Variable 
         *
         * @Constructor Person
         * @param {String}name
         */
        public Person(string name)
        {
            this._name = name;
        }
    }
}
