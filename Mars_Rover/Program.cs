using Mars_Rover_Business.Workflow.Concrate;
using Mars_Rover_Model.Models;
using System;

namespace Mars_Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get space limit
            Console.WriteLine("Space limits (X Y) : ");
            string spaceLimits = Console.ReadLine().ToUpper();
            string[] spaceLimitInfo = spaceLimits.Split(' ');

            // Get start coordinate
            Console.WriteLine("Start coordinate (X Y n) : ");
            string startLocation = Console.ReadLine().ToUpper();
            string[] starLocationInfo = startLocation.Split(' ');

            // Set data
            RoboticRoversLocation roboticRovers = new RoboticRoversLocation();
            roboticRovers.XCoordinate = Convert.ToInt32(starLocationInfo[0]);
            roboticRovers.YCoordinate = Convert.ToInt32(starLocationInfo[1]);
            roboticRovers.DirectionCode = char.Parse(starLocationInfo[2]);
            roboticRovers.XAxisLimit = Convert.ToInt32(spaceLimitInfo[0]);
            roboticRovers.YAxisLimit = Convert.ToInt32(spaceLimitInfo[1]);

            // Get move list
            Console.WriteLine("Movement list (L,R or M): ");
            string movement = Console.ReadLine().ToUpper();
            char[] moveList = movement.ToCharArray();

            MovementCalculateWorkflow movementCalculate = new MovementCalculateWorkflow();
         
            var response = movementCalculate.MoveCalculate(roboticRovers, moveList);

            Console.WriteLine(response.XCoordinate + " " + response.YCoordinate + " " + response.DirectionCode);
            Console.ReadKey();
        }
    }
}
