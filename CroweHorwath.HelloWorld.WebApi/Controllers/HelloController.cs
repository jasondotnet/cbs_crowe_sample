using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CroweHorwath.HelloWorld.Controllers
{
    /// <summary>
    /// Returns Hello World in two parts. 
    /// </summary>
    public class HelloController : ApiController
    {
        /// <summary>
        /// Returns two values for Hello World
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }
        
    }
}