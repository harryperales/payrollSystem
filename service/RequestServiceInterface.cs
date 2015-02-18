using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface RequestServiceInterface
    {
        List<Request> fetchOvertimeRequests(Employee employee, DateTime startDatePeriod, DateTime endDatePeriod);

        List<Request> fetchLeaveRequest(Employee employee, DateTime startDatePeriod, DateTime endDatePeriod);

        List<Request> fetchAllPendingRequests();

        Request fetchPendingRequestById(int requestId);

        Request updateRequestStatusById(int requestId, string status);

        Request fetchById(int requestId);
    }
}
