using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Model.Models
{
    public class RoboticRoversLocation
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public char Instructions { get; set; }
        public string Direction { get; set; }
        public char DirectionCode { get; set; }

        public int XAxisLimit { get; set; }
        public int YAxisLimit { get; set; }
    }
}
