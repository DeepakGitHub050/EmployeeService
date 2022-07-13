using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQLwebApp.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }   
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }    
        public string City { get; set; }
        public string Nationality { get; set; }
        public int PINCode { get; set; }
    }
}