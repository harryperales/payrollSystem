﻿using System;
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

        List<Request> fetchAllApprovedRequests();

        Request createRequest(Request request);

        List<Request> fetchPendingRequestByEmployee(Employee employee);

        List<Request> fetchApprovedRequestByEmployee(Employee employee);
    }
}
