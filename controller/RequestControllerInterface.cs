using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface RequestControllerInterface
    {
        List<Request> fetchAllPendingRequests();

        void updateRequestStatusById(int requestId, string status);
    }
}
