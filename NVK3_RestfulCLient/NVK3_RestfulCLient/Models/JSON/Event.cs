﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVK3_RestfulCLient.Models.JSON
{
    class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Weekday { get; set; }
        public string Monthday { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Time { get; set; }
        public string VPlaceforEvent { get; set; }
    }
}
