using Mars_Rover_Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Business.Component.Abstract
{
    public interface IDirectionComponent
    {
        public List<DirectionInstructions> StaticDirectionList();
    }
}
