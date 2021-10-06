    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
    class Employees:Person,Iaccount
    {
        float myaccount = 0,salary=0;
        public float Myaccount { get { return myaccount; } set { myaccount = value; } }
        public float Mysalary_variable { get { return salary; } set { salary = value; } }
        public Employees(string id,string name)
        {
            this.id = id;
           this.name = name;
        }
        public void print(string writeline)
        {
            Console.WriteLine(writeline);
        }
        public void print_Myaccount()
        {
            Console.WriteLine("Your account is : {0}",Myaccount);
        }
        enum position
        {
          branch_head=0,
          accountant=1,
          call_center=2,
          office_boy=3
        }
        public static int rposition()
        {
            Random rp = new Random();
            int pos = rp.Next(0, 4);
            return pos;
        }
        public void Mysalary_method(int random_position, string name,string id,Salary_List s1)
        {
            switch (random_position)
            {
                case 0:
                   Mysalary_variable = 11000;
                   Console.WriteLine("Hallo Mr : {0}\nyour position is branch head\nYour salary is : {1}", name, Mysalary_variable);
                   Myaccount += Mysalary_variable;
                   s1.push_salary(name,id,Mysalary_variable);
                    break;

                case 1:
                    Mysalary_variable = 6000;
                    Console.WriteLine("Hallo Mr : {0}\nyour position is accountant\nYour salary is : {1}", name, Mysalary_variable);
                    Myaccount += Mysalary_variable;
                    s1.push_salary(name, id, Mysalary_variable);
                    break;

                case 2:
                    Mysalary_variable = 5500;
                    Console.WriteLine("Hallo Mr : {0}\nyour position is call center\nYour salary is : {1}", name, Mysalary_variable);
                    Myaccount += Mysalary_variable;
                    s1.push_salary(name, id, Mysalary_variable);
                    break;

                case 3:
                    Mysalary_variable = 2000;
                    Console.WriteLine("Hallo Mr : {0}\nyour position is office boy\nYour salary is : {1}", name, Mysalary_variable);
                    Myaccount += Mysalary_variable;
                    s1.push_salary(name, id, Mysalary_variable);
                    break;

                default :
                    Console.WriteLine("invalid value");
                    break;
            }
        }
   }
}
