using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.ReverseModels
{
<<<<<<< HEAD
    public class AspNetUserRoles//many to many created by the two tables created
=======
    // This really doesn't exist, but the relationship does. ;)
    public class AspNetUserRoles
>>>>>>> fa2c08222308104e2613f410df4833b7ad863065
    {
        [Key]
        [MaxLength(128)]
        public string UserId { get; set; }

        [Key]
        [MaxLength(128)]
        public string RoleId { get; set; }
    }
}