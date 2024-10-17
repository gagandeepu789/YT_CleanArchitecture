﻿using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    internal interface ILeaveAllocationRepository:IGenericRepository<LeaveAllocation>
    {
    }
}
