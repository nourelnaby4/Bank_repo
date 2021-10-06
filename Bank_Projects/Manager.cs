using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
    class Manager:Person
    {

        string pass_word;
        public string Pass_Word
        { 
            get { return pass_word; }
            set
            {
                pass_word = value;
            }
        }
        public Manager(string id,string name)
            : base(id,name)
        {
            this.id = id;
            this.name = name;
            Console.Write("Enter the pass word : ");
            Pass_Word = Console.ReadLine();
            while (pass_word != "123456")
            {
                Console.WriteLine("Incorrect pass word");
                Console.Write("Try again : ");
                pass_word = Console.ReadLine();
            }
            Console.WriteLine("----------------------------------------------");
        }
    }
}
