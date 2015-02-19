using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface PositionControllerInterface
    {
        List<Position> viewAllPosition();

        Position addPosition(Position position);

        Position fetchPositionByName(string selectedPosition);

        Position updatePosition(Position position); 
    }
}
