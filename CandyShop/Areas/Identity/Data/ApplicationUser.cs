using CandyShop.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CandyShop.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    public string CustomerFName { get; set; }

    public string CustomerLName { get; set; }

    public string PostalCode { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string Country { get; set; }

    public string CreditCardNumber { get; set; }

    public Cart Cart { get; set; }


}


