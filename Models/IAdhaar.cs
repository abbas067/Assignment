using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
   public interface IAdhaar
    {
        List<TblAdhaarDetail> GetEmployeeList();
        TblAdhaarDetail Add(TblAdhaarDetail employee);

    }
}
