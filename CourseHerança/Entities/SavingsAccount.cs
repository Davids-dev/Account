namespace CourseHerança.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void WithDraw(double amount) //essa operação não pode ser sobrescrita novamente em outra subclasse
        {
            base.WithDraw(amount); //utilizando como base a taxa da conta Account
            Balance -= 2.0; // + taxa para a retirada da conta Savings
        }
    }
}
