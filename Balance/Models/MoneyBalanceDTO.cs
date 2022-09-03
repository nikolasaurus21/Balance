namespace Balance.Models
{
    public class MoneyBalanceDTO
    {
        
        public double Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public double Balance { get; set; }
        public double SavedAmount { get; set; }
        public double Expenses { get; set; }
        public double Salary { get; set; }

    }
}
