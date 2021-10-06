using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
  abstract class Person
    {
         string Name,Id;

         public string id 
         { 
             get { return Id;}
             set { Id = value; }    
         }
         public string name { get { return Name; } set { Name = value; } }
         public Person(string id)
         { 
             Id=id;
         }
         public Person(string name, string id)
         {
             Name = name;
             string sub_id = id.Substring(0, 3);
             while (sub_id!="011"&&id.Length!=11)
             {
                 Console.WriteLine("Incorrect ID");
                 Console.Write("Try again : ");
                 id = Console.ReadLine();
             }
             Id = id;
         }
         public Person() { }
    }
}
