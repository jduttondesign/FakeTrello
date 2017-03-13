<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
=======
﻿using System.ComponentModel.DataAnnotations;
>>>>>>> fa2c08222308104e2613f410df4833b7ad863065

namespace FakeTrello.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }

<<<<<<< HEAD
        [MaxLength(60)]
        public string Title { get; set; }

        [MaxLength(60)]
        public string Description { get; set; }

        public List<Users2> Contributors { get; set; }//one to many
        //public User2 Contributor {get; set;}//one to one user 

        //does not link to any other card so no public list needed here.
        //we provide navigation see below; we are saying return all columns not just the ID
        //Auxiliary: given a card instance, return the list it belongs to. 
        public List BelongsTo { get; set; }

=======
        public string Title { get; set; }
        public string Description { get; set; }

        // Auxiliary: given a card instance,
        // return the list it belongs to.
        public List BelongsTo { get; set; }
>>>>>>> fa2c08222308104e2613f410df4833b7ad863065
    }
}