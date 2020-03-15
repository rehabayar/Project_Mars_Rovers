using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Common.Helper
{
    public class ConsoleMessageHelper
    {
        public string MoveControlMessage(int oldX, int newX, int oldY, int newY)
        {
            string message = "";
            if (oldX == newX && oldY == newY)
                message = "Robotic rovers can't moving. Because this instruction is out of limit";

            else
                message =  "Move forward! New x axis:" + newX + " new y axis: " + newY;
            
            return message;
        }
    }
}
