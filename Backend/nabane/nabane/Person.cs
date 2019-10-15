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
        private bool admin;
        private bool train;

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

        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }

        public bool Train
        {
            get { return train; }
            set { train = value; }
        }

        public Person()
        {

        }

        public Person(int id, string name, int age, string email, bool admin, bool train)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.Admin = admin;
            this.Train = train;
        }

        public virtual string ChangeEmail(string changeemail)
        {
            return this.Email = changeemail;
        }

        public override string ToString()
        {
            return "Person: " + " ID: " + this.ID + " Name: " + this.Name;
        }
    }
}