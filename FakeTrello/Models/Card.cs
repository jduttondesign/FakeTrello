﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }

        [MaxLength(60)]
        public string Title { get; set; }

        [MaxLength(60)]
        public string Description { get; set; }

        //does not link to any other card so no public list needed here.
    }
}