public class PaymentCard
{
    public double Balance { get; set; }

    public PaymentCard(double balance)
    {
        Balance = balance;
    }
    public void AddMoney(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }
    public bool TakeMoney(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}