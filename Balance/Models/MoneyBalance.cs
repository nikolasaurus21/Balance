namespace Balance.Models
{
    public class MoneyBalance
    {
        private readonly User _user;
        public MoneyBalance(User user)
        {
            _user = user;
        }

        public int Id { get; set; }
        public double Balance { get; set; }
        public double SavedAmount { get; set; }
        public double Expenses { get; set; }



    }





}

        