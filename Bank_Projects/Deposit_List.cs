using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
    class Deposit_List
    {
        node Top,mynode;
        public Deposit_List()
        {
            Top = null;
        }
        public  void push_deposit(string name,string id,float data)
        {
            mynode = new node(name,id,data);
            if (Top == null)
                Top = mynode;
            else
            {
                mynode.next = Top;
                Top = mynode;
            }
        }
        public void show_deposit()
        {
            if (Top == null)
            {
                Console.WriteLine("there are not deposit transactions");
            }
            else
            {
                node p = Top;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Name\tId\t\tDeposit\n");
                while (p!= null)
                {
                    Console.WriteLine(p.name + "\t" + p.id + "\t" + p.data);
                    p = p.next;
                }
            }
        }
    }
}
