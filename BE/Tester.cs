﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester:Person
    {
        public Schedule Luz { get; set; }
        public CarType Expertise { get; set; }
        public int Experience { get; set; }
        public int MaxTestWeekly { get; set; }
        public int MaxDistance { get; set; }
        public override string ToString()
        {
            return base.ToString() + "\nExpertise: " + Expertise.ToString() + "\nMaxTestWeekly: " + MaxTestWeekly +
                "\nMaxDistance: " + MaxDistance + "\nLuz: " + Luz.ToString();
        }
        public new Tester Clone()
        {
            Tester result = null;
            result = new Tester
            {
                Address = this.Address.Clone(),
                DayOfBirth = this.DayOfBirth,
                Expertise = this.Expertise.Clone(),
                Gender = this.Gender,
                ID = this.ID,
                MaxDistance = this.MaxDistance,
                Name = this.Name,
                PhoneNumber=this.PhoneNumber,
                Experience = this.Experience,
                MaxTestWeekly = this.MaxTestWeekly,
                Luz = this.Luz.Clone()
            };
            return result;
        }
    }
}
