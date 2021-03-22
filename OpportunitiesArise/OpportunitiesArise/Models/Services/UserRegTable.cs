using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace OpportunitiesArise.Models.Services
{
    public class UserRegTable : ContentPage
    {
        public UserRegTable()
        {
             public Guid UserId { get; set; }
             public string UserName { get; set; }
             public string Password { get; set; }
             public string Email { get; set; }
             public string PhoneNumber { get; set; }
        }
    }
 }
    
