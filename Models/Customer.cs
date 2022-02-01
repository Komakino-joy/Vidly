using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        // Foreign key, Entity Framework knows because of the "Id" suffix
        public byte MemberShipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}