using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.service;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public class RequestController : RequestControllerInterface
    {
        RequestServiceInterface requestService;
        public RequestController()
        {
            requestService = new RequestService();
        }
        public List<Request> fetchAllPendingRequests()
        {
            return requestService.fetchAllPendingRequests();
        }

        public void updateRequestStatusById(int requestId, string status)
        {
            requestService.updateRequestStatusById(requestId, status);
        }

        public List<Request> fetchAllApprovedRequests()
        {
            return requestService.fetchAllApprovedRequests();
        }

        public Request createRequest(Request request)
        {
            return requestService.createRequest(request);
        }

        public List<Request> fetchPendingRequestByEmployee(Employee employee)
        {
            return requestService.fetchPendingRequestByEmployee(employee);
        }

        public List<Request> fetchApprovedRequestByEmployee(Employee employee)
        {
            return requestService.fetchApprovedRequestByEmployee(employee);
        }
    }
}
