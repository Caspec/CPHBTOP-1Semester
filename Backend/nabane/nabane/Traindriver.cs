using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace nabane.traindriver
{
    public class Traindriver : nabane.Person
    {
        private int licens;

        public Traindriver(int id, string name, int age, string email, bool admin, bool train, int licens) : base(id, name, age, email, admin, train)
        {
            this.licens = licens;
        }

        public override string ToString()
        {
            return "Traindriver number: " + this.licens;
        }

    }

    

}