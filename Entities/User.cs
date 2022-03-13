﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string PicturePath { get; set; }
        
        //ORM (Object Relational Mapping)
    }
}