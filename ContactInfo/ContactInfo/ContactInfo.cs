using System;
using System.Collections.Generic;
using System.Text;

namespace ContactInfo 
{
    class ContactInfo : ContactInfoMgr
    {
        private  String address;
        private String city;
        private String state;
        private String country;
        private String mobileNo;
        private String emailId;

        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
        public string MobileNo { get => mobileNo; set => mobileNo = value; }
        public string EmailId { get => emailId; set => emailId = value; }
    }
}
