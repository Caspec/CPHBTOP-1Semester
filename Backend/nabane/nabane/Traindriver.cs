using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace nabane.traindriver
{
    public class Traindriver : nabane.Person
    {
        private int licens;

        public Traindriver(int id, string name, int age, string email, bool title, int licens) : base(id, name, age, email, title)
        {
            this.licens = licens;
        }

        public override string ToString()
        {
            return "Train Driver: " + ID + " " + Name + " Licens: " + licens;
        }

    }

    

}