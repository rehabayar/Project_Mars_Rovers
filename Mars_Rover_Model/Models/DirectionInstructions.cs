using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Model.Models
{
    public class DirectionInstructions
    {
        public int ClockWiseId { get; set; }
        public char DirectionCode { get; set; }
        public string DirectionName { get; set; }
        public string XInstructions { get; set; }
        public string YInstructions { get; set; }
    }
}
