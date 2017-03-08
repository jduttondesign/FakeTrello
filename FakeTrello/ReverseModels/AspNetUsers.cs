using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.ReverseModels
{
    public class AspNetUsers
    {
        [Key]
        [MaxLength(128)]
        public string Id { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public bool EmailConfirmed { get; set; }
        //already has the inner workings, so no required/maxlength necessary 
        public string PasswordHash { get; set; }

        public string SecurtityStamp { get; set; }

        //html5 gives form validation for ph#s
        public string PhoneNumber { get; set; }

        [Required]
        public bool PhoneNumberConfirmed { get; set; }

        [Required]
        public bool TwoFactorEnabled { get; set; }

        public DateTime LockOutEndDateEnc { get; set; }

        public bool LockOutEnabled { get; set; }

        [Required]
        public int AccessFailedCount { get; set; }

        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        public ICollection <AspNetRoles> Roles { get; set; }

    }
}