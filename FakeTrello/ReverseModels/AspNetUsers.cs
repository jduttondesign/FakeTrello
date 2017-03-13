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

<<<<<<< HEAD
        [MaxLength(255)]
=======
        [MaxLength(256)]
>>>>>>> fa2c08222308104e2613f410df4833b7ad863065
        public string Email { get; set; }

        [Required]
        public bool EmailConfirmed { get; set; }
<<<<<<< HEAD
        //already has the inner workings, so no required/maxlength necessary 
        public string PasswordHash { get; set; }

        public string SecurtityStamp { get; set; }

        //html5 gives form validation for ph#s
=======

        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
>>>>>>> fa2c08222308104e2613f410df4833b7ad863065
        public string PhoneNumber { get; set; }

        [Required]
        public bool PhoneNumberConfirmed { get; set; }

        [Required]
        public bool TwoFactorEnabled { get; set; }

<<<<<<< HEAD
        public DateTime LockOutEndDateEnc { get; set; }

        public bool LockOutEnabled { get; set; }
=======
        public DateTime LockoutEndDateUtc { get; set; }

        [Required]
        public bool LockoutEnabled { get; set; }
>>>>>>> fa2c08222308104e2613f410df4833b7ad863065

        [Required]
        public int AccessFailedCount { get; set; }

        [Required]
<<<<<<< HEAD
        [MaxLength(255)]
        public string UserName { get; set; }

        public ICollection <AspNetRoles> Roles { get; set; }
=======
        [MaxLength(256)]
        public string UserName { get; set; }

        public ICollection<AspNetRoles> Roles { get; set; }
>>>>>>> fa2c08222308104e2613f410df4833b7ad863065

    }
}