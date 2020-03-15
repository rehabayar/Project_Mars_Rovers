using Mars_Rover_Business.Component.Abstract;
using Mars_Rover_Common.Enums;
using Mars_Rover_Common.Helper;
using Mars_Rover_Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Business.Component.Concrate
{
    public class MovementComponent : IMovementComponent
    {
        public RoboticRoversLocation MoveDecision(RoboticRoversLocation currentCoordinate)
        {

            if (currentCoordinate.Instructions == Instructions.Left || currentCoordinate.Instructions == Instructions.Right)
                Turn(currentCoordinate);

            else if (currentCoordinate.Instructions == Instructions.MoveForward)
                MoveForward(currentCoordinate);

            return currentCoordinate;
        }

        public RoboticRoversLocation MoveForward(RoboticRoversLocation currentCoordinate)
        {
            DirectionComponent directionList = new DirectionComponent();
            DirectionInstructions directionInstructions = directionList.GetDirectionInstructionsByDirectionCode(currentCoordinate.DirectionCode);
            ConsoleMessageHelper helper = new ConsoleMessageHelper();
            int startPointX = currentCoordinate.XCoordinate;
            int startPointY = currentCoordinate.YCoordinate;

            // X Axis instructions and limit control
            if (directionInstructions.XInstructions == Axis.XPositive && currentCoordinate.XCoordinate < currentCoordinate.XAxisLimit)
            {
                currentCoordinate.XCoordinate += 1;
            }

            else if (directionInstructions.XInstructions == Axis.XNegative && currentCoordinate.XCoordinate > -currentCoordinate.XAxisLimit)
            {
                currentCoordinate.XCoordinate -= 1;
            }

            // Y Axis instructions and limit control
            if (directionInstructions.YInstructions == Axis.YPositive && currentCoordinate.YCoordinate < currentCoordinate.YAxisLimit)
            {
                currentCoordinate.YCoordinate += 1;
            }

            else if (directionInstructions.YInstructions == Axis.YNegative && currentCoordinate.YCoordinate > -currentCoordinate.YAxisLimit)
            {
                currentCoordinate.YCoordinate -= 1;
            }

            var consoleMessage = helper.MoveControlMessage(startPointX, currentCoordinate.XCoordinate, startPointY, currentCoordinate.YCoordinate);
            Console.WriteLine(consoleMessage);

            return currentCoordinate;
        }

        public RoboticRoversLocation Turn(RoboticRoversLocation currentCoordinate)
        {
            DirectionComponent direction = new DirectionComponent();
            DirectionInstructions currentDirectionInstructions = direction.GetDirectionInstructionsByDirectionCode(currentCoordinate.DirectionCode);

            DirectionInstructions newDirection = new DirectionInstructions();

            // Turn Left
            if (currentCoordinate.Instructions == Instructions.Left)
            {
                if (currentDirectionInstructions.ClockWiseId == 1)
                    newDirection = direction.GetDirectionInstructionsByClockwiseId(4);

                else
                    newDirection = direction.GetDirectionInstructionsByClockwiseId(currentDirectionInstructions.ClockWiseId - 1);
            }

            // Turn Right
            else if (currentCoordinate.Instructions == Instructions.Right)
            {
                if (currentDirectionInstructions.ClockWiseId == 4)
                    newDirection = direction.GetDirectionInstructionsByClockwiseId(1);

                else
                    newDirection = direction.GetDirectionInstructionsByClockwiseId(currentDirectionInstructions.ClockWiseId + 1);
            }

            currentCoordinate.Direction = newDirection.DirectionName;
            currentCoordinate.DirectionCode = newDirection.DirectionCode;

            Console.WriteLine("Turn " + currentCoordinate.Instructions + " new direction is " + currentCoordinate.Direction);

            return currentCoordinate;
        }
    }
}
