using Mars_Rover_Business.Component.Abstract;
using Mars_Rover_Common.Enums;
using Mars_Rover_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Business.Component.Concrate
{
    public class DirectionComponent : IDirectionComponent
    {
        public List<DirectionInstructions> StaticDirectionList()
        {
            List<DirectionInstructions> directionList = new List<DirectionInstructions>();

            DirectionInstructions directionInstructionN = new DirectionInstructions();
            DirectionInstructions directionInstructionE = new DirectionInstructions();
            DirectionInstructions directionInstructionS = new DirectionInstructions();
            DirectionInstructions directionInstructionW = new DirectionInstructions();

            // North
            directionInstructionN.ClockWiseId = 1;
            directionInstructionN.DirectionCode = DirectionCode.N;
            directionInstructionN.DirectionName = DirectionName.North;
            directionInstructionN.XInstructions = Axis.XCurrent;
            directionInstructionN.YInstructions = Axis.YPositive;

            // East
            directionInstructionE.ClockWiseId = 2;
            directionInstructionE.DirectionCode = DirectionCode.E;
            directionInstructionE.DirectionName = DirectionName.East;
            directionInstructionE.XInstructions = Axis.XPositive;
            directionInstructionE.YInstructions = Axis.YCurrent;

            // South
            directionInstructionS.ClockWiseId = 3;
            directionInstructionS.DirectionCode = DirectionCode.S;
            directionInstructionS.DirectionName = DirectionName.South;
            directionInstructionS.XInstructions = Axis.XCurrent;
            directionInstructionS.YInstructions = Axis.YNegative;

            // West
            directionInstructionW.ClockWiseId = 4;
            directionInstructionW.DirectionCode = DirectionCode.W;
            directionInstructionW.DirectionName = DirectionName.West;
            directionInstructionW.XInstructions = Axis.XNegative;
            directionInstructionW.YInstructions = Axis.YCurrent;

            directionList.Add(directionInstructionN);
            directionList.Add(directionInstructionE);
            directionList.Add(directionInstructionS);
            directionList.Add(directionInstructionW);

            return directionList;
        }

        public DirectionInstructions GetDirectionInstructionsByDirectionCode(char directionCode)
        {
            DirectionInstructions direction = new DirectionInstructions();
            var directionList = StaticDirectionList();

            direction = directionList.Where(x => x.DirectionCode == directionCode).FirstOrDefault();

            return direction;
        }

        public DirectionInstructions GetDirectionInstructionsByClockwiseId(int clockwiseId)
        {
            DirectionInstructions direction = new DirectionInstructions();
            var directionList = StaticDirectionList();

            direction = directionList.Where(x => x.ClockWiseId == clockwiseId).FirstOrDefault();

            return direction;
        }
    }
}
