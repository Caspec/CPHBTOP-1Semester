using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace nabane
{
    public class Person
    {
        private int id;
        private string name;
        private int age;
        private string email;
        private Keycard.Keycard mykey;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
      
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Keycard.Keycard Mykey
        {
            get { return mykey; }
            set { mykey = value; }
        }


        public Person()
        {

        }

        public Person(int id, string name, int age, string email, Keycard.Keycard mykey)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.Mykey = mykey;
        }

        public virtual string ChangeEmail(string changeemail)
        {
            return this.Email = changeemail;
        }

        public override string ToString()
        {
            return "Person: " + " ID: " + this.ID + " Name: " + this.Name + " Keycard number: " + this.Mykey.ToString();
        }
    }
}