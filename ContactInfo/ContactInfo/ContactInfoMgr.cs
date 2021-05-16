using System;
using System.Collections.Generic;
using System.Text;

namespace ContactInfo
{
   /* private String address;
    private String city;
    private String state;
    private String country;
    private String mobileNo;
    private String emailId;
   */
    class ContactInfoMgr
    {
        public ContactInfo storeData(ContactInfo contactinfo)
        {
            Console.WriteLine("Enter your address");
            String addr = Console.ReadLine();

            Console.WriteLine("Enter your city");
            String city = Console.ReadLine();

            Console.WriteLine("Enter your state");
            String state = Console.ReadLine();

            Console.WriteLine("Enter your country");
            String country = Console.ReadLine();

            Console.WriteLine("Enter your mobilenumber");
            String mobile = Console.ReadLine();

            Console.WriteLine("Enter your emailId");
            String emailid = Console.ReadLine();

            contactinfo.Address = addr;
            contactinfo.City = city;
            contactinfo.Country = country;
            contactinfo.State = state;
            contactinfo.EmailId = emailid;
            contactinfo.MobileNo = mobile;




            return contactinfo;
        
        
        }
        public void showData(ContactInfo show)
        {

            Console.WriteLine("Address   : " + show.Address);
            Console.WriteLine("City      : " + show.City);
            Console.WriteLine("State     : " + show.State);
            Console.WriteLine("Country   : " + show.Country);
            Console.WriteLine("MobileNo. : " + show.MobileNo);
            Console.WriteLine("Email Id  : " + show.EmailId);
        
        
        }




    }
}
