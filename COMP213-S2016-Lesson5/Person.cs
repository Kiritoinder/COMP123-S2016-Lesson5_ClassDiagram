using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_Lesson5
{
    /**
     * This class defines a generic person
     * 
     * @class person
     * @field {string} _name 
     * @feild {int} _age
     */
    public class Person
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++
        private string _name;
        private int _age;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * this is property for our private _name field
         * </summary>
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
        // CONSTRUCRORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary 
         * This is a public property for our private _age feild
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

        /**
         * This is a default empty constructor for the person class
         * 
         * @constructor person
         */



        public Person()
        {
            this._initialize();
        }
        public Person(string name)
        {
            this._initialize();
            this.Name = name;
        }
        /**
         * This is a constructor that takes name as as paramater and 
         * passes it to the _name Private instance variable
         * 
         * @constructor person
         * @parm {string} _name
         */


        /**
         * <summary>
         * This is a constructor that takes age as paramater and passes
         * it to the _age private instance variable
         * </summary
         * 
         *
         */
        public Person(int age)
        {
            this._initialize();
            this.Age = age;
        }


        /**<summary>
         *This is a constructor that takes both name and age as paramaters,
         *It assigns the local name valur to the Name property
         * It assigns the local age valur to the Age property
         * </summary>
         * 
         * @constructor Person
         * 
         */
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method initializes the public properties Name and Age
         * </summary>
         * 
         * @private
         * @method _initialize
         * @returns {void}
         */
        private void _initialize()
        {
            this.Name = "unknown name!";
            this.Age = 0;
        }
        public void _sayHello()
        {
            Console.WriteLine(this.Name + " Says hello!");
        }

        /**
         * 
         * This method outputs the _name and _age values in the following
         * format: _name + "is" +_age + "years old".
         * 
         * @method ShowAge
         */
        public void ShowAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " years old");
        }
    }
}