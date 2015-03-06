using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.view;
using PayrollSystem.model;
using PayrollSystem.service;

namespace PayrollSystem.controller
{
    public class PositionController : PositionControllerInterface
    {
        private PositionServiceInterface positionService;
        public PositionController()
        {
            positionService = new PositionService();
        }

        public PositionController(PositionServiceInterface positionService)
        {
            this.positionService = positionService;
        }

        public Position addPosition(Position position)
        {
            return positionService.addPosition(position);
        }

        public List<Position> viewAllPosition()
        {
            return positionService.fetchAllPosition();
        }

        public Position fetchPositionByName(string selectedPosition)
        {
            return positionService.fetchPositionByName(selectedPosition);
        }

        public Position updatePosition(Position position)
        {
            return positionService.updatePosition(position);
        }

        public Position fetchPositionById(int positionId)
        {
            return positionService.fetchPositionById(positionId);
        }
    }
}
