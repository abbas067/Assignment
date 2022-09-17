using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Adhaar:IAdhaar
    {
        private readonly NC_DevContext context;
        public Adhaar(NC_DevContext _context)
        {
            context = _context;
        }
        public List<TblAdhaarDetail> GetEmployeeList()
        {
            return context.TblAdhaarDetails.ToList();
        }
        public TblAdhaarDetail Add(TblAdhaarDetail employee)
        {
            context.TblAdhaarDetails.Add(employee);
            context.SaveChanges();
            return employee;
        }
    }
}
