﻿using CS322_Projekat.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Projekat.Models
{
    public class User
    {
        public int UserId {  get; set; }
        public string Name {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; } 
        
    }
}
