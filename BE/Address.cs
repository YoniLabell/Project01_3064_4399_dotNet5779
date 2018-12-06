﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public struct Address
    {
        public String StreetName { get; set; }
        public int Number { get; set; }
        public String City { get; set; }
        public override string ToString()
        {
            return "\nStreetName:"+StreetName.ToString()+ " Number:"+Number.ToString()+ " City:"+ City.ToString();
        }
    }
}