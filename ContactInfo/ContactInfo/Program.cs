using System;

namespace ContactInfo
{
    class Program
    {

    /*    private String address;
        private String city;
        private String state;
        private String country;
        private String mobileNo;
        private String emailId;

        */
        static void Main(string[] args)
        {
            ContactInfo contact = new ContactInfo();
            contact.storeData(contact);
            contact.showData(contact);



        }
    }
}
