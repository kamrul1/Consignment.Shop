using System;

namespace Consignment.Shop.Library
{
    public class Vendor
    {

        public Vendor()
        {
            Commission = 0.5f;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; init; }
        public decimal PaymentDue { get; set; }

        public string Display
        {
            get { return $"{FirstName} {LastName} -${PaymentDue} "; }
        }
    }
}
