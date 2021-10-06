using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
    class Program
    {
        public static void print(string WriteLine2)
        {
            Console.WriteLine(WriteLine2);
        }

        static void Main(string[] args)
        {
            string name,id,quation1 = "yas",quation2="yas",quation3="yas",quation4="no";
            string num;
            Deposit_List d1 = new Deposit_List();
            Withdrawal_List w1 = new Withdrawal_List();
            Salary_List s1 = new Salary_List();
            print("Welcom you in CIB Bank\n\n");
            while (quation4.ToLower()!="yas")
            {
            label0:
                print("If you are a Client Please enter : 1");
                print("If you are a Employee Please enter : 2\nIf you are The Manager Please enter : 3");
                int status = int.Parse(Console.ReadLine());

                switch (status)
                {

                    case 1:
                        quation1 = "yas";
                        while (quation1.ToLower() == "yas")
                        {
                            Console.Write("Enter your name : ");
                            name = Console.ReadLine();
                            Console.Write("Enter your id : ");
                            id = Console.ReadLine();
                            Console.Write("Enter your Number of Visa : ");
                            num = Console.ReadLine();
                            Clients c1 = new Clients(num, name, id);
                            Implementation1 Ip1 = new Implementation1();
                            Ip1.Implement_Clint(c1, "yas",name,id,d1,w1);
                            print("are you a new client");
                            quation1 = Console.ReadLine();
                        }
                        break;

                    case 2:
                        quation2 = "yas";
                       
                        while (quation2.ToLower() == "yas")
                        {
                            Console.Write("Enter your name please : ");
                            name = Console.ReadLine();
                            Console.Write("Enter your id : ");
                            id = Console.ReadLine();
                            Employees e1 = new Employees(id, name);
                            Implementation1 Ip2 = new Implementation1();
                            int random_num = Employees.rposition();
                            Ip2.Implement_employee(e1, name,id, random_num,s1);
                            print("the next employee");
                            print("Are you the next employee (yas/no)");
                            quation2 = Console.ReadLine();
                        }
                        break;

                    case 3:
                            Console.Write("Enter your name : ");
                            name = Console.ReadLine();
                            Console.Write("Enter your id : ");
                            id = Console.ReadLine();
                            Manager m1 = new Manager(id, name);
                            Implementation1 Ip3 = new Implementation1();

                            Ip3.Implement_manager(d1,w1,s1);
                            quation3 = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("invalid value please try again ");
                        goto label0;
                        
                }
                print("Do you want to exist the program (yas/no)");
                Console.WriteLine("---------------------------------------------");
                quation4 = Console.ReadLine();

            }
           
            Console.ReadKey();
        }
    }
}
