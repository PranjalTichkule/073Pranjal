using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Library
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string email;
        private string age;

        public Person()
        {
            firstName = "Pranjal";
            lastName = "Tichkule";
            email = "pranjaltichkule@gmail.com";
            age = "25";
        }
        public Person(string firstName, string lastName, string email, string age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.age = age;
        }
        public string FirstName { get { return firstName; } set { firstName = value; } }    
        public string LastName { get { return lastName; } set { lastName = value; } }
        public String Email { get { return email; } set { email = value; } }
        public int Age { get { return Age; } set { Age = value; } }

        public override string ToString()
        {
            string result = string.Format("First_Name={0} Last_Name={1} email={2} age={3}",this.firstName,this.lastName,this.email,this.age);
            return result;
        }
    }
}
