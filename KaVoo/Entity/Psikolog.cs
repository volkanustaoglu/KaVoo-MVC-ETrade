using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaVoo.Entity
{
    public class Psikolog
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public string Info6 { get; set; }
        public string Info7 { get; set; }
        public string Info8 { get; set; }
        public string Info9 { get; set; }
        public string Info10 { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
        public string Phone { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool DisableNewAppointments { get; internal set; }
    }
}