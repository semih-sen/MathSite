﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Discussion:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ForumId { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public string Tags { get; set; }

    }
}
