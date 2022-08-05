//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Insuree
    {
        public int Id { get; set; }

        [DisplayName ("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Car Year")]
        public int CarYear { get; set; }

        [DisplayName("Car Make")]
        public string CarMake { get; set; }

        [DisplayName("Car Model")]
        public string CarModel { get; set; }

        [DisplayName("DUI")]
        public bool DUI { get; set; }

        [DisplayName("Speeding Tickets")]
        public string SpeedingTickets { get; set; }

        [DisplayName("Full Coverage")]
        public bool CoverageType { get; set; }
       
        public decimal Quote { get; set; }

       
    }
}
