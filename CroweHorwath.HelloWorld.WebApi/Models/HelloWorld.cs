using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CroweHorwath.HelloWorld.Models
{
    public class HelloWorld
    {
        private string value;
        public virtual string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public HelloWorld()
        {
            value = "Hello World";
        }
    }
}