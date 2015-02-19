using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface PositionServiceInterface
    {
        List<Position> fetchAllPosition();

        Position addPosition(Position position);

        Position fetchPositionByName(string selectedPosition);

        Position updatePosition(Position position);
    }
}
