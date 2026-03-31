using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASC.Model.BaseTypes;

namespace ASC.Model.BaseTypes
{
    public static class Constants
    {
    }

    public enum Roles
    {
        Admin,
        Engineer,
        User
    }

    public enum MasterKeys
    {
        VehicleName,
        VehicleType
    }

    public enum Status
    {
        New,
        Denied,
        Pending,
        Initiated,
        InProgress,
        PendingCustomerApproval,
        RequestForInformation,
        Completed
    }
}