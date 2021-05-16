using System;

namespace Current
{
    class Program
    {
        static void Main(string[] args)
        {
            Current company1 = new Current();
            Console.WriteLine("Company 2 details ");

            Console.WriteLine("Enter the company1 name ");
            company1.companyName = Console.ReadLine();

            Console.WriteLine("Enter the Type of business ");
            company1.typeOfBusiness = Console.ReadLine();

            Console.WriteLine("Enter the website ");
            company1.website = Console.ReadLine();

            Console.WriteLine("Enter the contactName ");
            company1.contactName = Console.ReadLine();

            
            Current company2 = new Current();
            Console.WriteLine("Company 2 details ");
            Console.WriteLine("Enter the company2 name ");
            company2.companyName = Console.ReadLine();

            Console.WriteLine("Enter the Type of business ");
            company2.typeOfBusiness = Console.ReadLine();

            Console.WriteLine("Enter the website ");
            company2.website = Console.ReadLine();

            Console.WriteLine("Enter the contactName ");
            company2.contactName = Console.ReadLine();

            //  Console.WriteLine(company1 == company2);
            Console.WriteLine(" Company1 equals company2 ?");

         
            Console.WriteLine(company1.Equals(company2));
        }
    }

    public class Current
    { 
        public String companyName
        { get; set; }
        public String typeOfBusiness
        { get; set; }
        public String website
        { get; set; }
        public String contactName
        { get; set; }



        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Current))
            {
                return false;

            }
            return this.companyName == ((Current)obj).companyName &&
                this.contactName == ((Current)obj).contactName &&
                this.typeOfBusiness == ((Current)obj).typeOfBusiness &&
                this.website == ((Current)obj).website;
        }

        public override int GetHashCode()
        {
            return this.companyName.GetHashCode()^ this.contactName.GetHashCode()
                ^this.typeOfBusiness.GetHashCode()^
                this.website.GetHashCode();
        }

    }



}
