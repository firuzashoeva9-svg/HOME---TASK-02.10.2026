public class PaymentTerminal
{
    public double Money { get; set; }
    public int AffordableMeals { get; set; }
    public int HeartyMeals { get; set; }
    private double AffordableMealPrice = 2.50;
    private double HeartyMealPrice = 4.30;
    public PaymentTerminal()
    {
        Money = 1000;
        AffordableMeals = 0;
        HeartyMeals = 0;
    }
    public double EatAffordable(double payment)
    {
        if (payment >= AffordableMealPrice)
        {
            Money += AffordableMealPrice;
            AffordableMeals++;
            return payment - AffordableMealPrice;
        }
        return payment;
    }
    public double EatHearty(double payment)
    {
        if (payment >= HeartyMealPrice)
        {
            Money += HeartyMealPrice;
            HeartyMeals++;
            return payment - HeartyMealPrice;
        }
        return payment;
    }
    public bool EatAffordable(PaymentCard card)
    {
        if (card.TakeMoney(AffordableMealPrice))
        {
            AffordableMeals++;
            return true;
        }
        return false;
    }
    public bool EatHearty(PaymentCard card)
    {
        if (card.TakeMoney(HeartyMealPrice))
        {
            HeartyMeals++;
            return true;
        }
        return false;
    }
    public void AddMoneyToCard(PaymentCard card, double sum)
    {
        if (sum > 0)
        {
            card.AddMoney(sum);
            Money += sum;
        }
    }
}