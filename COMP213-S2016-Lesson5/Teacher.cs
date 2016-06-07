using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_Lesson5
{
    /**
     *<summary>
     * The teacher class is derived from person class
     *  
     * </summary> 
     * @class teacher
     * @extends person
     */
    class Teacher : Person
    {
        //PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++
        private string _employeeID;

        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++
        public string EmployeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }
        //CONSTRUCTOR

        /**
         * <summary>
         * This constructor method takes 3 paramaters: name, age, emloyeeID             * 
         * </summary>
         * 
         * @constructor Teacher
         * @pram {string} name
         * @pram {int} age
         * @pram {string] employeeID
         * 
         */
        public Teacher(string name, int age, string employeeID)
            : base(name, age)
        {
            this.EmployeeID = employeeID;
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method enables the teacher behaviours for the teacher class
         * </summary>
         * 
         * 
         * 
         */
        public void Teaches()
        {
            Console.WriteLine(this.Name + " teaches.");
        }
    }
}
