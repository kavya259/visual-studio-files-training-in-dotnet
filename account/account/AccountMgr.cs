using System;
using System.Collections.Generic;
using System.Text;

namespace account
{
    class AccountMgr 
    {
     /*   private int accountNo;
        private String accountType;
        private int debitCardNo;
        private int pin;
        private String loginId;
        private String password;
        private double balance;

        */



        public Account storeData(Account account)
        {

            Console.WriteLine("Enter the account number");
            int accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the account type");
            String type = Console.ReadLine();

            Console.WriteLine("Enter the debitcard number");
            int dnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the loginid");
            String loginid = Console.ReadLine();

            Console.WriteLine("Enter the pin");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the password");
            String pwd = Console.ReadLine();


            Console.WriteLine("Enter the balance");
            double bal = Convert.ToDouble(Console.ReadLine());


            account.AccountNo = accno;
            account.AccountType = type;
            account.DebitCardNo = dnumber;
            account.LoginId = loginid;
            account.Pin = pin;
            account.Password = pwd;
            account.Balance = bal;

            return account;


        }



        public void showData(Account show)
        {


            Console.WriteLine("Account Number :"+show.AccountNo);
            Console.WriteLine("Account type :" + show.AccountType);
            Console.WriteLine("debitcard number :" + show.DebitCardNo);
            Console.WriteLine("LoginId :" + show.LoginId);
            Console.WriteLine("Pin :" + show.Pin);
            Console.WriteLine("Password :" + show.Password);
            Console.WriteLine("Balance :" + show.Balance);

   }



    }
}
