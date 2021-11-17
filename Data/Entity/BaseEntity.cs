﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_St.Data.Entity
{
    public class BaseEntity
    {
        public Guid Id { set; get; }
        public DateTime CreateTime { set; get; }
        public Guid CreatorId { set; get; }
        public DateTime UpdateTime { set; get; }
        public Guid UpdaterId { set; get; }
        public Guid DeletorId { set; get; }
    }
}