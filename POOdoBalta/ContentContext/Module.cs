﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOdoBalta.SharedContext;

namespace POOdoBalta.ContentContext
{
    public class Module : Base 
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
