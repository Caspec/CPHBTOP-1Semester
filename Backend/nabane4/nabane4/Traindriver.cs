using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace nabane.traindriver
{
    public class Traindriver : nabane.Person
    {
        private int licens;

        public Traindriver(int id, string name, int age, string email, int licens, Keycard.Keycard mykey) : base(id, name, age, email, mykey)
        {
            this.licens = licens;
        }

        public override string ToString()
        {
            return "Train Driver: " + ID + " " + Name + " Licens: " + licens;
        }

    }

    

}