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
        public MiscellaneousController()
        {
            miscService = new MiscService();
        }

        public Miscellaneous addMisc(Miscellaneous misc)
        {
            return miscService.addMisc(misc);
        }
    }
}
