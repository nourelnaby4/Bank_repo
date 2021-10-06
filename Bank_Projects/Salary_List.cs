using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
    class Salary_List
    {
        node Top, mynode;
        public void push_salary(string name, string id, float data)
        {
            mynode = new node(name, id, data);
            if (Top == null)
                Top = mynode;
            else
            {
                mynode.next = Top;
                Top = mynode;
            }
        }
        public void show_salary()
        {
            if (Top == null)
            {
                Console.WriteLine("there are not salary transactions");
            }
            else
            {
                node p = Top;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Name\tId\t\tsalary\n");
                while (p != null)
                {
                    Console.WriteLine(p.name + "\t" + p.id + "\t" + p.data);
                    p = p.next;
                }
            }
        }
    }
}
