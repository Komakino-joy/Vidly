﻿using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }

        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                {
                    return "Edit Customer: " + Customer.Name;
                }

                return "Add New Customer";
            }
        }


    }
}
