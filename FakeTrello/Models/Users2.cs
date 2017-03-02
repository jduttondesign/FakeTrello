﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Users2
    {
        [Key]
        public int Users2Id { get; set; }

        [MaxLength(60)]
        public string UserName { get; set; }

        [MaxLength(60)]
        public string Email { get; set; }

        [MaxLength(60)]
        public string FullName { get; set; }

        [MaxLength(60)]
        public string PasswordHash { get; set; }

        public List<Board> Card { get; set; }

    }
}