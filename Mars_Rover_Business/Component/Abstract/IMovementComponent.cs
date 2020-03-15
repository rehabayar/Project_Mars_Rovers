using Mars_Rover_Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Business.Component.Abstract
{
    public interface IMovementComponent
    {
        public RoboticRoversLocation MoveDecision(RoboticRoversLocation currentCoordinate);
        public RoboticRoversLocation MoveForward(RoboticRoversLocation currentCoordinate);
        public RoboticRoversLocation Turn(RoboticRoversLocation currentCoordinate);
    }
}
