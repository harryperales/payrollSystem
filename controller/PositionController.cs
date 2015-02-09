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

        public Position addPosition(Position position)
        {
            return positionService.addPosition(position);
        }
    }
}
