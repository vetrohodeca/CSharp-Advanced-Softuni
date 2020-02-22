using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DefiningClasses
{
    public class Family
    {
        private List<Person> personList; 
        public Family()
        {
           this.personList = new List<Person>();
        }
        
       public void AddMember(Person member)
        {
            this.personList.Add(member);
        }
       public Person GetOldestMember()  
        {
            var oldest = this.personList.OrderByDescending(p => p.Age).FirstOrDefault();
            return oldest;
        }


    }
}
