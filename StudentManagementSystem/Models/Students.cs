using Microsoft.AspNetCore.Http.HttpResults;
using System;

namespace StudentManagementSystem.Models
{
    public class Students
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Email { get; set; }
        public string Phone {  get; set; }
        public string Address { get; set; }
        public DateTime Admission_Date { get; set; }
        public double Fees {  get; set; }
        public bool Status { get; set; }

        public Students()
        {
        }

        public Students(int id, string name, string email, string phone, string address, DateTime admissionDate, double fees, bool status)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Admission_Date = admissionDate;
            this.Fees = fees;
            this.Status = status;
        }

        
    }

    
}