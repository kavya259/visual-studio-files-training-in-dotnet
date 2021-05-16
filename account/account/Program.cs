using System;

namespace account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.storeData(account);
            account.showData(account);
        }
    }
}
