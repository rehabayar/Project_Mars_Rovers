using Mars_Rover_Business.Component.Concrate;
using Mars_Rover_Business.Workflow.Abstract;
using Mars_Rover_Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Business.Workflow.Concrate
{
    public class MovementCalculateWorkflow : IMovementCalculateWorkflow
    {
        public RoboticRoversLocation MoveCalculate(RoboticRoversLocation currentCoordinate, char[] moveList)
        {
            MovementComponent movementComponent = new MovementComponent();

            for (int i = 0; i < moveList.Length; i++)
            {
                currentCoordinate.Instructions = moveList[i];
                currentCoordinate = movementComponent.MoveDecision(currentCoordinate);
            }

            return currentCoordinate;
        }
       
    }
}
