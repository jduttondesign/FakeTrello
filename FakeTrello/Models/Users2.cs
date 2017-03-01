using System;
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

        public string UserName { get; set; }

        public string FullName { get; set; }

    }
}