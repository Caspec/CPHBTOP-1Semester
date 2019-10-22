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
        private bool title;

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

        public bool Title
        {
            get { return title; }
            set { title = value; }
        }


        public Person()
        {

        }

        public Person(int id, string name, int age, string email, bool title)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.Title = title;
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