using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
    class node:Person
    {
       node Next;
       float Data;

       public node next { get { return Next; } set { Next = value; } }
       public  float data { get { return Data; } set { Data = value; } }
        
        public node(string name,string id,float data):base(name,id)
        {
            Data = data;
            Next = null;
        }
    }
}
