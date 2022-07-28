using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalFeaturesAssignment

{
    public class Identity
    {
        public string name;
        public int id;

        public Identity(string name) : this(name, 0)
        {

        }

        public Identity(string name, int id)
        {
            this.name = name;
            this.id = id;
        }     
       
    }
}
