using System;
using System.Collections.Generic;
using System.Text;

namespace account
{
    class Account : AccountMgr
    {
    
        private int accountNo;
        private String accountType;
        private int debitCardNo;
        private int pin;
        private String loginId;
        private String password;
        private double balance;

        public int AccountNo { get => accountNo; set => accountNo = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public int DebitCardNo { get => debitCardNo; set => debitCardNo = value; }
        public int Pin { get => pin; set => pin = value; }
        public string LoginId { get => loginId; set => loginId = value; }
        public string Password { get => password; set => password = value; }
        public double Balance { get => balance; set => balance = value; }
    }
} 
