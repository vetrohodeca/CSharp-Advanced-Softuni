using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person
    {
        public string Name { get; set }
        public int Age{get; set }
        public string Town { get; set; }
        public int CompareTo([] Person person)
        {
            int result = 1;
            if(person!=null)
            {
                result = this.Name.CompareTo(person.Name);
                if(result==0)
                {
                    result.thisAge
                }
            }
        }
    }
}
