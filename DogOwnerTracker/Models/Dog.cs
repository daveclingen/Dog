using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace DogOwnerTracker.Models
{
    [Authorize]
    public class Dog
    {
        [Key]
        public int DogID { get; set; }
        
        public string DogName { get; set; }
        public string Breed { get; set; }
        public string Sex { get; set; }
        public int OwnerID { get; set; }

        public Owner Owner { get; set; }
    }
}
