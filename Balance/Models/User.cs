﻿namespace Balance.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public double Salary { get; set; }
        public int MoneyBalanceId { get; set; } 
    }
}
