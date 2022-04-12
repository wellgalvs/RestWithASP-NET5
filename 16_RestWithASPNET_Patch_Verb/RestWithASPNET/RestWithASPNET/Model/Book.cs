﻿using System.ComponentModel.DataAnnotations.Schema;
using System;
using RestWithASPNET.Model.Base;

namespace RestWithASPNET.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }        

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime launchDate { get; set; }
    }
}
