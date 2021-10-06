using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Projects
{
  class Clients:Person,Iaccount
    {
        string NumberOfVisa;
        float myaccount=0;

        public float Myaccount
        {
            get { return myaccount; }
            set { myaccount = value; }
        }
        public string NumOfVisa
        {
            get{return NumberOfVisa;}
            set
            {
                NumberOfVisa = value;
            }
            
        }
        public Clients() { }
        public Clients(string visa, string name, string id)
            : base(name, id)
        {
            string sub_visa= id.Substring(0, 3);
            while (sub_visa != "012" && visa.Length != 11)
            {
                Console.WriteLine("Incorrect Visa number");
                Console.Write("Try again : ");
                visa = Console.ReadLine();
            }
            NumberOfVisa = visa;
        }
        public void Deposit_Transaction(float deposit, Deposit_List d1)
        {
            Myaccount += deposit;
            d1.push_deposit(name, id,deposit);
        }
        public void Withdrawal_Transaction(float withdrawal,Withdrawal_List w1)
        {
            if (Myaccount >= withdrawal)
            {
                Console.WriteLine("The withdrawal done successfully");
                Myaccount -= withdrawal;
                w1.push_Withdrawal(name, id,withdrawal);
            }
            else                         
                Console.WriteLine("The withdrawal is faild");
        }
        public void print_Myaccount()
        {
            Console.WriteLine("your account is : {0}", Myaccount);
        }
     
   }
}
