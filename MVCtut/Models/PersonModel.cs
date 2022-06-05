using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCtut.Models //models are classes with properties
{
    public class PersonModel
    {
        //these are properties or "props"
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } = 0;
        public bool IsAlive { get; set; } = true; 
    }
}