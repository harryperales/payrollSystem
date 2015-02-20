using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.view;
using PayrollSystem.model;
using PayrollSystem.service;

namespace PayrollSystem.controller
{
    public class MiscellaneousController: MiscControllerInterface
    {
        private MiscServiceInterface miscService;
        private MiscellaneousServiceInterface miscellaneousservice;
        public MiscellaneousController()
        {
            miscService = new MiscService();
            miscellaneousservice = new MiscellaneousService();
        }

        public Miscellaneous addMisc(Miscellaneous misc)
        {
            return miscService.addMisc(misc);
        }

        public Miscellaneous fetchFoodAllowance()
        {
            return miscellaneousservice.fetchMiscellaneousByName("FoodAllowance");
        }

        public Miscellaneous fetchTranspoAllowance()
        {
            return miscellaneousservice.fetchMiscellaneousByName("TransportationAllowance");
        }
    }
}
