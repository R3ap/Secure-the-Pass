﻿using System.ComponentModel.DataAnnotations;

namespace Password_Manager_.NET_6.Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}