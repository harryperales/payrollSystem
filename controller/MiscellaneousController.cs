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
        private MiscellaneousServiceInterface miscService;
        public MiscellaneousController()
        {
            miscService = new MiscellaneousService();
        }

        public Miscellaneous addMisc(Miscellaneous misc)
        {
            return miscService.addMisc(misc);
        }

        public List<Miscellaneous> viewAllMisc()
        {
            return miscService.fetchAllMisc();
        }

        public Miscellaneous fetchMiscByName(string selectedMisc)
        {
            return miscService.fetchMiscByName(selectedMisc);
        }

        public Miscellaneous updateMiscellaneous(Miscellaneous miscellaneous)
        {
            return miscService.updateMiscellaneous(miscellaneous);
        }
    }
}
