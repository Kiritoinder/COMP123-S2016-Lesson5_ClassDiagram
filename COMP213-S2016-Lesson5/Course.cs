using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_Lesson5
{
    /**
     * <summary>
     * This is the course class - we are using this as a custom
     * data type for our techer and student classes
     * </summary>
     * 
     * @class Course
     */
    class Course
    {
        //PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++
        private string _code;
        private string _description;

        //PUBLIC PROPRTIES ++++++++++++++++++++++++++++++++++++++
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor takes 2 paramaters: Code , Description
         * </summary>
         * 
         * @constructor Course
         * @pram {string} code
         * @pram {string description
         */
        public Course(string code, string description)
        {
            this.Code = code;
            this.Description = description;

        }
    }
}
