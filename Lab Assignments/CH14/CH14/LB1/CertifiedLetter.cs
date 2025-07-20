﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class CertifiedLetter : Letter
    {
        protected string _trackingNumber;

        public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber)

            //pass to parent constructor
            : base(recipient, sentDate) 
        {
            _trackingNumber = trackingNumber; 
        }
        public string TrackingNumber 
        { 
            get { return _trackingNumber; }
        }
        public override double Price 
        { 
            get { return .65; } 
        }
        public override string ToString()
        {
            //get parent-base
            return base.ToString() + $"(Certified, Tracking Number: {_trackingNumber})\n";
        }
    }
}
