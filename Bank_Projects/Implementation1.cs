using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
    class Implementation1
    {

        public void Implement_Clint(Clients c, string quation, string name, string id, Deposit_List d1, Withdrawal_List w1)
        {

            while (quation.ToLower() == "yas")
            {
            label1:
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Entre the type of the transaction \nIf you want Debosit money enter 11");
                Console.WriteLine("If you want withdrawal money enter 12\nIf you want to know your account enter 13");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 11:
                        Console.WriteLine("Enter the value of Deposit");
                        float d = float.Parse(Console.ReadLine());
                        c.Deposit_Transaction(d,d1);
                        System.Media.SystemSounds.Beep.Play();

                        break;
                    case 12:
                        Console.WriteLine("Enter the value of withdrawal");
                        float w = float.Parse(Console.ReadLine());
                        c.Withdrawal_Transaction(w,w1);
                        System.Media.SystemSounds.Beep.Play();
             
                        break;
                    case 13:
                        c.print_Myaccount();
                        System.Media.SystemSounds.Beep.Play();
                        break;
                    default:
                        Console.WriteLine("invaled value");
                        goto label1;
                     
                }
                Console.WriteLine("\nDo you want to continue as a client (yas/no)");
                Console.WriteLine("---------------------------------------------");
                quation = Console.ReadLine();
            }
        }
        public enum position
        {
            branch_head = 0,
            accountant = 1,
            call_center = 2,
            office_boy = 3
        }
             public void Implement_employee(Employees e1,string name,string id,int rand_num,Salary_List s1)
              {
     
                 label2:
              Console.WriteLine("If you want to get your salary enter : 0");
              int y = int.Parse(Console.ReadLine());
      
               switch (y)
                {
                    case 0:
                        e1.Mysalary_method(rand_num, name,id,s1);

                        break;
                    default:
                        Console.WriteLine("Try again please");
                        goto label2;
                       
                }
            }
             public void Implement_manager(Deposit_List d1, Withdrawal_List w1, Salary_List s1)
            {
                string quation = "yas";
                while (quation.ToLower() == "yas")
                {
                label3:
                    Console.WriteLine("If you want show your deposits enter : 0\nIf you want to show withdrawal enter : 1");
                    Console.WriteLine("If you want show salaries enter : 2");
                     
                    
                    
                    int z = int.Parse(Console.ReadLine());
                    switch (z)
                    {
                        case 0:
                            d1.show_deposit();
                            break;
                        case 1:
                            w1.show_Withdrawal();
                            break;
                        case 2:
                            s1.show_salary();
                            break;
                        default:
                            Console.WriteLine("invaled value try again");
                            goto label3;
                       
                    }
                    Console.WriteLine("Do you want to continue as a manager (yas/no)");
                    Console.WriteLine("---------------------------------------------");
                    quation = Console.ReadLine();
                }
            }
        }
    }

