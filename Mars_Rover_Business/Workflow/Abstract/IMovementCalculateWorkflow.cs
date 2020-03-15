using Mars_Rover_Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Business.Workflow.Abstract
{
    public interface IMovementCalculateWorkflow
    {
        public RoboticRoversLocation MoveCalculate(RoboticRoversLocation currentCoordinate, char[] moveList);
    }
}
