﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.Data
{
    public class BaseEntity
    {

        public int ID { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddedTime { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
