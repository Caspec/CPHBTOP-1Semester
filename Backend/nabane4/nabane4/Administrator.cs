using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace nabane.administrator
{
    public class Administrator : nabane.Person
    {
        // private fields if needed

        public Administrator(int id, string name, int age, string email, Keycard.Keycard mykey) : base(id, name, age, email, mykey)
        {

        }

        public override string ChangeEmail(string changeemail)
        {
            if (changeemail.ToLower().Contains("@pig.dk"))
            {
                return changeemail;
            }
            else
            {
                return "@ Not found";
            }
        }

        public override string ToString()
        {
            return "Administrator: " + ID + " " + Name;
        }

    }
}