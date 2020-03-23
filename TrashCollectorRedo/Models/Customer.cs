using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorRedo.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        [Display(Name="Pickup Day")]
        public string? PickupDay { get; set; }
        
        [Display(Name="One-time Pickup Day")]
        public DateTime? OneTimePickup { get; set; }
        
        public int Balance { get; set; }
        
        [Display(Name = "Suspend Trash Start Date")]
        public DateTime? SuspendStart { get; set; }
        
        [Display(Name = "Suspend Trash End Date")]
        public DateTime? SuspendEnd { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
