using System;
using System.Collections.Generic;
using System.Text;

namespace Annotations
{
    public class Employer
    {
        int id;
        string name;
        public Employer(int i, string n)
        {
            id = i;
            name = n;
        }
        [NewAttribute("Accessor", "Gives value of Employer Id")]
        public int getId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Gives value of Employer Name")]
        public string getName()
        {
            return name;
        }
    }
}