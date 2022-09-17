using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Assignment.Models
{
    public partial class TblAdhaarDetail
    {
        public string Name { get; set; }
        public string Dob { get; set; }
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Pincode { get; set; }
        public int? MobileNo { get; set; }
        public string Email { get; set; }
        public string PanNumber { get; set; }
        public string PanDocument { get; set; }
        public string AdhaarNumber { get; set; }
        public string AdhaarFrontImage { get; set; }
        public string AdhaarBackImage { get; set; }
        public string Gender { get; set; }
        [NotMapped]
        public IFormFile PhotoFront { get; set; }
        [NotMapped]
        public IFormFile PhotoBack { get; set; }
        [NotMapped]
        public IFormFile PanDoc { get; set; }

    }
}
