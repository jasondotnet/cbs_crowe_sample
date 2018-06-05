using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CroweHorwath.HelloWorld.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class HelloWorld
    {
        private string value;
        /// <summary>
        /// 
        /// </summary>
        public virtual string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public HelloWorld()
        {
            value = "Hello World";
        }
    }
}